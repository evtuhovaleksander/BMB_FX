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
            this.Order_TBox = new System.Windows.Forms.TextBox();
            this.Client_TBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Gap_Stop_TBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Gap_Start_TBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Service_TBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Maximize_But = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.client_leave_Status_TBox = new System.Windows.Forms.TextBox();
            this.end_job_Status_TBox = new System.Windows.Forms.TextBox();
            this.End_Job_But = new System.Windows.Forms.Button();
            this.Client_Leave_But = new System.Windows.Forms.Button();
            this.end_Status_TBox = new System.Windows.Forms.TextBox();
            this.Operation_End_But = new System.Windows.Forms.Button();
            this.begin_Status_TBox = new System.Windows.Forms.TextBox();
            this.Operation_Begin_But = new System.Windows.Forms.Button();
            this.client_Status_TBox = new System.Windows.Forms.TextBox();
            this.Client_But = new System.Windows.Forms.Button();
            this.master_Status_TBox = new System.Windows.Forms.TextBox();
            this.Master_But = new System.Windows.Forms.Button();
            this.Minimize_But = new System.Windows.Forms.Button();
            this.Red_But = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeINBox = new System.Windows.Forms.TextBox();
            this.tickBut = new System.Windows.Forms.Button();
            this.timeOUTBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Auto_RBut = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dgv = new BMB_FX.DataGridView_BMB();
            this.cancel_label = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_TBox
            // 
            this.Order_TBox.Location = new System.Drawing.Point(118, 21);
            this.Order_TBox.Name = "Order_TBox";
            this.Order_TBox.Size = new System.Drawing.Size(310, 22);
            this.Order_TBox.TabIndex = 0;
            // 
            // Client_TBox
            // 
            this.Client_TBox.Location = new System.Drawing.Point(118, 49);
            this.Client_TBox.Name = "Client_TBox";
            this.Client_TBox.Size = new System.Drawing.Size(310, 22);
            this.Client_TBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер заказа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancel_label);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Gap_Stop_TBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Gap_Start_TBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Service_TBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Order_TBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Client_TBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о заказе";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 167);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(422, 23);
            this.progressBar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Конец окна";
            // 
            // Gap_Stop_TBox
            // 
            this.Gap_Stop_TBox.Location = new System.Drawing.Point(118, 133);
            this.Gap_Stop_TBox.Name = "Gap_Stop_TBox";
            this.Gap_Stop_TBox.Size = new System.Drawing.Size(310, 22);
            this.Gap_Stop_TBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Начало окна";
            // 
            // Gap_Start_TBox
            // 
            this.Gap_Start_TBox.Location = new System.Drawing.Point(118, 105);
            this.Gap_Start_TBox.Name = "Gap_Start_TBox";
            this.Gap_Start_TBox.Size = new System.Drawing.Size(310, 22);
            this.Gap_Start_TBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Процедура";
            // 
            // Service_TBox
            // 
            this.Service_TBox.Location = new System.Drawing.Point(118, 77);
            this.Service_TBox.Name = "Service_TBox";
            this.Service_TBox.Size = new System.Drawing.Size(310, 22);
            this.Service_TBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Клиент";
            // 
            // Maximize_But
            // 
            this.Maximize_But.Location = new System.Drawing.Point(184, 408);
            this.Maximize_But.Name = "Maximize_But";
            this.Maximize_But.Size = new System.Drawing.Size(244, 23);
            this.Maximize_But.TabIndex = 4;
            this.Maximize_But.Text = "Проверить загруженность на день";
            this.Maximize_But.UseVisualStyleBackColor = true;
            this.Maximize_But.Click += new System.EventHandler(this.Maximize_But_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.client_leave_Status_TBox);
            this.groupBox2.Controls.Add(this.end_job_Status_TBox);
            this.groupBox2.Controls.Add(this.End_Job_But);
            this.groupBox2.Controls.Add(this.Client_Leave_But);
            this.groupBox2.Controls.Add(this.end_Status_TBox);
            this.groupBox2.Controls.Add(this.Operation_End_But);
            this.groupBox2.Controls.Add(this.begin_Status_TBox);
            this.groupBox2.Controls.Add(this.Operation_Begin_But);
            this.groupBox2.Controls.Add(this.client_Status_TBox);
            this.groupBox2.Controls.Add(this.Client_But);
            this.groupBox2.Controls.Add(this.master_Status_TBox);
            this.groupBox2.Controls.Add(this.Master_But);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.Maximize_But);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 436);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // client_leave_Status_TBox
            // 
            this.client_leave_Status_TBox.Location = new System.Drawing.Point(359, 340);
            this.client_leave_Status_TBox.Name = "client_leave_Status_TBox";
            this.client_leave_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.client_leave_Status_TBox.TabIndex = 18;
            // 
            // end_job_Status_TBox
            // 
            this.end_job_Status_TBox.Location = new System.Drawing.Point(359, 368);
            this.end_job_Status_TBox.Name = "end_job_Status_TBox";
            this.end_job_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.end_job_Status_TBox.TabIndex = 16;
            // 
            // End_Job_But
            // 
            this.End_Job_But.Location = new System.Drawing.Point(6, 367);
            this.End_Job_But.Name = "End_Job_But";
            this.End_Job_But.Size = new System.Drawing.Size(347, 23);
            this.End_Job_But.TabIndex = 15;
            this.End_Job_But.Text = "End Job";
            this.End_Job_But.UseVisualStyleBackColor = true;
            this.End_Job_But.Click += new System.EventHandler(this.End_Job_But_Click);
            // 
            // Client_Leave_But
            // 
            this.Client_Leave_But.Location = new System.Drawing.Point(6, 339);
            this.Client_Leave_But.Name = "Client_Leave_But";
            this.Client_Leave_But.Size = new System.Drawing.Size(347, 23);
            this.Client_Leave_But.TabIndex = 13;
            this.Client_Leave_But.Text = "Client_Leave";
            this.Client_Leave_But.UseVisualStyleBackColor = true;
            this.Client_Leave_But.Click += new System.EventHandler(this.Client_Leave_But_Click);
            // 
            // end_Status_TBox
            // 
            this.end_Status_TBox.Location = new System.Drawing.Point(359, 312);
            this.end_Status_TBox.Name = "end_Status_TBox";
            this.end_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.end_Status_TBox.TabIndex = 12;
            // 
            // Operation_End_But
            // 
            this.Operation_End_But.Location = new System.Drawing.Point(6, 311);
            this.Operation_End_But.Name = "Operation_End_But";
            this.Operation_End_But.Size = new System.Drawing.Size(347, 23);
            this.Operation_End_But.TabIndex = 11;
            this.Operation_End_But.Text = "End";
            this.Operation_End_But.UseVisualStyleBackColor = true;
            this.Operation_End_But.Click += new System.EventHandler(this.Operation_End_But_Click);
            // 
            // begin_Status_TBox
            // 
            this.begin_Status_TBox.Location = new System.Drawing.Point(359, 284);
            this.begin_Status_TBox.Name = "begin_Status_TBox";
            this.begin_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.begin_Status_TBox.TabIndex = 10;
            // 
            // Operation_Begin_But
            // 
            this.Operation_Begin_But.Location = new System.Drawing.Point(6, 283);
            this.Operation_Begin_But.Name = "Operation_Begin_But";
            this.Operation_Begin_But.Size = new System.Drawing.Size(347, 23);
            this.Operation_Begin_But.TabIndex = 9;
            this.Operation_Begin_But.Text = "Begin";
            this.Operation_Begin_But.UseVisualStyleBackColor = true;
            this.Operation_Begin_But.Click += new System.EventHandler(this.Operation_Begin_But_Click);
            // 
            // client_Status_TBox
            // 
            this.client_Status_TBox.Location = new System.Drawing.Point(359, 256);
            this.client_Status_TBox.Name = "client_Status_TBox";
            this.client_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.client_Status_TBox.TabIndex = 8;
            // 
            // Client_But
            // 
            this.Client_But.Location = new System.Drawing.Point(6, 255);
            this.Client_But.Name = "Client_But";
            this.Client_But.Size = new System.Drawing.Size(347, 23);
            this.Client_But.TabIndex = 7;
            this.Client_But.Text = "Client";
            this.Client_But.UseVisualStyleBackColor = true;
            this.Client_But.Click += new System.EventHandler(this.Client_But_Click);
            // 
            // master_Status_TBox
            // 
            this.master_Status_TBox.Location = new System.Drawing.Point(359, 228);
            this.master_Status_TBox.Name = "master_Status_TBox";
            this.master_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.master_Status_TBox.TabIndex = 6;
            // 
            // Master_But
            // 
            this.Master_But.Location = new System.Drawing.Point(6, 227);
            this.Master_But.Name = "Master_But";
            this.Master_But.Size = new System.Drawing.Size(347, 23);
            this.Master_But.TabIndex = 5;
            this.Master_But.Text = "Master";
            this.Master_But.UseVisualStyleBackColor = true;
            this.Master_But.Click += new System.EventHandler(this.Master_But_Click);
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
            this.timeINBox.Location = new System.Drawing.Point(914, 61);
            this.timeINBox.Name = "timeINBox";
            this.timeINBox.Size = new System.Drawing.Size(200, 22);
            this.timeINBox.TabIndex = 9;
            this.timeINBox.Text = "2017-02-6 09:30:00";
            // 
            // tickBut
            // 
            this.tickBut.Location = new System.Drawing.Point(914, 119);
            this.tickBut.Name = "tickBut";
            this.tickBut.Size = new System.Drawing.Size(200, 32);
            this.tickBut.TabIndex = 10;
            this.tickBut.Text = "Tick";
            this.tickBut.UseVisualStyleBackColor = true;
            this.tickBut.Click += new System.EventHandler(this.tickBut_Click);
            // 
            // timeOUTBox
            // 
            this.timeOUTBox.Location = new System.Drawing.Point(914, 89);
            this.timeOUTBox.Name = "timeOUTBox";
            this.timeOUTBox.Size = new System.Drawing.Size(200, 22);
            this.timeOUTBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1120, 56);
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
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(466, 20);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(442, 334);
            this.dgv.TabIndex = 12;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // cancel_label
            // 
            this.cancel_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancel_label.Location = new System.Drawing.Point(3, 161);
            this.cancel_label.Name = "cancel_label";
            this.cancel_label.Size = new System.Drawing.Size(428, 34);
            this.cancel_label.TabIndex = 11;
            this.cancel_label.Text = "Отменена!! Ожидает перераспределения!!!";
            this.cancel_label.UseVisualStyleBackColor = false;
            // 
            // Work_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 460);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.Auto_RBut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.timeOUTBox);
            this.Controls.Add(this.tickBut);
            this.Controls.Add(this.timeINBox);
            this.Controls.Add(this.Red_But);
            this.Controls.Add(this.Minimize_But);
            this.Controls.Add(this.groupBox2);
            this.Name = "Work_Form";
            this.Text = "Work_Form";
            this.Load += new System.EventHandler(this.Work_Form_Load);
            this.SizeChanged += new System.EventHandler(this.Work_Form_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Order_TBox;
        private System.Windows.Forms.TextBox Client_TBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Gap_Stop_TBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Gap_Start_TBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Service_TBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Maximize_But;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Minimize_But;
        private System.Windows.Forms.Button Red_But;
        private System.Windows.Forms.TextBox end_job_Status_TBox;
        private System.Windows.Forms.Button End_Job_But;
        private System.Windows.Forms.Button Client_Leave_But;
        private System.Windows.Forms.TextBox end_Status_TBox;
        private System.Windows.Forms.Button Operation_End_But;
        private System.Windows.Forms.TextBox begin_Status_TBox;
        private System.Windows.Forms.Button Operation_Begin_But;
        private System.Windows.Forms.TextBox client_Status_TBox;
        private System.Windows.Forms.Button Client_But;
        private System.Windows.Forms.TextBox master_Status_TBox;
        private System.Windows.Forms.Button Master_But;
        private System.Windows.Forms.TextBox client_leave_Status_TBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox timeINBox;
        private System.Windows.Forms.Button tickBut;
        private System.Windows.Forms.TextBox timeOUTBox;
        private DataGridView_BMB dgv;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Auto_RBut;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button cancel_label;
    }
}