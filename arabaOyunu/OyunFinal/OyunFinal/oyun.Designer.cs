namespace OyunFinal
{
    partial class oyun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyun));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Labelhiz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.puan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carpma = new System.Windows.Forms.PictureBox();
            this.bizim_araba = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.yol1 = new System.Windows.Forms.PictureBox();
            this.yol4 = new System.Windows.Forms.PictureBox();
            this.yol2 = new System.Windows.Forms.PictureBox();
            this.yol3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zorlukSeviyesi = new System.Windows.Forms.ComboBox();
            this.zorlukseviyesi_txt = new System.Windows.Forms.Label();
            this.aracecimi = new System.Windows.Forms.ComboBox();
            this.AracSecimi_txt = new System.Windows.Forms.Label();
            this.OyunaDevam_but = new System.Windows.Forms.Button();
            this.Oyundancik_but = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.arabagit = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cıkıs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizim_araba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabagit)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "GAZLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(33, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hiziniz:";
            // 
            // Labelhiz
            // 
            this.Labelhiz.AutoSize = true;
            this.Labelhiz.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Labelhiz.ForeColor = System.Drawing.Color.White;
            this.Labelhiz.Location = new System.Drawing.Point(125, 545);
            this.Labelhiz.Name = "Labelhiz";
            this.Labelhiz.Size = new System.Drawing.Size(0, 28);
            this.Labelhiz.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Oyunu durdurmak icin \r\n\"esc\"ye basiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(32, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Puan..:";
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan.ForeColor = System.Drawing.Color.White;
            this.puan.Location = new System.Drawing.Point(125, 509);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(38, 28);
            this.puan.TabIndex = 16;
            this.puan.Text = "00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.bizim_araba);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.yol1);
            this.panel1.Controls.Add(this.yol4);
            this.panel1.Controls.Add(this.yol2);
            this.panel1.Controls.Add(this.yol3);
            this.panel1.Location = new System.Drawing.Point(32, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 453);
            this.panel1.TabIndex = 15;
            // 
            // carpma
            // 
            this.carpma.Image = ((System.Drawing.Image)(resources.GetObject("carpma.Image")));
            this.carpma.Location = new System.Drawing.Point(231, 256);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(64, 64);
            this.carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.carpma.TabIndex = 22;
            this.carpma.TabStop = false;
            this.carpma.Visible = false;
            // 
            // bizim_araba
            // 
            this.bizim_araba.Image = global::OyunFinal.Properties.Resources.motor1;
            this.bizim_araba.Location = new System.Drawing.Point(244, 315);
            this.bizim_araba.MaximumSize = new System.Drawing.Size(64, 119);
            this.bizim_araba.MinimumSize = new System.Drawing.Size(51, 106);
            this.bizim_araba.Name = "bizim_araba";
            this.bizim_araba.Size = new System.Drawing.Size(51, 106);
            this.bizim_araba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bizim_araba.TabIndex = 21;
            this.bizim_araba.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = ((System.Drawing.Image)(resources.GetObject("araba2.Image")));
            this.araba2.Location = new System.Drawing.Point(244, 82);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(66, 122);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba2.TabIndex = 20;
            this.araba2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = ((System.Drawing.Image)(resources.GetObject("araba1.Image")));
            this.araba1.Location = new System.Drawing.Point(65, 37);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(69, 127);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba1.TabIndex = 19;
            this.araba1.TabStop = false;
            // 
            // yol1
            // 
            this.yol1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yol1.BackgroundImage")));
            this.yol1.Location = new System.Drawing.Point(0, -116);
            this.yol1.Name = "yol1";
            this.yol1.Size = new System.Drawing.Size(380, 677);
            this.yol1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol1.TabIndex = 18;
            this.yol1.TabStop = false;
            // 
            // yol4
            // 
            this.yol4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yol4.BackgroundImage")));
            this.yol4.Location = new System.Drawing.Point(0, -1116);
            this.yol4.Name = "yol4";
            this.yol4.Size = new System.Drawing.Size(395, 677);
            this.yol4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol4.TabIndex = 13;
            this.yol4.TabStop = false;
            // 
            // yol2
            // 
            this.yol2.Location = new System.Drawing.Point(-2, -638);
            this.yol2.Name = "yol2";
            this.yol2.Size = new System.Drawing.Size(385, 630);
            this.yol2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol2.TabIndex = 3;
            this.yol2.TabStop = false;
            // 
            // yol3
            // 
            this.yol3.Location = new System.Drawing.Point(-10, -1000);
            this.yol3.Name = "yol3";
            this.yol3.Size = new System.Drawing.Size(395, 677);
            this.yol3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol3.TabIndex = 2;
            this.yol3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zorlukSeviyesi
            // 
            this.zorlukSeviyesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zorlukSeviyesi.FormattingEnabled = true;
            this.zorlukSeviyesi.Items.AddRange(new object[] {
            "kolay",
            "normal",
            "zor"});
            this.zorlukSeviyesi.Location = new System.Drawing.Point(235, 586);
            this.zorlukSeviyesi.Name = "zorlukSeviyesi";
            this.zorlukSeviyesi.Size = new System.Drawing.Size(130, 21);
            this.zorlukSeviyesi.TabIndex = 22;
            // 
            // zorlukseviyesi_txt
            // 
            this.zorlukseviyesi_txt.AutoSize = true;
            this.zorlukseviyesi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zorlukseviyesi_txt.ForeColor = System.Drawing.Color.Transparent;
            this.zorlukseviyesi_txt.Location = new System.Drawing.Point(202, 564);
            this.zorlukseviyesi_txt.Name = "zorlukseviyesi_txt";
            this.zorlukseviyesi_txt.Size = new System.Drawing.Size(205, 20);
            this.zorlukseviyesi_txt.TabIndex = 23;
            this.zorlukseviyesi_txt.Text = "Lutfen oyun zorlugu seciniz;";
            // 
            // aracecimi
            // 
            this.aracecimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aracecimi.FormattingEnabled = true;
            this.aracecimi.Items.AddRange(new object[] {
            "Araba",
            "Motor"});
            this.aracecimi.Location = new System.Drawing.Point(235, 626);
            this.aracecimi.MinimumSize = new System.Drawing.Size(130, 0);
            this.aracecimi.Name = "aracecimi";
            this.aracecimi.Size = new System.Drawing.Size(130, 21);
            this.aracecimi.TabIndex = 24;
            this.aracecimi.SelectedIndexChanged += new System.EventHandler(this.aracecimi_SelectedIndexChanged);
            // 
            // AracSecimi_txt
            // 
            this.AracSecimi_txt.AutoSize = true;
            this.AracSecimi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AracSecimi_txt.ForeColor = System.Drawing.Color.Transparent;
            this.AracSecimi_txt.Location = new System.Drawing.Point(204, 606);
            this.AracSecimi_txt.Name = "AracSecimi_txt";
            this.AracSecimi_txt.Size = new System.Drawing.Size(200, 18);
            this.AracSecimi_txt.TabIndex = 25;
            this.AracSecimi_txt.Text = "istediginiz araci secebilirsiniz;";
            // 
            // OyunaDevam_but
            // 
            this.OyunaDevam_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(102)))));
            this.OyunaDevam_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OyunaDevam_but.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OyunaDevam_but.Location = new System.Drawing.Point(212, 564);
            this.OyunaDevam_but.Name = "OyunaDevam_but";
            this.OyunaDevam_but.Size = new System.Drawing.Size(167, 40);
            this.OyunaDevam_but.TabIndex = 26;
            this.OyunaDevam_but.Text = "Devam Et";
            this.OyunaDevam_but.UseVisualStyleBackColor = false;
            this.OyunaDevam_but.Click += new System.EventHandler(this.OyunaDevam_but_Click);
            // 
            // Oyundancik_but
            // 
            this.Oyundancik_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(102)))));
            this.Oyundancik_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Oyundancik_but.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oyundancik_but.Location = new System.Drawing.Point(212, 613);
            this.Oyundancik_but.Name = "Oyundancik_but";
            this.Oyundancik_but.Size = new System.Drawing.Size(167, 40);
            this.Oyundancik_but.TabIndex = 27;
            this.Oyundancik_but.Text = "Cikis";
            this.Oyundancik_but.UseVisualStyleBackColor = false;
            this.Oyundancik_but.Click += new System.EventHandler(this.Oyundancik_but_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-5, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 1);
            this.panel2.TabIndex = 29;
            // 
            // arabagit
            // 
            this.arabagit.BackColor = System.Drawing.Color.Transparent;
            this.arabagit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arabagit.ErrorImage = null;
            this.arabagit.Image = ((System.Drawing.Image)(resources.GetObject("arabagit.Image")));
            this.arabagit.Location = new System.Drawing.Point(-45, -9);
            this.arabagit.Name = "arabagit";
            this.arabagit.Size = new System.Drawing.Size(50, 52);
            this.arabagit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arabagit.TabIndex = 28;
            this.arabagit.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cıkıs
            // 
            this.cıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(102)))));
            this.cıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cıkıs.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cıkıs.Location = new System.Drawing.Point(38, 629);
            this.cıkıs.Name = "cıkıs";
            this.cıkıs.Size = new System.Drawing.Size(70, 28);
            this.cıkıs.TabIndex = 30;
            this.cıkıs.Text = "Cikis";
            this.cıkıs.UseVisualStyleBackColor = false;
            this.cıkıs.Click += new System.EventHandler(this.button2_Click);
            // 
            // oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(162)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(443, 697);
            this.Controls.Add(this.cıkıs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.arabagit);
            this.Controls.Add(this.Oyundancik_but);
            this.Controls.Add(this.OyunaDevam_but);
            this.Controls.Add(this.AracSecimi_txt);
            this.Controls.Add(this.aracecimi);
            this.Controls.Add(this.zorlukseviyesi_txt);
            this.Controls.Add(this.zorlukSeviyesi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Labelhiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oyun";
            this.Load += new System.EventHandler(this.oyun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oyun_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.oyun_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.oyun_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.oyun_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizim_araba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabagit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Labelhiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox carpma;
        private System.Windows.Forms.PictureBox bizim_araba;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.PictureBox yol1;
        private System.Windows.Forms.PictureBox yol4;
        private System.Windows.Forms.PictureBox yol2;
        private System.Windows.Forms.PictureBox yol3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox zorlukSeviyesi;
        private System.Windows.Forms.Label zorlukseviyesi_txt;
        private System.Windows.Forms.ComboBox aracecimi;
        private System.Windows.Forms.Label AracSecimi_txt;
        private System.Windows.Forms.Button OyunaDevam_but;
        private System.Windows.Forms.Button Oyundancik_but;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox arabagit;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button cıkıs;
    }
}