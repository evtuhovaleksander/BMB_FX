namespace BMB_FX
{
    partial class EditForm
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
            this.Delete_But = new System.Windows.Forms.Button();
            this.Save_But = new System.Windows.Forms.Button();
            this.Add_But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete_But
            // 
            this.Delete_But.Location = new System.Drawing.Point(253, 12);
            this.Delete_But.Name = "Delete_But";
            this.Delete_But.Size = new System.Drawing.Size(116, 23);
            this.Delete_But.TabIndex = 5;
            this.Delete_But.Text = "Delete";
            this.Delete_But.UseVisualStyleBackColor = true;
            this.Delete_But.Visible = false;
            this.Delete_But.Click += new System.EventHandler(this.Delete_But_Click);
            // 
            // Save_But
            // 
            this.Save_But.Location = new System.Drawing.Point(131, 12);
            this.Save_But.Name = "Save_But";
            this.Save_But.Size = new System.Drawing.Size(116, 23);
            this.Save_But.TabIndex = 4;
            this.Save_But.Text = "Save";
            this.Save_But.UseVisualStyleBackColor = true;
            this.Save_But.Visible = false;
            this.Save_But.Click += new System.EventHandler(this.Save_But_Click);
            // 
            // Add_But
            // 
            this.Add_But.Location = new System.Drawing.Point(9, 12);
            this.Add_But.Name = "Add_But";
            this.Add_But.Size = new System.Drawing.Size(116, 23);
            this.Add_But.TabIndex = 3;
            this.Add_But.Text = "Add";
            this.Add_But.UseVisualStyleBackColor = true;
            this.Add_But.Visible = false;
            this.Add_But.Click += new System.EventHandler(this.Add_But_Click);
            // 
            // RedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 1007);
            this.Controls.Add(this.Delete_But);
            this.Controls.Add(this.Save_But);
            this.Controls.Add(this.Add_But);
            this.Name = "RedForm";
            this.Text = "RedForm";
            this.Load += new System.EventHandler(this.RedForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Delete_But;
        public System.Windows.Forms.Button Save_But;
        public System.Windows.Forms.Button Add_But;
    }
}