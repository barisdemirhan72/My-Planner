using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace My_Planner
{
    public partial class Form1 : Form
    {
        List<string> alarmlar = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private string file = "";
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label7.Text = DateTime.Now.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = DateTime.Now.ToShortTimeString();

        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yeniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void notepad_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                listBox1.Items.Add(richTextBox1.Text);
                listBox3.Items.Add("Yeni Görev Eklendi");
            }
            else
            {
                MessageBox.Show("Görev Kutusu Boş!!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox3.Items.Add("Görev Tamamlandı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.Text);
            listBox2.Items.Remove(listBox2.SelectedItem);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            listBox3.Items.Add("Görev Silindi");
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox2.HorizontalScrollbar = true;
        }

        private void yeniToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();

            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            DialogResult dr = openFileDialog1.ShowDialog();

            openFileDialog1.Filter = "Text Files |*.txt ";

            if(dr == DialogResult.OK)
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

        private void yazdırToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            printDialog1 = new System.Windows.Forms.PrintDialog();
            printDialog1.ShowDialog();
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
            listBox3.Items.Add("Not Kaydedildi");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void yazıFontuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1 = new System.Windows.Forms.FontDialog();
            DialogResult dr = fontDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                notepad.Font = fontDialog1.Font;
            }
        }

        private void notepad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(notepad.CanUndo == true)
            {
                notepad.Undo();

            }
            
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(notepad.SelectedText != "") 
            {
                notepad.Cut();
            }
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(notepad.SelectionLength > 0) 
            {
                notepad.Copy();
            }
        }

        private void seçilenMetniSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                notepad.Paste();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad.SelectedText = "";
        }

        private void tümünüSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            notepad.Clear();
        }

        private void düzenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad.SelectAll();
        }

        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad.Select();
        }

        private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                alarmlar.Add(textBox1.Text + textBox2.Text + "#" + textBox3.Text);
                timer2.Start();
                listBox3.Items.Add("Alarm Kuruldu");
            }
            else
            {
                MessageBox.Show("Tarih ve Saat girilmedi!!!");
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string birlesikZaman = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();

            foreach (string alarm in alarmlar.ToList())
            {
                string[] words = alarm.Split('#');

                if (birlesikZaman == words[0])
                {
                    alarmlar.Remove(alarm);
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\dinazor ve kurbağa.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                    MessageBox.Show(words[1]);
                    ses.Stop();
                }
            }
            
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            alarmlar.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();   
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            listBox3.Items.Remove(listBox3.SelectedItem);
        }
    }
}
