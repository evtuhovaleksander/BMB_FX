namespace BMB_FX
{
    partial class Item_Load_Form
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
            this.dgv = new BMB_FX.DataGridView_TimeLine();
            this.cmBox = new System.Windows.Forms.ComboBox();
            this.Start_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Stop_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Load_but = new System.Windows.Forms.Button();
            this.masterRbut = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 135);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1228, 244);
            this.dgv.TabIndex = 0;
            // 
            // cmBox
            // 
            this.cmBox.FormattingEnabled = true;
            this.cmBox.Location = new System.Drawing.Point(12, 12);
            this.cmBox.Name = "cmBox";
            this.cmBox.Size = new System.Drawing.Size(200, 24);
            this.cmBox.TabIndex = 1;
            // 
            // Start_dateTimePicker
            // 
            this.Start_dateTimePicker.Location = new System.Drawing.Point(12, 42);
            this.Start_dateTimePicker.Name = "Start_dateTimePicker";
            this.Start_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.Start_dateTimePicker.TabIndex = 2;
            // 
            // Stop_dateTimePicker
            // 
            this.Stop_dateTimePicker.Location = new System.Drawing.Point(12, 70);
            this.Stop_dateTimePicker.Name = "Stop_dateTimePicker";
            this.Stop_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.Stop_dateTimePicker.TabIndex = 3;
            // 
            // Load_but
            // 
            this.Load_but.Location = new System.Drawing.Point(12, 98);
            this.Load_but.Name = "Load_but";
            this.Load_but.Size = new System.Drawing.Size(200, 31);
            this.Load_but.TabIndex = 4;
            this.Load_but.Text = "Load";
            this.Load_but.UseVisualStyleBackColor = true;
            this.Load_but.Click += new System.EventHandler(this.Load_but_Click);
            // 
            // masterRbut
            // 
            this.masterRbut.AutoSize = true;
            this.masterRbut.Location = new System.Drawing.Point(1129, 12);
            this.masterRbut.Name = "masterRbut";
            this.masterRbut.Size = new System.Drawing.Size(111, 21);
            this.masterRbut.TabIndex = 5;
            this.masterRbut.Text = "Master Mode";
            this.masterRbut.UseVisualStyleBackColor = true;
            this.masterRbut.CheckedChanged += new System.EventHandler(this.masterRbut_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1129, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Resource Mode";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Item_Load_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 391);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.masterRbut);
            this.Controls.Add(this.Load_but);
            this.Controls.Add(this.Stop_dateTimePicker);
            this.Controls.Add(this.Start_dateTimePicker);
            this.Controls.Add(this.cmBox);
            this.Controls.Add(this.dgv);
            this.Name = "Item_Load_Form";
            this.Text = "Item_Load_Form";
            this.Load += new System.EventHandler(this.Item_Load_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView_TimeLine dgv;
        private System.Windows.Forms.ComboBox cmBox;
        private System.Windows.Forms.DateTimePicker Start_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Stop_dateTimePicker;
        private System.Windows.Forms.Button Load_but;
        private System.Windows.Forms.RadioButton masterRbut;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}