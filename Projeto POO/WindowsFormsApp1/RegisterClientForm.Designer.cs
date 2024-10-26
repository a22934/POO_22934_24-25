namespace WindowsFormsApp1
{
    partial class RegisterClientForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 20);
            this.txtName.TabIndex = 1;

            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(12, 48);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(31, 13);
            this.lblNIF.TabIndex = 2;
            this.lblNIF.Text = "NIF:";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(12, 64);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(260, 20);
            this.txtNIF.TabIndex = 3;

            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(12, 87);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(52, 13);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contato:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(12, 103);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(260, 20);
            this.txtContact.TabIndex = 5;

            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(12, 129);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Adicionar";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);

            // 
            // RegisterClientForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "RegisterClientForm";
            this.Text = "Registrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label lblName; // Label para o nome
        private System.Windows.Forms.Label lblNIF; // Label para o NIF
        private System.Windows.Forms.Label lblContact; // Label para o contato
    }
}
