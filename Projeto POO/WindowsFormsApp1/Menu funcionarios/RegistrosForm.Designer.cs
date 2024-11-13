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
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(12, 12);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(103, 37);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Adicionar Cliente";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(147, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar Apartamento";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterEmployee
            // 
            this.RegisterEmployee.Location = new System.Drawing.Point(13, 66);
            this.RegisterEmployee.Name = "RegisterEmployee";
            this.RegisterEmployee.Size = new System.Drawing.Size(102, 36);
            this.RegisterEmployee.TabIndex = 2;
            this.RegisterEmployee.Text = "Registar funcionario";
            this.RegisterEmployee.UseVisualStyleBackColor = true;
            this.RegisterEmployee.Click += new System.EventHandler(this.btnRegisterEmployee_Click);
            // 
            // RegistrosForm
            // 
            this.ClientSize = new System.Drawing.Size(280, 165);
            this.Controls.Add(this.RegisterEmployee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddClient);
            this.Name = "RegistrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnAddClient; // Botão para adicionar cliente
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegisterEmployee;
    }
}
