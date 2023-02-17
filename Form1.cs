using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace _8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int WM_USER = 0x400;

        const int EM_GETSCROLLPOS = WM_USER + 221;

        const int EM_SETSCROLLPOS = WM_USER + 222;

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Point lParam);

        private void richTextBoxEx1_VScroll(object sender, EventArgs e)
        {
            Point pt = new Point();

            SendMessage(richTextBoxEx1.Handle, EM_GETSCROLLPOS, 0, ref pt);

            SendMessage(richTextBoxEx2.Handle, EM_SETSCROLLPOS, 0, ref pt);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            richTextBoxEx1.Size = new Size(control.Size.Width / 2, control.Size.Height);
            richTextBoxEx2.Location = new Point(control.Size.Width / 2, 0);
            richTextBoxEx2.Size = new Size(control.Size.Width / 2, control.Size.Height);
        }

        private void richTextBoxEx1_TextChanged(object sender, EventArgs e)
        {
            /*var pos = richTextBoxEx1.GetLineFromCharIndex(richTextBoxEx1.SelectionStart);

            if (richTextBoxEx2.Lines.Length == 0)
            {
                richTextBoxEx2.AppendText(richTextBoxEx1.Lines[pos]);
            }
            else if (richTextBoxEx2.Lines.Length - 1 < pos)
            {
                richTextBoxEx2.AppendText("\n" + richTextBoxEx1.Lines[pos]);
            }
            else
            {
                replaceLine(richTextBoxEx2, pos, richTextBoxEx1.Lines[pos]);
            }*/
        }

        void replaceLine(RichTextBoxEx RTB, int line, string text)
        {
            int start = RTB.GetFirstCharIndexFromLine(line);
            int end = line < RTB.Lines.Count() - 1 ?
                        RTB.GetFirstCharIndexFromLine(line + 1) - 1 :
                        RTB.Text.Length;
            RTB.Select(start, end - start);
            RTB.SelectedText = text;
        }

        private void convertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Converter cv = new Converter();
            string temp = cv.run(richTextBoxEx1.Text);
            temp = temp.Insert(0, @"{\rtf1\ansi {\colortbl;\red0\green0\blue0;\red155\green0\blue0;\red0\green155\blue0;\red0\green0\blue255;}");
            temp.Append('}');
            richTextBoxEx2.Rtf = temp;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".rtf")
                {
                    richTextBoxEx1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }

                if (Path.GetExtension(openFileDialog1.FileName) == ".txt")
                {
                    richTextBoxEx1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "text";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                RichTextBoxStreamType stream_type;
                if (saveFileDialog1.FilterIndex == 2)
                    stream_type = RichTextBoxStreamType.RichText;
                else
                    stream_type = RichTextBoxStreamType.PlainText;

                richTextBoxEx1.SaveFile(saveFileDialog1.FileName, stream_type);
            }
        }

        private void saveHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "hex";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                RichTextBoxStreamType stream_type;
                if (saveFileDialog1.FilterIndex == 2)
                    stream_type = RichTextBoxStreamType.RichText;
                else
                    stream_type = RichTextBoxStreamType.PlainText;

                richTextBoxEx2.SaveFile(saveFileDialog1.FileName, stream_type);
            }
        }
    }
}
