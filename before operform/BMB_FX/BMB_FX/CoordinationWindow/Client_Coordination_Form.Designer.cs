namespace BMB_FX.CoordinationWindow
{
    partial class Client_Coordination_Form
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
            this.dataGridView_BMB1 = new BMB_FX.DataGridView_BMB();
            this.Add_But = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BMB1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_BMB1
            // 
            this.dataGridView_BMB1.AllowUserToAddRows = false;
            this.dataGridView_BMB1.AllowUserToDeleteRows = false;
            this.dataGridView_BMB1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_BMB1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BMB1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_BMB1.Name = "dataGridView_BMB1";
            this.dataGridView_BMB1.ReadOnly = true;
            this.dataGridView_BMB1.RowTemplate.Height = 24;
            this.dataGridView_BMB1.Size = new System.Drawing.Size(1370, 324);
            this.dataGridView_BMB1.TabIndex = 0;
            // 
            // Add_But
            // 
            this.Add_But.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Add_But.Location = new System.Drawing.Point(12, 342);
            this.Add_But.Name = "Add_But";
            this.Add_But.Size = new System.Drawing.Size(75, 23);
            this.Add_But.TabIndex = 1;
            this.Add_But.Text = "Add";
            this.Add_But.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(93, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Client_Coordination_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add_But);
            this.Controls.Add(this.dataGridView_BMB1);
            this.Name = "Client_Coordination_Form";
            this.Text = "Client_Coordination_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BMB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView_BMB dataGridView_BMB1;
        private System.Windows.Forms.Button Add_But;
        private System.Windows.Forms.Button button2;
    }
}