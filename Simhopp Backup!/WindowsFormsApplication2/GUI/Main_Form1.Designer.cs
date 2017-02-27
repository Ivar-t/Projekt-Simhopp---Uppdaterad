namespace WindowsFormsApplication2
{
    partial class Main_Form1
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
            this.buttonLogInJudge = new System.Windows.Forms.Button();
            this.buttonLogInAdmin = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAvsluta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogInJudge
            // 
            this.buttonLogInJudge.Location = new System.Drawing.Point(40, 491);
            this.buttonLogInJudge.Name = "buttonLogInJudge";
            this.buttonLogInJudge.Size = new System.Drawing.Size(169, 42);
            this.buttonLogInJudge.TabIndex = 1;
            this.buttonLogInJudge.Text = "Domare";
            this.buttonLogInJudge.UseVisualStyleBackColor = true;
            this.buttonLogInJudge.Click += new System.EventHandler(this.buttonLogInJudge_Click);
            // 
            // buttonLogInAdmin
            // 
            this.buttonLogInAdmin.Location = new System.Drawing.Point(280, 491);
            this.buttonLogInAdmin.Name = "buttonLogInAdmin";
            this.buttonLogInAdmin.Size = new System.Drawing.Size(169, 42);
            this.buttonLogInAdmin.TabIndex = 2;
            this.buttonLogInAdmin.Text = "Administratör";
            this.buttonLogInAdmin.UseVisualStyleBackColor = true;
            this.buttonLogInAdmin.Click += new System.EventHandler(this.buttonLogInAdmin_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(715, 138);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(169, 42);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Hjälp";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.LoggaInBild;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAvsluta
            // 
            this.buttonAvsluta.Location = new System.Drawing.Point(715, 491);
            this.buttonAvsluta.Name = "buttonAvsluta";
            this.buttonAvsluta.Size = new System.Drawing.Size(169, 42);
            this.buttonAvsluta.TabIndex = 5;
            this.buttonAvsluta.Text = "Avsluta";
            this.buttonAvsluta.UseVisualStyleBackColor = true;
            this.buttonAvsluta.Click += new System.EventHandler(this.buttonAvsluta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 577);
            this.Controls.Add(this.buttonAvsluta);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonLogInAdmin);
            this.Controls.Add(this.buttonLogInJudge);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simhoppstävling - Logga In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLogInJudge;
        private System.Windows.Forms.Button buttonLogInAdmin;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAvsluta;
    }
}

