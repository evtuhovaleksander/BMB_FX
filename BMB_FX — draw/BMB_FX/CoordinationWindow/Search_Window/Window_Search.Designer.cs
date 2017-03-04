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
            this.Service_CmBox1 = new System.Windows.Forms.ComboBox();
            this.Day_Stop_Picker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_Work_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Client_TBox = new System.Windows.Forms.TextBox();
            this.Select_Client = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Client_GrBox = new System.Windows.Forms.GroupBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.winintervalSpec_DGV = new System.Windows.Forms.DataGridView();
            this.allwindows_dgv = new System.Windows.Forms.DataGridView();
            this.MasterTabControll = new System.Windows.Forms.TabControl();
            this.button4 = new System.Windows.Forms.Button();
            this.ResourceTabControll = new System.Windows.Forms.TabControl();
            this.GroupServiceDGV = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.Spec_Windows_DGV = new System.Windows.Forms.DataGridView();
            this.TimeLine_DGV = new BMB_FX.DataGridView_TimeLine();
            this.filter = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Master_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resource_DGV)).BeginInit();
            this.Client_GrBox.SuspendLayout();
            this.Request_GrBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winintervalSpec_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allwindows_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupServiceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spec_Windows_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLine_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Day_Start_Picker
            // 
            this.Day_Start_Picker.Location = new System.Drawing.Point(1028, 54);
            this.Day_Start_Picker.Name = "Day_Start_Picker";
            this.Day_Start_Picker.Size = new System.Drawing.Size(180, 22);
            this.Day_Start_Picker.TabIndex = 0;
            // 
            // Master_DGV
            // 
            this.Master_DGV.AllowUserToAddRows = false;
            this.Master_DGV.AllowUserToDeleteRows = false;
            this.Master_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Master_DGV.Location = new System.Drawing.Point(587, 109);
            this.Master_DGV.Name = "Master_DGV";
            this.Master_DGV.RowTemplate.Height = 24;
            this.Master_DGV.Size = new System.Drawing.Size(459, 114);
            this.Master_DGV.TabIndex = 1;
            // 
            // Resource_DGV
            // 
            this.Resource_DGV.AllowUserToAddRows = false;
            this.Resource_DGV.AllowUserToDeleteRows = false;
            this.Resource_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resource_DGV.Location = new System.Drawing.Point(587, 21);
            this.Resource_DGV.Name = "Resource_DGV";
            this.Resource_DGV.RowTemplate.Height = 24;
            this.Resource_DGV.Size = new System.Drawing.Size(237, 74);
            this.Resource_DGV.TabIndex = 3;
            // 
            // Service_CmBox1
            // 
            this.Service_CmBox1.FormattingEnabled = true;
            this.Service_CmBox1.Location = new System.Drawing.Point(90, 19);
            this.Service_CmBox1.Name = "Service_CmBox1";
            this.Service_CmBox1.Size = new System.Drawing.Size(300, 24);
            this.Service_CmBox1.TabIndex = 5;
            this.Service_CmBox1.SelectedIndexChanged += new System.EventHandler(this.Service_CmBox_SelectedIndexChanged);
            // 
            // Day_Stop_Picker
            // 
            this.Day_Stop_Picker.Location = new System.Drawing.Point(1028, 82);
            this.Day_Stop_Picker.Name = "Day_Stop_Picker";
            this.Day_Stop_Picker.Size = new System.Drawing.Size(180, 22);
            this.Day_Stop_Picker.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 16);
            this.button1.TabIndex = 14;
            this.button1.Text = "BUILD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Add_Work_Button
            // 
            this.Add_Work_Button.Location = new System.Drawing.Point(1735, 664);
            this.Add_Work_Button.Name = "Add_Work_Button";
            this.Add_Work_Button.Size = new System.Drawing.Size(164, 213);
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
            // Client_GrBox
            // 
            this.Client_GrBox.Controls.Add(this.Service_CmBox1);
            this.Client_GrBox.Controls.Add(this.label2);
            this.Client_GrBox.Location = new System.Drawing.Point(6, 15);
            this.Client_GrBox.Name = "Client_GrBox";
            this.Client_GrBox.Size = new System.Drawing.Size(401, 49);
            this.Client_GrBox.TabIndex = 21;
            this.Client_GrBox.TabStop = false;
            this.Client_GrBox.Text = "Выбор процедуры";
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
            this.Request_GrBox.Location = new System.Drawing.Point(6, 21);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 171);
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.winintervalSpec_DGV);
            this.groupBox3.Controls.Add(this.allwindows_dgv);
            this.groupBox3.Controls.Add(this.Request_GrBox);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.Resource_DGV);
            this.groupBox3.Controls.Add(this.Master_DGV);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Client_GrBox);
            this.groupBox3.Location = new System.Drawing.Point(1808, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(82, 28);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OLD";
            // 
            // winintervalSpec_DGV
            // 
            this.winintervalSpec_DGV.AllowUserToAddRows = false;
            this.winintervalSpec_DGV.AllowUserToDeleteRows = false;
            this.winintervalSpec_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.winintervalSpec_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.winintervalSpec_DGV.Location = new System.Drawing.Point(23, 244);
            this.winintervalSpec_DGV.Name = "winintervalSpec_DGV";
            this.winintervalSpec_DGV.ReadOnly = true;
            this.winintervalSpec_DGV.RowTemplate.Height = 24;
            this.winintervalSpec_DGV.Size = new System.Drawing.Size(957, 213);
            this.winintervalSpec_DGV.TabIndex = 25;
            // 
            // allwindows_dgv
            // 
            this.allwindows_dgv.AllowUserToAddRows = false;
            this.allwindows_dgv.AllowUserToDeleteRows = false;
            this.allwindows_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.allwindows_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allwindows_dgv.Location = new System.Drawing.Point(51, 221);
            this.allwindows_dgv.Name = "allwindows_dgv";
            this.allwindows_dgv.RowTemplate.Height = 24;
            this.allwindows_dgv.Size = new System.Drawing.Size(798, 213);
            this.allwindows_dgv.TabIndex = 24;
            // 
            // MasterTabControll
            // 
            this.MasterTabControll.Location = new System.Drawing.Point(12, 146);
            this.MasterTabControll.Name = "MasterTabControll";
            this.MasterTabControll.SelectedIndex = 0;
            this.MasterTabControll.Size = new System.Drawing.Size(1196, 297);
            this.MasterTabControll.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 83);
            this.button4.TabIndex = 27;
            this.button4.Text = "step1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // ResourceTabControll
            // 
            this.ResourceTabControll.Location = new System.Drawing.Point(1214, 146);
            this.ResourceTabControll.Name = "ResourceTabControll";
            this.ResourceTabControll.SelectedIndex = 0;
            this.ResourceTabControll.Size = new System.Drawing.Size(676, 297);
            this.ResourceTabControll.TabIndex = 28;
            // 
            // GroupServiceDGV
            // 
            this.GroupServiceDGV.AllowUserToAddRows = false;
            this.GroupServiceDGV.AllowUserToDeleteRows = false;
            this.GroupServiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupServiceDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            this.GroupServiceDGV.Location = new System.Drawing.Point(12, 12);
            this.GroupServiceDGV.Name = "GroupServiceDGV";
            this.GroupServiceDGV.ReadOnly = true;
            this.GroupServiceDGV.RowTemplate.Height = 24;
            this.GroupServiceDGV.Size = new System.Drawing.Size(641, 128);
            this.GroupServiceDGV.TabIndex = 29;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Order";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Service";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Length";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1028, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 31);
            this.button5.TabIndex = 30;
            this.button5.Text = "step2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Spec_Windows_DGV
            // 
            this.Spec_Windows_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Spec_Windows_DGV.Location = new System.Drawing.Point(12, 664);
            this.Spec_Windows_DGV.Name = "Spec_Windows_DGV";
            this.Spec_Windows_DGV.RowTemplate.Height = 24;
            this.Spec_Windows_DGV.Size = new System.Drawing.Size(1717, 213);
            this.Spec_Windows_DGV.TabIndex = 31;
            this.Spec_Windows_DGV.SelectionChanged += new System.EventHandler(this.Spec_Windows_DGV_SelectionChanged);
            // 
            // TimeLine_DGV
            // 
            this.TimeLine_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeLine_DGV.Location = new System.Drawing.Point(12, 449);
            this.TimeLine_DGV.Name = "TimeLine_DGV";
            this.TimeLine_DGV.RowTemplate.Height = 24;
            this.TimeLine_DGV.Size = new System.Drawing.Size(1887, 209);
            this.TimeLine_DGV.TabIndex = 34;
            this.TimeLine_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeLine_DGV_CellClick);
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Checked = true;
            this.filter.Location = new System.Drawing.Point(1698, 12);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(77, 21);
            this.filter.TabIndex = 35;
            this.filter.TabStop = true;
            this.filter.Text = "filterON";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1698, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 21);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.Text = "filterOFFF";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // Window_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 889);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.TimeLine_DGV);
            this.Controls.Add(this.Spec_Windows_DGV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.GroupServiceDGV);
            this.Controls.Add(this.ResourceTabControll);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MasterTabControll);
            this.Controls.Add(this.Add_Work_Button);
            this.Controls.Add(this.Day_Stop_Picker);
            this.Controls.Add(this.Day_Start_Picker);
            this.Name = "Window_Search";
            this.Text = "------------------------------";
            this.Load += new System.EventHandler(this.Window_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Master_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resource_DGV)).EndInit();
            this.Client_GrBox.ResumeLayout(false);
            this.Client_GrBox.PerformLayout();
            this.Request_GrBox.ResumeLayout(false);
            this.Request_GrBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.winintervalSpec_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allwindows_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupServiceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spec_Windows_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLine_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Day_Start_Picker;
        private System.Windows.Forms.DataGridView Master_DGV;
        private System.Windows.Forms.DataGridView Resource_DGV;
        private System.Windows.Forms.ComboBox Service_CmBox1;
        private System.Windows.Forms.DateTimePicker Day_Stop_Picker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add_Work_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Client_TBox;
        private System.Windows.Forms.Button Select_Client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Client_GrBox;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl MasterTabControll;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl ResourceTabControll;
        private System.Windows.Forms.DataGridView GroupServiceDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView winintervalSpec_DGV;
        private System.Windows.Forms.DataGridView allwindows_dgv;
        private System.Windows.Forms.DataGridView Spec_Windows_DGV;
        private DataGridView_TimeLine TimeLine_DGV;
        private System.Windows.Forms.RadioButton filter;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

