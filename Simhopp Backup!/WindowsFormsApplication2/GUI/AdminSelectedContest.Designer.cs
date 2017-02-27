namespace WindowsFormsApplication2
{
    partial class AdminSelectedContest_window
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
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone.Location = new System.Drawing.Point(310, 387);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(169, 42);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Klar";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // AdminSelectedContest_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.buttonDone);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminSelectedContest_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vald tävling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
    }
}