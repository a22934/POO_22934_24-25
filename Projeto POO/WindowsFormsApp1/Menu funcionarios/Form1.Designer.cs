namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnApartments;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnCheckInCheckOut;

        /// <summary>
        /// Limpa todos os recursos em uso.
        /// </summary>
        /// <param name="disposing">Determina se os recursos gerenciados devem ser descartados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Forms Designer

        /// <summary>
        /// Método necessário para suportar o Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClients = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnApartments = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnCheckInCheckOut = new System.Windows.Forms.Button();
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
            this.btnRegister.Location = new System.Drawing.Point(12, 58);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 40);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Registros";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnApartments
            // 
            this.btnApartments.Location = new System.Drawing.Point(12, 104);
            this.btnApartments.Name = "btnApartments";
            this.btnApartments.Size = new System.Drawing.Size(120, 40);
            this.btnApartments.TabIndex = 2;
            this.btnApartments.Text = "Apartamentos";
            this.btnApartments.UseVisualStyleBackColor = true;
            this.btnApartments.Click += new System.EventHandler(this.btnApartments_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(12, 150);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(120, 40);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnCheckInCheckOut
            // 
            this.btnCheckInCheckOut.Location = new System.Drawing.Point(12, 196);
            this.btnCheckInCheckOut.Name = "btnCheckInCheckOut";
            this.btnCheckInCheckOut.Size = new System.Drawing.Size(120, 40);
            this.btnCheckInCheckOut.TabIndex = 4;
            this.btnCheckInCheckOut.Text = "Check-in/Check-out";
            this.btnCheckInCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckInCheckOut.Click += new System.EventHandler(this.btnCheckInCheckOut_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(150, 300);
            this.Controls.Add(this.btnCheckInCheckOut);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnApartments);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClients);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
