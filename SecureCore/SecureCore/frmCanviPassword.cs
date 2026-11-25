using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataAccess;

namespace SecureCore
{
    public partial class frmCanviPassword : Form
    {
        private string login;

        public frmCanviPassword(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnDesar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (txtNouPassword.Text == "" || txtNouPassword.Text != txtRepetirPassword.Text)
            {
                lblError.Text = "Les contrasenyes no coincideixen.";
                return;
            }
            if (txtNouPassword.Text == "12345aA")
            {
                lblError.Text = "Has de triar una contrasenya diferent de la inicial.";
                return;
            }

            try
            {
                string salt = HashUser.GenerarSalt();
                string hash = HashUser.PasswordSaltat(txtNouPassword.Text, salt);

                Dictionary<string, object> parametres = new Dictionary<string, object>();
                parametres.Add("@Password", hash);
                parametres.Add("@Salt", salt);
                parametres.Add("@Login", login);

                ComponentDades bd = new ComponentDades();
                bd.Connectar();
                bd.Executa("update Users set Password = @Password, Salt = @Salt where Login = @Login", parametres);

                MessageBox.Show("Contrasenya canviada. Torna a entrar amb la nova.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No s'ha pogut canviar la contrasenya:\n" + ex.Message);
            }
        }
    }
}