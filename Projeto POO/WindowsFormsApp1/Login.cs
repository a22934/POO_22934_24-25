using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário e senha são válidos
            if (txtUsername.Text == "12" && txtPassword.Text == "12")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblErrorMessage.Text = "Usuário ou senha inválidos.";
                lblErrorMessage.Visible = true;
            }
        }
    }
}