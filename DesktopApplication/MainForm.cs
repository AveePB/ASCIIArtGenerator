namespace DesktopApplication
{
    /// <summary>
    /// Main window of the application. Lets the user load an image,
    /// choose the DLL implementation language and the number of threads,
    /// generate an ASCII representation of the image and save it to a file.
    /// </summary>
    public partial class AppForm : Form
    {
        /// <summary>
        /// Language of the DLL used to process the image.
        /// </summary>
        private enum DLLLanguage
        {
            /// <summary>Assembly implementation.</summary>
            ASM,
            /// <summary>C++ implementation.</summary>
            CPP,
            /// <summary>C# implementation.</summary>
            CSHARP
        }

        /// <summary>Currently loaded source image, or null if none is loaded.</summary>
        private Bitmap? originalImage;

        /// <summary>Currently selected DLL implementation language.</summary>
        private DLLLanguage dllLanguage;

        /// <summary>Number of threads selected for processing.</summary>
        private int threadNumber;

        /// <summary>
        /// Initializes the form and sets the defaults:
        /// C# DLL and a single thread.
        /// </summary>
        public AppForm()
        {
            InitializeComponent();
            this.dllLanguage = DLLLanguage.CSHARP;
            this.threadNumber = 1;
        }

        /// <summary>
        /// Handles the form's Load event. Currently does nothing.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Lets the user pick an image file, loads it into memory
        /// (disposing the previous one) and shows it in the original picture box.
        /// The file is copied into a new Bitmap so it is not locked on disk.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() != DialogResult.OK) return;

            this.originalImage?.Dispose();
            using (var tmp = new Bitmap(openFileDialog.FileName))
                this.originalImage = new Bitmap(tmp);

            this.originalPictureBox.Image = this.originalImage;
        }

        /// <summary>
        /// Lets the user choose a destination and saves the contents
        /// of the ASCII text box to that file.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(this.saveFileDialog.FileName, ASCIITextBox.Text);
        }

        /// <summary>
        /// Generates the ASCII representation of the loaded image using the
        /// selected DLL language. Does nothing if no image is loaded.
        /// Only the C# version is implemented so far: it converts the image
        /// to ASCII with a target width of a quarter of the image width and
        /// puts the result in the ASCII text box. The C++ and ASM branches
        /// are still placeholders.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.originalImage == null) return;

            if (this.dllLanguage == DLLLanguage.CSHARP)
                this.ASCIITextBox.Text = ASCIIConverter.Convert(this.originalImage, this.originalImage.Width / 4);
            else if (this.dllLanguage == DLLLanguage.CPP)
            { } // C++ Execution
            else
            { } // ASM Execution
        }

        /// <summary>
        /// Selects the ASM DLL: unchecks all items in the DLL menu,
        /// checks the ASM item and updates <see cref="dllLanguage"/>.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void aSMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.dLLToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.aSMToolStripMenuItem.Checked = true;
            this.dllLanguage = DLLLanguage.ASM;
        }

        /// <summary>
        /// Selects the C++ DLL: unchecks all items in the DLL menu,
        /// checks the C++ item and updates <see cref="dllLanguage"/>.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.dLLToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.cToolStripMenuItem.Checked = true;
            this.dllLanguage = DLLLanguage.CPP;
        }

        /// <summary>
        /// Selects the C# DLL: unchecks all items in the DLL menu,
        /// checks the C# item and updates <see cref="dllLanguage"/>.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.dLLToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.cToolStripMenuItem1.Checked = true;
            this.dllLanguage = DLLLanguage.CSHARP;
        }

        /// <summary>
        /// Selects 1 thread: unchecks all items in the Threads menu,
        /// checks this item and sets <see cref="threadNumber"/> to 1.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem2.Checked = true;
            this.threadNumber = 1;
        }

        /// <summary>
        /// Selects 2 threads: unchecks all items in the Threads menu,
        /// checks this item and sets <see cref="threadNumber"/> to 2.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem3.Checked = true;
            this.threadNumber = 2;
        }

        /// <summary>
        /// Selects 4 threads: unchecks all items in the Threads menu,
        /// checks this item and sets <see cref="threadNumber"/> to 4.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem4.Checked = true;
            this.threadNumber = 4;
        }

        /// <summary>
        /// Selects 8 threads: unchecks all items in the Threads menu,
        /// checks this item and sets <see cref="threadNumber"/> to 8.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem5.Checked = true;
            this.threadNumber = 8;
        }

        /// <summary>
        /// Selects 16 threads: unchecks all items in the Threads menu,
        /// checks this item and sets <see cref="threadNumber"/> to 16.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem6.Checked = true;
            this.threadNumber = 16;
        }

        /// <summary>
        /// Selects 32 threads: unchecks all items in the Threads menu,
        /// checks this item and sets <see cref="threadNumber"/> to 32.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem7.Checked = true;
            this.threadNumber = 32;
        }

        /// <summary>
        /// Selects 64 threads: unchecks all items in the Threads menu,
        /// checks this item and sets <see cref="threadNumber"/> to 64.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event data.</param>
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem8.Checked = true;
            this.threadNumber = 64;
        }
    }
}