namespace WindowsFormsApplication2
{
    partial class AdminCreateContest_window
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
            this.buttonCancelCreateContest = new System.Windows.Forms.Button();
            this.buttonCreateContest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contestNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.jumpheightTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelCreateContest
            // 
            this.buttonCancelCreateContest.Image = global::WindowsFormsApplication2.Properties.Resources.CancelIcon;
            this.buttonCancelCreateContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelCreateContest.Location = new System.Drawing.Point(411, 337);
            this.buttonCancelCreateContest.Name = "buttonCancelCreateContest";
            this.buttonCancelCreateContest.Size = new System.Drawing.Size(169, 42);
            this.buttonCancelCreateContest.TabIndex = 1;
            this.buttonCancelCreateContest.Text = "Avbryt";
            this.buttonCancelCreateContest.UseVisualStyleBackColor = true;
            this.buttonCancelCreateContest.Click += new System.EventHandler(this.buttonCancelCreateContest_Click);
            // 
            // buttonCreateContest
            // 
            this.buttonCreateContest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCreateContest.Image = global::WindowsFormsApplication2.Properties.Resources.CheckMarkIcon;
            this.buttonCreateContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateContest.Location = new System.Drawing.Point(147, 337);
            this.buttonCreateContest.Name = "buttonCreateContest";
            this.buttonCreateContest.Size = new System.Drawing.Size(169, 42);
            this.buttonCreateContest.TabIndex = 0;
            this.buttonCreateContest.Text = "Skapa";
            this.buttonCreateContest.UseVisualStyleBackColor = true;
            this.buttonCreateContest.Click += new System.EventHandler(this.buttonCreateContest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.contestNameTextBox);
            this.groupBox1.Controls.Add(this.dateTextBox);
            this.groupBox1.Controls.Add(this.genderTextBox);
            this.groupBox1.Controls.Add(this.jumpheightTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(74, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hopphöjd(m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(26, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Man/Dam-Tävling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum(xx/xx-xxxx)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(152, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Namn";
            // 
            // contestNameTextBox
            // 
            this.contestNameTextBox.Location = new System.Drawing.Point(248, 65);
            this.contestNameTextBox.Multiline = true;
            this.contestNameTextBox.Name = "contestNameTextBox";
            this.contestNameTextBox.Size = new System.Drawing.Size(123, 29);
            this.contestNameTextBox.TabIndex = 3;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(248, 117);
            this.dateTextBox.Multiline = true;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(123, 29);
            this.dateTextBox.TabIndex = 2;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(248, 168);
            this.genderTextBox.Multiline = true;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(123, 29);
            this.genderTextBox.TabIndex = 1;
            // 
            // jumpheightTextBox
            // 
            this.jumpheightTextBox.Location = new System.Drawing.Point(248, 220);
            this.jumpheightTextBox.Multiline = true;
            this.jumpheightTextBox.Name = "jumpheightTextBox";
            this.jumpheightTextBox.Size = new System.Drawing.Size(123, 29);
            this.jumpheightTextBox.TabIndex = 0;
            // 
            // AdminCreateContest_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelCreateContest);
            this.Controls.Add(this.buttonCreateContest);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminCreateContest_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkapaTävling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateContest;
        private System.Windows.Forms.Button buttonCancelCreateContest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contestNameTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox jumpheightTextBox;
    }
}