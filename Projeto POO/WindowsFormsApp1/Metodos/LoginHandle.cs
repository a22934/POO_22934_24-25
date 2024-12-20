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
            MessageBox.Show("Login de funcionário bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            loginForm.IsFuncionario = false;
            loginForm.SetLoggedClient(client); // Define o cliente logado
            loginForm.DialogResult = DialogResult.OK;
            loginForm.Close();
            return;
        }
        else
        {
            MessageBox.Show("Nome de utilizador ou palavra-passe incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
       
        }
    
   
public static void HandleRegister(LoginForm loginForm)
    {
        RegisterClientForm registerClientForm = new RegisterClientForm(loginForm.Clients);
        if (registerClientForm.ShowDialog() == DialogResult.OK)
        {
            loginForm.Clients = DataLoader.LoadClientsFromFile("Clients.json");
        }
    }
}
