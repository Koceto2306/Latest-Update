namespace VolleyballRecruitmentApp
{
    partial class TransferDashboard_UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridTransfers;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblWelcomeTransfer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnInterested;  // New button

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
            dataGridTransfers = new DataGridView();
            cmbCountry = new ComboBox();
            txtTeamName = new TextBox();
            btnFilter = new Button();
            lblWelcomeTransfer = new Label();
            lblInfo = new Label();
            btnInterested = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTransfers).BeginInit();
            SuspendLayout();
            // 
            // dataGridTransfers
            // 
            dataGridTransfers.ColumnHeadersHeight = 29;
            dataGridTransfers.Location = new Point(20, 100);
            dataGridTransfers.Name = "dataGridTransfers";
            dataGridTransfers.RowHeadersWidth = 51;
            dataGridTransfers.Size = new Size(380, 300);
            dataGridTransfers.TabIndex = 0;
            // 
            // cmbCountry
            // 
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.Location = new Point(20, 50);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(150, 28);
            cmbCountry.TabIndex = 1;
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(200, 50);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(150, 27);
            txtTeamName.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(370, 50);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(100, 30);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Search";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblWelcomeTransfer
            // 
            lblWelcomeTransfer.AutoSize = true;
            lblWelcomeTransfer.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblWelcomeTransfer.Location = new Point(20, 10);
            lblWelcomeTransfer.Name = "lblWelcomeTransfer";
            lblWelcomeTransfer.Size = new Size(344, 29);
            lblWelcomeTransfer.TabIndex = 4;
            lblWelcomeTransfer.Text = "Welcome to the Recruitment!";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(20, 420);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(295, 20);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "Filter and view teams by country and name.";
            // 
            // btnInterested
            // 
            btnInterested.Location = new Point(400, 420);
            btnInterested.Name = "btnInterested";
            btnInterested.Size = new Size(150, 35);
            btnInterested.TabIndex = 6;
            btnInterested.Text = "I am interested";
            btnInterested.UseVisualStyleBackColor = true;
            btnInterested.Click += btnInterested_Click;
            // 
            // TransferDashboard_UserControl
            // 
            Controls.Add(dataGridTransfers);
            Controls.Add(cmbCountry);
            Controls.Add(txtTeamName);
            Controls.Add(btnFilter);
            Controls.Add(lblWelcomeTransfer);
            Controls.Add(lblInfo);
            Controls.Add(btnInterested);
            Name = "TransferDashboard_UserControl";
            Size = new Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)dataGridTransfers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
