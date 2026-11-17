using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace DesktopApplication
{
    /// <summary>
    /// Converts images to ASCII art with optional Sobel edge overlay.
    /// </summary>
    public static class ASCIIConverter
    {
        /// <summary>
        /// Default ramp, darkest to brightest (for dark text on a light background).
        /// </summary>
        public const string DefaultRamp = "@%#*+=-:. ";

        /// <summary>
        /// Converts a bitmap to an ASCII-art string.
        /// </summary>
        /// <param name="source">The source image.</param>
        /// <param name="width">Output width in characters.</param>
        /// <param name="detectEdges">If true, overlays | / \ _ characters on detected edges.</param>
        /// <param name="edgeThreshold">Sobel magnitude above which a pixel counts as an edge.</param>
        /// <param name="ramp">Characters ordered from darkest to brightest.</param>
        /// <returns>The ASCII art, one line per row.</returns>
        public static string Convert(Bitmap source, int width, bool detectEdges = true,
                                     int edgeThreshold = 150, string ramp = DefaultRamp)
        {
            using Bitmap resized = Resize(source, width);
            byte[,] gray = ToGrayscale(resized);
            char[,] chars = PixelsToChars(gray, ramp);

            if (detectEdges)
                ApplySobelEdges(gray, chars, edgeThreshold);

            return CharsToString(chars);
        }

        /// <summary>
        /// Resizes the bitmap, compensating for characters being taller than wide.
        /// </summary>
        /// <param name="source">The source image.</param>
        /// <param name="targetWidth">Width in pixels (one pixel = one character).</param>
        /// <param name="charAspect">Character width/height ratio. Height is scaled by this.</param>
        /// <returns>A new 32bpp ARGB bitmap. The caller must dispose it.</returns>
        public static Bitmap Resize(Bitmap source, int targetWidth, double charAspect = 0.5)
        {
            int targetHeight = Math.Max(1, (int)(source.Height * (double)targetWidth / source.Width * charAspect));
            var result = new Bitmap(targetWidth, targetHeight, PixelFormat.Format32bppArgb);

            using Graphics g = Graphics.FromImage(result);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(source, 0, 0, targetWidth, targetHeight);
            return result;
        }

        /// <summary>
        /// Converts a bitmap to a grayscale 2D array indexed as [y, x] with values 0..255.
        /// </summary>
        /// <param name="bmp">The bitmap to convert.</param>
        /// <returns>Luminance values (ITU-R BT.601 weights).</returns>
        public static byte[,] ToGrayscale(Bitmap bmp)
        {
            int w = bmp.Width, h = bmp.Height;
            var gray = new byte[h, w];

            var rect = new Rectangle(0, 0, w, h);
            BitmapData data = bmp.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            try
            {
                int stride = data.Stride;
                byte[] buffer = new byte[stride * h];
                Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);

                for (int y = 0; y < h; y++)
                {
                    int row = y * stride;
                    for (int x = 0; x < w; x++)
                    {
                        int i = row + x * 4;          // BGRA order
                        int b = buffer[i];
                        int g = buffer[i + 1];
                        int r = buffer[i + 2];
                        gray[y, x] = (byte)((299 * r + 587 * g + 114 * b) / 1000);
                    }
                }
            }
            finally
            {
                bmp.UnlockBits(data);
            }
            return gray;
        }

        /// <summary>
        /// Maps each grayscale value to a character from the ramp.
        /// </summary>
        /// <param name="gray">Grayscale values indexed as [y, x].</param>
        /// <param name="ramp">Characters ordered from darkest to brightest.</param>
        /// <returns>A character grid of the same size as <paramref name="gray"/>.</returns>
        public static char[,] PixelsToChars(byte[,] gray, string ramp = DefaultRamp)
        {
            int h = gray.GetLength(0), w = gray.GetLength(1);
            var chars = new char[h, w];
            int last = ramp.Length - 1;

            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    chars[y, x] = ramp[gray[y, x] * last / 255];

            return chars;
        }

        /// <summary>
        /// Runs Sobel edge detection and overwrites edge pixels in <paramref name="chars"/>
        /// with an orientation character (| / \ _).
        /// </summary>
        /// <param name="gray">Grayscale values indexed as [y, x].</param>
        /// <param name="chars">Character grid modified in place.</param>
        /// <param name="threshold">Minimum gradient magnitude to count as an edge.</param>
        public static void ApplySobelEdges(byte[,] gray, char[,] chars, int threshold = 150)
        {
            int h = gray.GetLength(0), w = gray.GetLength(1);

            // border pixels are skipped (no full 3x3 neighbourhood)
            for (int y = 1; y < h - 1; y++)
            {
                for (int x = 1; x < w - 1; x++)
                {
                    int gx =
                        -gray[y - 1, x - 1] + gray[y - 1, x + 1]
                        - 2 * gray[y, x - 1] + 2 * gray[y, x + 1]
                        - gray[y + 1, x - 1] + gray[y + 1, x + 1];

                    int gy =
                        -gray[y - 1, x - 1] - 2 * gray[y - 1, x] - gray[y - 1, x + 1]
                        + gray[y + 1, x - 1] + 2 * gray[y + 1, x] + gray[y + 1, x + 1];

                    double magnitude = Math.Sqrt(gx * gx + gy * gy);
                    if (magnitude < threshold) continue;

                    // The gradient points across the edge, so the edge itself
                    // runs perpendicular to it (+90 degrees). Y axis points down.
                    double gradientAngle = Math.Atan2(gy, gx) * 180.0 / Math.PI;   // -180..180
                    double edgeAngle = ((gradientAngle + 90.0) % 180.0 + 180.0) % 180.0; // 0..180

                    chars[y, x] = EdgeAngleToChar(edgeAngle);
                }
            }
        }

        /// <summary>
        /// Maps an edge orientation angle to the character that best represents it.
        /// </summary>
        /// <param name="angle">Edge direction in degrees, in the range 0..180 (Y axis points down).</param>
        /// <returns>
        /// <c>_</c> for horizontal, <c>\</c> for right-down, <c>|</c> for vertical,
        /// or <c>/</c> for right-up edges.
        /// </returns>
        private static char EdgeAngleToChar(double angle)
        {
            if (angle < 22.5 || angle >= 157.5) return '_';   // horizontal
            if (angle < 67.5) return '\\';                    // going right-down
            if (angle < 112.5) return '|';                    // vertical
            return '/';                                       // going right-up
        }

        /// <summary>
        /// Joins a character grid into a multi-line string.
        /// </summary>
        /// <param name="chars">Character grid indexed as [y, x].</param>
        /// <returns>The grid as text, one line per row.</returns>
        public static string CharsToString(char[,] chars)
        {
            int h = chars.GetLength(0), w = chars.GetLength(1);
            var sb = new StringBuilder(h * (w + 2));

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                    sb.Append(chars[y, x]);
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}