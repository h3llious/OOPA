namespace _11_01_2017
{
    partial class fLogin
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(147, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 24);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(147, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 20);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(15, 33);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(126, 20);
            this.txbPass.TabIndex = 2;
            this.txbPass.Text = "Password";
            this.txbPass.Click += new System.EventHandler(this.txbPass_Click);
            this.txbPass.TextChanged += new System.EventHandler(this.txbPass_TextChanged);
            this.txbPass.Enter += new System.EventHandler(this.txbPass_Enter);
            this.txbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPass_KeyDown);
            this.txbPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPass_KeyUp);
            // 
            // txbUser
            // 
            this.txbUser.AcceptsTab = true;
            this.txbUser.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(15, 5);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(126, 22);
            this.txbUser.TabIndex = 1;
            this.txbUser.Text = "Username";
            this.txbUser.Click += new System.EventHandler(this.txbUser_Click);
            this.txbUser.TextChanged += new System.EventHandler(this.txbUser_TextChanged);
            this.txbUser.Enter += new System.EventHandler(this.txbUser_Enter);
            this.txbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbUser_KeyDown);
            this.txbUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txbUser_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbUser);
            this.panel1.Controls.Add(this.txbPass);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(237, 75);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Panel panel1;
    }
}

