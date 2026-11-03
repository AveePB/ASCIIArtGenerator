namespace DesktopApplication
{
    public partial class AppForm : Form
    {
        private Bitmap? originalImage;

        public AppForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() != DialogResult.OK) return;

            this.originalImage?.Dispose();
            using (var tmp = new Bitmap(openFileDialog.FileName))
                this.originalImage = new Bitmap(tmp);

            this.originalPictureBox.Image = this.originalImage;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(this.saveFileDialog.FileName, ASCIITextBox.Text);
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aSMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.dLLToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.aSMToolStripMenuItem.Checked = true;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.dLLToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.cToolStripMenuItem.Checked = true;
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.dLLToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.cToolStripMenuItem1.Checked = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem2.Checked = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem3.Checked = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem4.Checked = true;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem5.Checked = true;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem6.Checked = true;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem7.Checked = true;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem other in this.threadsToolStripMenuItem.DropDownItems)
                other.Checked = false;
            this.toolStripMenuItem8.Checked = true;
        }
    }
}
