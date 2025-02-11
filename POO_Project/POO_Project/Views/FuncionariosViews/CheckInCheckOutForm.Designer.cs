namespace Views
{
    partial class CheckInCheckOutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;

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
            dgvReservas = new DataGridView();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(12, 12);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.Size = new Size(776, 300);
            dgvReservas.TabIndex = 0;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(12, 330);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(100, 30);
            btnCheckIn.TabIndex = 1;
            btnCheckIn.Text = "Check-In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(130, 330);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(100, 30);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Check-Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // CheckInCheckOutForm
            // 
            ClientSize = new Size(800, 370);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(dgvReservas);
            Name = "CheckInCheckOutForm";
            Text = "Check-In / Check-Out";
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
        }
    }
}
