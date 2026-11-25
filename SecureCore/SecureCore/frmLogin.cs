using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SecureCore
{
    public partial class frmLogin : Form
    {
        private Timer timer;
        private Timer fadeTimer;

        private int opacidad = 0;

        private const string PasswordInicial = "12345aA";
        private const string ColumnaNivell = "AccessLevel";

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
            
        private DataRow ObtenirUsuari(string login)
        {
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["SecureCoreG5ConnectionString"];
            if (conf == null)
            {
                throw new Exception("No trobo la cadena de connexió a l'App.config.");
            }
            SqlConnection conn = new SqlConnection(conf.ConnectionString);

            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from Users where Login = @Login";
            command.Parameters.Add(new SqlParameter("@Login", login));
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
            }
            finally
            {
                conn.Close();
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            return ds.Tables[0].Rows[0];
        }

        private string ObtenirNivell(object idUserCategory)
        {
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["SecureCoreG5ConnectionString"];
            SqlConnection conn = new SqlConnection(conf.ConnectionString);

            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from UserCategories where idUserCategory = @id";
            command.Parameters.Add(new SqlParameter("@id", idUserCategory));
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                adapter.Fill(ds);
            }
            finally
            {
                conn.Close();
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                throw new Exception("L'usuari no té cap categoria a UserCategories.");
            }
            if (!ds.Tables[0].Columns.Contains(ColumnaNivell))
            {
                throw new Exception("UserCategories no té la columna '" + ColumnaNivell + "'. Canvia ColumnaNivell a frmLogin.cs.");
            }
            return ds.Tables[0].Rows[0][ColumnaNivell].ToString();
        }

        private void DespresDe(int milisegons, Action accio)
        {
            Timer t = new Timer();
            t.Interval = milisegons;
            t.Tick += (s, args) =>
            {
                t.Stop();
                t.Dispose();
                accio();
            };
            t.Start();
        }

        private void MostrarMissatge(string text, Color color)
        {
            componentsInvisible();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            lblErrorMessage.ForeColor = color;
            lblErrorMessage.MaximumSize = new Size(300, 0);
            lblErrorMessage.Location = new Point(16, 40);
            lblErrorMessage.Text = text;
            lblErrorMessage.Visible = true;
        }

        private void MostrarIntrusio()
        {
            MostrarMissatge("INTRÚS DETECTAT\n\nAquest intent d'accés no autoritzat ha quedat registrat. "
                + "La Rebel Alliance ja sap qui ets.", Color.Red);

            DespresDe(3000, () =>
            {
                lblErrorMessage.Visible = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                componentsVisible();
                txtPassword.Text = "";
                txtPassword.Focus();
            });
        }

        private void MostrarBenvinguda(string nom, string codi, string nivell)
        {
            MostrarMissatge("Benvingut/da, " + nom + "\n\nCodi: " + codi + "\nNivell d'accés: " + nivell
                + "\n\nS'està verificant el nivell d'accés.\nAviat seràs redirigit a l'aplicació principal...",
                Color.FromArgb(64, 0, 0));

            DespresDe(5000, () =>
            {
                frmPrincipal frm = new frmPrincipal(nom, nivell);
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
                this.Hide();
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow usuari = ObtenirUsuari(txtUser.Text);
                if (usuari == null)
                {
                    MostrarIntrusio();
                    return;
                }

                string passwordBD = usuari["Password"].ToString();
                string saltBD = usuari["Salt"].ToString();

                if (txtPassword.Text == PasswordInicial && passwordBD == PasswordInicial)
                {
                    lblErrorMessage.Visible = false;
                    frmCanviPassword frmCanvi = new frmCanviPassword(txtUser.Text);
                    frmCanvi.ShowDialog();
                    txtPassword.Text = "";
                    return;
                }

                if (saltBD != "" && HashUser.PasswordSaltat(txtPassword.Text, saltBD) == passwordBD)
                {
                    string nivell = ObtenirNivell(usuari["idUserCategory"]);
                    MostrarBenvinguda(usuari["UserName"].ToString(), usuari["CodeUser"].ToString(), nivell);
                }
                else
                {
                    MostrarIntrusio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en validar:\n" + ex.Message);
            }
        }
    }
}