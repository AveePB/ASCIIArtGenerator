namespace DesktopApplication
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            menuStrip = new MenuStrip();
            selectToolStripMenuItem = new ToolStripMenuItem();
            generateToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dLLToolStripMenuItem = new ToolStripMenuItem();
            aSMToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem1 = new ToolStripMenuItem();
            threadsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            tabMenu = new TabControl();
            originalImageTabPage = new TabPage();
            panel2 = new Panel();
            originalPictureBox = new PictureBox();
            ASCIIArtTabPage = new TabPage();
            panel1 = new Panel();
            ASCIITextBox = new TextBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            tabMenu.SuspendLayout();
            originalImageTabPage.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).BeginInit();
            ASCIIArtTabPage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.MediumAquamarine;
            menuStrip.Items.AddRange(new ToolStripItem[] { selectToolStripMenuItem, generateToolStripMenuItem, saveToolStripMenuItem, dLLToolStripMenuItem, threadsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(484, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.Size = new Size(50, 20);
            selectToolStripMenuItem.Text = "Select";
            selectToolStripMenuItem.Click += selectToolStripMenuItem_Click;
            // 
            // generateToolStripMenuItem
            // 
            generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            generateToolStripMenuItem.Size = new Size(66, 20);
            generateToolStripMenuItem.Text = "Generate";
            generateToolStripMenuItem.Click += generateToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dLLToolStripMenuItem
            // 
            dLLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aSMToolStripMenuItem, cToolStripMenuItem, cToolStripMenuItem1 });
            dLLToolStripMenuItem.Name = "dLLToolStripMenuItem";
            dLLToolStripMenuItem.Size = new Size(39, 20);
            dLLToolStripMenuItem.Text = "DLL";
            // 
            // aSMToolStripMenuItem
            // 
            aSMToolStripMenuItem.Name = "aSMToolStripMenuItem";
            aSMToolStripMenuItem.Size = new Size(99, 22);
            aSMToolStripMenuItem.Text = "ASM";
            aSMToolStripMenuItem.Click += aSMToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(99, 22);
            cToolStripMenuItem.Text = "C";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem1
            // 
            cToolStripMenuItem1.Checked = true;
            cToolStripMenuItem1.CheckState = CheckState.Checked;
            cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            cToolStripMenuItem1.Size = new Size(99, 22);
            cToolStripMenuItem1.Text = "C#";
            cToolStripMenuItem1.Click += cToolStripMenuItem1_Click;
            // 
            // threadsToolStripMenuItem
            // 
            threadsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8 });
            threadsToolStripMenuItem.Name = "threadsToolStripMenuItem";
            threadsToolStripMenuItem.Size = new Size(61, 20);
            threadsToolStripMenuItem.Text = "Threads";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem2.CheckState = CheckState.Checked;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "1";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "2";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 22);
            toolStripMenuItem4.Text = "4";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(180, 22);
            toolStripMenuItem5.Text = "8";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(180, 22);
            toolStripMenuItem6.Text = "16";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(180, 22);
            toolStripMenuItem7.Text = "32";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(180, 22);
            toolStripMenuItem8.Text = "64";
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(originalImageTabPage);
            tabMenu.Controls.Add(ASCIIArtTabPage);
            tabMenu.Location = new Point(0, 27);
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(484, 483);
            tabMenu.TabIndex = 1;
            // 
            // originalImageTabPage
            // 
            originalImageTabPage.BackColor = Color.Transparent;
            originalImageTabPage.Controls.Add(panel2);
            originalImageTabPage.Location = new Point(4, 24);
            originalImageTabPage.Name = "originalImageTabPage";
            originalImageTabPage.Padding = new Padding(3);
            originalImageTabPage.Size = new Size(476, 455);
            originalImageTabPage.TabIndex = 0;
            originalImageTabPage.Text = "Original Image";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(originalPictureBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 449);
            panel2.TabIndex = 0;
            // 
            // originalPictureBox
            // 
            originalPictureBox.Location = new Point(0, 0);
            originalPictureBox.Name = "originalPictureBox";
            originalPictureBox.Size = new Size(100, 50);
            originalPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            originalPictureBox.TabIndex = 0;
            originalPictureBox.TabStop = false;
            // 
            // ASCIIArtTabPage
            // 
            ASCIIArtTabPage.Controls.Add(panel1);
            ASCIIArtTabPage.Location = new Point(4, 24);
            ASCIIArtTabPage.Name = "ASCIIArtTabPage";
            ASCIIArtTabPage.Padding = new Padding(3);
            ASCIIArtTabPage.Size = new Size(476, 455);
            ASCIIArtTabPage.TabIndex = 1;
            ASCIIArtTabPage.Text = "ASCII Art";
            ASCIIArtTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(ASCIITextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 449);
            panel1.TabIndex = 0;
            // 
            // ASCIITextBox
            // 
            ASCIITextBox.BackColor = Color.Black;
            ASCIITextBox.Dock = DockStyle.Fill;
            ASCIITextBox.Font = new Font("Consolas", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ASCIITextBox.ForeColor = SystemColors.Window;
            ASCIITextBox.Location = new Point(0, 0);
            ASCIITextBox.Multiline = true;
            ASCIITextBox.Name = "ASCIITextBox";
            ASCIITextBox.ReadOnly = true;
            ASCIITextBox.ScrollBars = ScrollBars.Both;
            ASCIITextBox.Size = new Size(470, 449);
            ASCIITextBox.TabIndex = 0;
            ASCIITextBox.WordWrap = false;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "PNG Files|*.png|Bitmap Files|*.bmp|JPEG Files|*.jpg;*.jpeg";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "Text file|*.txt";
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 511);
            Controls.Add(tabMenu);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "AppForm";
            Text = "ASCII Art Generator";
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tabMenu.ResumeLayout(false);
            originalImageTabPage.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).EndInit();
            ASCIIArtTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem generateToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TabControl tabMenu;
        private TabPage ASCIIArtTabPage;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem dLLToolStripMenuItem;
        private ToolStripMenuItem aSMToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem threadsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private Panel panel1;
        private TabPage originalImageTabPage;
        private Panel panel2;
        private PictureBox originalPictureBox;
        private TextBox ASCIITextBox;
    }
}
