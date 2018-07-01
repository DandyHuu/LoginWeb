namespace login
{
    partial class ChangePassword
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsersName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPassoword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbErr = new System.Windows.Forms.Label();
            this.lbPassoword = new System.Windows.Forms.Label();
            this.lbConfirmPassoword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // txtUsersName
            // 
            this.txtUsersName.Location = new System.Drawing.Point(133, 23);
            this.txtUsersName.Name = "txtUsersName";
            this.txtUsersName.Size = new System.Drawing.Size(149, 20);
            this.txtUsersName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập lại mật khẩu :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(187, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassoword
            // 
            this.txtPassoword.Location = new System.Drawing.Point(133, 73);
            this.txtPassoword.Name = "txtPassoword";
            this.txtPassoword.Size = new System.Drawing.Size(149, 20);
            this.txtPassoword.TabIndex = 3;
            this.txtPassoword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(133, 117);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(149, 20);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lbErr
            // 
            this.lbErr.AutoSize = true;
            this.lbErr.Location = new System.Drawing.Point(130, 149);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(0, 13);
            this.lbErr.TabIndex = 4;
            // 
            // lbPassoword
            // 
            this.lbPassoword.AutoSize = true;
            this.lbPassoword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassoword.Location = new System.Drawing.Point(260, 76);
            this.lbPassoword.Name = "lbPassoword";
            this.lbPassoword.Size = new System.Drawing.Size(22, 13);
            this.lbPassoword.TabIndex = 5;
            this.lbPassoword.Text = "***";
            this.lbPassoword.Click += new System.EventHandler(this.lbPassoword_Click);
            this.lbPassoword.DoubleClick += new System.EventHandler(this.lbPassoword_Clicks);
            // 
            // lbConfirmPassoword
            // 
            this.lbConfirmPassoword.AutoSize = true;
            this.lbConfirmPassoword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassoword.Location = new System.Drawing.Point(260, 120);
            this.lbConfirmPassoword.Name = "lbConfirmPassoword";
            this.lbConfirmPassoword.Size = new System.Drawing.Size(22, 13);
            this.lbConfirmPassoword.TabIndex = 5;
            this.lbConfirmPassoword.Text = "***";
            this.lbConfirmPassoword.Click += new System.EventHandler(this.lbConfirmPassoword_Click);
            this.lbConfirmPassoword.DoubleClick += new System.EventHandler(this.lbConfirmPassoword_Clicks);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 245);
            this.Controls.Add(this.lbConfirmPassoword);
            this.Controls.Add(this.lbPassoword);
            this.Controls.Add(this.lbErr);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassoword);
            this.Controls.Add(this.txtUsersName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsersName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPassoword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lbErr;
        private System.Windows.Forms.Label lbPassoword;
        private System.Windows.Forms.Label lbConfirmPassoword;
    }
}