using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    public partial class RegisterEmployeeForm : Form
    {
        private EmployeeController _EmployeeController; // Controller para Gerir funcionários

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="RegisterEmployeeForm"/>.
        /// </summary>
        /// <param name="EmployeeController">O controller de funcionários.</param>
        public RegisterEmployeeForm(EmployeeController EmployeeController)
        {
            InitializeComponent();
            _EmployeeController = EmployeeController; // Inicializa o controller
        }

        /// <summary>
        /// Evento de clique do botão para registar um funcionário.
        /// </summary>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Obtém os dados dos campos do formulário
            string Name = txtName.Text;
            string EmployeeNumber = txtEmployeeNumber.Text;
            string password = txtPassword.Text;

            // Regista o funcionário usando o controller
            var result = _EmployeeController.RegisterEmployee(Name, EmployeeNumber, password);

            if (result.success)
            {
                MessageBox.Show(result.message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fecha o formulário após o registo bem-sucedido
            }
            else
            {
                MessageBox.Show(result.message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
