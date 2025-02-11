namespace Views
{
    partial class RegistrosForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegisterEmployee;

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
            btnAddClient = new Button();
            button1 = new Button();
            RegisterEmployee = new Button();
            SuspendLayout();
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(12, 12);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(103, 48);
            btnAddClient.TabIndex = 0;
            btnAddClient.Text = "Adicionar Cliente";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(147, 12);
            button1.Name = "button1";
            button1.Size = new Size(101, 49);
            button1.TabIndex = 1;
            button1.Text = "Adicionar Apartamento";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegisterEmployee
            // 
            RegisterEmployee.Location = new Point(13, 66);
            RegisterEmployee.Name = "RegisterEmployee";
            RegisterEmployee.Size = new Size(102, 43);
            RegisterEmployee.TabIndex = 2;
            RegisterEmployee.Text = "Adicionar Employee";
            RegisterEmployee.UseVisualStyleBackColor = true;
            RegisterEmployee.Click += btnRegisterEmployee_Click;
            // 
            // RegistrosForm
            // 
            ClientSize = new Size(280, 165);
            Controls.Add(RegisterEmployee);
            Controls.Add(button1);
            Controls.Add(btnAddClient);
            Name = "RegistrosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            ResumeLayout(false);
        }
    }
}