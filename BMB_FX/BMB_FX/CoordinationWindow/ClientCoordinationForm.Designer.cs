﻿namespace BMB_FX
{
    partial class ClientCoordinationForm
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
            this.Select_But = new System.Windows.Forms.Button();
            this.Add_But = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterTBox = new System.Windows.Forms.TextBox();
            this.dgv = new BMB_FX.DataGridView_BMB();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Select_But
            // 
            this.Select_But.Location = new System.Drawing.Point(86, 489);
            this.Select_But.Name = "Select_But";
            this.Select_But.Size = new System.Drawing.Size(75, 23);
            this.Select_But.TabIndex = 5;
            this.Select_But.Text = "Select";
            this.Select_But.UseVisualStyleBackColor = true;
            this.Select_But.Click += new System.EventHandler(this.Select_But_Click);
            // 
            // Add_But
            // 
            this.Add_But.Location = new System.Drawing.Point(5, 489);
            this.Add_But.Name = "Add_But";
            this.Add_But.Size = new System.Drawing.Size(75, 23);
            this.Add_But.TabIndex = 4;
            this.Add_But.Text = "Add";
            this.Add_But.UseVisualStyleBackColor = true;
            this.Add_But.Click += new System.EventHandler(this.Add_But_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фильтр";
            // 
            // FilterTBox
            // 
            this.FilterTBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FilterTBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FilterTBox.Location = new System.Drawing.Point(77, 76);
            this.FilterTBox.Name = "FilterTBox";
            this.FilterTBox.Size = new System.Drawing.Size(425, 22);
            this.FilterTBox.TabIndex = 7;
            this.FilterTBox.TextChanged += new System.EventHandler(this.FilterTBox_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(5, 114);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(798, 369);
            this.dgv.TabIndex = 3;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // ClientCoordinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 516);
            this.Controls.Add(this.FilterTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Select_But);
            this.Controls.Add(this.Add_But);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientCoordinationForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientCoordinationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Select_But;
        private System.Windows.Forms.Button Add_But;
        private DataGridView_BMB dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterTBox;
    }
}