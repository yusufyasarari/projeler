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
    public partial class PauseMenu : Form
    {
        private oyun form1;
        public PauseMenu(oyun form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oyunadevam_but_Click(object sender, EventArgs e)
        {
            this.Hide();

            form1.TimerInForm1.Start();
        }
    }
}
