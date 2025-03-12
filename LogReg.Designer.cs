namespace VolleyballRecruitmentApp
{
    partial class LogReg
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            linkSignUp = new LinkLabel();
            linkSignIn = new LinkLabel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(73, 76);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(73, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(72, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 2;
            txtEmail.Visible = false;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Azure;
            btnLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(131, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Azure;
            btnRegister.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(131, 282);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 35);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Visible = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(73, 41);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 21);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.Location = new Point(72, 122);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 21);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEmail.Location = new Point(72, 202);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            lblEmail.Visible = false;
            lblEmail.Click += lblEmail_Click;
            // 
            // linkSignUp
            // 
            linkSignUp.AutoSize = true;
            linkSignUp.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkSignUp.Location = new Point(27, 334);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(341, 23);
            linkSignUp.TabIndex = 8;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Don't have an account yet? Sign Up";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // linkSignIn
            // 
            linkSignIn.AutoSize = true;
            linkSignIn.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkSignIn.Location = new Point(26, 334);
            linkSignIn.Name = "linkSignIn";
            linkSignIn.Size = new Size(321, 23);
            linkSignIn.TabIndex = 9;
            linkSignIn.TabStop = true;
            linkSignIn.Text = "Already have an account? Sign In";
            linkSignIn.Visible = false;
            linkSignIn.LinkClicked += linkSignIn_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 570);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 383);
            label3.Name = "label3";
            label3.Size = new Size(295, 20);
            label3.TabIndex = 3;
            label3.Text = "🏐 Your Gateway to Volleyball Success";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 428);
            label2.Name = "label2";
            label2.Size = new Size(319, 40);
            label2.TabIndex = 2;
            label2.Text = "🔥 Join a growing community of volleyball\r\nplayers, coaches, and scouts.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Niagara Solid", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(33, 273);
            label1.Name = "label1";
            label1.Size = new Size(285, 85);
            label1.TabIndex = 1;
            label1.Text = "NetProspects";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = KonstantinStoykovD.Properties.Resources.VRA;
            pictureBox1.Location = new Point(91, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(331, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(553, 570);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnRegister);
            panel3.Controls.Add(linkSignIn);
            panel3.Controls.Add(lblUsername);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(lblPassword);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(linkSignUp);
            panel3.Location = new Point(91, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 392);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // LogReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 570);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LogReg";
            Text = "Login/Register";
            Load += LogReg_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblEmail;
        private LinkLabel linkSignUp;
        private LinkLabel linkSignIn;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
    }
}
