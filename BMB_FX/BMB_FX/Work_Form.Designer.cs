namespace BMB_FX
{
    partial class Work_Form
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
            this.components = new System.ComponentModel.Container();
            this.Maximize_But = new System.Windows.Forms.Button();
            this.Minimize_But = new System.Windows.Forms.Button();
            this.Red_But = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeINBox = new System.Windows.Forms.TextBox();
            this.tickBut = new System.Windows.Forms.Button();
            this.timeOUTBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Auto_RBut = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.dgv = new BMB_FX.DataGridView_BMB();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Maximize_But
            // 
            this.Maximize_But.Location = new System.Drawing.Point(466, 498);
            this.Maximize_But.Name = "Maximize_But";
            this.Maximize_But.Size = new System.Drawing.Size(244, 23);
            this.Maximize_But.TabIndex = 4;
            this.Maximize_But.Text = "Проверить загруженность на день";
            this.Maximize_But.UseVisualStyleBackColor = true;
            this.Maximize_But.Click += new System.EventHandler(this.Maximize_But_Click);
            // 
            // Minimize_But
            // 
            this.Minimize_But.Location = new System.Drawing.Point(625, 409);
            this.Minimize_But.Name = "Minimize_But";
            this.Minimize_But.Size = new System.Drawing.Size(91, 34);
            this.Minimize_But.TabIndex = 7;
            this.Minimize_But.Text = "Свернуть";
            this.Minimize_But.UseVisualStyleBackColor = true;
            this.Minimize_But.Click += new System.EventHandler(this.Minimize_But_Click);
            // 
            // Red_But
            // 
            this.Red_But.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Red_But.Location = new System.Drawing.Point(466, 409);
            this.Red_But.Name = "Red_But";
            this.Red_But.Size = new System.Drawing.Size(153, 34);
            this.Red_But.TabIndex = 8;
            this.Red_But.Text = "Отменить заказ";
            this.Red_But.UseVisualStyleBackColor = false;
            this.Red_But.Click += new System.EventHandler(this.Red_But_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeINBox
            // 
            this.timeINBox.Location = new System.Drawing.Point(742, 421);
            this.timeINBox.Name = "timeINBox";
            this.timeINBox.Size = new System.Drawing.Size(200, 22);
            this.timeINBox.TabIndex = 9;
            this.timeINBox.Text = "2017-02-6 09:30:00";
            // 
            // tickBut
            // 
            this.tickBut.Location = new System.Drawing.Point(742, 479);
            this.tickBut.Name = "tickBut";
            this.tickBut.Size = new System.Drawing.Size(200, 32);
            this.tickBut.TabIndex = 10;
            this.tickBut.Text = "Tick";
            this.tickBut.UseVisualStyleBackColor = true;
            this.tickBut.Click += new System.EventHandler(this.tickBut_Click);
            // 
            // timeOUTBox
            // 
            this.timeOUTBox.Location = new System.Drawing.Point(742, 449);
            this.timeOUTBox.Name = "timeOUTBox";
            this.timeOUTBox.Size = new System.Drawing.Size(200, 22);
            this.timeOUTBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "tick next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Auto_RBut
            // 
            this.Auto_RBut.AutoSize = true;
            this.Auto_RBut.Checked = true;
            this.Auto_RBut.Location = new System.Drawing.Point(474, 360);
            this.Auto_RBut.Name = "Auto_RBut";
            this.Auto_RBut.Size = new System.Drawing.Size(239, 21);
            this.Auto_RBut.TabIndex = 14;
            this.Auto_RBut.TabStop = true;
            this.Auto_RBut.Text = "Автоматическое переключение";
            this.Auto_RBut.UseVisualStyleBackColor = true;
            this.Auto_RBut.CheckedChanged += new System.EventHandler(this.Auto_RBut_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(474, 385);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(178, 21);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Ручное переключение";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(5, 8);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(452, 513);
            this.panel.TabIndex = 16;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(466, 20);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(985, 334);
            this.dgv.TabIndex = 12;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // Work_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 533);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.Auto_RBut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.timeOUTBox);
            this.Controls.Add(this.tickBut);
            this.Controls.Add(this.timeINBox);
            this.Controls.Add(this.Red_But);
            this.Controls.Add(this.Minimize_But);
            this.Controls.Add(this.Maximize_But);
            this.Name = "Work_Form";
            this.Text = "Work_Form";
            this.Load += new System.EventHandler(this.Work_Form_Load);
            this.SizeChanged += new System.EventHandler(this.Work_Form_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Maximize_But;
        private System.Windows.Forms.Button Minimize_But;
        private System.Windows.Forms.Button Red_But;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox timeINBox;
        private System.Windows.Forms.Button tickBut;
        private System.Windows.Forms.TextBox timeOUTBox;
        private DataGridView_BMB dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Auto_RBut;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel;
    }
}