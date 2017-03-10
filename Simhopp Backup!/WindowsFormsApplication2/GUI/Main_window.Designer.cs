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
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonAvsluta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omDiving1000BCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.divin_logo = new System.Windows.Forms.PictureBox();
            this.judge_picture_box = new System.Windows.Forms.PictureBox();
            this.admin_picture_box = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxJudge = new System.Windows.Forms.CheckBox();
            this.checkBoxAdm = new System.Windows.Forms.CheckBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divin_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judge_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(12, 362);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(139, 53);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Hjälp";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonAvsluta
            // 
            this.buttonAvsluta.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvsluta.Location = new System.Drawing.Point(633, 364);
            this.buttonAvsluta.Name = "buttonAvsluta";
            this.buttonAvsluta.Size = new System.Drawing.Size(139, 51);
            this.buttonAvsluta.TabIndex = 5;
            this.buttonAvsluta.Text = "Avsluta";
            this.buttonAvsluta.UseVisualStyleBackColor = true;
            this.buttonAvsluta.Click += new System.EventHandler(this.buttonAvsluta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hjälpToolStripMenuItem,
            this.avslutaToolStripMenuItem,
            this.omDiving1000BCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.hjälpToolStripMenuItem.Text = "Hjälp";
            this.hjälpToolStripMenuItem.Click += new System.EventHandler(this.hjälpToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // omDiving1000BCToolStripMenuItem
            // 
            this.omDiving1000BCToolStripMenuItem.Name = "omDiving1000BCToolStripMenuItem";
            this.omDiving1000BCToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.omDiving1000BCToolStripMenuItem.Text = "Om Diving 1000BC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.c724df86_834f_4035_b852_f0c5e3a3411a1;
            this.pictureBox1.Location = new System.Drawing.Point(242, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // divin_logo
            // 
            this.divin_logo.BackColor = System.Drawing.Color.Transparent;
            this.divin_logo.Image = global::WindowsFormsApplication2.Properties.Resources._2000px_Diving_pictogram4;
            this.divin_logo.Location = new System.Drawing.Point(357, 11);
            this.divin_logo.Margin = new System.Windows.Forms.Padding(2);
            this.divin_logo.Name = "divin_logo";
            this.divin_logo.Size = new System.Drawing.Size(78, 110);
            this.divin_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.divin_logo.TabIndex = 11;
            this.divin_logo.TabStop = false;
            // 
            // judge_picture_box
            // 
            this.judge_picture_box.BackColor = System.Drawing.Color.Transparent;
            this.judge_picture_box.Image = global::WindowsFormsApplication2.Properties.Resources.Judge_icon;
            this.judge_picture_box.Location = new System.Drawing.Point(12, 76);
            this.judge_picture_box.Name = "judge_picture_box";
            this.judge_picture_box.Size = new System.Drawing.Size(170, 170);
            this.judge_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.judge_picture_box.TabIndex = 8;
            this.judge_picture_box.TabStop = false;
            // 
            // admin_picture_box
            // 
            this.admin_picture_box.BackColor = System.Drawing.Color.Transparent;
            this.admin_picture_box.Image = global::WindowsFormsApplication2.Properties.Resources.admin_icon;
            this.admin_picture_box.Location = new System.Drawing.Point(602, 76);
            this.admin_picture_box.Name = "admin_picture_box";
            this.admin_picture_box.Size = new System.Drawing.Size(170, 170);
            this.admin_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admin_picture_box.TabIndex = 7;
            this.admin_picture_box.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(430, 306);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 29);
            this.PasswordTextBox.TabIndex = 13;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(430, 268);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 29);
            this.UsernameTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Användarnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lösenord:";
            // 
            // checkBoxJudge
            // 
            this.checkBoxJudge.AutoSize = true;
            this.checkBoxJudge.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxJudge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJudge.Location = new System.Drawing.Point(430, 362);
            this.checkBoxJudge.Name = "checkBoxJudge";
            this.checkBoxJudge.Size = new System.Drawing.Size(85, 24);
            this.checkBoxJudge.TabIndex = 17;
            this.checkBoxJudge.Text = "Domare";
            this.checkBoxJudge.UseVisualStyleBackColor = false;
            this.checkBoxJudge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxJudge_MouseClick);
            // 
            // checkBoxAdm
            // 
            this.checkBoxAdm.AutoSize = true;
            this.checkBoxAdm.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdm.Location = new System.Drawing.Point(430, 390);
            this.checkBoxAdm.Name = "checkBoxAdm";
            this.checkBoxAdm.Size = new System.Drawing.Size(122, 24);
            this.checkBoxAdm.TabIndex = 18;
            this.checkBoxAdm.Text = "Administratör";
            this.checkBoxAdm.UseVisualStyleBackColor = false;
            this.checkBoxAdm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxAdm_MouseClick);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(282, 363);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(139, 53);
            this.buttonLogIn.TabIndex = 19;
            this.buttonLogIn.Text = "Logga in";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click_1);
            // 
            // Main_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.checkBoxAdm);
            this.Controls.Add(this.checkBoxJudge);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.judge_picture_box);
            this.Controls.Add(this.admin_picture_box);
            this.Controls.Add(this.buttonAvsluta);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.divin_logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simhoppstävling - Logga In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divin_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judge_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonAvsluta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox admin_picture_box;
        private System.Windows.Forms.PictureBox judge_picture_box;
        private System.Windows.Forms.PictureBox divin_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omDiving1000BCToolStripMenuItem;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxJudge;
        private System.Windows.Forms.CheckBox checkBoxAdm;
        private System.Windows.Forms.Button buttonLogIn;
    }
}

