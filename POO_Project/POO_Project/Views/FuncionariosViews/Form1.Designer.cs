namespace Views
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnApartments;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnCheckInCheckOut;
        private System.Windows.Forms.Button btnLogs; // Novo botão para logs

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnClients = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnApartments = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnCheckInCheckOut = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button(); // Inicializa o novo botão
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(12, 12);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(120, 40);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clientes";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(149, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 40);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Registros";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnApartments
            // 
            this.btnApartments.Location = new System.Drawing.Point(299, 12);
            this.btnApartments.Name = "btnApartments";
            this.btnApartments.Size = new System.Drawing.Size(120, 40);
            this.btnApartments.TabIndex = 2;
            this.btnApartments.Text = "Apartamentos";
            this.btnApartments.UseVisualStyleBackColor = true;
            this.btnApartments.Click += new System.EventHandler(this.btnApartments_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(12, 74);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(120, 40);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnCheckInCheckOut
            // 
            this.btnCheckInCheckOut.Location = new System.Drawing.Point(149, 74);
            this.btnCheckInCheckOut.Name = "btnCheckInCheckOut";
            this.btnCheckInCheckOut.Size = new System.Drawing.Size(120, 40);
            this.btnCheckInCheckOut.TabIndex = 4;
            this.btnCheckInCheckOut.Text = "Check-in/Check-out";
            this.btnCheckInCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckInCheckOut.Click += new System.EventHandler(this.btnCheckInCheckOut_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(299, 74); // Posição ao lado do botão "Check-in/Check-out"
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(120, 40);
            this.btnLogs.TabIndex = 5;
            this.btnLogs.Text = "Ver Logs de Login";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click); // Associa o evento de clique
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 141);
            this.Controls.Add(this.btnLogs); // Adiciona o novo botão ao formulário
            this.Controls.Add(this.btnCheckInCheckOut);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnApartments);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClients);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Funcionários";
            this.ResumeLayout(false);
        }
    }
}