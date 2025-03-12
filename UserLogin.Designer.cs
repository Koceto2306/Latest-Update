namespace VolleyballRecruitmentApp
{
    partial class UserLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel1; // For Dashboard and other controls
        private System.Windows.Forms.Panel panel2; // For TransferDashboard

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btSupport = new Button();
            btNotifications = new Button();
            btTransfer = new Button();
            btDashboard = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(371, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1546, 1080);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(371, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1546, 1080);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btSupport);
            panel3.Controls.Add(btNotifications);
            panel3.Controls.Add(btTransfer);
            panel3.Controls.Add(btDashboard);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(374, 1080);
            panel3.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(129, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(113, 113);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(107, 406);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(86, 346);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(107, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btSupport
            // 
            btSupport.BackColor = Color.SteelBlue;
            btSupport.FlatAppearance.BorderSize = 0;
            btSupport.FlatStyle = FlatStyle.Flat;
            btSupport.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btSupport.ForeColor = Color.White;
            btSupport.Location = new Point(0, 395);
            btSupport.Name = "btSupport";
            btSupport.Size = new Size(374, 54);
            btSupport.TabIndex = 5;
            btSupport.Text = "Support";
            btSupport.UseVisualStyleBackColor = false;
            // 
            // btNotifications
            // 
            btNotifications.BackColor = Color.SteelBlue;
            btNotifications.FlatAppearance.BorderSize = 0;
            btNotifications.FlatStyle = FlatStyle.Flat;
            btNotifications.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btNotifications.ForeColor = Color.White;
            btNotifications.Location = new Point(0, 335);
            btNotifications.Name = "btNotifications";
            btNotifications.Size = new Size(374, 54);
            btNotifications.TabIndex = 6;
            btNotifications.Text = "Notifications";
            btNotifications.UseVisualStyleBackColor = false;
            btNotifications.Click += btNotifications_Click_1;
            // 
            // btTransfer
            // 
            btTransfer.BackColor = Color.SteelBlue;
            btTransfer.FlatAppearance.BorderSize = 0;
            btTransfer.FlatStyle = FlatStyle.Flat;
            btTransfer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btTransfer.ForeColor = Color.White;
            btTransfer.Location = new Point(0, 275);
            btTransfer.Name = "btTransfer";
            btTransfer.Size = new Size(374, 54);
            btTransfer.TabIndex = 7;
            btTransfer.Text = "Transfer";
            btTransfer.UseVisualStyleBackColor = false;
            btTransfer.Click += btTransfer_Click_1;
            // 
            // btDashboard
            // 
            btDashboard.BackColor = Color.SteelBlue;
            btDashboard.FlatAppearance.BorderSize = 0;
            btDashboard.FlatStyle = FlatStyle.Flat;
            btDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btDashboard.ForeColor = Color.White;
            btDashboard.Location = new Point(0, 215);
            btDashboard.Name = "btDashboard";
            btDashboard.Size = new Size(374, 54);
            btDashboard.TabIndex = 8;
            btDashboard.Text = "Dashboard";
            btDashboard.UseVisualStyleBackColor = false;
            btDashboard.Click += btDashboard_Click_1;
            // 
            // UserLogin
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "UserLogin";
            Text = "User Login";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel3;
        private Button btDashboard;
        private Button btSupport;
        private Button btNotifications;
        private Button btTransfer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
    }
}