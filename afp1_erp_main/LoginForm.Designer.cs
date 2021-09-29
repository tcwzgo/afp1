
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
            this.tb_uName = new System.Windows.Forms.TextBox();
            this.tb_passwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.LB_LOGIN = new System.Windows.Forms.Label();
            this.L1_UNAME = new System.Windows.Forms.Label();
            this.L2_PASSWD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_uName
            // 
            this.tb_uName.Location = new System.Drawing.Point(15, 76);
            this.tb_uName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_uName.Name = "tb_uName";
            this.tb_uName.Size = new System.Drawing.Size(258, 23);
            this.tb_uName.TabIndex = 0;
            // 
            // tb_passwd
            // 
            this.tb_passwd.Location = new System.Drawing.Point(15, 124);
            this.tb_passwd.Margin = new System.Windows.Forms.Padding(2);
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.Size = new System.Drawing.Size(258, 23);
            this.tb_passwd.TabIndex = 0;
            this.tb_passwd.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(15, 158);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(180, 43);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // LB_LOGIN
            // 
            this.LB_LOGIN.AutoSize = true;
            this.LB_LOGIN.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_LOGIN.Location = new System.Drawing.Point(11, 19);
            this.LB_LOGIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_LOGIN.Name = "LB_LOGIN";
            this.LB_LOGIN.Size = new System.Drawing.Size(180, 25);
            this.LB_LOGIN.TabIndex = 2;
            this.LB_LOGIN.Text = "Login to GC module";
            // 
            // L1_UNAME
            // 
            this.L1_UNAME.AutoSize = true;
            this.L1_UNAME.Location = new System.Drawing.Point(15, 59);
            this.L1_UNAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L1_UNAME.Name = "L1_UNAME";
            this.L1_UNAME.Size = new System.Drawing.Size(63, 15);
            this.L1_UNAME.TabIndex = 3;
            this.L1_UNAME.Text = "Username:";
            // 
            // L2_PASSWD
            // 
            this.L2_PASSWD.AutoSize = true;
            this.L2_PASSWD.Location = new System.Drawing.Point(15, 107);
            this.L2_PASSWD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L2_PASSWD.Name = "L2_PASSWD";
            this.L2_PASSWD.Size = new System.Drawing.Size(60, 15);
            this.L2_PASSWD.TabIndex = 3;
            this.L2_PASSWD.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 228);
            this.Controls.Add(this.L2_PASSWD);
            this.Controls.Add(this.L1_UNAME);
            this.Controls.Add(this.LB_LOGIN);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_passwd);
            this.Controls.Add(this.tb_uName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Login";
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
    }
}

