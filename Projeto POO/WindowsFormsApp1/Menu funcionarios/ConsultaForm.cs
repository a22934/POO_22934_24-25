using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ConsultaForm : Form
    {
        private const string caminhoArquivoReservas = "reservas.json";

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

                // Lê e desserializa as reservas do arquivo JSON
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
    
