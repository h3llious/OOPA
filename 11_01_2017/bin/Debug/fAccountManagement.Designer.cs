namespace _11_01_2017
{
    partial class fAccountManagement
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
            this.dtgQLTKNV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAccountID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQLNVReset = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemTl = new System.Windows.Forms.Button();
            this.btnSuaTk = new System.Windows.Forms.Button();
            this.btnXoaTk = new System.Windows.Forms.Button();
            this.btnDoiMk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQLTKNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgQLTKNV
            // 
            this.dtgQLTKNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgQLTKNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQLTKNV.Location = new System.Drawing.Point(12, 12);
            this.dtgQLTKNV.Name = "dtgQLTKNV";
            this.dtgQLTKNV.ReadOnly = true;
            this.dtgQLTKNV.Size = new System.Drawing.Size(594, 375);
            this.dtgQLTKNV.TabIndex = 0;
            this.dtgQLTKNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgQLTKNV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DisplayName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PassWord";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(104, 64);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(228, 20);
            this.tbUserName.TabIndex = 4;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(104, 99);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(228, 20);
            this.tbDisplayName.TabIndex = 5;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(104, 140);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(228, 20);
            this.tbPassWord.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAccountID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnQLNVReset);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbConfirmPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDisplayName);
            this.groupBox1.Controls.Add(this.tbPassWord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(631, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 258);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AccountManagement";
            // 
            // tbAccountID
            // 
            this.tbAccountID.Location = new System.Drawing.Point(104, 32);
            this.tbAccountID.Name = "tbAccountID";
            this.tbAccountID.ReadOnly = true;
            this.tbAccountID.Size = new System.Drawing.Size(228, 20);
            this.tbAccountID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // btnQLNVReset
            // 
            this.btnQLNVReset.Location = new System.Drawing.Point(239, 215);
            this.btnQLNVReset.Name = "btnQLNVReset";
            this.btnQLNVReset.Size = new System.Drawing.Size(93, 23);
            this.btnQLNVReset.TabIndex = 12;
            this.btnQLNVReset.Text = "Reset";
            this.btnQLNVReset.UseVisualStyleBackColor = true;
            this.btnQLNVReset.Click += new System.EventHandler(this.btnQLNVReset_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 218);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(118, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại tài khoản";
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Location = new System.Drawing.Point(104, 173);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.PasswordChar = '*';
            this.tbConfirmPass.Size = new System.Drawing.Size(228, 20);
            this.tbConfirmPass.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ComfirmPass";
            // 
            // btnThemTl
            // 
            this.btnThemTl.Location = new System.Drawing.Point(34, 23);
            this.btnThemTl.Name = "btnThemTl";
            this.btnThemTl.Size = new System.Drawing.Size(60, 63);
            this.btnThemTl.TabIndex = 8;
            this.btnThemTl.Text = "Thêm";
            this.btnThemTl.UseVisualStyleBackColor = true;
            this.btnThemTl.Click += new System.EventHandler(this.btnThemTl_Click);
            // 
            // btnSuaTk
            // 
            this.btnSuaTk.Location = new System.Drawing.Point(115, 23);
            this.btnSuaTk.Name = "btnSuaTk";
            this.btnSuaTk.Size = new System.Drawing.Size(67, 63);
            this.btnSuaTk.TabIndex = 9;
            this.btnSuaTk.Text = "Sửa";
            this.btnSuaTk.UseVisualStyleBackColor = true;
            this.btnSuaTk.Click += new System.EventHandler(this.btnSuaTk_Click);
            // 
            // btnXoaTk
            // 
            this.btnXoaTk.Location = new System.Drawing.Point(204, 23);
            this.btnXoaTk.Name = "btnXoaTk";
            this.btnXoaTk.Size = new System.Drawing.Size(65, 63);
            this.btnXoaTk.TabIndex = 10;
            this.btnXoaTk.Text = "Xóa";
            this.btnXoaTk.UseVisualStyleBackColor = true;
            this.btnXoaTk.Click += new System.EventHandler(this.btnXoaTk_Click);
            // 
            // btnDoiMk
            // 
            this.btnDoiMk.Location = new System.Drawing.Point(285, 23);
            this.btnDoiMk.Name = "btnDoiMk";
            this.btnDoiMk.Size = new System.Drawing.Size(67, 63);
            this.btnDoiMk.TabIndex = 11;
            this.btnDoiMk.Text = "Đặt lại mật khẩu mặc định";
            this.btnDoiMk.UseVisualStyleBackColor = true;
            this.btnDoiMk.Click += new System.EventHandler(this.btnDoiMk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaTk);
            this.groupBox2.Controls.Add(this.btnDoiMk);
            this.groupBox2.Controls.Add(this.btnThemTl);
            this.groupBox2.Controls.Add(this.btnSuaTk);
            this.groupBox2.Location = new System.Drawing.Point(631, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 98);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // fAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgQLTKNV);
            this.Name = "fAccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgQLTKNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgQLTKNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemTl;
        private System.Windows.Forms.Button btnSuaTk;
        private System.Windows.Forms.Button btnXoaTk;
        private System.Windows.Forms.Button btnDoiMk;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQLNVReset;
        private System.Windows.Forms.TextBox tbAccountID;
        private System.Windows.Forms.Label label6;
    }
}