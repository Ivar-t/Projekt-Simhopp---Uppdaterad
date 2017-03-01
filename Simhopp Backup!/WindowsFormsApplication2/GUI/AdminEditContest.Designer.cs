namespace WindowsFormsApplication2
{
    partial class AdminEditContest_window
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCancelEditContest = new System.Windows.Forms.Button();
            this.buttonEditContest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(205, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ange tävlingens namn som ska ändras";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 29);
            this.textBox1.TabIndex = 2;
            // 
            // buttonCancelEditContest
            // 
            this.buttonCancelEditContest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancelEditContest.Image = global::WindowsFormsApplication2.Properties.Resources.CancelIcon;
            this.buttonCancelEditContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelEditContest.Location = new System.Drawing.Point(415, 195);
            this.buttonCancelEditContest.Name = "buttonCancelEditContest";
            this.buttonCancelEditContest.Size = new System.Drawing.Size(169, 42);
            this.buttonCancelEditContest.TabIndex = 3;
            this.buttonCancelEditContest.Text = "Avbryt";
            this.buttonCancelEditContest.UseVisualStyleBackColor = true;
            this.buttonCancelEditContest.Click += new System.EventHandler(this.buttonCancelEditContest_Click);
            // 
            // buttonEditContest
            // 
            this.buttonEditContest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditContest.Image = global::WindowsFormsApplication2.Properties.Resources.CheckMarkIcon;
            this.buttonEditContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditContest.Location = new System.Drawing.Point(240, 195);
            this.buttonEditContest.Name = "buttonEditContest";
            this.buttonEditContest.Size = new System.Drawing.Size(169, 42);
            this.buttonEditContest.TabIndex = 0;
            this.buttonEditContest.Text = "Ändra";
            this.buttonEditContest.UseVisualStyleBackColor = true;
            this.buttonEditContest.Click += new System.EventHandler(this.buttonEditContest_Click);
            // 
            // AdminEditContest_window
            // 
            this.AcceptButton = this.buttonCancelEditContest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.buttonCancelEditContest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditContest);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminEditContest_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditContest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditContest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCancelEditContest;
    }
}