namespace VolleyballRecruitmentApp
{
    partial class Dashboard_UserControl
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
            lblWelcome = new Label();
            lblPlayerName = new Label();
            lblTeam = new Label();
            lblPosition = new Label();
            lblAge = new Label();
            lblHeight = new Label();
            framePanel = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            framePanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(0, 51, 102);
            lblWelcome.Location = new Point(197, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(770, 72);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Your Dashboard!";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Segoe UI", 18F);
            lblPlayerName.ForeColor = Color.Black;
            lblPlayerName.Location = new Point(45, 171);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(200, 41);
            lblPlayerName.TabIndex = 1;
            lblPlayerName.Text = "Player Name: ";
            lblPlayerName.Click += lblPlayerName_Click;
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Segoe UI", 18F);
            lblTeam.ForeColor = Color.Black;
            lblTeam.Location = new Point(45, 335);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(103, 41);
            lblTeam.TabIndex = 2;
            lblTeam.Text = "Email: ";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 18F);
            lblPosition.ForeColor = Color.Black;
            lblPosition.Location = new Point(45, 253);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(139, 41);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position: ";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 18F);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(45, 212);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(199, 41);
            lblAge.TabIndex = 4;
            lblAge.Text = "Date of Birth: ";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 18F);
            lblHeight.ForeColor = Color.Black;
            lblHeight.Location = new Point(45, 294);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(122, 41);
            lblHeight.TabIndex = 5;
            lblHeight.Text = "Height: ";
            // 
            // framePanel
            // 
            framePanel.Controls.Add(flowLayoutPanel);
            framePanel.Location = new Point(0, 0);
            framePanel.Name = "framePanel";
            framePanel.Size = new Size(200, 100);
            framePanel.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(977, 480);
            flowLayoutPanel.TabIndex = 0;
            // 
            // Dashboard_UserControl
            // 
            BackColor = Color.Cornsilk;
            Controls.Add(lblPlayerName);
            Controls.Add(lblWelcome);
            Controls.Add(lblTeam);
            Controls.Add(framePanel);
            Controls.Add(lblHeight);
            Controls.Add(lblAge);
            Controls.Add(lblPosition);
            Name = "Dashboard_UserControl";
            Size = new Size(1104, 631);
            Load += Dashboard_UserControl_Load;
            framePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        // Label declarations
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private Panel framePanel;
        private FlowLayoutPanel flowLayoutPanel;
    }
}
