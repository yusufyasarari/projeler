using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunFinal
{
    public partial class Giris : Form
    {
        public Point mouseLocation;
        public Giris()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arabagit.Location = new Point(arabagit.Location.X + 10, arabagit.Location.Y);
            int value = arabagit.Width + arabagit.Location.X;
            if (value >= this.Width + 100)
            {
                arabagit.Location = new Point(-20, arabagit.Location.Y);
            }
        }

        private void oyunbasla_but_Click(object sender, EventArgs e)
        {

            oyun oyunabasla = new oyun();
            oyunabasla.Show();
            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

            
        }

        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
