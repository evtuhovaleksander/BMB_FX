namespace BMB_FX
{
    partial class Window_Search
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Day_Start_Picker = new System.Windows.Forms.DateTimePicker();
            this.Master_DGV = new System.Windows.Forms.DataGridView();
            this.Resource_DGV = new System.Windows.Forms.DataGridView();
            this.Window_DGV = new System.Windows.Forms.DataGridView();
            this.Service_CmBox = new System.Windows.Forms.ComboBox();
            this.allwindows_dgv = new System.Windows.Forms.DataGridView();
            this.winintervalSpec_DGV = new System.Windows.Forms.DataGridView();
            this.Day_Stop_Picker = new System.Windows.Forms.DateTimePicker();
            this.length_Tbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_Work_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Client_TBox = new System.Windows.Forms.TextBox();
            this.Select_Client = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Client_GrBox = new System.Windows.Forms.GroupBox();
            this.Client_Operation_Request_Indicator = new System.Windows.Forms.Button();
            this.Request_GrBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.track_value = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.hide = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Master_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resource_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allwindows_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winintervalSpec_DGV)).BeginInit();
            this.Client_GrBox.SuspendLayout();
            this.Request_GrBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Day_Start_Picker
            // 
            this.Day_Start_Picker.Location = new System.Drawing.Point(12, 160);
            this.Day_Start_Picker.Name = "Day_Start_Picker";
            this.Day_Start_Picker.Size = new System.Drawing.Size(180, 22);
            this.Day_Start_Picker.TabIndex = 0;
            // 
            // Master_DGV
            // 
            this.Master_DGV.AllowUserToAddRows = false;
            this.Master_DGV.AllowUserToDeleteRows = false;
            this.Master_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Master_DGV.Location = new System.Drawing.Point(12, 220);
            this.Master_DGV.Name = "Master_DGV";
            this.Master_DGV.RowTemplate.Height = 24;
            this.Master_DGV.Size = new System.Drawing.Size(920, 223);
            this.Master_DGV.TabIndex = 1;
            this.Master_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Master_DGV_CellContentClick);
            // 
            // Resource_DGV
            // 
            this.Resource_DGV.AllowUserToAddRows = false;
            this.Resource_DGV.AllowUserToDeleteRows = false;
            this.Resource_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resource_DGV.Location = new System.Drawing.Point(938, 220);
            this.Resource_DGV.Name = "Resource_DGV";
            this.Resource_DGV.RowTemplate.Height = 24;
            this.Resource_DGV.Size = new System.Drawing.Size(952, 223);
            this.Resource_DGV.TabIndex = 3;
            this.Resource_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Resource_DGV_CellContentClick);
            // 
            // Window_DGV
            // 
            this.Window_DGV.AllowUserToAddRows = false;
            this.Window_DGV.AllowUserToDeleteRows = false;
            this.Window_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Window_DGV.Location = new System.Drawing.Point(12, 449);
            this.Window_DGV.Name = "Window_DGV";
            this.Window_DGV.RowTemplate.Height = 24;
            this.Window_DGV.Size = new System.Drawing.Size(1887, 209);
            this.Window_DGV.TabIndex = 4;
            this.Window_DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Window_DGV_CellDoubleClick);
            // 
            // Service_CmBox
            // 
            this.Service_CmBox.FormattingEnabled = true;
            this.Service_CmBox.Location = new System.Drawing.Point(90, 19);
            this.Service_CmBox.Name = "Service_CmBox";
            this.Service_CmBox.Size = new System.Drawing.Size(300, 24);
            this.Service_CmBox.TabIndex = 5;
            this.Service_CmBox.SelectedIndexChanged += new System.EventHandler(this.Service_CmBox_SelectedIndexChanged);
            // 
            // allwindows_dgv
            // 
            this.allwindows_dgv.AllowUserToAddRows = false;
            this.allwindows_dgv.AllowUserToDeleteRows = false;
            this.allwindows_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.allwindows_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allwindows_dgv.Location = new System.Drawing.Point(12, 664);
            this.allwindows_dgv.Name = "allwindows_dgv";
            this.allwindows_dgv.RowTemplate.Height = 24;
            this.allwindows_dgv.Size = new System.Drawing.Size(798, 213);
            this.allwindows_dgv.TabIndex = 10;
            this.allwindows_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allwindows_dgv_CellContentClick);
            // 
            // winintervalSpec_DGV
            // 
            this.winintervalSpec_DGV.AllowUserToAddRows = false;
            this.winintervalSpec_DGV.AllowUserToDeleteRows = false;
            this.winintervalSpec_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.winintervalSpec_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.winintervalSpec_DGV.Location = new System.Drawing.Point(816, 664);
            this.winintervalSpec_DGV.Name = "winintervalSpec_DGV";
            this.winintervalSpec_DGV.ReadOnly = true;
            this.winintervalSpec_DGV.RowTemplate.Height = 24;
            this.winintervalSpec_DGV.Size = new System.Drawing.Size(957, 213);
            this.winintervalSpec_DGV.TabIndex = 11;
            this.winintervalSpec_DGV.SelectionChanged += new System.EventHandler(this.winintervalSpec_DGV_SelectionChanged);
            // 
            // Day_Stop_Picker
            // 
            this.Day_Stop_Picker.Location = new System.Drawing.Point(12, 188);
            this.Day_Stop_Picker.Name = "Day_Stop_Picker";
            this.Day_Stop_Picker.Size = new System.Drawing.Size(180, 22);
            this.Day_Stop_Picker.TabIndex = 12;
            // 
            // length_Tbox
            // 
            this.length_Tbox.Location = new System.Drawing.Point(504, 21);
            this.length_Tbox.Name = "length_Tbox";
            this.length_Tbox.Size = new System.Drawing.Size(55, 22);
            this.length_Tbox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "BUILD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Work_Button
            // 
            this.Add_Work_Button.Location = new System.Drawing.Point(1790, 699);
            this.Add_Work_Button.Name = "Add_Work_Button";
            this.Add_Work_Button.Size = new System.Drawing.Size(100, 107);
            this.Add_Work_Button.TabIndex = 15;
            this.Add_Work_Button.Text = "Оформить заказ процедуры";
            this.Add_Work_Button.UseVisualStyleBackColor = true;
            this.Add_Work_Button.Click += new System.EventHandler(this.Add_Work_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Клиент";
            // 
            // Client_TBox
            // 
            this.Client_TBox.Location = new System.Drawing.Point(76, 21);
            this.Client_TBox.Name = "Client_TBox";
            this.Client_TBox.Size = new System.Drawing.Size(374, 22);
            this.Client_TBox.TabIndex = 17;
            // 
            // Select_Client
            // 
            this.Select_Client.Location = new System.Drawing.Point(456, 21);
            this.Select_Client.Name = "Select_Client";
            this.Select_Client.Size = new System.Drawing.Size(103, 23);
            this.Select_Client.TabIndex = 18;
            this.Select_Client.Text = "Select Client";
            this.Select_Client.UseVisualStyleBackColor = true;
            this.Select_Client.Click += new System.EventHandler(this.Select_Client_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Процедура";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Длительность";
            // 
            // Client_GrBox
            // 
            this.Client_GrBox.Controls.Add(this.Client_Operation_Request_Indicator);
            this.Client_GrBox.Controls.Add(this.Service_CmBox);
            this.Client_GrBox.Controls.Add(this.label3);
            this.Client_GrBox.Controls.Add(this.length_Tbox);
            this.Client_GrBox.Controls.Add(this.label2);
            this.Client_GrBox.Location = new System.Drawing.Point(12, 66);
            this.Client_GrBox.Name = "Client_GrBox";
            this.Client_GrBox.Size = new System.Drawing.Size(568, 88);
            this.Client_GrBox.TabIndex = 21;
            this.Client_GrBox.TabStop = false;
            this.Client_GrBox.Text = "Прямое оформление";
            // 
            // Client_Operation_Request_Indicator
            // 
            this.Client_Operation_Request_Indicator.Location = new System.Drawing.Point(6, 51);
            this.Client_Operation_Request_Indicator.Name = "Client_Operation_Request_Indicator";
            this.Client_Operation_Request_Indicator.Size = new System.Drawing.Size(553, 31);
            this.Client_Operation_Request_Indicator.TabIndex = 21;
            this.Client_Operation_Request_Indicator.UseVisualStyleBackColor = true;
            // 
            // Request_GrBox
            // 
            this.Request_GrBox.Controls.Add(this.label6);
            this.Request_GrBox.Controls.Add(this.label5);
            this.Request_GrBox.Controls.Add(this.textBox3);
            this.Request_GrBox.Controls.Add(this.textBox2);
            this.Request_GrBox.Controls.Add(this.label4);
            this.Request_GrBox.Controls.Add(this.textBox1);
            this.Request_GrBox.Controls.Add(this.button2);
            this.Request_GrBox.Location = new System.Drawing.Point(586, 70);
            this.Request_GrBox.Name = "Request_GrBox";
            this.Request_GrBox.Size = new System.Drawing.Size(568, 144);
            this.Request_GrBox.TabIndex = 22;
            this.Request_GrBox.TabStop = false;
            this.Request_GrBox.Text = "Оформление по заявке";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Комент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Время";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(470, 62);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Процедура";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 51);
            this.button2.TabIndex = 0;
            this.button2.Text = "Select Request";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Select_Client);
            this.groupBox1.Controls.Add(this.Client_TBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 52);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор клиента";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(565, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Show Client";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.track_value);
            this.groupBox2.Controls.Add(this.trackBar);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.hide);
            this.groupBox2.Location = new System.Drawing.Point(1133, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 100);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режим отображения";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "Resize";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // track_value
            // 
            this.track_value.AutoSize = true;
            this.track_value.Location = new System.Drawing.Point(161, 72);
            this.track_value.Name = "track_value";
            this.track_value.Size = new System.Drawing.Size(46, 17);
            this.track_value.TabIndex = 3;
            this.track_value.Text = "label7";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(131, 31);
            this.trackBar.Maximum = 8;
            this.trackBar.Minimum = 5;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(104, 56);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 6;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "non hide";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // hide
            // 
            this.hide.AutoSize = true;
            this.hide.Location = new System.Drawing.Point(22, 31);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(56, 21);
            this.hide.TabIndex = 0;
            this.hide.Text = "hide";
            this.hide.UseVisualStyleBackColor = true;
            // 
            // Window_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 889);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Request_GrBox);
            this.Controls.Add(this.Client_GrBox);
            this.Controls.Add(this.Add_Work_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Day_Stop_Picker);
            this.Controls.Add(this.winintervalSpec_DGV);
            this.Controls.Add(this.allwindows_dgv);
            this.Controls.Add(this.Window_DGV);
            this.Controls.Add(this.Resource_DGV);
            this.Controls.Add(this.Master_DGV);
            this.Controls.Add(this.Day_Start_Picker);
            this.Name = "Window_Search";
            this.Text = "------------------------------";
            this.Load += new System.EventHandler(this.Window_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Master_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resource_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allwindows_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winintervalSpec_DGV)).EndInit();
            this.Client_GrBox.ResumeLayout(false);
            this.Client_GrBox.PerformLayout();
            this.Request_GrBox.ResumeLayout(false);
            this.Request_GrBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Day_Start_Picker;
        private System.Windows.Forms.DataGridView Master_DGV;
        private System.Windows.Forms.DataGridView Resource_DGV;
        private System.Windows.Forms.DataGridView Window_DGV;
        private System.Windows.Forms.ComboBox Service_CmBox;
        private System.Windows.Forms.DataGridView allwindows_dgv;
        private System.Windows.Forms.DataGridView winintervalSpec_DGV;
        private System.Windows.Forms.DateTimePicker Day_Stop_Picker;
        private System.Windows.Forms.TextBox length_Tbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add_Work_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Client_TBox;
        private System.Windows.Forms.Button Select_Client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Client_GrBox;
        private System.Windows.Forms.Button Client_Operation_Request_Indicator;
        private System.Windows.Forms.GroupBox Request_GrBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton hide;
        private System.Windows.Forms.Label track_value;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button button4;
    }
}

