namespace WindowsFormsApplication2
{
    partial class AdminMeny_window
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
            this.buttonAdminLoggaUt = new System.Windows.Forms.Button();
            this.buttonEditContest = new System.Windows.Forms.Button();
            this.buttonSearchContest = new System.Windows.Forms.Button();
            this.buttonEraseContestW = new System.Windows.Forms.Button();
            this.buttonCreateContest = new System.Windows.Forms.Button();
            this.admin_picture_box = new System.Windows.Forms.PictureBox();
            this.Backgroundpicture_adminmeny = new System.Windows.Forms.PictureBox();
            this.buttonStartContest = new System.Windows.Forms.Button();
            this.contestComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.admin_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backgroundpicture_adminmeny)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdminLoggaUt
            // 
            this.buttonAdminLoggaUt.Location = new System.Drawing.Point(622, 387);
            this.buttonAdminLoggaUt.Name = "buttonAdminLoggaUt";
            this.buttonAdminLoggaUt.Size = new System.Drawing.Size(150, 40);
            this.buttonAdminLoggaUt.TabIndex = 1;
            this.buttonAdminLoggaUt.Text = "Logga ut";
            this.buttonAdminLoggaUt.UseVisualStyleBackColor = true;
            this.buttonAdminLoggaUt.Click += new System.EventHandler(this.buttonAdminLoggaUt_Click);
            // 
            // buttonEditContest
            // 
            this.buttonEditContest.Location = new System.Drawing.Point(471, 387);
            this.buttonEditContest.Name = "buttonEditContest";
            this.buttonEditContest.Size = new System.Drawing.Size(145, 40);
            this.buttonEditContest.TabIndex = 2;
            this.buttonEditContest.Text = "Redigera tävling";
            this.buttonEditContest.UseVisualStyleBackColor = true;
            this.buttonEditContest.Click += new System.EventHandler(this.buttonEditContest_Click);
            // 
            // buttonSearchContest
            // 
            this.buttonSearchContest.Location = new System.Drawing.Point(314, 387);
            this.buttonSearchContest.Name = "buttonSearchContest";
            this.buttonSearchContest.Size = new System.Drawing.Size(145, 40);
            this.buttonSearchContest.TabIndex = 3;
            this.buttonSearchContest.Text = "Sök";
            this.buttonSearchContest.UseVisualStyleBackColor = true;
            this.buttonSearchContest.Click += new System.EventHandler(this.buttonSearchContest_Click);
            // 
            // buttonEraseContestW
            // 
            this.buttonEraseContestW.Location = new System.Drawing.Point(163, 387);
            this.buttonEraseContestW.Name = "buttonEraseContestW";
            this.buttonEraseContestW.Size = new System.Drawing.Size(145, 40);
            this.buttonEraseContestW.TabIndex = 4;
            this.buttonEraseContestW.Text = "Ta bort tävling";
            this.buttonEraseContestW.UseVisualStyleBackColor = true;
            this.buttonEraseContestW.Click += new System.EventHandler(this.buttonEraseContestW_Click);
            // 
            // buttonCreateContest
            // 
            this.buttonCreateContest.Location = new System.Drawing.Point(12, 387);
            this.buttonCreateContest.Name = "buttonCreateContest";
            this.buttonCreateContest.Size = new System.Drawing.Size(145, 40);
            this.buttonCreateContest.TabIndex = 5;
            this.buttonCreateContest.Text = "Skapa ny tävling";
            this.buttonCreateContest.UseVisualStyleBackColor = true;
            this.buttonCreateContest.Click += new System.EventHandler(this.buttonCreateContest_Click);
            // 
            // admin_picture_box
            // 
            this.admin_picture_box.BackColor = System.Drawing.Color.Transparent;
            this.admin_picture_box.Image = global::WindowsFormsApplication2.Properties.Resources.admin_icon;
            this.admin_picture_box.Location = new System.Drawing.Point(627, 12);
            this.admin_picture_box.Name = "admin_picture_box";
            this.admin_picture_box.Size = new System.Drawing.Size(145, 145);
            this.admin_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admin_picture_box.TabIndex = 8;
            this.admin_picture_box.TabStop = false;
            // 
            // Backgroundpicture_adminmeny
            // 
            this.Backgroundpicture_adminmeny.Image = global::WindowsFormsApplication2.Properties.Resources.swimming_pool_icon_png_3___kopia2;
            this.Backgroundpicture_adminmeny.Location = new System.Drawing.Point(2, 0);
            this.Backgroundpicture_adminmeny.Name = "Backgroundpicture_adminmeny";
            this.Backgroundpicture_adminmeny.Size = new System.Drawing.Size(787, 444);
            this.Backgroundpicture_adminmeny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Backgroundpicture_adminmeny.TabIndex = 9;
            this.Backgroundpicture_adminmeny.TabStop = false;
            this.Backgroundpicture_adminmeny.Click += new System.EventHandler(this.Backgroundpicture_adminmeny_Click);
            // 
            // buttonStartContest
            // 
            this.buttonStartContest.Location = new System.Drawing.Point(314, 23);
            this.buttonStartContest.Name = "buttonStartContest";
            this.buttonStartContest.Size = new System.Drawing.Size(145, 40);
            this.buttonStartContest.TabIndex = 10;
            this.buttonStartContest.Text = "Starta tävling";
            this.buttonStartContest.UseVisualStyleBackColor = true;
            this.buttonStartContest.Click += new System.EventHandler(this.buttonStartContest_Click);
            // 
            // contestComboBox
            // 
            this.contestComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestComboBox.FormattingEnabled = true;
            this.contestComboBox.Location = new System.Drawing.Point(314, 83);
            this.contestComboBox.Name = "contestComboBox";
            this.contestComboBox.Size = new System.Drawing.Size(145, 32);
            this.contestComboBox.TabIndex = 11;
            // 
            // AdminMeny_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.contestComboBox);
            this.Controls.Add(this.buttonStartContest);
            this.Controls.Add(this.admin_picture_box);
            this.Controls.Add(this.buttonCreateContest);
            this.Controls.Add(this.buttonEraseContestW);
            this.Controls.Add(this.buttonSearchContest);
            this.Controls.Add(this.buttonEditContest);
            this.Controls.Add(this.buttonAdminLoggaUt);
            this.Controls.Add(this.Backgroundpicture_adminmeny);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminMeny_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meny - Administratör";
            ((System.ComponentModel.ISupportInitialize)(this.admin_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backgroundpicture_adminmeny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdminLoggaUt;
        private System.Windows.Forms.Button buttonEditContest;
        private System.Windows.Forms.Button buttonSearchContest;
        private System.Windows.Forms.Button buttonEraseContestW;
        private System.Windows.Forms.Button buttonCreateContest;
        private System.Windows.Forms.PictureBox admin_picture_box;
        private System.Windows.Forms.PictureBox Backgroundpicture_adminmeny;
        private System.Windows.Forms.Button buttonStartContest;
        private System.Windows.Forms.ComboBox contestComboBox;
    }
}