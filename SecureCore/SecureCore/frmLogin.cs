
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
    public partial class frmLogin : Form
    {
        private Timer timer;
        private Timer fadeTimer;

        private int opacidad = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        public void componentsVisible()
        {


            txtUser.Visible = true;
            txtPassword.Visible = true;

            lblLogin.Visible = true;

            label1.Visible = true;
            label2.Visible = true;

            btnLogin.Visible = true;
            btnsortir.Visible = true;

        }

        public void componentsInvisible()
        {
            txtUser.Visible = false;
            txtPassword.Visible = false;

            lblLogin.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            btnLogin.Visible = false;
            btnsortir.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            opacidad = 0;
            this.Opacity = 0;

            fadeTimer = new Timer();
            fadeTimer.Interval = 20;

            fadeTimer.Tick += (s2, e2) =>
            {
                opacidad += 5;

                if (opacidad >= 100)
                {
                    opacidad = 100;
                    fadeTimer.Stop();
                    fadeTimer.Dispose();
                }

                this.Opacity = opacidad / 100.0;
            };

            fadeTimer.Start();

            timer = new Timer();
            timer.Interval = 2800;

            timer.Tick += (s, args) =>
            {
                timer.Stop();

                componentsVisible();


                
            };

            timer.Start();
        }

       

        public void ObrirFrmPrincipal()
        {
            frmPrincipal frm = new frmPrincipal();

            frm.Show();

            this.Hide();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkOrange;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.SaddleBrown;

        }

        private void btnsortir_MouseHover(object sender, EventArgs e)
        {
            btnsortir.BackColor = Color.DarkOrange;

        }

        private void btnsortir_MouseLeave(object sender, EventArgs e)
        {
            btnsortir.BackColor = Color.SaddleBrown;

        }

        private void btnsortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtPassword.Text == "12345aA")
            {
                lblErrorMessage.Visible = false;

                pnlFirstLogin.Visible = false;

                pnlContrassenya.Visible = true;

            }
            else
            {
                lblErrorMessage.Visible = true;

            }

        }

        private void btnAccedir2_Click(object sender, EventArgs e)
        {

            if(txtPass2.Text.Length >= 5)
            {
                if (txtPass2.Text == txtRepPass.Text)
                {
                    lblerror2.Visible = false;

                    ObrirFrmPrincipal();


                }
                else
                {
                    lblerror2.Text = "No coincideix";

                    lblerror2.Visible = true;
                }
            }
            else
            {
                lblerror2.Text = "Minim 5 caracters";
                lblerror2.Visible = true;

            }



        }
    } 
}
