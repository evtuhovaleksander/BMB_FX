namespace BMB_FX.CoordinationWindow
{
    partial class Coordination_Form
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
            this.Client_Panel = new System.Windows.Forms.Panel();
            this.Request_Panel = new System.Windows.Forms.Panel();
            this.Client_But = new System.Windows.Forms.Button();
            this.Request_But = new System.Windows.Forms.Button();
            this.Window_Panel = new System.Windows.Forms.Panel();
            this.Window_But = new System.Windows.Forms.Button();
            this.Client_Panel.SuspendLayout();
            this.Request_Panel.SuspendLayout();
            this.Window_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client_Panel
            // 
            this.Client_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Client_Panel.Controls.Add(this.Client_But);
            this.Client_Panel.Location = new System.Drawing.Point(0, 0);
            this.Client_Panel.Name = "Client_Panel";
            this.Client_Panel.Size = new System.Drawing.Size(1900, 30);
            this.Client_Panel.TabIndex = 0;
            // 
            // Request_Panel
            // 
            this.Request_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Request_Panel.Controls.Add(this.Request_But);
            this.Request_Panel.Location = new System.Drawing.Point(0, 32);
            this.Request_Panel.Name = "Request_Panel";
            this.Request_Panel.Size = new System.Drawing.Size(1900, 28);
            this.Request_Panel.TabIndex = 1;
            // 
            // Client_But
            // 
            this.Client_But.Location = new System.Drawing.Point(1820, 0);
            this.Client_But.Name = "Client_But";
            this.Client_But.Size = new System.Drawing.Size(80, 30);
            this.Client_But.TabIndex = 2;
            this.Client_But.Text = "button1";
            this.Client_But.UseVisualStyleBackColor = true;
            this.Client_But.Click += new System.EventHandler(this.Client_But_Click);
            // 
            // Request_But
            // 
            this.Request_But.Location = new System.Drawing.Point(1820, 0);
            this.Request_But.Name = "Request_But";
            this.Request_But.Size = new System.Drawing.Size(80, 30);
            this.Request_But.TabIndex = 3;
            this.Request_But.Text = "button2";
            this.Request_But.UseVisualStyleBackColor = true;
            this.Request_But.Click += new System.EventHandler(this.Request_But_Click);
            // 
            // Window_Panel
            // 
            this.Window_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Window_Panel.Controls.Add(this.Window_But);
            this.Window_Panel.Location = new System.Drawing.Point(0, 66);
            this.Window_Panel.Name = "Window_Panel";
            this.Window_Panel.Size = new System.Drawing.Size(1900, 28);
            this.Window_Panel.TabIndex = 4;
            // 
            // Window_But
            // 
            this.Window_But.Location = new System.Drawing.Point(1820, -1);
            this.Window_But.Name = "Window_But";
            this.Window_But.Size = new System.Drawing.Size(80, 30);
            this.Window_But.TabIndex = 3;
            this.Window_But.Text = "button3";
            this.Window_But.UseVisualStyleBackColor = true;
            this.Window_But.Click += new System.EventHandler(this.Window_But_Click);
            // 
            // Coordination_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.Window_Panel);
            this.Controls.Add(this.Request_Panel);
            this.Controls.Add(this.Client_Panel);
            this.Name = "Coordination_Form";
            this.Text = "Coordination_Form";
            this.Load += new System.EventHandler(this.Coordination_Form_Load);
            this.Client_Panel.ResumeLayout(false);
            this.Request_Panel.ResumeLayout(false);
            this.Window_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel Client_Panel;
        private System.Windows.Forms.Panel Request_Panel;
        private System.Windows.Forms.Button Client_But;
        private System.Windows.Forms.Button Request_But;
        private System.Windows.Forms.Panel Window_Panel;
        private System.Windows.Forms.Button Window_But;
    }
}