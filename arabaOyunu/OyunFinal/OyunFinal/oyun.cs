using System;
using System.Drawing;
using System.Windows.Forms;

namespace OyunFinal
{
    public partial class oyun : Form
    {

        public oyun()
        {
            InitializeComponent();
            timer2.Start();
        }
        public Point mouseLocation;
        private void oyun_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

        }

        private void oyun_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        int hizOlcer = 0;
        int kazanilan_puan = 0;
        int yol_hizi = 15;
        int araba_hiz = 15;
        bool sol_yon = false;
        bool sag_yon = false;
        int diger_araba_hizi = 15;
        Random rnd = new Random();

        private void basla()
        {
            oyunBasladi = true;
            aracecimi.Visible = false;
            AracSecimi_txt.Visible = false;
            carpma.Visible = false;
           

            if (zorlukSeviyesi.SelectedIndex == 0)
            {
                diger_araba_hizi = 10;
                yol_hizi = 10;
                timer1.Start();
                zorlukseviyesi_txt.Visible = false;
                zorlukSeviyesi.Visible = false;
                button1.Enabled = false;
                Labelhiz.Text = "10km";
            }
            else if (zorlukSeviyesi.SelectedIndex == 1)
            {
                diger_araba_hizi = 20;
                yol_hizi = 20;
                timer1.Start();
                zorlukseviyesi_txt.Visible = false;
                zorlukSeviyesi.Visible = false;
                button1.Enabled = false;
                Labelhiz.Text = "50km";
            }

            else if (zorlukSeviyesi.SelectedIndex == 2)
            {
                diger_araba_hizi = 25;
                yol_hizi = 25;
                timer1.Start();
                zorlukseviyesi_txt.Visible = false;
                zorlukSeviyesi.Visible = false;
                button1.Enabled = false;
                Labelhiz.Text = "110km";
            }
            else if (zorlukSeviyesi.SelectedIndex == -1)
            {
                MessageBox.Show("lutfen bir zorluk seciniz");
                timer1.Stop();
            }
            
          
                kazanilan_puan = 0;

                bizim_araba.Left = 166;
                bizim_araba.Top = 293;

                sol_yon = false;
                sag_yon = false;

                araba1.Left = 66;
                araba1.Top = -120;
                araba2.Left = 294;
                araba2.Top = -185;

                yol1.Left = -3;
                yol1.Top = -222;
                yol4.Left = -2;
                yol4.Top = -638;



            }
            private void timer1_Tick(object sender, EventArgs e)
            {
         
            hizOlcer++;
                kazanilan_puan++;
                puan.Text = kazanilan_puan.ToString();

                yol2.Top += yol_hizi;
                if (yol1.Top > 630) yol1.Top = -630;
                if (yol4.Top > 630) yol4.Top = -630;

                if (sol_yon) bizim_araba.Left -= araba_hiz;
                if (sag_yon) bizim_araba.Left += araba_hiz;
                if (bizim_araba.Left < 1) { sol_yon = false; }
                else if (bizim_araba.Left + bizim_araba.Width > 380) { sag_yon = false; }
            
            araba1.Top += diger_araba_hizi;
                araba2.Top += diger_araba_hizi;
                if (araba1.Top > panel1.Height)
                {
                    araba1_degistir();
                    araba1.Left = rnd.Next(2, 160);
                    araba1.Top = rnd.Next(100, 200) * -1;
                }

                if (araba2.Top > panel1.Height)
                {
                    araba2_degistir();
                    araba2.Left = rnd.Next(185, 327);
                    araba2.Top = rnd.Next(100, 200) * -1;
                }

                if (bizim_araba.Bounds.IntersectsWith(araba1.Bounds) || bizim_araba.Bounds.IntersectsWith(araba2.Bounds))
                {
                    oyunBitti();
                }

            }
        private void oyunarasi()
        {

        }
            private void oyunBitti()
            {
            cıkıs.Visible = true;

            oyunBasladi = false;
            int value = bizim_araba.Width + bizim_araba.Location.X;
            timer1.Stop();
            Oyundancik_but.Visible = false;
            OyunaDevam_but.Visible = false;
            zorlukSeviyesi.Visible = true;
                zorlukseviyesi_txt.Visible = true;
                button1.Enabled = true;
                carpma.Visible = true;
                bizim_araba.Controls.Add(carpma);
                carpma.Location = new Point(-8, 5);
                carpma.BringToFront();
                carpma.BackColor = Color.Transparent;
                MessageBox.Show("PUANINIZ: " + puan.Text + " !", "Oyun Sonu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                aracecimi.Visible = true;
                AracSecimi_txt.Visible = true;
        }
            private void araba1_degistir()
            {
                int sira = rnd.Next(1, 7);
                switch (sira)
                {
                    case 1:
                        araba1.Image = Properties.Resources.araba2;
                        break;
                    case 2:
                        araba1.Image = Properties.Resources.araba3;
                        break;
                    case 3:
                        araba1.Image = Properties.Resources.araba4;
                        break;
                    case 4:
                        araba1.Image = Properties.Resources.araba5;
                        break;
                    case 5:
                        araba1.Image = Properties.Resources.araba6;
                        break;
                    case 6:
                        araba1.Image = Properties.Resources.araba7;
                        break;
                    case 7:
                        araba1.Image = Properties.Resources.araba8;
                        break;
                    default:
                        break;

                }
            }

            private void araba2_degistir()
            {
                int sira = rnd.Next(1, 7);
                switch (sira)
                {
                    case 1:
                        araba2.Image = Properties.Resources.araba1;
                        break;
                    case 2:
                        araba2.Image = Properties.Resources.araba3;
                        break;
                    case 3:
                        araba2.Image = Properties.Resources.araba4;
                        break;
                    case 4:
                        araba2.Image = Properties.Resources.araba5;
                        break;
                    case 5:
                        araba2.Image = Properties.Resources.araba6;
                        break;
                    case 6:
                        araba2.Image = Properties.Resources.araba7;
                        break;
                    case 7:
                        araba2.Image = Properties.Resources.araba8;
                        break;
                    default:
                        break;

                }
            }
        private bool oyunBasladi = false;
        private void oyun_KeyDown(object sender, KeyEventArgs e)
            {
           
                if (e.KeyCode == Keys.Left && bizim_araba.Left > 0) sol_yon = true;

                if (e.KeyCode == Keys.Right && bizim_araba.Left + bizim_araba.Width < panel1.Width) sag_yon = true;


                if (e.KeyCode == Keys.Escape)
                {
                if (oyunBasladi) // Oyun başladıysa sadece ESC'ye basıldığında menüyü göster
                {
                    OyunaDevam_but.Visible = true;
                    Oyundancik_but.Visible = true;
                    timer1.Stop();
                }
            }

            }

            private void oyun_KeyUp(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Left) sol_yon = false;
                if (e.KeyCode == Keys.Right) sag_yon = false;

          
        }

