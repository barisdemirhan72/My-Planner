using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Planner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string file = "";

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            DialogResult dr = openFileDialog1.ShowDialog();

            openFileDialog1.Filter = "Text Files |*.txt ";

            if (dr == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.FileName);

                while (!read.EndOfStream)
                {
                    file += read.ReadLine();
                }
                notepad.Text = file;
                read.Close();
                file = "";
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.FileName = "Adsız";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (.txt)|.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);

                write.Write(notepad.Text);
                write.Close();

            }
            else
            {
                try
                {
                    StreamWriter write = new StreamWriter(saveFileDialog1.FileName);

                    write.Write(notepad.Text);
                    write.Close();
                }
                catch
                {

                }
            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.FileName = "Adsız";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (.txt)|.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);

                write.Write(notepad.Text);
                write.Close();

            }
            else
            {
                try
                {
                    StreamWriter write = new StreamWriter(saveFileDialog1.FileName);

                    write.Write(notepad.Text);
                    write.Close();
                }
                catch
                {

                }
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1 = new System.Windows.Forms.PrintDialog();
            printDialog1.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad.Select();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad.SelectAll();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notepad.CanUndo == true)
            {
                notepad.Undo();

            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notepad.SelectedText != "")
            {
                notepad.Cut();
            }
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notepad.SelectionLength > 0)
            {
                notepad.Copy();
                
            }
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                notepad.Paste();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad.SelectedText = "";
        }

        private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad.Clear();
        }

        private void yazıFontuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1 = new System.Windows.Forms.FontDialog();
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                notepad.Font = fontDialog1.Font;
            }
        }

        private void notepad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
