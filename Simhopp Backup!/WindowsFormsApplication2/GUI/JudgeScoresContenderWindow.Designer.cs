namespace WindowsFormsApplication2
{
    partial class JudgeScoresContenderWindow
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmitScore = new System.Windows.Forms.Button();
            this.judgepointstrackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNamn = new System.Windows.Forms.Label();
            this.labelshowpoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHoppnr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNation = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelHoppNamn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.judgepointstrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::WindowsFormsApplication2.Properties.Resources.CancelIcon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(523, 619);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(256, 52);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Avbryt";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmitScore
            // 
            this.buttonSubmitScore.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitScore.Image = global::WindowsFormsApplication2.Properties.Resources.SubmitJudgeScore;
            this.buttonSubmitScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmitScore.Location = new System.Drawing.Point(611, 341);
            this.buttonSubmitScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmitScore.Name = "buttonSubmitScore";
            this.buttonSubmitScore.Size = new System.Drawing.Size(254, 100);
            this.buttonSubmitScore.TabIndex = 2;
            this.buttonSubmitScore.Text = "    Döm";
            this.buttonSubmitScore.UseVisualStyleBackColor = true;
            this.buttonSubmitScore.Click += new System.EventHandler(this.buttonSubmitScore_Click);
            // 
            // judgepointstrackbar
            // 
            this.judgepointstrackbar.BackColor = System.Drawing.Color.MediumBlue;
            this.judgepointstrackbar.Location = new System.Drawing.Point(523, 245);
            this.judgepointstrackbar.Margin = new System.Windows.Forms.Padding(4);
            this.judgepointstrackbar.Name = "judgepointstrackbar";
            this.judgepointstrackbar.Size = new System.Drawing.Size(444, 56);
            this.judgepointstrackbar.TabIndex = 1;
            this.judgepointstrackbar.Scroll += new System.EventHandler(this.judgepointstrackbar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ange poäng och klicka sedan på \"döm\" för att ge poäng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nu hoppar";
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.BackColor = System.Drawing.Color.Transparent;
            this.labelNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamn.Location = new System.Drawing.Point(142, 279);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(64, 25);
            this.labelNamn.TabIndex = 26;
            this.labelNamn.Text = "Namn";
            // 
            // labelshowpoint
            // 
            this.labelshowpoint.AutoSize = true;
            this.labelshowpoint.Font = new System.Drawing.Font("Rockwell Extra Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshowpoint.Location = new System.Drawing.Point(695, 171);
            this.labelshowpoint.Name = "labelshowpoint";
            this.labelshowpoint.Size = new System.Drawing.Size(119, 32);
            this.labelshowpoint.TabIndex = 27;
            this.labelshowpoint.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Namn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(108, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hoppnummer";
            // 
            // labelHoppnr
            // 
            this.labelHoppnr.AutoSize = true;
            this.labelHoppnr.BackColor = System.Drawing.Color.Transparent;
            this.labelHoppnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoppnr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHoppnr.Location = new System.Drawing.Point(234, 151);
            this.labelHoppnr.Name = "labelHoppnr";
            this.labelHoppnr.Size = new System.Drawing.Size(76, 25);
            this.labelHoppnr.TabIndex = 30;
            this.labelHoppnr.Text = "Hoppnr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nationalitet";
            // 
            // labelNation
            // 
            this.labelNation.AutoSize = true;
            this.labelNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNation.Location = new System.Drawing.Point(143, 328);
            this.labelNation.Name = "labelNation";
            this.labelNation.Size = new System.Drawing.Size(68, 25);
            this.labelNation.TabIndex = 32;
            this.labelNation.Text = "Nation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 26);
            this.label8.TabIndex = 33;
            this.label8.Text = "Hopp";
            // 
            // labelHoppNamn
            // 
            this.labelHoppNamn.AutoSize = true;
            this.labelHoppNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoppNamn.Location = new System.Drawing.Point(146, 370);
            this.labelHoppNamn.Name = "labelHoppNamn";
            this.labelHoppNamn.Size = new System.Drawing.Size(59, 25);
            this.labelHoppNamn.TabIndex = 34;
            this.labelHoppNamn.Text = "Hopp";
            // 
            // JudgeScoresContenderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.labelHoppNamn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelNation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelHoppnr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelshowpoint);
            this.Controls.Add(this.labelNamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.judgepointstrackbar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmitScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JudgeScoresContenderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JudgeScoresContenderWindow";
            ((System.ComponentModel.ISupportInitialize)(this.judgepointstrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSubmitScore;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TrackBar judgepointstrackbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label labelshowpoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHoppnr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelHoppNamn;
    }
}