using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement_OOP;
using WindowsFormsApp1;

public static class LoginHandler
{
    public static void HandleLogin(string username, string password, List<Funcionario> funcionarios, List<Client> clients, LoginForm loginForm)
    {
        // Verifica se o login é de um funcionário
        Funcionario funcionario = funcionarios.Find(f => f.NumeroFuncionario == username && f.Password == password);
        if (funcionario != null)
        {
            // Login bem-sucedido de funcionário
            MessageBox.Show("Login de funcionário bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Define que o utilizador logado é um funcionário
            loginForm.IsFuncionario = true;

            // Define o DialogResult como OK e fecha o LoginForm
            loginForm.DialogResult = DialogResult.OK;
            loginForm.Close();
            return;  // Interrompe o fluxo, pois o login foi bem-sucedido
        }

        // Caso não seja funcionário, verifica se é um cliente
        Client client = clients.Find(c => c.Nome == username && c.Password == password);
        if (client != null)
        {
            // Login bem-sucedido de cliente
            MessageBox.Show("Login de cliente bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Define que o utilizador logado não é um funcionário
            loginForm.IsFuncionario = false;

            // Define o DialogResult como OK e fecha o LoginForm
            loginForm.DialogResult = DialogResult.OK;
            loginForm.Close();
            return;  // Interrompe o fluxo, pois o login foi bem-sucedido
        }
        else
        {
            // Caso o login falhe para funcionário e cliente
            MessageBox.Show("Nome de utilizador ou palavra-passe incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

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
