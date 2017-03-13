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
            this.label10 = new System.Windows.Forms.Label();
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
            this.Hopp7TextBox = new MetroFramework.Controls.MetroComboBox();
            this.Hopp6TextBox = new MetroFramework.Controls.MetroComboBox();
            this.Hopp5TextBox = new MetroFramework.Controls.MetroComboBox();
            this.Hopp4TextBox = new MetroFramework.Controls.MetroComboBox();
            this.Hopp3TextBox = new MetroFramework.Controls.MetroComboBox();
            this.Hopp2TextBox = new MetroFramework.Controls.MetroComboBox();
            this.Hopp1TextBox = new MetroFramework.Controls.MetroComboBox();
            this.contestNameLabel = new System.Windows.Forms.Label();
            this.deltagare_id_input = new System.Windows.Forms.NumericUpDown();
            this.nat_input = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.deltagare_id_input)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(399, 476);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(225, 52);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Avbryt";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddAnotherContender
            // 
            this.buttonAddAnotherContender.Location = new System.Drawing.Point(23, 476);
            this.buttonAddAnotherContender.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAnotherContender.Name = "buttonAddAnotherContender";
            this.buttonAddAnotherContender.Size = new System.Drawing.Size(225, 52);
            this.buttonAddAnotherContender.TabIndex = 11;
            this.buttonAddAnotherContender.Text = "Lägg till ";
            this.buttonAddAnotherContender.UseVisualStyleBackColor = true;
            this.buttonAddAnotherContender.Click += new System.EventHandler(this.buttonAddAnotherContender_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(796, 476);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(225, 52);
            this.buttonDone.TabIndex = 13;
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
            this.label7.Location = new System.Drawing.Point(16, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Namn";
            // 
            // namn_input
            // 
            this.namn_input.BackColor = System.Drawing.SystemColors.MenuBar;
            this.namn_input.Location = new System.Drawing.Point(127, 15);
            this.namn_input.Margin = new System.Windows.Forms.Padding(4);
            this.namn_input.Multiline = true;
            this.namn_input.Name = "namn_input";
            this.namn_input.Size = new System.Drawing.Size(163, 31);
            this.namn_input.TabIndex = 1;
            this.namn_input.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(309, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 36);
            this.label9.TabIndex = 21;
            this.label9.Text = "Deltagar-ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(671, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 36);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nationalitet";
            // 
            // Hopp_nr_1
            // 
            this.Hopp_nr_1.BackColor = System.Drawing.Color.Transparent;
            this.Hopp_nr_1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Hopp_nr_1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Hopp_nr_1.Location = new System.Drawing.Point(32, 133);
            this.Hopp_nr_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hopp_nr_1.Name = "Hopp_nr_1";
            this.Hopp_nr_1.Size = new System.Drawing.Size(144, 36);
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
            this.Hopp_nr2.Location = new System.Drawing.Point(32, 180);
            this.Hopp_nr2.Name = "Hopp_nr2";
            this.Hopp_nr2.Size = new System.Drawing.Size(144, 36);
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
            this.metroLabel2.Location = new System.Drawing.Point(32, 324);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(144, 36);
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
            this.metroLabel3.Location = new System.Drawing.Point(32, 226);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(144, 36);
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
            this.metroLabel4.Location = new System.Drawing.Point(32, 276);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(144, 36);
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
            this.metroLabel5.Location = new System.Drawing.Point(32, 374);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(144, 36);
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
            this.metroLabel6.Location = new System.Drawing.Point(32, 421);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(144, 36);
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
            this.listView1.Location = new System.Drawing.Point(348, 133);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(672, 323);
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
            // Hopp7TextBox
            // 
            this.Hopp7TextBox.FormattingEnabled = true;
            this.Hopp7TextBox.ItemHeight = 24;
            this.Hopp7TextBox.Location = new System.Drawing.Point(183, 421);
            this.Hopp7TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Hopp7TextBox.Name = "Hopp7TextBox";
            this.Hopp7TextBox.Size = new System.Drawing.Size(136, 30);
            this.Hopp7TextBox.TabIndex = 10;
            this.Hopp7TextBox.UseSelectable = true;
            // 
            // Hopp6TextBox
            // 
            this.Hopp6TextBox.FormattingEnabled = true;
            this.Hopp6TextBox.ItemHeight = 24;
            this.Hopp6TextBox.Location = new System.Drawing.Point(183, 374);
            this.Hopp6TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Hopp6TextBox.Name = "Hopp6TextBox";
            this.Hopp6TextBox.Size = new System.Drawing.Size(136, 30);
            this.Hopp6TextBox.TabIndex = 9;
            this.Hopp6TextBox.UseSelectable = true;
            // 
            // Hopp5TextBox
            // 
            this.Hopp5TextBox.FormattingEnabled = true;
            this.Hopp5TextBox.ItemHeight = 24;
            this.Hopp5TextBox.Location = new System.Drawing.Point(183, 324);
            this.Hopp5TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Hopp5TextBox.Name = "Hopp5TextBox";
            this.Hopp5TextBox.Size = new System.Drawing.Size(136, 30);
            this.Hopp5TextBox.TabIndex = 8;
            this.Hopp5TextBox.UseSelectable = true;
            // 
            // Hopp4TextBox
            // 
            this.Hopp4TextBox.FormattingEnabled = true;
            this.Hopp4TextBox.ItemHeight = 24;
            this.Hopp4TextBox.Location = new System.Drawing.Point(183, 276);
            this.Hopp4TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Hopp4TextBox.Name = "Hopp4TextBox";
            this.Hopp4TextBox.Size = new System.Drawing.Size(136, 30);
            this.Hopp4TextBox.TabIndex = 7;
            this.Hopp4TextBox.UseSelectable = true;
            this.Hopp4TextBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox4_SelectedIndexChanged);
            // 
            // Hopp3TextBox
            // 
            this.Hopp3TextBox.FormattingEnabled = true;
            this.Hopp3TextBox.ItemHeight = 24;
            this.Hopp3TextBox.Location = new System.Drawing.Point(183, 226);
            this.Hopp3TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Hopp3TextBox.Name = "Hopp3TextBox";
            this.Hopp3TextBox.Size = new System.Drawing.Size(136, 30);
            this.Hopp3TextBox.TabIndex = 6;
            this.Hopp3TextBox.UseSelectable = true;
            this.Hopp3TextBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox3_SelectedIndexChanged);
            // 
            // Hopp2TextBox
            // 
            this.Hopp2TextBox.FormattingEnabled = true;
            this.Hopp2TextBox.ItemHeight = 24;
            this.Hopp2TextBox.Location = new System.Drawing.Point(183, 180);
            this.Hopp2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Hopp2TextBox.Name = "Hopp2TextBox";
            this.Hopp2TextBox.Size = new System.Drawing.Size(136, 30);
            this.Hopp2TextBox.TabIndex = 5;
            this.Hopp2TextBox.UseSelectable = true;
            this.Hopp2TextBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // Hopp1TextBox
            // 
            this.Hopp1TextBox.FormattingEnabled = true;
            this.Hopp1TextBox.ItemHeight = 24;
            this.Hopp1TextBox.Location = new System.Drawing.Point(183, 133);
            this.Hopp1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Hopp1TextBox.Name = "Hopp1TextBox";
            this.Hopp1TextBox.Size = new System.Drawing.Size(136, 30);
            this.Hopp1TextBox.TabIndex = 4;
            this.Hopp1TextBox.UseSelectable = true;
            this.Hopp1TextBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // contestNameLabel
            // 
            this.contestNameLabel.AutoSize = true;
            this.contestNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestNameLabel.Location = new System.Drawing.Point(347, 80);
            this.contestNameLabel.Name = "contestNameLabel";
            this.contestNameLabel.Size = new System.Drawing.Size(128, 36);
            this.contestNameLabel.TabIndex = 45;
            this.contestNameLabel.Text = "Tävling: ";
            // 
            // deltagare_id_input
            // 
            this.deltagare_id_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltagare_id_input.Location = new System.Drawing.Point(481, 13);
            this.deltagare_id_input.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.deltagare_id_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deltagare_id_input.Name = "deltagare_id_input";
            this.deltagare_id_input.Size = new System.Drawing.Size(165, 34);
            this.deltagare_id_input.TabIndex = 2;
            this.deltagare_id_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deltagare_id_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nat_input
            // 
            this.nat_input.DropDownHeight = 200;
            this.nat_input.DropDownWidth = 200;
            this.nat_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nat_input.FormattingEnabled = true;
            this.nat_input.IntegralHeight = false;
            this.nat_input.Items.AddRange(new object[] {
            "Sweden",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.nat_input.Location = new System.Drawing.Point(842, 13);
            this.nat_input.MaxDropDownItems = 4;
            this.nat_input.MaximumSize = new System.Drawing.Size(100, 0);
            this.nat_input.Name = "nat_input";
            this.nat_input.Size = new System.Drawing.Size(100, 33);
            this.nat_input.TabIndex = 3;
            // 
            // AddContenders_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Swimiing_pools1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.nat_input);
            this.Controls.Add(this.deltagare_id_input);
            this.Controls.Add(this.contestNameLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Hopp7TextBox);
            this.Controls.Add(this.Hopp6TextBox);
            this.Controls.Add(this.Hopp5TextBox);
            this.Controls.Add(this.Hopp4TextBox);
            this.Controls.Add(this.Hopp3TextBox);
            this.Controls.Add(this.Hopp2TextBox);
            this.Controls.Add(this.Hopp1TextBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Hopp_nr2);
            this.Controls.Add(this.Hopp_nr_1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.namn_input);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonAddAnotherContender);
            this.Controls.Add(this.buttonCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddContenders_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till deltagare";
            this.Load += new System.EventHandler(this.AddContenders_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deltagare_id_input)).EndInit();
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
        private System.Windows.Forms.Label label10;
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
        private MetroFramework.Controls.MetroComboBox Hopp7TextBox;
        private MetroFramework.Controls.MetroComboBox Hopp6TextBox;
        private MetroFramework.Controls.MetroComboBox Hopp5TextBox;
        private MetroFramework.Controls.MetroComboBox Hopp4TextBox;
        private MetroFramework.Controls.MetroComboBox Hopp3TextBox;
        private MetroFramework.Controls.MetroComboBox Hopp2TextBox;
        private MetroFramework.Controls.MetroComboBox Hopp1TextBox;
        private System.Windows.Forms.Label contestNameLabel;
        private System.Windows.Forms.NumericUpDown deltagare_id_input;
        private System.Windows.Forms.ComboBox nat_input;
    }
}