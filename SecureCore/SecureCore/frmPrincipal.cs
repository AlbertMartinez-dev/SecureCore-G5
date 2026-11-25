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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(string usuari, string nivell)
        {
            InitializeComponent();
            label1.Text = usuari + " - Nivell " + nivell;
            this.Text = "Secure Core - " + usuari;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(
        pictureBox1,
        0,
        pictureBox1.Height
    );
        }
    }
}
