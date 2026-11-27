using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWControls
{
    public partial class SWLoginButton : UserControl
    {
        public SWLoginButton()
        {
            InitializeComponent();


            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.ForeColor = Color.White;
            button1.BackColor = Color.SaddleBrown;

            button1.Padding = Padding.Empty;
            button1.Margin = Padding.Empty;
            button1.AutoSize = false;
            button1.Font = new Font("Microsoft Tai Le", 17f, FontStyle.Regular);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOrange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SaddleBrown;

        }

        public string TextBoto
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }
    }
}
