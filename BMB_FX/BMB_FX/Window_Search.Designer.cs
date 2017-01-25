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
            this.Day_Picker = new System.Windows.Forms.DateTimePicker();
            this.Master_DGV = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Window_DGV = new System.Windows.Forms.DataGridView();
            this.Service_CmBox = new System.Windows.Forms.ComboBox();
            this.allwindows_dgv = new System.Windows.Forms.DataGridView();
            this.winintervalSpec_DGV = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.length_Tbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Master_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allwindows_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winintervalSpec_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Day_Picker
            // 
            this.Day_Picker.Location = new System.Drawing.Point(12, 50);
            this.Day_Picker.Name = "Day_Picker";
            this.Day_Picker.Size = new System.Drawing.Size(632, 22);
            this.Day_Picker.TabIndex = 0;
            // 
            // Master_DGV
            // 
            this.Master_DGV.AllowUserToAddRows = false;
            this.Master_DGV.AllowUserToDeleteRows = false;
            this.Master_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Master_DGV.Location = new System.Drawing.Point(12, 106);
            this.Master_DGV.Name = "Master_DGV";
            this.Master_DGV.RowTemplate.Height = 24;
            this.Master_DGV.Size = new System.Drawing.Size(632, 191);
            this.Master_DGV.TabIndex = 1;
            this.Master_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Master_DGV_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(650, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(468, 191);
            this.dataGridView2.TabIndex = 3;
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
            this.allwindows_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.allwindows_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allwindows_dgv.Location = new System.Drawing.Point(12, 620);
            this.allwindows_dgv.Name = "allwindows_dgv";
            this.allwindows_dgv.RowTemplate.Height = 24;
            this.allwindows_dgv.Size = new System.Drawing.Size(1030, 257);
            this.allwindows_dgv.TabIndex = 10;
            // 
            // winintervalSpec_DGV
            // 
            this.winintervalSpec_DGV.AllowUserToAddRows = false;
            this.winintervalSpec_DGV.AllowUserToDeleteRows = false;
            this.winintervalSpec_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.winintervalSpec_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.winintervalSpec_DGV.Location = new System.Drawing.Point(1061, 620);
            this.winintervalSpec_DGV.Name = "winintervalSpec_DGV";
            this.winintervalSpec_DGV.ReadOnly = true;
            this.winintervalSpec_DGV.RowTemplate.Height = 24;
            this.winintervalSpec_DGV.Size = new System.Drawing.Size(829, 257);
            this.winintervalSpec_DGV.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(632, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // length_Tbox
            // 
            this.length_Tbox.Location = new System.Drawing.Point(660, 20);
            this.length_Tbox.Name = "length_Tbox";
            this.length_Tbox.Size = new System.Drawing.Size(100, 22);
            this.length_Tbox.TabIndex = 13;
            // 
            // Window_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 889);
            this.Controls.Add(this.length_Tbox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.winintervalSpec_DGV);
            this.Controls.Add(this.allwindows_dgv);
            this.Controls.Add(this.Service_CmBox);
            this.Controls.Add(this.Window_DGV);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Master_DGV);
            this.Controls.Add(this.Day_Picker);
            this.Name = "Window_Search";
            this.Text = "------------------------------";
            this.Load += new System.EventHandler(this.Window_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Master_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allwindows_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winintervalSpec_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Day_Picker;
        private System.Windows.Forms.DataGridView Master_DGV;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView Window_DGV;
        private System.Windows.Forms.ComboBox Service_CmBox;
        private System.Windows.Forms.DataGridView allwindows_dgv;
        private System.Windows.Forms.DataGridView winintervalSpec_DGV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox length_Tbox;
    }
}

