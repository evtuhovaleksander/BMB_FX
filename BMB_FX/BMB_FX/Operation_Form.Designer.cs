namespace BMB_FX
{
    partial class Operation_Form
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancel_label = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Gap_Stop_TBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Gap_Start_TBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Service_TBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Order_TBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Client_TBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Resource_Tbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Master_Tbox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancel_label);
            this.groupBox2.Controls.Add(this.progressBar);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 442);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 243);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(422, 23);
            this.progressBar.TabIndex = 10;
            // 
            // cancel_label
            // 
            this.cancel_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancel_label.Location = new System.Drawing.Point(6, 232);
            this.cancel_label.Name = "cancel_label";
            this.cancel_label.Size = new System.Drawing.Size(428, 34);
            this.cancel_label.TabIndex = 11;
            this.cancel_label.Text = "Отменена!! Ожидает перераспределения!!!";
            this.cancel_label.UseVisualStyleBackColor = false;
            // 
            // client_leave_Status_TBox
            // 
            this.client_leave_Status_TBox.Location = new System.Drawing.Point(359, 385);
            this.client_leave_Status_TBox.Name = "client_leave_Status_TBox";
            this.client_leave_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.client_leave_Status_TBox.TabIndex = 18;
            // 
            // end_job_Status_TBox
            // 
            this.end_job_Status_TBox.Location = new System.Drawing.Point(359, 413);
            this.end_job_Status_TBox.Name = "end_job_Status_TBox";
            this.end_job_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.end_job_Status_TBox.TabIndex = 16;
            // 
            // End_Job_But
            // 
            this.End_Job_But.Location = new System.Drawing.Point(6, 412);
            this.End_Job_But.Name = "End_Job_But";
            this.End_Job_But.Size = new System.Drawing.Size(347, 23);
            this.End_Job_But.TabIndex = 15;
            this.End_Job_But.Text = "End Job";
            this.End_Job_But.UseVisualStyleBackColor = true;
            this.End_Job_But.Click += new System.EventHandler(this.End_Job_But_Click);
            // 
            // Client_Leave_But
            // 
            this.Client_Leave_But.Location = new System.Drawing.Point(6, 384);
            this.Client_Leave_But.Name = "Client_Leave_But";
            this.Client_Leave_But.Size = new System.Drawing.Size(347, 23);
            this.Client_Leave_But.TabIndex = 13;
            this.Client_Leave_But.Text = "Client_Leave";
            this.Client_Leave_But.UseVisualStyleBackColor = true;
            this.Client_Leave_But.Click += new System.EventHandler(this.Client_Leave_But_Click);
            // 
            // end_Status_TBox
            // 
            this.end_Status_TBox.Location = new System.Drawing.Point(359, 357);
            this.end_Status_TBox.Name = "end_Status_TBox";
            this.end_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.end_Status_TBox.TabIndex = 12;
            // 
            // Operation_End_But
            // 
            this.Operation_End_But.Location = new System.Drawing.Point(6, 356);
            this.Operation_End_But.Name = "Operation_End_But";
            this.Operation_End_But.Size = new System.Drawing.Size(347, 23);
            this.Operation_End_But.TabIndex = 11;
            this.Operation_End_But.Text = "End";
            this.Operation_End_But.UseVisualStyleBackColor = true;
            this.Operation_End_But.Click += new System.EventHandler(this.Operation_End_But_Click);
            // 
            // begin_Status_TBox
            // 
            this.begin_Status_TBox.Location = new System.Drawing.Point(359, 329);
            this.begin_Status_TBox.Name = "begin_Status_TBox";
            this.begin_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.begin_Status_TBox.TabIndex = 10;
            // 
            // Operation_Begin_But
            // 
            this.Operation_Begin_But.Location = new System.Drawing.Point(6, 328);
            this.Operation_Begin_But.Name = "Operation_Begin_But";
            this.Operation_Begin_But.Size = new System.Drawing.Size(347, 23);
            this.Operation_Begin_But.TabIndex = 9;
            this.Operation_Begin_But.Text = "Begin";
            this.Operation_Begin_But.UseVisualStyleBackColor = true;
            this.Operation_Begin_But.Click += new System.EventHandler(this.Operation_Begin_But_Click);
            // 
            // client_Status_TBox
            // 
            this.client_Status_TBox.Location = new System.Drawing.Point(359, 301);
            this.client_Status_TBox.Name = "client_Status_TBox";
            this.client_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.client_Status_TBox.TabIndex = 8;
            // 
            // Client_But
            // 
            this.Client_But.Location = new System.Drawing.Point(6, 300);
            this.Client_But.Name = "Client_But";
            this.Client_But.Size = new System.Drawing.Size(347, 23);
            this.Client_But.TabIndex = 7;
            this.Client_But.Text = "Client";
            this.Client_But.UseVisualStyleBackColor = true;
            this.Client_But.Click += new System.EventHandler(this.Client_But_Click);
            // 
            // master_Status_TBox
            // 
            this.master_Status_TBox.Location = new System.Drawing.Point(359, 273);
            this.master_Status_TBox.Name = "master_Status_TBox";
            this.master_Status_TBox.Size = new System.Drawing.Size(75, 22);
            this.master_Status_TBox.TabIndex = 6;
            // 
            // Master_But
            // 
            this.Master_But.Location = new System.Drawing.Point(6, 272);
            this.Master_But.Name = "Master_But";
            this.Master_But.Size = new System.Drawing.Size(347, 23);
            this.Master_But.TabIndex = 5;
            this.Master_But.Text = "Master";
            this.Master_But.UseVisualStyleBackColor = true;
            this.Master_But.Click += new System.EventHandler(this.Master_But_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Resource_Tbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Master_Tbox);
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
            this.groupBox1.Size = new System.Drawing.Size(436, 214);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о заказе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Конец окна";
            // 
            // Gap_Stop_TBox
            // 
            this.Gap_Stop_TBox.Location = new System.Drawing.Point(118, 182);
            this.Gap_Stop_TBox.Name = "Gap_Stop_TBox";
            this.Gap_Stop_TBox.Size = new System.Drawing.Size(310, 22);
            this.Gap_Stop_TBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Начало окна";
            // 
            // Gap_Start_TBox
            // 
            this.Gap_Start_TBox.Location = new System.Drawing.Point(118, 154);
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
            // Order_TBox
            // 
            this.Order_TBox.Location = new System.Drawing.Point(118, 21);
            this.Order_TBox.Name = "Order_TBox";
            this.Order_TBox.Size = new System.Drawing.Size(310, 22);
            this.Order_TBox.TabIndex = 0;
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
            // Client_TBox
            // 
            this.Client_TBox.Location = new System.Drawing.Point(118, 49);
            this.Client_TBox.Name = "Client_TBox";
            this.Client_TBox.Size = new System.Drawing.Size(310, 22);
            this.Client_TBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Место";
            // 
            // Resource_Tbox
            // 
            this.Resource_Tbox.Location = new System.Drawing.Point(118, 129);
            this.Resource_Tbox.Name = "Resource_Tbox";
            this.Resource_Tbox.Size = new System.Drawing.Size(310, 22);
            this.Resource_Tbox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Мастер";
            // 
            // Master_Tbox
            // 
            this.Master_Tbox.Location = new System.Drawing.Point(118, 101);
            this.Master_Tbox.Name = "Master_Tbox";
            this.Master_Tbox.Size = new System.Drawing.Size(310, 22);
            this.Master_Tbox.TabIndex = 10;
            // 
            // Operation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 466);
            this.Controls.Add(this.groupBox2);
            this.Name = "Operation_Form";
            this.Text = "Operation_Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox client_leave_Status_TBox;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancel_label;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Gap_Stop_TBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Gap_Start_TBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Service_TBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Order_TBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Client_TBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Resource_Tbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Master_Tbox;
    }
}