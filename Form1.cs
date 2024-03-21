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
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtSaat.Text = DateTime.Now.ToShortTimeString();

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

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            if (txtGörevEkle.Text != "")
            {
                listEklenen.Items.Add(txtGörevEkle.Text);
                listBoxHistory.Items.Add("Yeni Görev Eklendi");
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

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            listEklenen.Items.Clear();
            listTamanlanan.Items.Clear();
        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            listTamanlanan.Items.Add(listEklenen.Text);
            listEklenen.Items.Remove(listEklenen.SelectedItem);
            listBoxHistory.Items.Add("Görev Tamamlandı");
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            listEklenen.Items.Add(listTamanlanan.Text);
            listTamanlanan.Items.Remove(listTamanlanan.SelectedItem);
            
        }

        private void btnGorevSil_Click(object sender, EventArgs e)
        {
            listEklenen.Items.Remove(listEklenen.SelectedItem);
            listTamanlanan.Items.Remove(listTamanlanan.SelectedItem);
            listBoxHistory.Items.Add("Görev Silindi");
        }

        private void listEklenen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listEklenen.HorizontalScrollbar = true;
        }

        private void listTamamlanan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listTamanlanan.HorizontalScrollbar = true;
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
            listBoxHistory.Items.Add("Not Kaydedildi");
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

        private void btnAlarmKur_Click(object sender, EventArgs e)
        {
            if (txtTarih.Text != "" || txtSaat.Text != "")
            {
                alarmlar.Add(txtTarih.Text + txtSaat.Text + "#" + txtMetin.Text);
                timer2.Start();
                listBoxHistory.Items.Add("Alarm Kuruldu");
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

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            alarmlar.Clear();
            txtTarih.Clear();
            txtSaat.Clear();
            txtMetin.Clear();   
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

        private void txtSaat_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBoxHistory.Items.Clear();

        }

        private void btnTumTemizle_Click(object sender, EventArgs e)
        {
            listBoxHistory.Items.Clear();

        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGörevEkle_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            listBoxHistory.Items.Remove(listBoxHistory.SelectedItem);
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void lblAlarmKur_Click(object sender, EventArgs e)
        {

        }
    }
}
