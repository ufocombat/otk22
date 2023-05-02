namespace otk22
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.passCheckBox = new System.Windows.Forms.CheckBox();
            this.pasVisOffButton = new System.Windows.Forms.Button();
            this.pasVisOnButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.passwordLabelError = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelEnter = new System.Windows.Forms.Label();
            this.loginLabelError = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(131)))), ((int)(((byte)(204)))));
            this.panelLeft.Controls.Add(this.logo);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(212, 337);
            this.panelLeft.TabIndex = 6;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(22, 88);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(161, 122);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.panelLogin.Controls.Add(this.passCheckBox);
            this.panelLogin.Controls.Add(this.pasVisOffButton);
            this.panelLogin.Controls.Add(this.pasVisOnButton);
            this.panelLogin.Controls.Add(this.exitButton);
            this.panelLogin.Controls.Add(this.enterButton);
            this.panelLogin.Controls.Add(this.passwordLabelError);
            this.panelLogin.Controls.Add(this.passwordLabel);
            this.panelLogin.Controls.Add(this.passwordTextBox);
            this.panelLogin.Controls.Add(this.panelTop);
            this.panelLogin.Controls.Add(this.loginLabelError);
            this.panelLogin.Controls.Add(this.loginTextBox);
            this.panelLogin.Controls.Add(this.loginLabel);
            this.panelLogin.Location = new System.Drawing.Point(210, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(376, 337);
            this.panelLogin.TabIndex = 7;
            // 
            // passCheckBox
            // 
            this.passCheckBox.AutoSize = true;
            this.passCheckBox.Location = new System.Drawing.Point(52, 222);
            this.passCheckBox.Name = "passCheckBox";
            this.passCheckBox.Size = new System.Drawing.Size(117, 19);
            this.passCheckBox.TabIndex = 18;
            this.passCheckBox.Text = "показать пароль";
            this.passCheckBox.UseVisualStyleBackColor = true;
            this.passCheckBox.CheckedChanged += new System.EventHandler(this.passCheckBox_CheckedChanged);
            // 
            // pasVisOffButton
            // 
            this.pasVisOffButton.Image = ((System.Drawing.Image)(resources.GetObject("pasVisOffButton.Image")));
            this.pasVisOffButton.Location = new System.Drawing.Point(238, 174);
            this.pasVisOffButton.Name = "pasVisOffButton";
            this.pasVisOffButton.Size = new System.Drawing.Size(27, 23);
            this.pasVisOffButton.TabIndex = 17;
            this.pasVisOffButton.UseVisualStyleBackColor = true;
            this.pasVisOffButton.Click += new System.EventHandler(this.pasVisOnButton_Click);
            // 
            // pasVisOnButton
            // 
            this.pasVisOnButton.Image = global::otk22.Properties.Resources.vis_on16;
            this.pasVisOnButton.Location = new System.Drawing.Point(238, 175);
            this.pasVisOnButton.Name = "pasVisOnButton";
            this.pasVisOnButton.Size = new System.Drawing.Size(27, 23);
            this.pasVisOnButton.TabIndex = 16;
            this.pasVisOnButton.UseVisualStyleBackColor = true;
            this.pasVisOnButton.Visible = false;
            this.pasVisOnButton.Click += new System.EventHandler(this.pasVisOnButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(152, 267);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 28);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enterButton.Location = new System.Drawing.Point(52, 267);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(86, 28);
            this.enterButton.TabIndex = 14;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passwordLabelError
            // 
            this.passwordLabelError.AutoSize = true;
            this.passwordLabelError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(44)))), ((int)(((byte)(31)))));
            this.passwordLabelError.Location = new System.Drawing.Point(52, 201);
            this.passwordLabelError.Name = "passwordLabelError";
            this.passwordLabelError.Size = new System.Drawing.Size(109, 13);
            this.passwordLabelError.TabIndex = 13;
            this.passwordLabelError.Text = "passwordLabelError";
            this.passwordLabelError.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(52, 157);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(49, 15);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(52, 175);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(180, 23);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.panelTop.Controls.Add(this.labelEnter);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(376, 69);
            this.panelTop.TabIndex = 6;
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnter.Location = new System.Drawing.Point(39, 19);
            this.labelEnter.Margin = new System.Windows.Forms.Padding(0);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(181, 32);
            this.labelEnter.TabIndex = 0;
            this.labelEnter.Text = "Вход в систему";
            // 
            // loginLabelError
            // 
            this.loginLabelError.AutoSize = true;
            this.loginLabelError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(44)))), ((int)(((byte)(31)))));
            this.loginLabelError.Location = new System.Drawing.Point(52, 138);
            this.loginLabelError.Name = "loginLabelError";
            this.loginLabelError.Size = new System.Drawing.Size(86, 13);
            this.loginLabelError.TabIndex = 10;
            this.loginLabelError.Text = "loginLabelError";
            this.loginLabelError.Visible = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(52, 112);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(180, 23);
            this.loginTextBox.TabIndex = 8;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(52, 94);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 15);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Логин";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelLeft);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(600, 375);
            this.MinimumSize = new System.Drawing.Size(500, 375);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ОТК - Вход";
            this.VisibleChanged += new System.EventHandler(this.LoginForm_VisibleChanged);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panelLeft;
        private Panel panelLogin;
        private Panel panelTop;
        private Label labelEnter;
        private Label loginLabelError;
        private TextBox loginTextBox;
        private Label loginLabel;
        private PictureBox logo;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button enterButton;
        private Label passwordLabelError;
        private Button exitButton;
        private System.Windows.Forms.Timer timer1;
        private Button pasVisOffButton;
        private Button pasVisOnButton;
        private CheckBox passCheckBox;
    }
}