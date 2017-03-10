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
            this.labelinfodeltagare = new System.Windows.Forms.Label();
            this.labelshowpoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.buttonSubmitScore.Image = global::WindowsFormsApplication2.Properties.Resources.SubmitJudgeScore;
            this.buttonSubmitScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmitScore.Location = new System.Drawing.Point(631, 338);
            this.buttonSubmitScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmitScore.Name = "buttonSubmitScore";
            this.buttonSubmitScore.Size = new System.Drawing.Size(256, 52);
            this.buttonSubmitScore.TabIndex = 21;
            this.buttonSubmitScore.Text = "Döm";
            this.buttonSubmitScore.UseVisualStyleBackColor = true;
            this.buttonSubmitScore.Click += new System.EventHandler(this.buttonSubmitScore_Click);
            // 
            // judgepointstrackbar
            // 
            this.judgepointstrackbar.BackColor = System.Drawing.Color.DarkBlue;
            this.judgepointstrackbar.Location = new System.Drawing.Point(529, 255);
            this.judgepointstrackbar.Margin = new System.Windows.Forms.Padding(4);
            this.judgepointstrackbar.Name = "judgepointstrackbar";
            this.judgepointstrackbar.Size = new System.Drawing.Size(444, 56);
            this.judgepointstrackbar.TabIndex = 23;
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
            // labelinfodeltagare
            // 
            this.labelinfodeltagare.AutoSize = true;
            this.labelinfodeltagare.BackColor = System.Drawing.Color.Transparent;
            this.labelinfodeltagare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfodeltagare.Location = new System.Drawing.Point(97, 311);
            this.labelinfodeltagare.Name = "labelinfodeltagare";
            this.labelinfodeltagare.Size = new System.Drawing.Size(145, 24);
            this.labelinfodeltagare.TabIndex = 26;
            this.labelinfodeltagare.Text = "infoomdeltagare";
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
            this.label3.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Namn,    Nationalitet,    Hopp";
            // 
            // JudgeScoresContenderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelshowpoint);
            this.Controls.Add(this.labelinfodeltagare);
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
        private System.Windows.Forms.Label labelinfodeltagare;
        private System.Windows.Forms.Label labelshowpoint;
        private System.Windows.Forms.Label label3;
    }
}