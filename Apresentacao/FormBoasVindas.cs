using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Apresentacao
{
    public partial class FormBoasVindas : Form
    {
        public FormBoasVindas()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar2.Value += 1;
            circularProgressBar2.Text = circularProgressBar2.Value.ToString();
            if (circularProgressBar2.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void FormBoasVindas_Load(object sender, EventArgs e)
        {

            lblUserName.Text = UserCache.PrimeiroNome +" "+ UserCache.SobreNome;
            this.Opacity = 0.0;
            circularProgressBar2.Value = 0;
            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;

                timer1.Start();
            
        }
    }
}
