namespace BMB_FX
{
    partial class TimeLineForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.track_value = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.hide = new System.Windows.Forms.RadioButton();
            this.dgv = new BMB_FX.DataGridView_TimeLine();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.track_value);
            this.groupBox2.Controls.Add(this.trackBar);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.hide);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 100);
            this.groupBox2.TabIndex = 25;
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
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 118);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(952, 207);
            this.dgv.TabIndex = 26;
            // 
            // TimeLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 332);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox2);
            this.Name = "TimeLineForm";
            this.Text = "TimeLineForm";
            this.Load += new System.EventHandler(this.TimeLineForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label track_value;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton hide;
        private DataGridView_TimeLine dgv;
    }
}