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
            ((System.ComponentModel.ISupportInitialize)(this.Master_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resource_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allwindows_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winintervalSpec_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Day_Start_Picker
            // 
            this.Day_Start_Picker.Location = new System.Drawing.Point(12, 50);
            this.Day_Start_Picker.Name = "Day_Start_Picker";
            this.Day_Start_Picker.Size = new System.Drawing.Size(632, 22);
            this.Day_Start_Picker.TabIndex = 0;
            // 
            // Master_DGV
            // 
            this.Master_DGV.AllowUserToAddRows = false;
            this.Master_DGV.AllowUserToDeleteRows = false;
            this.Master_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Master_DGV.Location = new System.Drawing.Point(12, 106);
            this.Master_DGV.Name = "Master_DGV";
            this.Master_DGV.RowTemplate.Height = 24;
            this.Master_DGV.Size = new System.Drawing.Size(920, 191);
            this.Master_DGV.TabIndex = 1;
            this.Master_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Master_DGV_CellContentClick);
            // 
            // Resource_DGV
            // 
            this.Resource_DGV.AllowUserToAddRows = false;
            this.Resource_DGV.AllowUserToDeleteRows = false;
            this.Resource_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resource_DGV.Location = new System.Drawing.Point(938, 106);
            this.Resource_DGV.Name = "Resource_DGV";
            this.Resource_DGV.RowTemplate.Height = 24;
            this.Resource_DGV.Size = new System.Drawing.Size(952, 191);
            this.Resource_DGV.TabIndex = 3;
            this.Resource_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Resource_DGV_CellContentClick);
            // 
            // Window_DGV
            // 
            this.Window_DGV.AllowUserToAddRows = false;
            this.Window_DGV.AllowUserToDeleteRows = false;
            this.Window_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Window_DGV.Location = new System.Drawing.Point(12, 404);
            this.Window_DGV.Name = "Window_DGV";
            this.Window_DGV.RowTemplate.Height = 24;
            this.Window_DGV.Size = new System.Drawing.Size(1887, 191);
            this.Window_DGV.TabIndex = 4;
            this.Window_DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Window_DGV_CellDoubleClick);
            // 
            // Service_CmBox
            // 
            this.Service_CmBox.FormattingEnabled = true;
            this.Service_CmBox.Location = new System.Drawing.Point(12, 20);
            this.Service_CmBox.Name = "Service_CmBox";
            this.Service_CmBox.Size = new System.Drawing.Size(632, 24);
            this.Service_CmBox.TabIndex = 5;
            this.Service_CmBox.SelectedIndexChanged += new System.EventHandler(this.Service_CmBox_SelectedIndexChanged);
            // 
            // allwindows_dgv
            // 
            this.allwindows_dgv.AllowUserToAddRows = false;
            this.allwindows_dgv.AllowUserToDeleteRows = false;
            this.allwindows_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.allwindows_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allwindows_dgv.Location = new System.Drawing.Point(12, 620);
            this.allwindows_dgv.Name = "allwindows_dgv";
            this.allwindows_dgv.RowTemplate.Height = 24;
            this.allwindows_dgv.Size = new System.Drawing.Size(798, 257);
            this.allwindows_dgv.TabIndex = 10;
            this.allwindows_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allwindows_dgv_CellContentClick);
            // 
            // winintervalSpec_DGV
            // 
            this.winintervalSpec_DGV.AllowUserToAddRows = false;
            this.winintervalSpec_DGV.AllowUserToDeleteRows = false;
            this.winintervalSpec_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.winintervalSpec_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.winintervalSpec_DGV.Location = new System.Drawing.Point(816, 620);
            this.winintervalSpec_DGV.Name = "winintervalSpec_DGV";
            this.winintervalSpec_DGV.ReadOnly = true;
            this.winintervalSpec_DGV.RowTemplate.Height = 24;
            this.winintervalSpec_DGV.Size = new System.Drawing.Size(957, 257);
            this.winintervalSpec_DGV.TabIndex = 11;
            this.winintervalSpec_DGV.SelectionChanged += new System.EventHandler(this.winintervalSpec_DGV_SelectionChanged);
            // 
            // Day_Stop_Picker
            // 
            this.Day_Stop_Picker.Location = new System.Drawing.Point(12, 78);
            this.Day_Stop_Picker.Name = "Day_Stop_Picker";
            this.Day_Stop_Picker.Size = new System.Drawing.Size(632, 22);
            this.Day_Stop_Picker.TabIndex = 12;
            // 
            // length_Tbox
            // 
            this.length_Tbox.Location = new System.Drawing.Point(660, 20);
            this.length_Tbox.Name = "length_Tbox";
            this.length_Tbox.Size = new System.Drawing.Size(100, 22);
            this.length_Tbox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 76);
            this.button1.TabIndex = 14;
            this.button1.Text = "BUILD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Work_Button
            // 
            this.Add_Work_Button.Location = new System.Drawing.Point(1789, 619);
            this.Add_Work_Button.Name = "Add_Work_Button";
            this.Add_Work_Button.Size = new System.Drawing.Size(100, 107);
            this.Add_Work_Button.TabIndex = 15;
            this.Add_Work_Button.Text = "Add";
            this.Add_Work_Button.UseVisualStyleBackColor = true;
            this.Add_Work_Button.Click += new System.EventHandler(this.Add_Work_Button_Click);
            // 
            // Window_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 889);
            this.Controls.Add(this.Add_Work_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.length_Tbox);
            this.Controls.Add(this.Day_Stop_Picker);
            this.Controls.Add(this.winintervalSpec_DGV);
            this.Controls.Add(this.allwindows_dgv);
            this.Controls.Add(this.Service_CmBox);
            this.Controls.Add(this.Window_DGV);
            this.Controls.Add(this.Resource_DGV);
            this.Controls.Add(this.Master_DGV);
            this.Controls.Add(this.Day_Start_Picker);
            this.Name = "Window_Search";
            this.Text = "------------------------------";
            ((System.ComponentModel.ISupportInitialize)(this.Master_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resource_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allwindows_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winintervalSpec_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

