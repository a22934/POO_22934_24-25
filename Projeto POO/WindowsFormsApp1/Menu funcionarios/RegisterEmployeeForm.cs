using ClientManagement_OOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class RegisterEmployeeForm : Form
    {
        public List<Funcionario> Funcionarios { get; set; }
        public RegisterEmployeeForm(List<Funcionario> funcionarios)
        {
            InitializeComponent();
            LoadFuncionariosFromFile();
            
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string numeroFuncionario = txtNumeroFuncionario.Text;
            string password = txtPassword.Text;

            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(numeroFuncionario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o número de funcionário já existe
            if (Funcionarios.Exists(f => f.NumeroFuncionario == numeroFuncionario))
            {
                MessageBox.Show("Número de funcionário já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria um novo objeto Funcionario
            Funcionario newFuncionario = new Funcionario(nome, numeroFuncionario, password);
            Funcionarios.Add(newFuncionario);
            SaveFuncionariosToFile();

            MessageBox.Show("Funcionário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Define o DialogResult como OK e fecha o formulário
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void SaveFuncionariosToFile()
        {
            string filePath = "funcionarios.json"; // Certifique-se de que o caminho está correto

            try
            {
                string updatedJson = JsonConvert.SerializeObject(Funcionarios, Formatting.Indented); // Serializa a lista `Funcionarios`
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar funcionarios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadFuncionariosFromFile()
        {
            string filePath = "funcionarios.json"; // Caminho do arquivo JSON

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    Funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(json) ?? new List<Funcionario>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar funcionarios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Funcionarios = new List<Funcionario>();
                }
            }
            else
            {
                Funcionarios = new List<Funcionario>();
            }
        }
       
    }
}



   
       
  

    
