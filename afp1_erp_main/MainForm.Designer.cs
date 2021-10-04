
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
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_Budget = new System.Windows.Forms.ComboBox();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.cb_Platform = new System.Windows.Forms.ComboBox();
            this.lb_Budget = new System.Windows.Forms.Label();
            this.lb_Genre = new System.Windows.Forms.Label();
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
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_SerialNum = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.gb_Output = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_List = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.cb_Sort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbF_Filter = new System.Windows.Forms.Label();
            this.cbF_Platform = new System.Windows.Forms.ComboBox();
            this.datePickerF = new System.Windows.Forms.DateTimePicker();
            this.cbF_Arrival = new System.Windows.Forms.ComboBox();
            this.num1stPrice = new System.Windows.Forms.NumericUpDown();
            this.num2ndPrice = new System.Windows.Forms.NumericUpDown();
            this.cbF_Price = new System.Windows.Forms.ComboBox();
            this.Btn_Filter = new System.Windows.Forms.Button();
            this.listF = new System.Windows.Forms.ListBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_Output.SuspendLayout();
            this.flowLayoutPanel_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1stPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2ndPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RemoveItem);
            this.groupBox1.Controls.Add(this.btn_AddItem);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.cb_Budget);
            this.groupBox1.Controls.Add(this.cb_Genre);
            this.groupBox1.Controls.Add(this.cb_Platform);
            this.groupBox1.Controls.Add(this.lb_Budget);
            this.groupBox1.Controls.Add(this.lb_Genre);
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
            this.groupBox1.Controls.Add(this.tb_Price);
            this.groupBox1.Controls.Add(this.tb_SerialNum);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 709);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.Location = new System.Drawing.Point(226, 641);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(199, 68);
            this.btn_RemoveItem.TabIndex = 11;
            this.btn_RemoveItem.TabStop = false;
            this.btn_RemoveItem.Text = "Remove Item";
            this.btn_RemoveItem.UseVisualStyleBackColor = true;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(8, 641);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(199, 68);
            this.btn_AddItem.TabIndex = 10;
            this.btn_AddItem.TabStop = false;
            this.btn_AddItem.Text = "Add Item";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(8, 585);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(415, 44);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.TabStop = false;
            this.btn_Search.Text = "Search By Name && Serial Number";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_Budget
            // 
            this.cb_Budget.FormattingEnabled = true;
            this.cb_Budget.Items.AddRange(new object[] {
            "",
            "AAA",
            "indie"});
            this.cb_Budget.Location = new System.Drawing.Point(308, 410);
            this.cb_Budget.Name = "cb_Budget";
            this.cb_Budget.Size = new System.Drawing.Size(116, 23);
            this.cb_Budget.TabIndex = 6;
            // 
            // cb_Genre
            // 
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Items.AddRange(new object[] {
            "",
            "action_adventure",
            "action_role_play",
            "battle_royale",
            "MMORPG",
            "shooter",
            "strategy_horror",
            "platformer",
            "point_and_click",
            "simulator",
            "strategy "});
            this.cb_Genre.Location = new System.Drawing.Point(8, 410);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(265, 23);
            this.cb_Genre.TabIndex = 5;
            // 
            // cb_Platform
            // 
            this.cb_Platform.FormattingEnabled = true;
            this.cb_Platform.Items.AddRange(new object[] {
            "Windows",
            "PS4",
            "PS5",
            "XboX Series X/S",
            "Stadia",
            "Nintendo Switch"});
            this.cb_Platform.Location = new System.Drawing.Point(8, 336);
            this.cb_Platform.Name = "cb_Platform";
            this.cb_Platform.Size = new System.Drawing.Size(417, 23);
            this.cb_Platform.TabIndex = 4;
            // 
            // lb_Budget
            // 
            this.lb_Budget.AutoSize = true;
            this.lb_Budget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_Budget.Location = new System.Drawing.Point(308, 392);
            this.lb_Budget.Name = "lb_Budget";
            this.lb_Budget.Size = new System.Drawing.Size(45, 15);
            this.lb_Budget.TabIndex = 1;
            this.lb_Budget.Text = "Budget";
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_Genre.Location = new System.Drawing.Point(8, 392);
            this.lb_Genre.Name = "lb_Genre";
            this.lb_Genre.Size = new System.Drawing.Size(38, 15);
            this.lb_Genre.TabIndex = 1;
            this.lb_Genre.Text = "Genre";
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
            this.dateTimePicker_ArrivelDate.CustomFormat = "yyyy. MM. dd., dddd";
            this.dateTimePicker_ArrivelDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ArrivelDate.Location = new System.Drawing.Point(8, 478);
            this.dateTimePicker_ArrivelDate.Name = "dateTimePicker_ArrivelDate";
            this.dateTimePicker_ArrivelDate.Size = new System.Drawing.Size(417, 23);
            this.dateTimePicker_ArrivelDate.TabIndex = 7;
            // 
            // dateTimePicker_ReleaseDate
            // 
            this.dateTimePicker_ReleaseDate.Location = new System.Drawing.Point(7, 196);
            this.dateTimePicker_ReleaseDate.Name = "dateTimePicker_ReleaseDate";
            this.dateTimePicker_ReleaseDate.Size = new System.Drawing.Size(417, 23);
            this.dateTimePicker_ReleaseDate.TabIndex = 2;
            this.dateTimePicker_ReleaseDate.Value = new System.DateTime(2021, 10, 3, 19, 18, 56, 0);
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
            this.tb_SteamKey.TabIndex = 8;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(5, 266);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(418, 23);
            this.tb_Price.TabIndex = 3;
            // 
            // tb_SerialNum
            // 
            this.tb_SerialNum.Location = new System.Drawing.Point(6, 126);
            this.tb_SerialNum.Name = "tb_SerialNum";
            this.tb_SerialNum.Size = new System.Drawing.Size(418, 23);
            this.tb_SerialNum.TabIndex = 1;
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
            this.gb_Output.Location = new System.Drawing.Point(472, 123);
            this.gb_Output.Name = "gb_Output";
            this.gb_Output.Size = new System.Drawing.Size(1057, 598);
            this.gb_Output.TabIndex = 21;
            this.gb_Output.TabStop = false;
            this.gb_Output.Text = "Output";
            // 
            // flowLayoutPanel_List
            // 
            this.flowLayoutPanel_List.AutoScroll = true;
            this.flowLayoutPanel_List.Controls.Add(this.dataGridView);
            this.flowLayoutPanel_List.Location = new System.Drawing.Point(7, 23);
            this.flowLayoutPanel_List.Name = "flowLayoutPanel_List";
            this.flowLayoutPanel_List.Size = new System.Drawing.Size(1048, 669);
            this.flowLayoutPanel_List.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1025, 779);
            this.dataGridView.TabIndex = 21;
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(773, 39);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(78, 26);
            this.btn_Sort.TabIndex = 14;
            this.btn_Sort.TabStop = false;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // cb_Sort
            // 
            this.cb_Sort.FormattingEnabled = true;
            this.cb_Sort.Items.AddRange(new object[] {
            "",
            "Price ascending",
            "Price descending",
            "Name ascending",
            "Name descending",
            "Serial number ascending",
            "Serial number descending"});
            this.cb_Sort.Location = new System.Drawing.Point(482, 39);
            this.cb_Sort.Name = "cb_Sort";
            this.cb_Sort.Size = new System.Drawing.Size(270, 23);
            this.cb_Sort.TabIndex = 13;
            this.cb_Sort.TabStop = false;
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
            // lbF_Filter
            // 
            this.lbF_Filter.AutoSize = true;
            this.lbF_Filter.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbF_Filter.Location = new System.Drawing.Point(869, 9);
            this.lbF_Filter.Name = "lbF_Filter";
            this.lbF_Filter.Size = new System.Drawing.Size(76, 25);
            this.lbF_Filter.TabIndex = 4;
            this.lbF_Filter.Text = "Filter by";
            // 
            // cbF_Platform
            // 
            this.cbF_Platform.FormattingEnabled = true;
            this.cbF_Platform.Items.AddRange(new object[] {
            "Windows",
            "PS4",
            "PS5",
            "XboX Series X/S",
            "Stadia",
            "Nintendo Switch"});
            this.cbF_Platform.Location = new System.Drawing.Point(951, 36);
            this.cbF_Platform.Name = "cbF_Platform";
            this.cbF_Platform.Size = new System.Drawing.Size(110, 23);
            this.cbF_Platform.TabIndex = 15;
            // 
            // datePickerF
            // 
            this.datePickerF.CustomFormat = "yyyy. MM. dd., dddd";
            this.datePickerF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerF.Location = new System.Drawing.Point(1076, 65);
            this.datePickerF.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.datePickerF.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.datePickerF.Name = "datePickerF";
            this.datePickerF.Size = new System.Drawing.Size(154, 23);
            this.datePickerF.TabIndex = 17;
            // 
            // cbF_Arrival
            // 
            this.cbF_Arrival.FormattingEnabled = true;
            this.cbF_Arrival.Items.AddRange(new object[] {
            "before",
            "after"});
            this.cbF_Arrival.Location = new System.Drawing.Point(951, 65);
            this.cbF_Arrival.Name = "cbF_Arrival";
            this.cbF_Arrival.Size = new System.Drawing.Size(110, 23);
            this.cbF_Arrival.TabIndex = 16;
            // 
            // num1stPrice
            // 
            this.num1stPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num1stPrice.Location = new System.Drawing.Point(1076, 96);
            this.num1stPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num1stPrice.Name = "num1stPrice";
            this.num1stPrice.Size = new System.Drawing.Size(79, 23);
            this.num1stPrice.TabIndex = 19;
            this.num1stPrice.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // num2ndPrice
            // 
            this.num2ndPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num2ndPrice.Location = new System.Drawing.Point(1188, 96);
            this.num2ndPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num2ndPrice.Name = "num2ndPrice";
            this.num2ndPrice.Size = new System.Drawing.Size(82, 23);
            this.num2ndPrice.TabIndex = 20;
            this.num2ndPrice.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.num2ndPrice.Visible = false;
            // 
            // cbF_Price
            // 
            this.cbF_Price.FormattingEnabled = true;
            this.cbF_Price.Items.AddRange(new object[] {
            "between",
            "over",
            "under"});
            this.cbF_Price.Location = new System.Drawing.Point(951, 96);
            this.cbF_Price.Name = "cbF_Price";
            this.cbF_Price.Size = new System.Drawing.Size(110, 23);
            this.cbF_Price.TabIndex = 18;
            this.cbF_Price.SelectedIndexChanged += new System.EventHandler(this.cbF_Price_SelectedIndexChanged);
            // 
            // Btn_Filter
            // 
            this.Btn_Filter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Filter.Location = new System.Drawing.Point(1303, 65);
            this.Btn_Filter.Name = "Btn_Filter";
            this.Btn_Filter.Size = new System.Drawing.Size(103, 54);
            this.Btn_Filter.TabIndex = 22;
            this.Btn_Filter.Text = "Filter";
            this.Btn_Filter.UseVisualStyleBackColor = true;
            this.Btn_Filter.Click += new System.EventHandler(this.Btn_Filter_Click);
            // 
            // listF
            // 
            this.listF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listF.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listF.FormattingEnabled = true;
            this.listF.ItemHeight = 20;
            this.listF.Items.AddRange(new object[] {
            "Platform",
            "Arrival date",
            "Price"});
            this.listF.Location = new System.Drawing.Point(857, 39);
            this.listF.Name = "listF";
            this.listF.Size = new System.Drawing.Size(88, 60);
            this.listF.TabIndex = 23;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(1454, 86);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(61, 31);
            this.btn_Reset.TabIndex = 22;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 733);
            this.Controls.Add(this.listF);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.Btn_Filter);
            this.Controls.Add(this.num2ndPrice);
            this.Controls.Add(this.num1stPrice);
            this.Controls.Add(this.lbF_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Sort);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.cbF_Price);
            this.Controls.Add(this.cbF_Arrival);
            this.Controls.Add(this.cbF_Platform);
            this.Controls.Add(this.gb_Output);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datePickerF);
            this.Name = "MainForm";
            this.Text = "GC Module";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Output.ResumeLayout(false);
            this.flowLayoutPanel_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1stPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2ndPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Genre;
        private System.Windows.Forms.ComboBox cb_Platform;
        private System.Windows.Forms.Label lb_Genre;
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
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_Output;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_List;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.ComboBox cb_Sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbF_Filter;
        private System.Windows.Forms.ComboBox cbF_Platform;
        private System.Windows.Forms.DateTimePicker datePickerF;
        private System.Windows.Forms.ComboBox cbF_Arrival;
        private System.Windows.Forms.NumericUpDown num1stPrice;
        private System.Windows.Forms.NumericUpDown num2ndPrice;
        private System.Windows.Forms.ComboBox cbF_Price;
        private System.Windows.Forms.Label lb_Budget;
        private System.Windows.Forms.ComboBox cb_Budget;
        private System.Windows.Forms.Button Btn_Filter;
        private System.Windows.Forms.ListBox listF;
        private System.Windows.Forms.Button btn_Reset;
    }
}