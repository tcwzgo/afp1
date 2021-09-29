
namespace afp1_erp_main
{
    partial class MainForm
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_incomeDate = new System.Windows.Forms.ComboBox();
            this.cb_releaseDate = new System.Windows.Forms.ComboBox();
            this.cb_platform = new System.Windows.Forms.ComboBox();
            this.cb_genre = new System.Windows.Forms.ComboBox();
            this.tb_serialNum = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1191, 13);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 446);
            this.vScrollBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(12, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 471);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.cb_incomeDate);
            this.panel2.Controls.Add(this.cb_releaseDate);
            this.panel2.Controls.Add(this.cb_platform);
            this.panel2.Controls.Add(this.cb_genre);
            this.panel2.Controls.Add(this.tb_serialNum);
            this.panel2.Controls.Add(this.tb_name);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 173);
            this.panel2.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1052, 120);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(155, 50);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // cb_incomeDate
            // 
            this.cb_incomeDate.FormattingEnabled = true;
            this.cb_incomeDate.Location = new System.Drawing.Point(921, 133);
            this.cb_incomeDate.Name = "cb_incomeDate";
            this.cb_incomeDate.Size = new System.Drawing.Size(112, 23);
            this.cb_incomeDate.TabIndex = 1;
            // 
            // cb_releaseDate
            // 
            this.cb_releaseDate.FormattingEnabled = true;
            this.cb_releaseDate.Location = new System.Drawing.Point(768, 133);
            this.cb_releaseDate.Name = "cb_releaseDate";
            this.cb_releaseDate.Size = new System.Drawing.Size(130, 23);
            this.cb_releaseDate.TabIndex = 1;
            // 
            // cb_platform
            // 
            this.cb_platform.FormattingEnabled = true;
            this.cb_platform.Location = new System.Drawing.Point(617, 133);
            this.cb_platform.Name = "cb_platform";
            this.cb_platform.Size = new System.Drawing.Size(119, 23);
            this.cb_platform.TabIndex = 1;
            // 
            // cb_genre
            // 
            this.cb_genre.FormattingEnabled = true;
            this.cb_genre.Location = new System.Drawing.Point(470, 133);
            this.cb_genre.Name = "cb_genre";
            this.cb_genre.Size = new System.Drawing.Size(117, 23);
            this.cb_genre.TabIndex = 1;
            // 
            // tb_serialNum
            // 
            this.tb_serialNum.Location = new System.Drawing.Point(216, 133);
            this.tb_serialNum.Name = "tb_serialNum";
            this.tb_serialNum.Size = new System.Drawing.Size(225, 23);
            this.tb_serialNum.TabIndex = 0;
            this.tb_serialNum.Text = "Serial number";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(16, 133);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(149, 23);
            this.tb_name.TabIndex = 0;
            this.tb_name.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_genre;
        private System.Windows.Forms.TextBox tb_serialNum;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_incomeDate;
        private System.Windows.Forms.ComboBox cb_releaseDate;
        private System.Windows.Forms.ComboBox cb_platform;
    }
}