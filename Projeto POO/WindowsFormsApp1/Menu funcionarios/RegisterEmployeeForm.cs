using ClientManagement_OOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{       /// <summary>
        /// Formulário para registar novos funcionários.
        /// </summary>
    public partial class RegisterEmployeeForm : Form
    {
        public List<Funcionario> Funcionarios { get; set; } // Adiciona a lista de funcionários
        private readonly string filePath = "funcionarios.json"; // Caminho do arquivo JSON

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="RegisterEmployeeForm"/>.
        /// </summary>
        /// <param name="funcionarios">Lista de funcionários existente.</param>
        public RegisterEmployeeForm(List<Funcionario> funcionarios)
        {
            InitializeComponent();

            // Carrega a lista de funcionários do arquivo JSON
            Funcionarios = DataLoader.LoadFuncionariosFromFile(filePath);
        }
        /// <summary>
        /// Evento de clique do botão para registrar um funcionário.
        /// </summary>
        /// <param name="sender">O objeto que gerou o evento.</param>
        /// <param name="e">Os dados do evento.</param>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text; // Obtém o nome do funcionário
            string numeroFuncionario = txtNumeroFuncionario.Text;// Obtém o número do funcionário
            string password = txtPassword.Text;// Obtém a senha do funcionário

            // Chama o método da classe Registos para registar o funcionário
            Registos.RegisterEmployee(Funcionarios, filePath, nome, numeroFuncionario, password);

            // Fecha o formulário após registar com sucesso
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}







