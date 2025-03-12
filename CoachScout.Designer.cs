namespace VolleyballRecruitmentApp
{
    partial class CoachScout
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button DashboardBt;
        private System.Windows.Forms.Button PlayersBt;
        private System.Windows.Forms.Panel panel1; // Dashboard panel
        private System.Windows.Forms.Panel panel2; // Players panel
        private System.Windows.Forms.ComboBox PlayersComboBox; // ComboBox to select player
        private System.Windows.Forms.Label lblPlayerHeight; // Label to display height
        private System.Windows.Forms.Label lblPlayerWeight; // Label to display weight
        private System.Windows.Forms.Label lblPlayerEmail; // Label to display email
        private System.Windows.Forms.Label lblPlayerPosition; // Label to display position
        private System.Windows.Forms.Label lblPlayerBirthDate; // Label to display birth date

        // New Controls for search and position filter
        private System.Windows.Forms.TextBox SearchTextBox; // TextBox for name search
        private System.Windows.Forms.ComboBox PositionComboBox; // ComboBox to filter by position
        private System.Windows.Forms.Button SearchButton; // Button to trigger search

        private void InitializeComponent()
        {
            panelTop = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            DashboardBt = new Button();
            PlayersBt = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            PlayersComboBox = new ComboBox();
            SearchTextBox = new TextBox();
            PositionComboBox = new ComboBox();
            SearchButton = new Button();
            lblPlayerHeight = new Label();
            lblPlayerWeight = new Label();
            lblPlayerEmail = new Label();
            lblPlayerPosition = new Label();
            lblPlayerBirthDate = new Label();
            panelTop.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.LightGray;
            panelTop.Controls.Add(tableLayoutPanel);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 5, 4, 5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1924, 95);
            panelTop.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(DashboardBt, 0, 0);
            tableLayoutPanel.Controls.Add(PlayersBt, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1924, 95);
            tableLayoutPanel.TabIndex = 0;
            // 
            // DashboardBt
            // 
            DashboardBt.BackColor = Color.MidnightBlue;
            DashboardBt.Dock = DockStyle.Fill;
            DashboardBt.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            DashboardBt.ForeColor = Color.White;
            DashboardBt.Location = new Point(4, 5);
            DashboardBt.Margin = new Padding(4, 5, 4, 5);
            DashboardBt.Name = "DashboardBt";
            DashboardBt.Size = new Size(954, 85);
            DashboardBt.TabIndex = 0;
            DashboardBt.Text = "Dashboard";
            DashboardBt.UseVisualStyleBackColor = false;
            // 
            // PlayersBt
            // 
            PlayersBt.BackColor = Color.MidnightBlue;
            PlayersBt.Dock = DockStyle.Fill;
            PlayersBt.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            PlayersBt.ForeColor = Color.White;
            PlayersBt.Location = new Point(966, 5);
            PlayersBt.Margin = new Padding(4, 5, 4, 5);
            PlayersBt.Name = "PlayersBt";
            PlayersBt.Size = new Size(954, 85);
            PlayersBt.TabIndex = 1;
            PlayersBt.Text = "Players";
            PlayersBt.UseVisualStyleBackColor = false;
            PlayersBt.Click += PlayersBt_Click_1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 95);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 942);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(PlayersComboBox);
            panel2.Controls.Add(SearchTextBox);
            panel2.Controls.Add(PositionComboBox);
            panel2.Controls.Add(SearchButton);
            panel2.Controls.Add(lblPlayerHeight);
            panel2.Controls.Add(lblPlayerWeight);
            panel2.Controls.Add(lblPlayerEmail);
            panel2.Controls.Add(lblPlayerPosition);
            panel2.Controls.Add(lblPlayerBirthDate);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 95);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 942);
            panel2.TabIndex = 2;
            // 
            // PlayersComboBox
            // 
            PlayersComboBox.Location = new Point(0, 0);
            PlayersComboBox.Margin = new Padding(4, 5, 4, 5);
            PlayersComboBox.Name = "PlayersComboBox";
            PlayersComboBox.Size = new Size(160, 28);
            PlayersComboBox.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(0, 0);
            SearchTextBox.Margin = new Padding(4, 5, 4, 5);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(132, 27);
            SearchTextBox.TabIndex = 1;
            // 
            // PositionComboBox
            // 
            PositionComboBox.Location = new Point(0, 0);
            PositionComboBox.Margin = new Padding(4, 5, 4, 5);
            PositionComboBox.Name = "PositionComboBox";
            PositionComboBox.Size = new Size(160, 28);
            PositionComboBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(0, 0);
            SearchButton.Margin = new Padding(4, 5, 4, 5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(100, 35);
            SearchButton.TabIndex = 3;
            // 
            // lblPlayerHeight
            // 
            lblPlayerHeight.Location = new Point(0, 0);
            lblPlayerHeight.Margin = new Padding(4, 0, 4, 0);
            lblPlayerHeight.Name = "lblPlayerHeight";
            lblPlayerHeight.Size = new Size(133, 35);
            lblPlayerHeight.TabIndex = 4;
            // 
            // lblPlayerWeight
            // 
            lblPlayerWeight.Location = new Point(0, 0);
            lblPlayerWeight.Margin = new Padding(4, 0, 4, 0);
            lblPlayerWeight.Name = "lblPlayerWeight";
            lblPlayerWeight.Size = new Size(133, 35);
            lblPlayerWeight.TabIndex = 5;
            // 
            // lblPlayerEmail
            // 
            lblPlayerEmail.Location = new Point(0, 0);
            lblPlayerEmail.Margin = new Padding(4, 0, 4, 0);
            lblPlayerEmail.Name = "lblPlayerEmail";
            lblPlayerEmail.Size = new Size(133, 35);
            lblPlayerEmail.TabIndex = 6;
            // 
            // lblPlayerPosition
            // 
            lblPlayerPosition.Location = new Point(0, 0);
            lblPlayerPosition.Margin = new Padding(4, 0, 4, 0);
            lblPlayerPosition.Name = "lblPlayerPosition";
            lblPlayerPosition.Size = new Size(133, 35);
            lblPlayerPosition.TabIndex = 7;
            // 
            // lblPlayerBirthDate
            // 
            lblPlayerBirthDate.Location = new Point(0, 0);
            lblPlayerBirthDate.Margin = new Padding(4, 0, 4, 0);
            lblPlayerBirthDate.Name = "lblPlayerBirthDate";
            lblPlayerBirthDate.Size = new Size(133, 35);
            lblPlayerBirthDate.TabIndex = 8;
            // 
            // CoachScout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1037);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CoachScout";
            Text = "CoachScout";
            panelTop.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }
    }
}
