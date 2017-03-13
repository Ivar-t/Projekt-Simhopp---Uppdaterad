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
            this.buttonCancelEditContest = new System.Windows.Forms.Button();
            this.buttonEditContest = new System.Windows.Forms.Button();
            this.contestNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(273, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ange tävlingens namn som ska ändras";
            // 
            // buttonCancelEditContest
            // 
            this.buttonCancelEditContest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancelEditContest.Image = global::WindowsFormsApplication2.Properties.Resources.CancelIcon;
            this.buttonCancelEditContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelEditContest.Location = new System.Drawing.Point(553, 240);
            this.buttonCancelEditContest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelEditContest.Name = "buttonCancelEditContest";
            this.buttonCancelEditContest.Size = new System.Drawing.Size(225, 52);
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
            this.buttonEditContest.Location = new System.Drawing.Point(320, 240);
            this.buttonEditContest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditContest.Name = "buttonEditContest";
            this.buttonEditContest.Size = new System.Drawing.Size(225, 52);
            this.buttonEditContest.TabIndex = 2;
            this.buttonEditContest.Text = "Ändra";
            this.buttonEditContest.UseVisualStyleBackColor = true;
            this.buttonEditContest.Click += new System.EventHandler(this.buttonEditContest_Click);
            // 
            // contestNameComboBox
            // 
            this.contestNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestNameComboBox.FormattingEnabled = true;
            this.contestNameComboBox.Location = new System.Drawing.Point(409, 174);
            this.contestNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contestNameComboBox.Name = "contestNameComboBox";
            this.contestNameComboBox.Size = new System.Drawing.Size(240, 37);
            this.contestNameComboBox.TabIndex = 1;
            // 
            // AdminEditContest_window
            // 
            this.AcceptButton = this.buttonCancelEditContest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.contestNameComboBox);
            this.Controls.Add(this.buttonCancelEditContest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditContest);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminEditContest_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditContest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditContest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelEditContest;
        private System.Windows.Forms.ComboBox contestNameComboBox;
    }
}