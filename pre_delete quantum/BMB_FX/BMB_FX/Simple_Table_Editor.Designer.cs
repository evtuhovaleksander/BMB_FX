namespace BMB_FX
{
    partial class Simple_Table_Editor
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
            this.Upload_But = new System.Windows.Forms.Button();
            this.dgv = new BMB_FX.DataGridView_BMB();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Upload_But
            // 
            this.Upload_But.Location = new System.Drawing.Point(12, 460);
            this.Upload_But.Name = "Upload_But";
            this.Upload_But.Size = new System.Drawing.Size(136, 37);
            this.Upload_But.TabIndex = 1;
            this.Upload_But.Text = "Upload";
            this.Upload_But.UseVisualStyleBackColor = true;
            this.Upload_But.Click += new System.EventHandler(this.Upload_But_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(892, 442);
            this.dgv.TabIndex = 2;
            // 
            // Simple_Table_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 506);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Upload_But);
            this.Name = "Simple_Table_Editor";
            this.Text = "Simple_Table_Editor";
            this.Load += new System.EventHandler(this.Simple_Table_Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Upload_But;
        private DataGridView_BMB dgv;
    }
}