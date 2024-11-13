namespace WindowsFormsApp1
{
    partial class RegisterEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumeroFuncionario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNumeroFuncionario;
        private System.Windows.Forms.Label lblPassword;

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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumeroFuncionario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNumeroFuncionario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();

            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.Text = "Nome:";

            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);

            // 
            // lblNumeroFuncionario
            // 
            this.lblNumeroFuncionario.AutoSize = true;
            this.lblNumeroFuncionario.Location = new System.Drawing.Point(20, 60);
            this.lblNumeroFuncionario.Name = "lblNumeroFuncionario";
            this.lblNumeroFuncionario.Size = new System.Drawing.Size(120, 13);
            this.lblNumeroFuncionario.Text = "Número de Funcionário:";

            // 
            // txtNumeroFuncionario
            // 
            this.txtNumeroFuncionario.Location = new System.Drawing.Point(150, 60);
            this.txtNumeroFuncionario.Name = "txtNumeroFuncionario";
            this.txtNumeroFuncionario.Size = new System.Drawing.Size(200, 20);

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.Text = "Password:";

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);

            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(150, 140);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.Text = "Adicionar";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);

            // 
            // RegisterEmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumeroFuncionario);
            this.Controls.Add(this.txtNumeroFuncionario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "RegisterEmployeeForm";
            this.Text = "Registrar Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
