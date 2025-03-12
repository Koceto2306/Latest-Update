namespace VolleyballRecruitmentApp
{
    partial class PlayerDetails
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
            lblPlayerDetails = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblPosition = new Label();
            cmbPosition = new ComboBox();
            lblHeight = new Label();
            txtHeight = new TextBox();
            lblWeight = new Label();
            txtWeight = new TextBox();
            lblRole = new Label();
            radioButtonPlayer = new RadioButton();
            radioButtonCoachScout = new RadioButton();
            btnSavePlayerDetails = new Button();
            btnSaveCoachScoutDetails = new Button();
            SuspendLayout();
            // 
            // lblPlayerDetails
            // 
            lblPlayerDetails.AutoSize = true;
            lblPlayerDetails.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPlayerDetails.Location = new Point(122, 22);
            lblPlayerDetails.Name = "lblPlayerDetails";
            lblPlayerDetails.Size = new Size(162, 27);
            lblPlayerDetails.TabIndex = 0;
            lblPlayerDetails.Text = "Player Details";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Century Gothic", 9F);
            lblFirstName.Location = new Point(32, 73);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(87, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Century Gothic", 9F);
            txtFirstName.Location = new Point(150, 70);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 26);
            txtFirstName.TabIndex = 2;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Century Gothic", 9F);
            lblMiddleName.Location = new Point(32, 113);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(112, 20);
            lblMiddleName.TabIndex = 3;
            lblMiddleName.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Century Gothic", 9F);
            txtMiddleName.Location = new Point(150, 110);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(200, 26);
            txtMiddleName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Century Gothic", 9F);
            lblLastName.Location = new Point(32, 153);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(89, 20);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Century Gothic", 9F);
            txtLastName.Location = new Point(150, 150);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 26);
            txtLastName.TabIndex = 6;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Century Gothic", 9F);
            lblBirthDate.Location = new Point(32, 193);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(103, 20);
            lblBirthDate.TabIndex = 7;
            lblBirthDate.Text = "Date of Birth:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Century Gothic", 9F);
            dtpBirthDate.Location = new Point(150, 190);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 26);
            dtpBirthDate.TabIndex = 8;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Century Gothic", 9F);
            lblPosition.Location = new Point(32, 233);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(68, 20);
            lblPosition.TabIndex = 9;
            lblPosition.Text = "Position:";
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Century Gothic", 9F);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(150, 230);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(200, 28);
            cmbPosition.TabIndex = 10;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Century Gothic", 9F);
            lblHeight.Location = new Point(32, 273);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(60, 20);
            lblHeight.TabIndex = 11;
            lblHeight.Text = "Height:";
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Century Gothic", 9F);
            txtHeight.Location = new Point(150, 270);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(200, 26);
            txtHeight.TabIndex = 12;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Century Gothic", 9F);
            lblWeight.Location = new Point(32, 313);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(65, 20);
            lblWeight.TabIndex = 13;
            lblWeight.Text = "Weight:";
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Century Gothic", 9F);
            txtWeight.Location = new Point(150, 310);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(200, 26);
            txtWeight.TabIndex = 14;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Century Gothic", 9F);
            lblRole.Location = new Point(32, 352);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(45, 20);
            lblRole.TabIndex = 15;
            lblRole.Text = "Role:";
            // 
            // radioButtonPlayer
            // 
            radioButtonPlayer.AutoSize = true;
            radioButtonPlayer.Font = new Font("Century Gothic", 9F);
            radioButtonPlayer.Location = new Point(139, 350);
            radioButtonPlayer.Name = "radioButtonPlayer";
            radioButtonPlayer.Size = new Size(75, 24);
            radioButtonPlayer.TabIndex = 16;
            radioButtonPlayer.TabStop = true;
            radioButtonPlayer.Text = "Player";
            radioButtonPlayer.UseVisualStyleBackColor = true;
            radioButtonPlayer.CheckedChanged += radioButtonPlayer_CheckedChanged;
            // 
            // radioButtonCoachScout
            // 
            radioButtonCoachScout.AutoSize = true;
            radioButtonCoachScout.Font = new Font("Century Gothic", 9F);
            radioButtonCoachScout.Location = new Point(220, 350);
            radioButtonCoachScout.Name = "radioButtonCoachScout";
            radioButtonCoachScout.Size = new Size(129, 24);
            radioButtonCoachScout.TabIndex = 17;
            radioButtonCoachScout.TabStop = true;
            radioButtonCoachScout.Text = "Coach/Scout";
            radioButtonCoachScout.UseVisualStyleBackColor = true;
            radioButtonCoachScout.CheckedChanged += radioButtonCoachScout_CheckedChanged;
            // 
            // btnSavePlayerDetails
            // 
            btnSavePlayerDetails.Font = new Font("Century Gothic", 9F);
            btnSavePlayerDetails.Location = new Point(150, 430);
            btnSavePlayerDetails.Name = "btnSavePlayerDetails";
            btnSavePlayerDetails.Size = new Size(100, 30);
            btnSavePlayerDetails.TabIndex = 20;
            btnSavePlayerDetails.Text = "Save";
            btnSavePlayerDetails.UseVisualStyleBackColor = true;
            btnSavePlayerDetails.Click += btnSavePlayerDetails_Click;
            // 
            // btnSaveCoachScoutDetails
            // 
            btnSaveCoachScoutDetails.Font = new Font("Century Gothic", 9F);
            btnSaveCoachScoutDetails.Location = new Point(150, 430);
            btnSaveCoachScoutDetails.Name = "btnSaveCoachScoutDetails";
            btnSaveCoachScoutDetails.Size = new Size(100, 30);
            btnSaveCoachScoutDetails.TabIndex = 21;
            btnSaveCoachScoutDetails.Text = "Save";
            btnSaveCoachScoutDetails.UseVisualStyleBackColor = true;
            btnSaveCoachScoutDetails.Click += btnSaveCoachScoutDetails_Click;
            // 
            // PlayerDetails
            // 
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(428, 480);
            Controls.Add(btnSaveCoachScoutDetails);
            Controls.Add(btnSavePlayerDetails);
            Controls.Add(radioButtonCoachScout);
            Controls.Add(radioButtonPlayer);
            Controls.Add(lblRole);
            Controls.Add(txtWeight);
            Controls.Add(lblWeight);
            Controls.Add(txtHeight);
            Controls.Add(lblHeight);
            Controls.Add(cmbPosition);
            Controls.Add(lblPosition);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(lblPlayerDetails);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "PlayerDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblPlayerDetails;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.RadioButton radioButtonPlayer;
        private System.Windows.Forms.RadioButton radioButtonCoachScout;
        private System.Windows.Forms.Button btnSavePlayerDetails;
        private System.Windows.Forms.Button btnSaveCoachScoutDetails;
    }
}
