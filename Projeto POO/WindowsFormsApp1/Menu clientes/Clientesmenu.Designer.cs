namespace WindowsFormsApp1
{
    partial class ClientesMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnListApartments;

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
            this.btnListApartments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListApartments
            // 
            this.btnListApartments.Location = new System.Drawing.Point(50, 50);
            this.btnListApartments.Name = "btnListApartments";
            this.btnListApartments.Size = new System.Drawing.Size(150, 30);
            this.btnListApartments.TabIndex = 0;
            this.btnListApartments.Text = "Listar Apartamentos";
            this.btnListApartments.Click += new System.EventHandler(this.btnListApartments_Click);
            // 
            // ClientesMenu
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnListApartments);
            this.Name = "ClientesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Menu";
            this.ResumeLayout(false);

        }
    }
}
