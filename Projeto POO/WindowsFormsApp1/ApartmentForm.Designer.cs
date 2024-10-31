namespace WindowsFormsApp1
{
    partial class ApartmentForm
    {
        private System.Windows.Forms.ListBox listBoxApartments;
        private System.Windows.Forms.Button btnRemoveApartment;

        private void InitializeComponent()
        {
            this.listBoxApartments = new System.Windows.Forms.ListBox();
            this.btnRemoveApartment = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // listBoxApartments
            // 
            this.listBoxApartments.FormattingEnabled = true;
            this.listBoxApartments.Location = new System.Drawing.Point(10, 10);
            this.listBoxApartments.Name = "listBoxApartments";
            this.listBoxApartments.Size = new System.Drawing.Size(300, 200);
            this.listBoxApartments.TabIndex = 0;

            // 
            // btnRemoveApartment
            // 
            this.btnRemoveApartment.Location = new System.Drawing.Point(10, 220);
            this.btnRemoveApartment.Name = "btnRemoveApartment";
            this.btnRemoveApartment.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveApartment.TabIndex = 1;
            this.btnRemoveApartment.Text = "Remover Apartamento";
            this.btnRemoveApartment.UseVisualStyleBackColor = true;
            this.btnRemoveApartment.Click += new System.EventHandler(this.btnRemoveApartment_Click);

            // 
            // ApartmentForm
            // 
            this.ClientSize = new System.Drawing.Size(330, 270);
            this.Controls.Add(this.listBoxApartments);
            this.Controls.Add(this.btnRemoveApartment);
            this.Name = "ApartmentForm";
            this.Text = "Lista de Apartamentos";
            this.ResumeLayout(false);
        }
    }
}

