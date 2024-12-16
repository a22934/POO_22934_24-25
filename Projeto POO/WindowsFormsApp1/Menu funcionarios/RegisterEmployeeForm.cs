using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterEmployeeForm : Form
    {
        public List<Funcionario> Funcionarios { get; set; }
        private readonly string filePath = "funcionarios.json";

        public RegisterEmployeeForm(List<Funcionario> funcionarios)
        {
            InitializeComponent();

            // Carrega a lista de funcionários do arquivo JSON
            Funcionarios = DataLoader.LoadFuncionariosFromFile(filePath);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Obtém os dados dos campos do formulário
            string nome = txtNome.Text;
            string numeroFuncionario = txtNumeroFuncionario.Text;
            string password = txtPassword.Text;

            // Chama o método da classe Registos para registrar o funcionário
            Registos.RegisterEmployee(Funcionarios, filePath, nome, numeroFuncionario, password);

            // Fecha o formulário após registrar com sucesso
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}







