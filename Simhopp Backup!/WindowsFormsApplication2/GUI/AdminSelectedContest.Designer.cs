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
            this.contestInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone.Location = new System.Drawing.Point(413, 476);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(225, 52);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Klar";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // contestInfoTextBox
            // 
            this.contestInfoTextBox.Location = new System.Drawing.Point(119, 15);
            this.contestInfoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contestInfoTextBox.Name = "contestInfoTextBox";
            this.contestInfoTextBox.Size = new System.Drawing.Size(797, 416);
            this.contestInfoTextBox.TabIndex = 1;
            this.contestInfoTextBox.Text = "";
            // 
            // AdminSelectedContest_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.contestInfoTextBox);
            this.Controls.Add(this.buttonDone);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminSelectedContest_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vald tävling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.RichTextBox contestInfoTextBox;
    }
}