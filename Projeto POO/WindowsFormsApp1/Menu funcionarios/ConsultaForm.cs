using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ConsultaForm : Form
    {
        private const string caminhoArquivoReservas = "reservas.json"; // Caminho do arquivo de reservas
        /// <summary>
        /// Inicializa uma nova instância do formulário <see cref="ConsultaForm"/>.
        /// </summary>
        public ConsultaForm()
        {
            InitializeComponent();
            CarregarReservas();
        }

        /// <summary>
        /// Carrega as reservas do arquivo JSON e exibe no DataGridView.
        /// </summary>
        private void CarregarReservas()
        {
            try
            {
                // Verifica se o arquivo de reservas existe
                if (!File.Exists(caminhoArquivoReservas))
                {
                    MessageBox.Show("Nenhuma reserva encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Lê o arquivo de reservas e desserializa o JSON
                string json = File.ReadAllText(caminhoArquivoReservas);
                List<Reserva> reservas = JsonConvert.DeserializeObject<List<Reserva>>(json);

                // Exibe as reservas no DataGridView
                dataGridView1.DataSource = reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    
