namespace BMB_FX.Elements.Element_Show
{
    partial class Search_Form
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
            this.dgv = new BMB_FX.DataGridView_BMB();
            this.Add_But = new System.Windows.Forms.Button();
            this.Select_But = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1377, 369);
            this.dgv.TabIndex = 0;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // Add_But
            // 
            this.Add_But.Location = new System.Drawing.Point(12, 387);
            this.Add_But.Name = "Add_But";
            this.Add_But.Size = new System.Drawing.Size(75, 23);
            this.Add_But.TabIndex = 1;
            this.Add_But.Text = "Add";
            this.Add_But.UseVisualStyleBackColor = true;
            this.Add_But.Click += new System.EventHandler(this.Add_But_Click);
            // 
            // Select_But
            // 
            this.Select_But.Location = new System.Drawing.Point(151, 387);
            this.Select_But.Name = "Select_But";
            this.Select_But.Size = new System.Drawing.Size(75, 23);
            this.Select_But.TabIndex = 2;
            this.Select_But.Text = "Select";
            this.Select_But.UseVisualStyleBackColor = true;
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 432);
            this.Controls.Add(this.Select_But);
            this.Controls.Add(this.Add_But);
            this.Controls.Add(this.dgv);
            this.Name = "Search_Form";
            this.Text = "Search_Form";
            this.Load += new System.EventHandler(this.Search_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView_BMB dgv;
        private System.Windows.Forms.Button Add_But;
        private System.Windows.Forms.Button Select_But;
    }
}