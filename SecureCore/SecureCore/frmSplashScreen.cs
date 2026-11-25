using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCore
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {

            InitializeComponent();

            Timer();
        }


        public void Timer()
        {

            pgbSplash.Minimum = 0;
            pgbSplash.Maximum = 100;
            pgbSplash.Value = 0;


            timer1.Interval = 70;

            timer1.Start();



            pgbSplash.Value++;
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (pgbSplash.Value < pgbSplash.Maximum)
            {
                pgbSplash.Value += 1;
            }
            else
            {
                timer1.Stop();

                this.Close();
            }

        }
    }
}
