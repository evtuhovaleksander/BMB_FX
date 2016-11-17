namespace BMB_FX
{
    partial class Table_Editor_Multi_Table
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
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.Upload_But = new System.Windows.Forms.Button();
            this.dgv = new BMB_FX.DataGridView_BMB();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Location = new System.Drawing.Point(581, 12);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(644, 509);
            this.tabContainer.TabIndex = 0;
            // 
            // Upload_But
            // 
            this.Upload_But.Location = new System.Drawing.Point(12, 478);
            this.Upload_But.Name = "Upload_But";
            this.Upload_But.Size = new System.Drawing.Size(121, 39);
            this.Upload_But.TabIndex = 2;
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
            this.dgv.Size = new System.Drawing.Size(563, 460);
            this.dgv.TabIndex = 3;
            // 
            // Table_Editor_Multi_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 533);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Upload_But);
            this.Controls.Add(this.tabContainer);
            this.Name = "Table_Editor_Multi_Table";
            this.Text = "Table_Editor_Multi_Table";
          
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.Button Upload_But;
        private DataGridView_BMB dgv;
    }
}