namespace WindowsFormsApp1
{
    partial class ApartmentForm
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
            this.listBoxApartments = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxApartments
            // 
            this.listBoxApartments.FormattingEnabled = true;
            this.listBoxApartments.Location = new System.Drawing.Point(12, 12);
            this.listBoxApartments.Name = "listBoxApartments";
            this.listBoxApartments.Size = new System.Drawing.Size(928, 342);
            this.listBoxApartments.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 372);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // ApartmentForm
            // 
            this.ClientSize = new System.Drawing.Size(971, 474);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listBoxApartments);
            this.Name = "ApartmentForm";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox listBoxApartments; // Declare apenas uma vez
        private System.Windows.Forms.Button btnRemove; // Declare o botão de remoção
    }
}