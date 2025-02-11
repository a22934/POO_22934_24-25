using System.Collections.Generic;
using Models; 

namespace Controllers
{
    /// <summary>
    /// Controlador responsável pela gestão de logs de login de usuários.
    /// </summary>
    public class LoginLogController
    {
        /// <summary>
        /// Regista uma tentativa de login de um usuário.
        /// </summary>
        /// <param name="username">Nome de usuário do usuário que está a fazer login.</param>
        public void RegisterLogin(string username)
        {
            // Chama o método LogUserLogin da classe LoginLogger para registar o login
            LoginLogger.LogUserLogin(username);
        }

        /// <summary>
        /// Obtém o histórico de logins registados.
        /// </summary>
        /// <returns>Uma lista contendo os registos de login (LoginEntry).</returns>
        public List<LoginEntry> GetLoginHistory()
        {
            // Chama o método GetLoginHistory da classe LoginLogger para obter todos os registos de login
            return LoginLogger.GetLoginHistory();
        }
    }
}
