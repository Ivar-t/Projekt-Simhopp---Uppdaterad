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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contestNameTextBox = new System.Windows.Forms.TextBox();
            this.jumpheightTextBox = new System.Windows.Forms.TextBox();
            this.checkBoxwoman = new System.Windows.Forms.CheckBox();
            this.checkBoxman = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelCreateContest
            // 
            this.buttonCancelCreateContest.Image = global::WindowsFormsApplication2.Properties.Resources.CancelIcon;
            this.buttonCancelCreateContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelCreateContest.Location = new System.Drawing.Point(548, 415);
            this.buttonCancelCreateContest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelCreateContest.Name = "buttonCancelCreateContest";
            this.buttonCancelCreateContest.Size = new System.Drawing.Size(225, 52);
            this.buttonCancelCreateContest.TabIndex = 2;
            this.buttonCancelCreateContest.Text = "Avbryt";
            this.buttonCancelCreateContest.UseVisualStyleBackColor = true;
            this.buttonCancelCreateContest.Click += new System.EventHandler(this.buttonCancelCreateContest_Click);
            // 
            // buttonCreateContest
            // 
            this.buttonCreateContest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCreateContest.Image = global::WindowsFormsApplication2.Properties.Resources.CheckMarkIcon;
            this.buttonCreateContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateContest.Location = new System.Drawing.Point(196, 415);
            this.buttonCreateContest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateContest.Name = "buttonCreateContest";
            this.buttonCreateContest.Size = new System.Drawing.Size(225, 52);
            this.buttonCreateContest.TabIndex = 1;
            this.buttonCreateContest.Text = "Skapa";
            this.buttonCreateContest.UseVisualStyleBackColor = true;
            this.buttonCreateContest.Click += new System.EventHandler(this.buttonCreateContest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBoxman);
            this.groupBox1.Controls.Add(this.checkBoxwoman);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.contestNameTextBox);
            this.groupBox1.Controls.Add(this.jumpheightTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(556, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(99, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hopphöjd(m)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 151);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 3, 8, 11, 35, 7, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 32);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2017, 3, 8, 11, 35, 7, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum(xx/xx-xxxx)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(203, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Namn";
            // 
            // contestNameTextBox
            // 
            this.contestNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestNameTextBox.Location = new System.Drawing.Point(331, 80);
            this.contestNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contestNameTextBox.Multiline = true;
            this.contestNameTextBox.Name = "contestNameTextBox";
            this.contestNameTextBox.Size = new System.Drawing.Size(163, 35);
            this.contestNameTextBox.TabIndex = 0;
            this.contestNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contestNameTextBox_KeyDown);
            // 
            // jumpheightTextBox
            // 
            this.jumpheightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumpheightTextBox.Location = new System.Drawing.Point(331, 271);
            this.jumpheightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jumpheightTextBox.Multiline = true;
            this.jumpheightTextBox.Name = "jumpheightTextBox";
            this.jumpheightTextBox.Size = new System.Drawing.Size(163, 35);
            this.jumpheightTextBox.TabIndex = 3;
            // 
            // checkBoxwoman
            // 
            this.checkBoxwoman.AutoSize = true;
            this.checkBoxwoman.Location = new System.Drawing.Point(331, 205);
            this.checkBoxwoman.Name = "checkBoxwoman";
            this.checkBoxwoman.Size = new System.Drawing.Size(73, 21);
            this.checkBoxwoman.TabIndex = 8;
            this.checkBoxwoman.Text = "Kvinna";
            this.checkBoxwoman.UseVisualStyleBackColor = true;
            this.checkBoxwoman.Click += new System.EventHandler(this.checkBoxwoman_Click);
            // 
            // checkBoxman
            // 
            this.checkBoxman.AutoSize = true;
            this.checkBoxman.Location = new System.Drawing.Point(331, 232);
            this.checkBoxman.Name = "checkBoxman";
            this.checkBoxman.Size = new System.Drawing.Size(57, 21);
            this.checkBoxman.TabIndex = 9;
            this.checkBoxman.Text = "Man";
            this.checkBoxman.UseVisualStyleBackColor = true;
            this.checkBoxman.Click += new System.EventHandler(this.checkBoxman_Click);
            // 
            // AdminCreateContest_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelCreateContest);
            this.Controls.Add(this.buttonCreateContest);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contestNameTextBox;
        private System.Windows.Forms.TextBox jumpheightTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxman;
        private System.Windows.Forms.CheckBox checkBoxwoman;
    }
}