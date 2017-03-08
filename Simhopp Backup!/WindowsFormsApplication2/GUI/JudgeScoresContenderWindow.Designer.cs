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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Judgepointscombobox = new System.Windows.Forms.ComboBox();
            this.labelinfodeltagare = new System.Windows.Forms.Label();
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
            this.buttonSubmitScore.Location = new System.Drawing.Point(413, 202);
            this.buttonSubmitScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmitScore.Name = "buttonSubmitScore";
            this.buttonSubmitScore.Size = new System.Drawing.Size(256, 52);
            this.buttonSubmitScore.TabIndex = 21;
            this.buttonSubmitScore.Text = "Döm";
            this.buttonSubmitScore.UseVisualStyleBackColor = true;
            this.buttonSubmitScore.Click += new System.EventHandler(this.buttonSubmitScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nu hoppar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ange poäng du vill ge och tryck på \"Döm\"";
            // 
            // Judgepointscombobox
            // 
            this.Judgepointscombobox.FormattingEnabled = true;
            this.Judgepointscombobox.Items.AddRange(new object[] {
            "0,0",
            "0,5",
            "1,0",
            "1,5",
            "2,0",
            "2,5",
            "3,0",
            "3,5",
            "4,0",
            "4,5",
            "5,0",
            "5,5",
            "6,0",
            "6,5",
            "7,0",
            "7,5",
            "8,0",
            "8,5",
            "9,0",
            "9,5",
            "10,0"});
            this.Judgepointscombobox.Location = new System.Drawing.Point(746, 217);
            this.Judgepointscombobox.Name = "Judgepointscombobox";
            this.Judgepointscombobox.Size = new System.Drawing.Size(121, 24);
            this.Judgepointscombobox.TabIndex = 25;
            // 
            // labelinfodeltagare
            // 
            this.labelinfodeltagare.AutoSize = true;
            this.labelinfodeltagare.Location = new System.Drawing.Point(64, 180);
            this.labelinfodeltagare.Name = "labelinfodeltagare";
            this.labelinfodeltagare.Size = new System.Drawing.Size(110, 17);
            this.labelinfodeltagare.TabIndex = 26;
            this.labelinfodeltagare.Text = "Infoomdeltagare";
            // 
            // JudgeScoresContenderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.labelinfodeltagare);
            this.Controls.Add(this.Judgepointscombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmitScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JudgeScoresContenderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JudgeScoresContenderWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSubmitScore;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Judgepointscombobox;
        private System.Windows.Forms.Label labelinfodeltagare;
    }
}