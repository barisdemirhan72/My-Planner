namespace My_Planner
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMyPlanner = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGorevler = new System.Windows.Forms.Label();
            this.lblTamamlananlar = new System.Windows.Forms.Label();
            this.lblEklenen = new System.Windows.Forms.Label();
            this.txtGörevEkle = new System.Windows.Forms.RichTextBox();
            this.listTamanlanan = new System.Windows.Forms.ListBox();
            this.listEklenen = new System.Windows.Forms.ListBox();
            this.lblYapilacaklarListesi = new System.Windows.Forms.Label();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnTamamlandi = new System.Windows.Forms.Button();
            this.btnGorevSil = new System.Windows.Forms.Button();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlarmSifirla = new System.Windows.Forms.Button();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.btnAlarmKur = new System.Windows.Forms.Button();
            this.lblAlarmMetni = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblAlarmKur = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.notepad = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıFontuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.btnTumTemizle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMyPlanner
            // 
            this.lblMyPlanner.AutoSize = true;
            this.lblMyPlanner.BackColor = System.Drawing.Color.Transparent;
            this.lblMyPlanner.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMyPlanner.ForeColor = System.Drawing.Color.White;
            this.lblMyPlanner.Location = new System.Drawing.Point(624, 8);
            this.lblMyPlanner.Name = "lblMyPlanner";
            this.lblMyPlanner.Size = new System.Drawing.Size(289, 57);
            this.lblMyPlanner.TabIndex = 0;
            this.lblMyPlanner.Text = "My Planner";
            this.lblMyPlanner.Click += new System.EventHandler(this.lblMyPlanner_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(1139, 803);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(119, 40);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "label7";
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lblGorevler);
            this.panel1.Controls.Add(this.lblTamamlananlar);
            this.panel1.Controls.Add(this.lblEklenen);
            this.panel1.Controls.Add(this.txtGörevEkle);
            this.panel1.Controls.Add(this.listTamanlanan);
            this.panel1.Controls.Add(this.listEklenen);
            this.panel1.Controls.Add(this.lblYapilacaklarListesi);
            this.panel1.Controls.Add(this.btnSifirla);
            this.panel1.Controls.Add(this.btnGeriAl);
            this.panel1.Controls.Add(this.btnTamamlandi);
            this.panel1.Controls.Add(this.btnGorevSil);
            this.panel1.Controls.Add(this.btnGorevEkle);
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 462);
            this.panel1.TabIndex = 7;
            // 
            // lblGorevler
            // 
            this.lblGorevler.AutoSize = true;
            this.lblGorevler.BackColor = System.Drawing.Color.Transparent;
            this.lblGorevler.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorevler.ForeColor = System.Drawing.Color.White;
            this.lblGorevler.Location = new System.Drawing.Point(10, 76);
            this.lblGorevler.Name = "lblGorevler";
            this.lblGorevler.Size = new System.Drawing.Size(111, 28);
            this.lblGorevler.TabIndex = 16;
            this.lblGorevler.Text = "Görevler";
            this.lblGorevler.Click += new System.EventHandler(this.lblGorevler_Click);
            // 
            // lblTamamlananlar
            // 
            this.lblTamamlananlar.AutoSize = true;
            this.lblTamamlananlar.BackColor = System.Drawing.Color.Transparent;
            this.lblTamamlananlar.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTamamlananlar.ForeColor = System.Drawing.Color.White;
            this.lblTamamlananlar.Location = new System.Drawing.Point(339, 76);
            this.lblTamamlananlar.Name = "lblTamamlananlar";
            this.lblTamamlananlar.Size = new System.Drawing.Size(194, 28);
            this.lblTamamlananlar.TabIndex = 15;
            this.lblTamamlananlar.Text = "Tamamlananlar";
            this.lblTamamlananlar.Click += new System.EventHandler(this.lblTamamlananlar_Click_1);
            // 
            // lblEklenen
            // 
            this.lblEklenen.AutoSize = true;
            this.lblEklenen.BackColor = System.Drawing.Color.Transparent;
            this.lblEklenen.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEklenen.ForeColor = System.Drawing.Color.White;
            this.lblEklenen.Location = new System.Drawing.Point(174, 76);
            this.lblEklenen.Name = "lblEklenen";
            this.lblEklenen.Size = new System.Drawing.Size(136, 28);
            this.lblEklenen.TabIndex = 14;
            this.lblEklenen.Text = "Eklenenler";
            this.lblEklenen.Click += new System.EventHandler(this.lblEklenen_Click);
            // 
            // txtGörevEkle
            // 
            this.txtGörevEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGörevEkle.Location = new System.Drawing.Point(12, 107);
            this.txtGörevEkle.Name = "txtGörevEkle";
            this.txtGörevEkle.Size = new System.Drawing.Size(151, 146);
            this.txtGörevEkle.TabIndex = 13;
            this.txtGörevEkle.Text = "";
            this.txtGörevEkle.TextChanged += new System.EventHandler(this.txtGörevEkle_TextChanged_3);
            // 
            // listTamanlanan
            // 
            this.listTamanlanan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listTamanlanan.FormattingEnabled = true;
            this.listTamanlanan.ItemHeight = 24;
            this.listTamanlanan.Location = new System.Drawing.Point(368, 107);
            this.listTamanlanan.Name = "listTamanlanan";
            this.listTamanlanan.Size = new System.Drawing.Size(165, 268);
            this.listTamanlanan.TabIndex = 12;
            this.listTamanlanan.SelectedIndexChanged += new System.EventHandler(this.listTamamlanan_SelectedIndexChanged_1);
            // 
            // listEklenen
            // 
            this.listEklenen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listEklenen.FormattingEnabled = true;
            this.listEklenen.ItemHeight = 24;
            this.listEklenen.Location = new System.Drawing.Point(179, 107);
            this.listEklenen.Name = "listEklenen";
            this.listEklenen.Size = new System.Drawing.Size(165, 268);
            this.listEklenen.TabIndex = 11;
            this.listEklenen.SelectedIndexChanged += new System.EventHandler(this.listEklenen_SelectedIndexChanged_1);
            // 
            // lblYapilacaklarListesi
            // 
            this.lblYapilacaklarListesi.AutoSize = true;
            this.lblYapilacaklarListesi.BackColor = System.Drawing.Color.Transparent;
            this.lblYapilacaklarListesi.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYapilacaklarListesi.ForeColor = System.Drawing.Color.White;
            this.lblYapilacaklarListesi.Location = new System.Drawing.Point(3, 15);
            this.lblYapilacaklarListesi.Name = "lblYapilacaklarListesi";
            this.lblYapilacaklarListesi.Size = new System.Drawing.Size(376, 45);
            this.lblYapilacaklarListesi.TabIndex = 8;
            this.lblYapilacaklarListesi.Text = "Yapılacaklar Listesi";
            this.lblYapilacaklarListesi.Click += new System.EventHandler(this.lblYapilacaklarListesi_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.Turquoise;
            this.btnSifirla.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.ForeColor = System.Drawing.Color.White;
            this.btnSifirla.Location = new System.Drawing.Point(12, 397);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(148, 40);
            this.btnSifirla.TabIndex = 10;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGeriAl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriAl.ForeColor = System.Drawing.Color.White;
            this.btnGeriAl.Location = new System.Drawing.Point(366, 397);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(167, 40);
            this.btnGeriAl.TabIndex = 9;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = false;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTamamlandi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamlandi.ForeColor = System.Drawing.Color.White;
            this.btnTamamlandi.Location = new System.Drawing.Point(179, 397);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(165, 40);
            this.btnTamamlandi.TabIndex = 5;
            this.btnTamamlandi.Text = "Tamamlandı";
            this.btnTamamlandi.UseVisualStyleBackColor = false;
            this.btnTamamlandi.Click += new System.EventHandler(this.btnTamamlandi_Click);
            // 
            // btnGorevSil
            // 
            this.btnGorevSil.BackColor = System.Drawing.Color.Red;
            this.btnGorevSil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevSil.ForeColor = System.Drawing.Color.White;
            this.btnGorevSil.Location = new System.Drawing.Point(12, 335);
            this.btnGorevSil.Name = "btnGorevSil";
            this.btnGorevSil.Size = new System.Drawing.Size(148, 40);
            this.btnGorevSil.TabIndex = 3;
            this.btnGorevSil.Text = "Görev Sil";
            this.btnGorevSil.UseVisualStyleBackColor = false;
            this.btnGorevSil.Click += new System.EventHandler(this.btnGorevSil_Click);
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGorevEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevEkle.ForeColor = System.Drawing.Color.White;
            this.btnGorevEkle.Location = new System.Drawing.Point(12, 274);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(148, 40);
            this.btnGorevEkle.TabIndex = 2;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = false;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnAlarmSifirla);
            this.panel2.Controls.Add(this.txtMetin);
            this.panel2.Controls.Add(this.txtSaat);
            this.panel2.Controls.Add(this.txtTarih);
            this.panel2.Controls.Add(this.btnAlarmKur);
            this.panel2.Controls.Add(this.lblAlarmMetni);
            this.panel2.Controls.Add(this.lblSaat);
            this.panel2.Controls.Add(this.lblTarih);
            this.panel2.Controls.Add(this.lblAlarmKur);
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 268);
            this.panel2.TabIndex = 8;
            // 
            // btnAlarmSifirla
            // 
            this.btnAlarmSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarmSifirla.Location = new System.Drawing.Point(410, 145);
            this.btnAlarmSifirla.Name = "btnAlarmSifirla";
            this.btnAlarmSifirla.Size = new System.Drawing.Size(123, 101);
            this.btnAlarmSifirla.TabIndex = 30;
            this.btnAlarmSifirla.Text = "Tüm Alarmları Sıfırla";
            this.btnAlarmSifirla.UseVisualStyleBackColor = true;
            this.btnAlarmSifirla.Click += new System.EventHandler(this.btnAlarmSifirla_Click);
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMetin.Location = new System.Drawing.Point(205, 174);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(179, 34);
            this.txtMetin.TabIndex = 29;
            this.txtMetin.TextChanged += new System.EventHandler(this.txtMetin_TextChanged);
            // 
            // txtSaat
            // 
            this.txtSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaat.Location = new System.Drawing.Point(205, 135);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(179, 34);
            this.txtSaat.TabIndex = 28;
            this.txtSaat.TextChanged += new System.EventHandler(this.txtSaat_TextChanged);
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(205, 96);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(179, 34);
            this.txtTarih.TabIndex = 27;
            this.txtTarih.TextChanged += new System.EventHandler(this.txtTarih_TextChanged);
            // 
            // btnAlarmKur
            // 
            this.btnAlarmKur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarmKur.Location = new System.Drawing.Point(410, 28);
            this.btnAlarmKur.Name = "btnAlarmKur";
            this.btnAlarmKur.Size = new System.Drawing.Size(123, 101);
            this.btnAlarmKur.TabIndex = 24;
            this.btnAlarmKur.Text = "Kur";
            this.btnAlarmKur.UseVisualStyleBackColor = true;
            this.btnAlarmKur.Click += new System.EventHandler(this.btnAlarmKur_Click);
            // 
            // lblAlarmMetni
            // 
            this.lblAlarmMetni.AutoSize = true;
            this.lblAlarmMetni.BackColor = System.Drawing.Color.Transparent;
            this.lblAlarmMetni.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarmMetni.ForeColor = System.Drawing.Color.Black;
            this.lblAlarmMetni.Location = new System.Drawing.Point(9, 174);
            this.lblAlarmMetni.Name = "lblAlarmMetni";
            this.lblAlarmMetni.Size = new System.Drawing.Size(174, 34);
            this.lblAlarmMetni.TabIndex = 20;
            this.lblAlarmMetni.Text = "Alarm Metni:";
            this.lblAlarmMetni.Click += new System.EventHandler(this.lblAlarmMetni_Click);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.Black;
            this.lblSaat.Location = new System.Drawing.Point(58, 135);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(80, 34);
            this.lblSaat.TabIndex = 19;
            this.lblSaat.Text = "Saat:";
            this.lblSaat.Click += new System.EventHandler(this.lblSaat_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Black;
            this.lblTarih.Location = new System.Drawing.Point(50, 95);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(88, 34);
            this.lblTarih.TabIndex = 18;
            this.lblTarih.Text = "Tarih:";
            this.lblTarih.Click += new System.EventHandler(this.lblTarih_Click);
            // 
            // lblAlarmKur
            // 
            this.lblAlarmKur.AutoSize = true;
            this.lblAlarmKur.BackColor = System.Drawing.Color.Transparent;
            this.lblAlarmKur.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarmKur.ForeColor = System.Drawing.Color.Black;
            this.lblAlarmKur.Location = new System.Drawing.Point(7, 14);
            this.lblAlarmKur.Name = "lblAlarmKur";
            this.lblAlarmKur.Size = new System.Drawing.Size(206, 45);
            this.lblAlarmKur.TabIndex = 17;
            this.lblAlarmKur.Text = "Alarm Kur";
            this.lblAlarmKur.Click += new System.EventHandler(this.lblAlarmKur_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.notepad);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(552, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 728);
            this.panel3.TabIndex = 9;
            // 
            // notepad
            // 
            this.notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notepad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notepad.Location = new System.Drawing.Point(0, 28);
            this.notepad.Name = "notepad";
            this.notepad.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.notepad.Size = new System.Drawing.Size(736, 698);
            this.notepad.TabIndex = 1;
            this.notepad.Text = "";
            this.notepad.TextChanged += new System.EventHandler(this.notepad_TextChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click_1);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click_1);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçToolStripMenuItem,
            this.tümünüSeçToolStripMenuItem,
            this.geriAlToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.silToolStripMenuItem,
            this.tümünüSilToolStripMenuItem1});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            this.düzenToolStripMenuItem.Click += new System.EventHandler(this.düzenToolStripMenuItem_Click);
            // 
            // seçToolStripMenuItem
            // 
            this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
            this.seçToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.seçToolStripMenuItem.Text = "Seç";
            this.seçToolStripMenuItem.Click += new System.EventHandler(this.seçToolStripMenuItem_Click);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tümünüSilToolStripMenuItem1
            // 
            this.tümünüSilToolStripMenuItem1.Name = "tümünüSilToolStripMenuItem1";
            this.tümünüSilToolStripMenuItem1.Size = new System.Drawing.Size(172, 26);
            this.tümünüSilToolStripMenuItem1.Text = "Tümünü Sil";
            this.tümünüSilToolStripMenuItem1.Click += new System.EventHandler(this.tümünüSilToolStripMenuItem1_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıFontuToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.formatToolStripMenuItem.Text = "Görünüm";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.formatToolStripMenuItem_Click);
            // 
            // yazıFontuToolStripMenuItem
            // 
            this.yazıFontuToolStripMenuItem.Name = "yazıFontuToolStripMenuItem";
            this.yazıFontuToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.yazıFontuToolStripMenuItem.Text = "Yazı Fontu";
            this.yazıFontuToolStripMenuItem.Click += new System.EventHandler(this.yazıFontuToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxHistory.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 28;
            this.listBoxHistory.Location = new System.Drawing.Point(1288, 68);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(236, 620);
            this.listBoxHistory.TabIndex = 10;
            this.listBoxHistory.SelectedIndexChanged += new System.EventHandler(this.listBoxHistory_SelectedIndexChanged);
            // 
            // btnTumTemizle
            // 
            this.btnTumTemizle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTumTemizle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTumTemizle.Location = new System.Drawing.Point(1306, 744);
            this.btnTumTemizle.Name = "btnTumTemizle";
            this.btnTumTemizle.Size = new System.Drawing.Size(208, 40);
            this.btnTumTemizle.TabIndex = 17;
            this.btnTumTemizle.Text = "Tümünü Temizle";
            this.btnTumTemizle.UseVisualStyleBackColor = false;
            this.btnTumTemizle.Click += new System.EventHandler(this.btnTumTemizle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(1306, 689);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(208, 40);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1526, 853);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.btnTumTemizle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblMyPlanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Planner App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyPlanner;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTamamlandi;
        private System.Windows.Forms.Button btnGorevSil;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.Label lblYapilacaklarListesi;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.RichTextBox txtGörevEkle;
        private System.Windows.Forms.ListBox listTamanlanan;
        private System.Windows.Forms.ListBox listEklenen;
        private System.Windows.Forms.Label lblGorevler;
        private System.Windows.Forms.Label lblTamamlananlar;
        private System.Windows.Forms.Label lblEklenen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RichTextBox notepad;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıFontuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblAlarmKur;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSilToolStripMenuItem1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblAlarmMetni;
        private System.Windows.Forms.Button btnAlarmKur;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Button btnTumTemizle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAlarmSifirla;
    }
}

