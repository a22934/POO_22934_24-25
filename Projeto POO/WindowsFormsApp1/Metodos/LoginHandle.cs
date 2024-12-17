using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement_OOP;
using WindowsFormsApp1;
        /// <summary>
        /// Classe estática responsável por manipular o login e registro de usuários.
        /// </summary>  
public static class LoginHandler
{        
        /// <summary>
        /// Manipula o processo de login para funcionários e clientes.
        /// </summary>
        /// <param name="username">Nome de usuário fornecido.</param>
        /// <param name="password">Senha fornecida.</param>
        /// <param name="funcionarios">Lista de funcionários.</param>
        /// <param name="clients">Lista de clientes.</param>
        /// <param name="loginForm">Instância do formulário de login.</param>   
    public static void HandleLogin(string username, string password, List<Funcionario> funcionarios, List<Client> clients, LoginForm loginForm)
    {
        // Verifica se o login é de um funcionário
        Funcionario funcionario = funcionarios.Find(f => f.NumeroFuncionario == username && f.Password == password);
        if (funcionario != null)
        {
            
            MessageBox.Show("Login de funcionário bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Define que o utilizador logado é um funcionário
            loginForm.IsFuncionario = true;

            
            loginForm.DialogResult = DialogResult.OK;
            loginForm.Close();
            return;  
        }

        // Caso não seja funcionário, verifica se é um cliente
        Client client = clients.Find(c => c.Nome == username && c.Password == password);
        if (client != null)
        {
            
            MessageBox.Show("Login de cliente bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Define que o utilizador logado não é um funcionário
            loginForm.IsFuncionario = false;

           
            loginForm.DialogResult = DialogResult.OK;
            loginForm.Close();
            return; 
        }
        else
        {
            // Caso o login falhe para funcionário e cliente
            MessageBox.Show("Nome de utilizador ou palavra-passe incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    /// <summary>
    /// Manipula o processo de registro de novos clientes.
    /// </summary>
    /// <param name="loginForm">Instância do formulário de login.</param>
    public static void HandleRegister(LoginForm loginForm)
    {
        // Passa a lista de clientes do loginForm para o RegisterClientForm
        RegisterClientForm registerClientForm = new RegisterClientForm(loginForm.Clients);

        if (registerClientForm.ShowDialog() == DialogResult.OK)
        {
            // Recarrega a lista de clientes após o registro
            loginForm.Clients = DataLoader.LoadClientsFromFile("Clients.json"); // Recarrega os clientes do arquivo
        }
    }
}
