namespace BMB_FX.Request_Form_Package
{
    partial class Request_Form
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
            this.Add_Request_But = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1244, 274);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Add_Request_But
            // 
            this.Add_Request_But.Location = new System.Drawing.Point(12, 300);
            this.Add_Request_But.Name = "Add_Request_But";
            this.Add_Request_But.Size = new System.Drawing.Size(75, 23);
            this.Add_Request_But.TabIndex = 1;
            this.Add_Request_But.Text = "Add";
            this.Add_Request_But.UseVisualStyleBackColor = true;
            this.Add_Request_But.Click += new System.EventHandler(this.Add_Request_But_Click);
            // 
            // Request_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 335);
            this.Controls.Add(this.Add_Request_But);
            this.Controls.Add(this.dgv);
            this.Name = "Request_Form";
            this.Text = "Request_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView_BMB dgv;
        private System.Windows.Forms.Button Add_Request_But;
    }
}