namespace OyunFinal
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.oyunbasla_but = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.arabagit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arabagit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-12, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 1);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Yaris Oyunu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // oyunbasla_but
            // 
            this.oyunbasla_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(102)))));
            this.oyunbasla_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oyunbasla_but.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oyunbasla_but.Location = new System.Drawing.Point(116, 156);
            this.oyunbasla_but.Name = "oyunbasla_but";
            this.oyunbasla_but.Size = new System.Drawing.Size(167, 40);
            this.oyunbasla_but.TabIndex = 15;
            this.oyunbasla_but.Text = "Oyuna Basla";
            this.oyunbasla_but.UseVisualStyleBackColor = false;
            this.oyunbasla_but.Click += new System.EventHandler(this.oyunbasla_but_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(102)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(116, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 40);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cikis";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // arabagit
            // 
            this.arabagit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(128)))), ((int)(((byte)(149)))));
            this.arabagit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arabagit.ErrorImage = null;
            this.arabagit.Image = ((System.Drawing.Image)(resources.GetObject("arabagit.Image")));
            this.arabagit.Location = new System.Drawing.Point(-68, 286);
            this.arabagit.Name = "arabagit";
            this.arabagit.Size = new System.Drawing.Size(63, 56);
            this.arabagit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arabagit.TabIndex = 20;
            this.arabagit.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yapimci Yusuf Yasar Ari";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(128)))), ((int)(((byte)(149)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(393, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arabagit);
            this.Controls.Add(this.oyunbasla_but);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.arabagit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox arabagit;
        private System.Windows.Forms.Button oyunbasla_but;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

