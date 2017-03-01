namespace WindowsFormsApplication2
{
    partial class AddContenders_Window
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
            this.buttonAddAnotherContender = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.namn_input = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deltagare_id_input = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nat_input = new System.Windows.Forms.TextBox();
            this.Hopp_nr_1 = new MetroFramework.Controls.MetroLabel();
            this.Hopp_nr2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Namn_lägg_till_deltagare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deltagar_id_lägga_till_deltagare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nationalitet_lägg_till_deltagare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Typ_av_hopp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Svårighetsgrad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroComboBox7 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox6 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox5 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(299, 387);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(169, 42);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Avbryt";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddAnotherContender
            // 
            this.buttonAddAnotherContender.Location = new System.Drawing.Point(17, 387);
            this.buttonAddAnotherContender.Name = "buttonAddAnotherContender";
            this.buttonAddAnotherContender.Size = new System.Drawing.Size(169, 42);
            this.buttonAddAnotherContender.TabIndex = 1;
            this.buttonAddAnotherContender.Text = "Lägg till ";
            this.buttonAddAnotherContender.UseVisualStyleBackColor = true;
            this.buttonAddAnotherContender.Click += new System.EventHandler(this.buttonAddAnotherContender_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(597, 387);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(169, 42);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Klar";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Namn";
            // 
            // namn_input
            // 
            this.namn_input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.namn_input.Location = new System.Drawing.Point(95, 12);
            this.namn_input.Multiline = true;
            this.namn_input.Name = "namn_input";
            this.namn_input.Size = new System.Drawing.Size(123, 26);
            this.namn_input.TabIndex = 18;
            this.namn_input.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(232, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "Deltagar-ID";
            // 
            // deltagare_id_input
            // 
            this.deltagare_id_input.Location = new System.Drawing.Point(373, 9);
            this.deltagare_id_input.Multiline = true;
            this.deltagare_id_input.Name = "deltagare_id_input";
            this.deltagare_id_input.Size = new System.Drawing.Size(123, 29);
            this.deltagare_id_input.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(503, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nationalitet";
            // 
            // nat_input
            // 
            this.nat_input.Location = new System.Drawing.Point(643, 9);
            this.nat_input.Multiline = true;
            this.nat_input.Name = "nat_input";
            this.nat_input.Size = new System.Drawing.Size(123, 29);
            this.nat_input.TabIndex = 22;
            // 
            // Hopp_nr_1
            // 
            this.Hopp_nr_1.BackColor = System.Drawing.Color.Transparent;
            this.Hopp_nr_1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Hopp_nr_1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Hopp_nr_1.Location = new System.Drawing.Point(17, 65);
            this.Hopp_nr_1.Name = "Hopp_nr_1";
            this.Hopp_nr_1.Size = new System.Drawing.Size(108, 29);
            this.Hopp_nr_1.TabIndex = 30;
            this.Hopp_nr_1.Text = "Hopp #Nr 1";
            this.Hopp_nr_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hopp_nr_1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Hopp_nr_1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // Hopp_nr2
            // 
            this.Hopp_nr2.BackColor = System.Drawing.Color.Transparent;
            this.Hopp_nr2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Hopp_nr2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Hopp_nr2.ForeColor = System.Drawing.Color.Black;
            this.Hopp_nr2.Location = new System.Drawing.Point(17, 103);
            this.Hopp_nr2.Name = "Hopp_nr2";
            this.Hopp_nr2.Size = new System.Drawing.Size(108, 29);
            this.Hopp_nr2.TabIndex = 31;
            this.Hopp_nr2.Text = "Hopp #Nr 2";
            this.Hopp_nr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hopp_nr2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(17, 220);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 29);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Hopp #Nr 5";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(17, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 29);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Hopp #Nr 3";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(17, 181);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 29);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Hopp #Nr 4";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(17, 261);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 29);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Hopp #Nr 6";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.Black;
            this.metroLabel6.Location = new System.Drawing.Point(17, 299);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 29);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Hopp #Nr 7";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namn_lägg_till_deltagare,
            this.Deltagar_id_lägga_till_deltagare,
            this.Nationalitet_lägg_till_deltagare,
            this.Typ_av_hopp,
            this.Svårighetsgrad});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(261, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 263);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // Namn_lägg_till_deltagare
            // 
            this.Namn_lägg_till_deltagare.Text = "Namn";
            this.Namn_lägg_till_deltagare.Width = 115;
            // 
            // Deltagar_id_lägga_till_deltagare
            // 
            this.Deltagar_id_lägga_till_deltagare.Text = "ID";
            // 
            // Nationalitet_lägg_till_deltagare
            // 
            this.Nationalitet_lägg_till_deltagare.Text = "Nationalitet";
            this.Nationalitet_lägg_till_deltagare.Width = 109;
            // 
            // Typ_av_hopp
            // 
            this.Typ_av_hopp.Text = "Hopptyp";
            this.Typ_av_hopp.Width = 73;
            // 
            // Svårighetsgrad
            // 
            this.Svårighetsgrad.Text = "Svårighetsgrad";
            this.Svårighetsgrad.Width = 93;
            // 
            // metroComboBox7
            // 
            this.metroComboBox7.FormattingEnabled = true;
            this.metroComboBox7.ItemHeight = 23;
            this.metroComboBox7.Items.AddRange(new object[] {
            "Test 7"});
            this.metroComboBox7.Location = new System.Drawing.Point(137, 299);
            this.metroComboBox7.Name = "metroComboBox7";
            this.metroComboBox7.Size = new System.Drawing.Size(103, 29);
            this.metroComboBox7.TabIndex = 42;
            this.metroComboBox7.UseSelectable = true;
            // 
            // metroComboBox6
            // 
            this.metroComboBox6.FormattingEnabled = true;
            this.metroComboBox6.ItemHeight = 23;
            this.metroComboBox6.Items.AddRange(new object[] {
            "Test6"});
            this.metroComboBox6.Location = new System.Drawing.Point(137, 261);
            this.metroComboBox6.Name = "metroComboBox6";
            this.metroComboBox6.Size = new System.Drawing.Size(103, 29);
            this.metroComboBox6.TabIndex = 41;
            this.metroComboBox6.UseSelectable = true;
            // 
            // metroComboBox5
            // 
            this.metroComboBox5.FormattingEnabled = true;
            this.metroComboBox5.ItemHeight = 23;
            this.metroComboBox5.Items.AddRange(new object[] {
            "Test5"});
            this.metroComboBox5.Location = new System.Drawing.Point(137, 220);
            this.metroComboBox5.Name = "metroComboBox5";
            this.metroComboBox5.Size = new System.Drawing.Size(103, 29);
            this.metroComboBox5.TabIndex = 40;
            this.metroComboBox5.UseSelectable = true;
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 23;
            this.metroComboBox4.Items.AddRange(new object[] {
            "Test 4"});
            this.metroComboBox4.Location = new System.Drawing.Point(137, 181);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(103, 29);
            this.metroComboBox4.TabIndex = 39;
            this.metroComboBox4.UseSelectable = true;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "Test 3"});
            this.metroComboBox3.Location = new System.Drawing.Point(137, 141);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(103, 29);
            this.metroComboBox3.TabIndex = 38;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.SelectedIndexChanged += new System.EventHandler(this.metroComboBox3_SelectedIndexChanged);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Test test1"});
            this.metroComboBox2.Location = new System.Drawing.Point(137, 103);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(103, 29);
            this.metroComboBox2.TabIndex = 37;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "AB200",
            "BA200"});
            this.metroComboBox1.Location = new System.Drawing.Point(137, 65);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(103, 29);
            this.metroComboBox1.TabIndex = 36;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // AddContenders_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroComboBox7);
            this.Controls.Add(this.metroComboBox6);
            this.Controls.Add(this.metroComboBox5);
            this.Controls.Add(this.metroComboBox4);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Hopp_nr2);
            this.Controls.Add(this.Hopp_nr_1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nat_input);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deltagare_id_input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.namn_input);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonAddAnotherContender);
            this.Controls.Add(this.buttonCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddContenders_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till deltagare";
            this.Load += new System.EventHandler(this.AddContenders_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddAnotherContender;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox namn_input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox deltagare_id_input;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nat_input;
        private MetroFramework.Controls.MetroLabel Hopp_nr_1;
        private MetroFramework.Controls.MetroLabel Hopp_nr2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Deltagar_id_lägga_till_deltagare;
        private System.Windows.Forms.ColumnHeader Namn_lägg_till_deltagare;
        private System.Windows.Forms.ColumnHeader Nationalitet_lägg_till_deltagare;
        private System.Windows.Forms.ColumnHeader Typ_av_hopp;
        private System.Windows.Forms.ColumnHeader Svårighetsgrad;
        private MetroFramework.Controls.MetroComboBox metroComboBox7;
        private MetroFramework.Controls.MetroComboBox metroComboBox6;
        private MetroFramework.Controls.MetroComboBox metroComboBox5;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}