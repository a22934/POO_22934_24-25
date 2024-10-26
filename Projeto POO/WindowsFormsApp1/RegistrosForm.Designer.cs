namespace WindowsFormsApp1
{
    partial class RegistrosForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnAddClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(12, 12);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(100, 23);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Adicionar Cliente";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // RegistrosForm
            // 
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.btnAddClient);
            this.Name = "RegistrosForm";
            this.Text = "Registros";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddClient; // Botão para adicionar cliente
    }
}
