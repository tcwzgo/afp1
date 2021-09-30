
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_UpdateItem = new System.Windows.Forms.Button();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.cb_Platform = new System.Windows.Forms.ComboBox();
            this.lb_Genre = new System.Windows.Forms.Label();
            this.cb_Price = new System.Windows.Forms.ComboBox();
            this.lb_Platform = new System.Windows.Forms.Label();
            this.dateTimePicker_ArrivelDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_ArrivalDate = new System.Windows.Forms.Label();
            this.lb_ReleaseDate = new System.Windows.Forms.Label();
            this.lb_SteamKey = new System.Windows.Forms.Label();
            this.lb_Serial = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tb_SteamKey = new System.Windows.Forms.TextBox();
            this.tb_SerialNum = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.gb_Output = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_List = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.cb_Sort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gb_Output.SuspendLayout();
            this.flowLayoutPanel_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_UpdateItem);
            this.groupBox1.Controls.Add(this.btn_RemoveItem);
            this.groupBox1.Controls.Add(this.btn_AddItem);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.cb_Genre);
            this.groupBox1.Controls.Add(this.cb_Platform);
            this.groupBox1.Controls.Add(this.lb_Genre);
            this.groupBox1.Controls.Add(this.cb_Price);
            this.groupBox1.Controls.Add(this.lb_Platform);
            this.groupBox1.Controls.Add(this.dateTimePicker_ArrivelDate);
            this.groupBox1.Controls.Add(this.dateTimePicker_ReleaseDate);
            this.groupBox1.Controls.Add(this.lb_Price);
            this.groupBox1.Controls.Add(this.lb_ArrivalDate);
            this.groupBox1.Controls.Add(this.lb_ReleaseDate);
            this.groupBox1.Controls.Add(this.lb_SteamKey);
            this.groupBox1.Controls.Add(this.lb_Serial);
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.Controls.Add(this.tb_SteamKey);
            this.groupBox1.Controls.Add(this.tb_SerialNum);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 709);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btn_UpdateItem
            // 
            this.btn_UpdateItem.Location = new System.Drawing.Point(308, 635);
            this.btn_UpdateItem.Name = "btn_UpdateItem";
            this.btn_UpdateItem.Size = new System.Drawing.Size(115, 68);
            this.btn_UpdateItem.TabIndex = 5;
            this.btn_UpdateItem.Text = "Update Item";
            this.btn_UpdateItem.UseVisualStyleBackColor = true;
            this.btn_UpdateItem.Click += new System.EventHandler(this.btn_UpdateItem_Click);
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.Location = new System.Drawing.Point(158, 635);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(115, 68);
            this.btn_RemoveItem.TabIndex = 5;
            this.btn_RemoveItem.Text = "Remove Item";
            this.btn_RemoveItem.UseVisualStyleBackColor = true;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(8, 635);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(115, 68);
            this.btn_AddItem.TabIndex = 5;
            this.btn_AddItem.Text = "Add Item";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(8, 585);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(415, 44);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_Genre
            // 
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Items.AddRange(new object[] {
            "RPG",
            "FPS",
            "Action-Adventure",
            "Platformer",
            "Horror",
            "MOBA ",
            "RTS",
            "Party games",
            "Sport/Simulation"});
            this.cb_Genre.Location = new System.Drawing.Point(8, 406);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(417, 23);
            this.cb_Genre.TabIndex = 3;
            // 
            // cb_Platform
            // 
            this.cb_Platform.FormattingEnabled = true;
            this.cb_Platform.Items.AddRange(new object[] {
            "PC",
            "PS4",
            "XboX Series X/S",
            "Stadia",
            "Nintendo Switch"});
            this.cb_Platform.Location = new System.Drawing.Point(8, 336);
            this.cb_Platform.Name = "cb_Platform";
            this.cb_Platform.Size = new System.Drawing.Size(417, 23);
            this.cb_Platform.TabIndex = 3;
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_Genre.Location = new System.Drawing.Point(7, 388);
            this.lb_Genre.Name = "lb_Genre";
            this.lb_Genre.Size = new System.Drawing.Size(38, 15);
            this.lb_Genre.TabIndex = 1;
            this.lb_Genre.Text = "Genre";
            // 
            // cb_Price
            // 
            this.cb_Price.FormattingEnabled = true;
            this.cb_Price.Location = new System.Drawing.Point(7, 266);
            this.cb_Price.Name = "cb_Price";
            this.cb_Price.Size = new System.Drawing.Size(417, 23);
            this.cb_Price.TabIndex = 3;
            // 
            // lb_Platform
            // 
            this.lb_Platform.AutoSize = true;
            this.lb_Platform.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_Platform.Location = new System.Drawing.Point(8, 318);
            this.lb_Platform.Name = "lb_Platform";
            this.lb_Platform.Size = new System.Drawing.Size(52, 15);
            this.lb_Platform.TabIndex = 1;
            this.lb_Platform.Text = "Platform";
            // 
            // dateTimePicker_ArrivelDate
            // 
            this.dateTimePicker_ArrivelDate.Location = new System.Drawing.Point(6, 476);
            this.dateTimePicker_ArrivelDate.Name = "dateTimePicker_ArrivelDate";
            this.dateTimePicker_ArrivelDate.Size = new System.Drawing.Size(417, 23);
            this.dateTimePicker_ArrivelDate.TabIndex = 2;
            // 
            // dateTimePicker_ReleaseDate
            // 
            this.dateTimePicker_ReleaseDate.Location = new System.Drawing.Point(7, 196);
            this.dateTimePicker_ReleaseDate.Name = "dateTimePicker_ReleaseDate";
            this.dateTimePicker_ReleaseDate.Size = new System.Drawing.Size(417, 23);
            this.dateTimePicker_ReleaseDate.TabIndex = 2;
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_Price.Location = new System.Drawing.Point(6, 248);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(32, 15);
            this.lb_Price.TabIndex = 1;
            this.lb_Price.Text = "Price";
            // 
            // lb_ArrivalDate
            // 
            this.lb_ArrivalDate.AutoSize = true;
            this.lb_ArrivalDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_ArrivalDate.Location = new System.Drawing.Point(5, 460);
            this.lb_ArrivalDate.Name = "lb_ArrivalDate";
            this.lb_ArrivalDate.Size = new System.Drawing.Size(69, 15);
            this.lb_ArrivalDate.TabIndex = 1;
            this.lb_ArrivalDate.Text = "Arrival date";
            // 
            // lb_ReleaseDate
            // 
            this.lb_ReleaseDate.AutoSize = true;
            this.lb_ReleaseDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_ReleaseDate.Location = new System.Drawing.Point(5, 178);
            this.lb_ReleaseDate.Name = "lb_ReleaseDate";
            this.lb_ReleaseDate.Size = new System.Drawing.Size(74, 15);
            this.lb_ReleaseDate.TabIndex = 1;
            this.lb_ReleaseDate.Text = "Release date";
            // 
            // lb_SteamKey
            // 
            this.lb_SteamKey.AutoSize = true;
            this.lb_SteamKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_SteamKey.Location = new System.Drawing.Point(7, 530);
            this.lb_SteamKey.Name = "lb_SteamKey";
            this.lb_SteamKey.Size = new System.Drawing.Size(64, 15);
            this.lb_SteamKey.TabIndex = 1;
            this.lb_SteamKey.Text = "Steam-Key";
            // 
            // lb_Serial
            // 
            this.lb_Serial.AutoSize = true;
            this.lb_Serial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_Serial.Location = new System.Drawing.Point(5, 108);
            this.lb_Serial.Name = "lb_Serial";
            this.lb_Serial.Size = new System.Drawing.Size(80, 15);
            this.lb_Serial.TabIndex = 1;
            this.lb_Serial.Text = "Serial number";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_Name.Location = new System.Drawing.Point(6, 38);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(39, 15);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Name";
            // 
            // tb_SteamKey
            // 
            this.tb_SteamKey.Location = new System.Drawing.Point(7, 546);
            this.tb_SteamKey.Name = "tb_SteamKey";
            this.tb_SteamKey.Size = new System.Drawing.Size(418, 23);
            this.tb_SteamKey.TabIndex = 0;
            // 
            // tb_SerialNum
            // 
            this.tb_SerialNum.Location = new System.Drawing.Point(6, 126);
            this.tb_SerialNum.Name = "tb_SerialNum";
            this.tb_SerialNum.Size = new System.Drawing.Size(418, 23);
            this.tb_SerialNum.TabIndex = 0;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(6, 56);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(418, 23);
            this.tb_Name.TabIndex = 0;
            // 
            // gb_Output
            // 
            this.gb_Output.Controls.Add(this.flowLayoutPanel_List);
            this.gb_Output.Location = new System.Drawing.Point(472, 68);
            this.gb_Output.Name = "gb_Output";
            this.gb_Output.Size = new System.Drawing.Size(787, 653);
            this.gb_Output.TabIndex = 1;
            this.gb_Output.TabStop = false;
            this.gb_Output.Text = "Output";
            // 
            // flowLayoutPanel_List
            // 
            this.flowLayoutPanel_List.AutoScroll = true;
            this.flowLayoutPanel_List.Controls.Add(this.dataGridView);
            this.flowLayoutPanel_List.Location = new System.Drawing.Point(7, 23);
            this.flowLayoutPanel_List.Name = "flowLayoutPanel_List";
            this.flowLayoutPanel_List.Size = new System.Drawing.Size(774, 669);
            this.flowLayoutPanel_List.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(919, 779);
            this.dataGridView.TabIndex = 0;
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(773, 39);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(78, 26);
            this.btn_Sort.TabIndex = 2;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            // 
            // cb_Sort
            // 
            this.cb_Sort.FormattingEnabled = true;
            this.cb_Sort.Items.AddRange(new object[] {
            "Price ascending",
            "Price descending",
            "Name ascending",
            "Name descending",
            "Serial number ascending",
            "Serial number descending"});
            this.cb_Sort.Location = new System.Drawing.Point(482, 39);
            this.cb_Sort.Name = "cb_Sort";
            this.cb_Sort.Size = new System.Drawing.Size(270, 23);
            this.cb_Sort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(482, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort by";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Sort);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.gb_Output);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "GC Module";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Output.ResumeLayout(false);
            this.flowLayoutPanel_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Genre;
        private System.Windows.Forms.ComboBox cb_Platform;
        private System.Windows.Forms.Label lb_Genre;
        private System.Windows.Forms.ComboBox cb_Price;
        private System.Windows.Forms.Label lb_Platform;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ArrivelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReleaseDate;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_ArrivalDate;
        private System.Windows.Forms.Label lb_ReleaseDate;
        private System.Windows.Forms.Label lb_SteamKey;
        private System.Windows.Forms.Label lb_Serial;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox tb_SteamKey;
        private System.Windows.Forms.TextBox tb_SerialNum;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_UpdateItem;
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_Output;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_List;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.ComboBox cb_Sort;
        private System.Windows.Forms.Label label1;
    }
}