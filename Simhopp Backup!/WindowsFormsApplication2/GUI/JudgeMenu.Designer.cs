namespace WindowsFormsApplication2
{
    partial class JudgeMenu
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
            this.Judge_Log_Out_button = new System.Windows.Forms.Button();
            this.Judge_Contest_button = new System.Windows.Forms.Button();
            this.tävling_text_lable1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundpicture_jugdemeny = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundpicture_jugdemeny)).BeginInit();
            this.SuspendLayout();
            // 
            // Judge_Log_Out_button
            // 
            this.Judge_Log_Out_button.Location = new System.Drawing.Point(412, 315);
            this.Judge_Log_Out_button.Margin = new System.Windows.Forms.Padding(4);
            this.Judge_Log_Out_button.Name = "Judge_Log_Out_button";
            this.Judge_Log_Out_button.Size = new System.Drawing.Size(225, 52);
            this.Judge_Log_Out_button.TabIndex = 2;
            this.Judge_Log_Out_button.Text = "Logga Ut";
            this.Judge_Log_Out_button.UseVisualStyleBackColor = true;
            this.Judge_Log_Out_button.Click += new System.EventHandler(this.buttonJudgeLogOut_Click);
            // 
            // Judge_Contest_button
            // 
            this.Judge_Contest_button.Location = new System.Drawing.Point(412, 240);
            this.Judge_Contest_button.Margin = new System.Windows.Forms.Padding(4);
            this.Judge_Contest_button.Name = "Judge_Contest_button";
            this.Judge_Contest_button.Size = new System.Drawing.Size(225, 52);
            this.Judge_Contest_button.TabIndex = 1;
            this.Judge_Contest_button.Text = "Döm Tävling";
            this.Judge_Contest_button.UseVisualStyleBackColor = true;
            this.Judge_Contest_button.Click += new System.EventHandler(this.buttonJudgeContest_Click);
            // 
            // tävling_text_lable1
            // 
            this.tävling_text_lable1.AutoSize = true;
            this.tävling_text_lable1.Font = new System.Drawing.Font("Baskerville Old Face", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tävling_text_lable1.Location = new System.Drawing.Point(404, 105);
            this.tävling_text_lable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tävling_text_lable1.Name = "tävling_text_lable1";
            this.tävling_text_lable1.Size = new System.Drawing.Size(218, 45);
            this.tävling_text_lable1.TabIndex = 5;
            this.tävling_text_lable1.Text = "Tävlings ID";
            this.tävling_text_lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tävling_text_lable1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Judge_icon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundpicture_jugdemeny
            // 
            this.backgroundpicture_jugdemeny.Image = global::WindowsFormsApplication2.Properties.Resources.swimming_pool_icon_png_33;
            this.backgroundpicture_jugdemeny.Location = new System.Drawing.Point(-3, 0);
            this.backgroundpicture_jugdemeny.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundpicture_jugdemeny.Name = "backgroundpicture_jugdemeny";
            this.backgroundpicture_jugdemeny.Size = new System.Drawing.Size(1053, 542);
            this.backgroundpicture_jugdemeny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundpicture_jugdemeny.TabIndex = 14;
            this.backgroundpicture_jugdemeny.TabStop = false;
            // 
            // JudgeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tävling_text_lable1);
            this.Controls.Add(this.Judge_Contest_button);
            this.Controls.Add(this.Judge_Log_Out_button);
            this.Controls.Add(this.backgroundpicture_jugdemeny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JudgeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meny - Domare";
            this.Load += new System.EventHandler(this.JudgeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundpicture_jugdemeny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Judge_Log_Out_button;
        private System.Windows.Forms.Button Judge_Contest_button;
        private System.Windows.Forms.Label tävling_text_lable1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox backgroundpicture_jugdemeny;
    }
}