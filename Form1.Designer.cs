using System.Windows.Forms;

namespace _8086
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBoxEx2 = new _8086.RichTextBoxEx();
            this.richTextBoxEx1 = new _8086.RichTextBoxEx();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveTextToolStripMenuItem,
            this.saveHexToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveTextToolStripMenuItem.Text = "Save text";
            this.saveTextToolStripMenuItem.Click += new System.EventHandler(this.saveTextToolStripMenuItem_Click);
            // 
            // saveHexToolStripMenuItem
            // 
            this.saveHexToolStripMenuItem.Name = "saveHexToolStripMenuItem";
            this.saveHexToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveHexToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveHexToolStripMenuItem.Text = "Save hex";
            this.saveHexToolStripMenuItem.Click += new System.EventHandler(this.saveHexToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.convertToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.convertToolStripMenuItem.Text = "Convert          F5";
            this.convertToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.convertToolStripMenuItem.Click += new System.EventHandler(this.convertToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt|RTF files(*.rtf)|*.rtf|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Open file";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "ath";
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|RTF files(*.rtf)|*.rtf|All files (*.*)|*.*";
            this.saveFileDialog1.Title = "Save text";
            // 
            // richTextBoxEx2
            // 
            this.richTextBoxEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBoxEx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxEx2.Location = new System.Drawing.Point(299, 24);
            this.richTextBoxEx2.Name = "richTextBoxEx2";
            this.richTextBoxEx2.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxEx2.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxEx2.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxEx2.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxEx2.NumberBorderThickness = 1F;
            this.richTextBoxEx2.NumberColor = System.Drawing.Color.DodgerBlue;
            this.richTextBoxEx2.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx2.NumberLeadingZeroes = false;
            this.richTextBoxEx2.NumberLineCounting = _8086.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxEx2.NumberPadding = 2;
            this.richTextBoxEx2.ReadOnly = true;
            this.richTextBoxEx2.ShowLineNumbers = true;
            this.richTextBoxEx2.Size = new System.Drawing.Size(300, 374);
            this.richTextBoxEx2.TabIndex = 1;
            this.richTextBoxEx2.Text = "";
            // 
            // richTextBoxEx1
            // 
            this.richTextBoxEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxEx1.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.NumberAlignment = System.Drawing.StringAlignment.Center;
            this.richTextBoxEx1.NumberBackground1 = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxEx1.NumberBackground2 = System.Drawing.SystemColors.Window;
            this.richTextBoxEx1.NumberBorder = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxEx1.NumberBorderThickness = 1F;
            this.richTextBoxEx1.NumberColor = System.Drawing.Color.DodgerBlue;
            this.richTextBoxEx1.NumberFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx1.NumberLeadingZeroes = false;
            this.richTextBoxEx1.NumberLineCounting = _8086.RichTextBoxEx.LineCounting.CRLF;
            this.richTextBoxEx1.NumberPadding = 2;
            this.richTextBoxEx1.ShowLineNumbers = true;
            this.richTextBoxEx1.Size = new System.Drawing.Size(300, 374);
            this.richTextBoxEx1.TabIndex = 0;
            this.richTextBoxEx1.Text = " ";
            this.richTextBoxEx1.TextChanged += new System.EventHandler(this.richTextBoxEx1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 398);
            this.Controls.Add(this.richTextBoxEx2);
            this.Controls.Add(this.richTextBoxEx1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(615, 39);
            this.Name = "Form1";
            this.Text = "CM1800 assembler-to-hex";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBoxEx richTextBoxEx1;
        private RichTextBoxEx richTextBoxEx2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveTextToolStripMenuItem;
        private ToolStripMenuItem saveHexToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem convertToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}

