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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(387, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tävlingens Namn!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCancelEraseContest
            // 
            this.buttonCancelEraseContest.Image = global::WindowsFormsApplication2.Properties.Resources.CancelIcon;
            this.buttonCancelEraseContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelEraseContest.Location = new System.Drawing.Point(547, 292);
            this.buttonCancelEraseContest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelEraseContest.Name = "buttonCancelEraseContest";
            this.buttonCancelEraseContest.Size = new System.Drawing.Size(225, 52);
            this.buttonCancelEraseContest.TabIndex = 3;
            this.buttonCancelEraseContest.Text = "Avbryt";
            this.buttonCancelEraseContest.UseVisualStyleBackColor = true;
            this.buttonCancelEraseContest.Click += new System.EventHandler(this.buttonCancelEraseContest_Click);
            // 
            // buttonEraseContest
            // 
            this.buttonEraseContest.Image = global::WindowsFormsApplication2.Properties.Resources.CheckMarkIcon;
            this.buttonEraseContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEraseContest.Location = new System.Drawing.Point(281, 292);
            this.buttonEraseContest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEraseContest.Name = "buttonEraseContest";
            this.buttonEraseContest.Size = new System.Drawing.Size(225, 52);
            this.buttonEraseContest.TabIndex = 2;
            this.buttonEraseContest.Text = "Radera";
            this.buttonEraseContest.UseVisualStyleBackColor = true;
            this.buttonEraseContest.Click += new System.EventHandler(this.buttonEraseContest_Click);
            // 
            // contestNameComboBox
            // 
            this.contestNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestNameComboBox.FormattingEnabled = true;
            this.contestNameComboBox.Location = new System.Drawing.Point(416, 207);
            this.contestNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contestNameComboBox.Name = "contestNameComboBox";
            this.contestNameComboBox.Size = new System.Drawing.Size(225, 37);
            this.contestNameComboBox.TabIndex = 1;
            // 
            // EraseContest_form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools1;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.contestNameComboBox);
            this.Controls.Add(this.buttonCancelEraseContest);
            this.Controls.Add(this.buttonEraseContest);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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