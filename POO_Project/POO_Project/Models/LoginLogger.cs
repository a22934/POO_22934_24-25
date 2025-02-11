using System;
using System.Collections.Generic;
using Data; 

namespace Models
{
    /// <summary>
    /// Representa uma entrada de login no sistema.
    /// </summary>
    public class LoginEntry
    {
        /// <summary>
        /// Nome do user do login registrado.
        /// </summary>
        public required string Username { get; set; }

        /// <summary>
        /// Data e hora do login registado.
        /// </summary>
        public required string Timestamp { get; set; }
    }

    /// <summary>
    /// Classe responsável por registar e recuperar logs de login.
    /// </summary>
    public class LoginLogger
    {
        /// <summary>
        /// Caminho do arquivo onde os logs de login são armazenados.
        /// </summary>
        private const string FilePath = "logins.json";

        /// <summary>
        /// Regista um login no sistema, armazenando a data e o nome do usuário.
        /// </summary>
        /// <param name="username">Nome do user que realizou o login.</param>
        public static void LogUserLogin(string username)
        {
            List<LoginEntry> logins = DataLoader.LoadFromFile<LoginEntry>(FilePath);

            logins.Add(new LoginEntry
            {
                Username = username,
                Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            });

            DataSaver.SaveToFile(logins, FilePath);
        }

        /// <summary>
        /// Obtém o histórico de logins registados no sistema.
        /// </summary>
        /// <returns>Uma lista contendo todas as entradas de login registadas.</returns>
        public static List<LoginEntry> GetLoginHistory()
        {
            return DataLoader.LoadFromFile<LoginEntry>(FilePath);
        }
    }
}
