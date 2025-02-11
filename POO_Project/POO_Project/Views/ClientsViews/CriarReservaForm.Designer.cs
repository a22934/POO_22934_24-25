namespace Views
{
    partial class CriarReservaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbApartments;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnReservar;

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
            this.cbApartments = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbApartments
            // 
            this.cbApartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApartments.FormattingEnabled = true;
            this.cbApartments.Location = new System.Drawing.Point(50, 30);
            this.cbApartments.Name = "cbApartments";
            this.cbApartments.Size = new System.Drawing.Size(200, 21);
            this.cbApartments.TabIndex = 0;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(50, 70);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(50, 110);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 2;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(50, 150);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(150, 30);
            this.btnReservar.TabIndex = 3;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // CriarReservaForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.cbApartments);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnReservar);
            this.Name = "CriarReservaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Reserva";
            this.ResumeLayout(false);
        }
    }
}