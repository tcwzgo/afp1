
using System;
using System.Threading;
using System.Windows.Forms;

namespace afp1_erp_main
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
            this.tb_uName = new System.Windows.Forms.TextBox();
            this.tb_passwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.LB_LOGIN = new System.Windows.Forms.Label();
            this.L1_UNAME = new System.Windows.Forms.Label();
            this.L2_PASSWD = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_uName
            // 
            this.tb_uName.Location = new System.Drawing.Point(95, 46);
            this.tb_uName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_uName.Name = "tb_uName";
            this.tb_uName.Size = new System.Drawing.Size(240, 23);
            this.tb_uName.TabIndex = 0;
            // 
            // tb_passwd
            // 
            this.tb_passwd.Location = new System.Drawing.Point(95, 88);
            this.tb_passwd.Margin = new System.Windows.Forms.Padding(2);
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.PasswordChar = '*';
            this.tb_passwd.Size = new System.Drawing.Size(240, 23);
            this.tb_passwd.TabIndex = 1;
            this.tb_passwd.UseSystemPasswordChar = true;
            this.tb_passwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_passwd_KeyPress);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(257, 129);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(78, 27);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // LB_LOGIN
            // 
            this.LB_LOGIN.AutoSize = true;
            this.LB_LOGIN.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_LOGIN.Location = new System.Drawing.Point(89, 9);
            this.LB_LOGIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_LOGIN.Name = "LB_LOGIN";
            this.LB_LOGIN.Size = new System.Drawing.Size(180, 25);
            this.LB_LOGIN.TabIndex = 2;
            this.LB_LOGIN.Text = "Login to GC module";
            // 
            // L1_UNAME
            // 
            this.L1_UNAME.AutoSize = true;
            this.L1_UNAME.Location = new System.Drawing.Point(28, 49);
            this.L1_UNAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L1_UNAME.Name = "L1_UNAME";
            this.L1_UNAME.Size = new System.Drawing.Size(63, 15);
            this.L1_UNAME.TabIndex = 3;
            this.L1_UNAME.Text = "Username:";
            // 
            // L2_PASSWD
            // 
            this.L2_PASSWD.AutoSize = true;
            this.L2_PASSWD.Location = new System.Drawing.Point(28, 91);
            this.L2_PASSWD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L2_PASSWD.Name = "L2_PASSWD";
            this.L2_PASSWD.Size = new System.Drawing.Size(60, 15);
            this.L2_PASSWD.TabIndex = 3;
            this.L2_PASSWD.Text = "Password:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 167);
            this.Controls.Add(this.L2_PASSWD);
            this.Controls.Add(this.L1_UNAME);
            this.Controls.Add(this.LB_LOGIN);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_passwd);
            this.Controls.Add(this.tb_uName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox tb_uName;
        private System.Windows.Forms.TextBox tb_passwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label LB_LOGIN;
        private System.Windows.Forms.Label L1_UNAME;
        private System.Windows.Forms.Label L2_PASSWD;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

