namespace Views
{
    partial class ApartmentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewApartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTypology;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPropertyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAdditionalFeatures;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPricePerNight; // Adiciona esta linha
        private System.Windows.Forms.Button btnRemoveApartment;

        /// <summary>
        /// Limpa todos os recursos usados.
        /// </summary>
        /// <param name="disposing">Indica se os recursos gerenciados devem ser descartados.</param>
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
        /// Método necessário para a compatibilidade com o Windows Forms Designer - não modifique
        /// o conteúdo do método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewApartments = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTypology = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPropertyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAdditionalFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPricePerNight = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Adiciona esta linha
            this.btnRemoveApartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApartments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewApartments
            // 
            this.dataGridViewApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnLocation,
            this.columnTypology,
            this.columnPropertyType,
            this.columnAdditionalFeatures,
            this.columnPricePerNight}); // Adiciona esta linha
            this.dataGridViewApartments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewApartments.Name = "dataGridViewApartments";
            this.dataGridViewApartments.RowHeadersVisible = false;
            this.dataGridViewApartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewApartments.Size = new System.Drawing.Size(800, 250);
            this.dataGridViewApartments.TabIndex = 0;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            // 
            // columnLocation
            // 
            this.columnLocation.HeaderText = "Localização";
            this.columnLocation.Name = "columnLocation";
            // 
            // columnTypology
            // 
            this.columnTypology.HeaderText = "Tipologia";
            this.columnTypology.Name = "columnTypology";
            // 
            // columnPropertyType
            // 
            this.columnPropertyType.HeaderText = "Tipo Imóvel";
            this.columnPropertyType.Name = "columnPropertyType";
            // 
            // columnAdditionalFeatures
            // 
            this.columnAdditionalFeatures.HeaderText = "Descrição Adicional";
            this.columnAdditionalFeatures.Name = "columnAdditionalFeatures";
            // 
            // columnPricePerNight
            // 
            this.columnPricePerNight.HeaderText = "Preço por Noite";
            this.columnPricePerNight.Name = "columnPricePerNight";
            // 
            // btnRemoveApartment
            // 
            this.btnRemoveApartment.Location = new System.Drawing.Point(12, 280);
            this.btnRemoveApartment.Name = "btnRemoveApartment";
            this.btnRemoveApartment.Size = new System.Drawing.Size(125, 23);
            this.btnRemoveApartment.TabIndex = 1;
            this.btnRemoveApartment.Text = "Remove Apartment";
            this.btnRemoveApartment.UseVisualStyleBackColor = true;
            this.btnRemoveApartment.Click += new System.EventHandler(this.btnRemoveApartment_Click);
            // 
            // ApartmentForm
            // 
            this.ClientSize = new System.Drawing.Size(824, 321);
            this.Controls.Add(this.btnRemoveApartment);
            this.Controls.Add(this.dataGridViewApartments);
            this.Name = "ApartmentForm";
            this.Text = "Apartments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
