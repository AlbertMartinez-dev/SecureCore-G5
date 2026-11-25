using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

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

                ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["SecureCoreG5ConnectionString"];
                SqlConnection conn = new SqlConnection(conf.ConnectionString);
                try
                {
                    conn.Open();
                    SqlCommand command = conn.CreateCommand();
                    command.CommandText = "update Users set Password = @Password, Salt = @Salt where Login = @Login";
                    command.Parameters.Add(new SqlParameter("@Password", hash));
                    command.Parameters.Add(new SqlParameter("@Salt", salt));
                    command.Parameters.Add(new SqlParameter("@Login", login));
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }

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