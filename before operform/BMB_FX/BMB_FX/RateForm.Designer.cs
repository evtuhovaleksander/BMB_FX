namespace BMB_FX
{
    partial class RateForm
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
            this.Set_One = new System.Windows.Forms.Button();
            this.Set_Five = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Set_One
            // 
            this.Set_One.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Set_One.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Set_One.Location = new System.Drawing.Point(12, 12);
            this.Set_One.Name = "Set_One";
            this.Set_One.Size = new System.Drawing.Size(238, 91);
            this.Set_One.TabIndex = 0;
            this.Set_One.Text = "1";
            this.Set_One.UseVisualStyleBackColor = false;
            this.Set_One.Click += new System.EventHandler(this.Set_One_Click);
            // 
            // Set_Five
            // 
            this.Set_Five.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Set_Five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Set_Five.Location = new System.Drawing.Point(12, 109);
            this.Set_Five.Name = "Set_Five";
            this.Set_Five.Size = new System.Drawing.Size(238, 84);
            this.Set_Five.TabIndex = 1;
            this.Set_Five.Text = "5";
            this.Set_Five.UseVisualStyleBackColor = false;
            this.Set_Five.Click += new System.EventHandler(this.Set_Five_Click);
            // 
            // RateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 208);
            this.Controls.Add(this.Set_Five);
            this.Controls.Add(this.Set_One);
            this.Name = "RateForm";
            this.Text = "RateForm";
            this.Load += new System.EventHandler(this.RateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Set_One;
        private System.Windows.Forms.Button Set_Five;
    }
}