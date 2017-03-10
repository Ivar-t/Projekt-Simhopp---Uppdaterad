namespace WindowsFormsApplication2
{
    partial class EraseContest_form1
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
            this.buttonCancelEraseContest = new System.Windows.Forms.Button();
            this.buttonEraseContest = new System.Windows.Forms.Button();
            this.contestNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(261, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namge tävlingens namn";
            // 
            // buttonCancelEraseContest
            // 
            this.buttonCancelEraseContest.Image = global::WindowsFormsApplication2.Properties.Resources.CancelIcon;
            this.buttonCancelEraseContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelEraseContest.Location = new System.Drawing.Point(410, 237);
            this.buttonCancelEraseContest.Name = "buttonCancelEraseContest";
            this.buttonCancelEraseContest.Size = new System.Drawing.Size(169, 42);
            this.buttonCancelEraseContest.TabIndex = 3;
            this.buttonCancelEraseContest.Text = "Avbryt";
            this.buttonCancelEraseContest.UseVisualStyleBackColor = true;
            this.buttonCancelEraseContest.Click += new System.EventHandler(this.buttonCancelEraseContest_Click);
            // 
            // buttonEraseContest
            // 
            this.buttonEraseContest.Image = global::WindowsFormsApplication2.Properties.Resources.CheckMarkIcon;
            this.buttonEraseContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEraseContest.Location = new System.Drawing.Point(211, 237);
            this.buttonEraseContest.Name = "buttonEraseContest";
            this.buttonEraseContest.Size = new System.Drawing.Size(169, 42);
            this.buttonEraseContest.TabIndex = 2;
            this.buttonEraseContest.Text = "Radera";
            this.buttonEraseContest.UseVisualStyleBackColor = true;
            this.buttonEraseContest.Click += new System.EventHandler(this.buttonEraseContest_Click);
            // 
            // contestNameComboBox
            // 
            this.contestNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestNameComboBox.FormattingEnabled = true;
            this.contestNameComboBox.Location = new System.Drawing.Point(312, 168);
            this.contestNameComboBox.Name = "contestNameComboBox";
            this.contestNameComboBox.Size = new System.Drawing.Size(170, 32);
            this.contestNameComboBox.TabIndex = 4;
            // 
            // EraseContest_form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools1;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.contestNameComboBox);
            this.Controls.Add(this.buttonCancelEraseContest);
            this.Controls.Add(this.buttonEraseContest);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EraseContest_form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EraseContestWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEraseContest;
        private System.Windows.Forms.Button buttonCancelEraseContest;
        private System.Windows.Forms.ComboBox contestNameComboBox;
    }
}