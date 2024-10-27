namespace WindowsFormsApp1
{
    partial class RegisterApartmentForm
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddApartment = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtTypology = new System.Windows.Forms.TextBox();
            this.txtAdditionalFeatures = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPropertyType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddApartment
            // 
            this.btnAddApartment.Location = new System.Drawing.Point(126, 245);
            this.btnAddApartment.Name = "btnAddApartment";
            this.btnAddApartment.Size = new System.Drawing.Size(75, 23);
            this.btnAddApartment.TabIndex = 0;
            this.btnAddApartment.Text = "Adicionar ";
            this.btnAddApartment.UseVisualStyleBackColor = true;
            this.btnAddApartment.Click += new System.EventHandler(this.btnAddApartment_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(111, 67);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 2;
            // 
            // txtTypology
            // 
            this.txtTypology.Location = new System.Drawing.Point(111, 105);
            this.txtTypology.Name = "txtTypology";
            this.txtTypology.Size = new System.Drawing.Size(100, 20);
            this.txtTypology.TabIndex = 3;
            // 
            // txtAdditionalFeatures
            // 
            this.txtAdditionalFeatures.Location = new System.Drawing.Point(111, 178);
            this.txtAdditionalFeatures.Name = "txtAdditionalFeatures";
            this.txtAdditionalFeatures.Size = new System.Drawing.Size(100, 20);
            this.txtAdditionalFeatures.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Localização";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipologia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Imóvel";
            // 
            // txtPropertyType
            // 
            this.txtPropertyType.Location = new System.Drawing.Point(111, 141);
            this.txtPropertyType.Name = "txtPropertyType";
            this.txtPropertyType.Size = new System.Drawing.Size(100, 20);
            this.txtPropertyType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição adicional";
            // 
            // RegisterApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 280);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdditionalFeatures);
            this.Controls.Add(this.txtPropertyType);
            this.Controls.Add(this.txtTypology);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddApartment);
            this.Name = "RegisterApartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddApartment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtTypology;
        private System.Windows.Forms.TextBox txtAdditionalFeatures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPropertyType;
        private System.Windows.Forms.Label label5;
    }
}