            private void button1_Click(object sender, EventArgs e)
            {
                basla();
            cıkıs.Visible = false;


        }
        public Timer TimerInForm1 { get; } = new Timer();

        private void oyun_Load(object sender, EventArgs e)
        {
                this.KeyPreview = true;
           OyunaDevam_but.Visible = false;
            Oyundancik_but.Visible = false;

        }

        private void aracecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenArac = aracecimi.SelectedItem.ToString();
            

            if (secilenArac == "Araba" )
            {
                bizim_araba.Image = Properties.Resources.araba9;
                bizim_araba.MinimumSize = new Size(64, 119); // Minimum boyutu ayarlayın (örneğin 100x100)
                bizim_araba.MaximumSize = new Size(64, 119); // Maksimum boyutu ayarlayın (örneğin 200x200)
            }
            else if (secilenArac == "Motor" )
            {
                bizim_araba.Image = Properties.Resources.motor1;
                bizim_araba.MinimumSize = new Size(51, 106); // Minimum boyutu ayarlayın (örneğin 100x100)
                bizim_araba.MaximumSize = new Size(51, 106); // Maksimum boyutu ayarlayın (örneğin 200x200)
            }
        }

        private void OyunaDevam_but_Click(object sender, EventArgs e)
        {
            timer1.Start();
            OyunaDevam_but.Visible = false;
            Oyundancik_but.Visible = false;
            
        }

        private void Oyundancik_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            arabagit.Location = new Point(arabagit.Location.X + 10, arabagit.Location.Y);
            int value = arabagit.Width + arabagit.Location.X;
            if (value >= this.Width + 100)
            {
                arabagit.Location = new Point(-20, arabagit.Location.Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
