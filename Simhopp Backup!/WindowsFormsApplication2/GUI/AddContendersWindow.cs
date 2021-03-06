﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Controls;
using System.IO;
using System.Globalization;



namespace WindowsFormsApplication2
{
    public partial class AddContenders_Window : Form
    {
        public ListViewItem lv1;
        Dictionary<string, string> mapObj = new Dictionary<string, string>();

        List<string> LOC = new List<string>(); // Tar emot den nya listan av tävlingsnamn efter vi raderat vald fil
        List<string> contestNameFiles = new List<string>();

        Thread th; //Skapar tråd objekt så vi kan skapa nya fönster
        string fileNameHolder = "";
        List<string> checkConflictID = new List<string>();
        string idThatTheAdminIsTryingToGiveToTheContender = String.Empty;
        bool allowedID = true;
        string fileNaame;
        public AddContenders_Window()
        {
            InitializeComponent();
        }
        public AddContenders_Window(string dataRecieved) //skapar en ny konstruktor så vi kan ta emot info från andra forms
        {
            InitializeComponent();
            fileNaame = dataRecieved;
            contestNameLabel.Text = contestNameLabel.Text + dataRecieved;  //Skriver ut tävlingens namn på fönstret
            fileNameHolder = dataRecieved; //ska hämta filnamn

            if (File.Exists("ListOfJump.txt"))
            {
                using (StreamReader sr = new StreamReader("ListOfJump.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] holder = line.Split(';');
                        mapObj.Add(holder[0], holder[1]);
                    }
                    int q = 0;
                    foreach (var x in mapObj)
                    {
                        Hopp1TextBox.Items.Insert(q, x.Key);
                        Hopp2TextBox.Items.Insert(q, x.Key);
                        Hopp3TextBox.Items.Insert(q, x.Key);
                        Hopp4TextBox.Items.Insert(q, x.Key);
                        Hopp5TextBox.Items.Insert(q, x.Key);
                        Hopp6TextBox.Items.Insert(q, x.Key);
                        Hopp7TextBox.Items.Insert(q, x.Key);
                        q++;
                    }
                }
            }
            else { MessageBox.Show("nej", "as", MessageBoxButtons.OK); }
        }


        #region buttonClicks

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Kod för ruta som frågar om den är säker på att avbryta (OK/CANCEL)
            //..
            string cName = fileNaame + ".txt";
            //frågar om man vill radera tävling(OK/CANCEL) kollar också om tävling existerar
            if (File.Exists(cName))
            {
                DialogResult dialogResult = MessageBox.Show("All information kommer gå förlorad!\n\tÄr du säker?", fileNaame, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int underJuding = 0;
                    int contestFinished = 0;
                    using (StreamReader sr = new StreamReader(cName))
                    {
                        string line = "";
                        line = sr.ReadLine();
                        string[] holder = line.Split(';');
                        underJuding = Convert.ToInt32(holder[4]);
                        contestFinished = Convert.ToInt32(holder[5]);
                    }
                    if ((contestFinished == 0) && (underJuding == 0))
                    {

                        using (StreamReader sr = new StreamReader("ListOfContest.txt"))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                if (!(line == fileNaame))
                                {
                                    LOC.Add(line);
                                }
                            }
                        }
                        FileStream fileStream = File.Open("ListOfContest.txt", FileMode.Open);
                        fileStream.SetLength(0);
                        fileStream.Close();
                        using (StreamWriter sw = new StreamWriter("ListOfContest.txt"))
                        {
                            foreach (var x in LOC)
                            {
                                sw.WriteLine(x);
                            }
                        }

                        File.Delete(fileNaame + ".txt");
                        MessageBox.Show("Tävling är borttagen", "Radera tävling", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            //Kod för ruta som säger att Tävlingen är skapad och redo att startas (OK)
            //..
            //Kod här som Skriver över allt som lagts till i en behållare till rätt tävlings fil
            //..
            this.Close();
        }


        private void buttonAddAnotherContender_Click(object sender, EventArgs e)
        {
            //Kod här som slänger in informationen till ett objekt som i sin tur går till en ContestList
            //..
            if (namn_input.Text != "" && deltagare_id_input.Text != "" && nat_input.Text != "" && Hopp1TextBox.Text != "" && Hopp2TextBox.Text != "" && Hopp3TextBox.Text != "" && Hopp4TextBox.Text != "" && Hopp5TextBox.Text != "" && Hopp6TextBox.Text != "" && Hopp7TextBox.Text != "")
            {
                string line = namn_input.Text + ";" + deltagare_id_input.Text + ";" + nat_input.Text + ";" + Hopp1TextBox.Text + ";" + mapObj[Hopp1TextBox.Text] + ";" + Hopp2TextBox.Text + ";" + mapObj[Hopp2TextBox.Text] + ";" + Hopp3TextBox.Text + ";" + mapObj[Hopp3TextBox.Text] + ";" + Hopp4TextBox.Text + ";" + mapObj[Hopp4TextBox.Text] + ";" + Hopp5TextBox.Text + ";" + mapObj[Hopp5TextBox.Text] + ";" + Hopp6TextBox.Text + ";" + mapObj[Hopp6TextBox.Text] + ";" + Hopp7TextBox.Text + ";" + mapObj[Hopp7TextBox.Text];
                string cName = fileNameHolder + ".txt";
                using (StreamReader sr = new StreamReader(cName))
                {
                    string fileLine = "";
                    string firstLineJunk = "";      //behöver ignorera första linjen i filen
                    firstLineJunk = sr.ReadLine();
                    while ((fileLine = sr.ReadLine()) != null)
                    {
                        string[] holder = fileLine.Split(';');
                        checkConflictID.Add(holder[1]);
                    }
                }

                foreach (var x in checkConflictID)
                {
                    if (x == deltagare_id_input.Text)
                    {
                        MessageBox.Show("ID är redan upptaget!\nTesta ett annat", "ID-konflikt", MessageBoxButtons.OK);
                        deltagare_id_input.Text = "";
                        allowedID = false;
                        break;
                    }
                }
                if (allowedID == true)
                {
                    if (string.IsNullOrWhiteSpace(namn_input.Text) || string.IsNullOrWhiteSpace(deltagare_id_input.Text) || string.IsNullOrWhiteSpace(nat_input.Text) || Hopp1TextBox.SelectedIndex == -1 ||
                        Hopp2TextBox.SelectedIndex == -1 || Hopp3TextBox.SelectedIndex == -1 || Hopp4TextBox.SelectedIndex == -1 || Hopp5TextBox.SelectedIndex == -1 || Hopp6TextBox.SelectedIndex == -1
                        || Hopp7TextBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("fill all the information.");
                    }
                    else
                    {
                        //Första raden!//
                        double doub = double.Parse(mapObj[Hopp1TextBox.Text], CultureInfo.InvariantCulture) * 30;
                        String str = doub.ToString();
                        ListViewItem item = new ListViewItem();
                        item.Text = namn_input.Text; // Deltagarens namn //
                        item.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
                        item.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
                        item.SubItems.Add(Hopp1TextBox.Text); // Lägger till vilket hopp man valt //
                        item.SubItems.Add(str);
                        //Funktion för att läsa av combobox val (hopp) och hämta avårighetsgrad till det!

                        //Rad 2 //
                        double doub2 = double.Parse(mapObj[Hopp2TextBox.Text], CultureInfo.InvariantCulture) * 30;
                        String str2 = doub2.ToString();
                        ListViewItem item1 = new ListViewItem();
                        item1.Text = namn_input.Text; // Deltagarens namn //
                        item1.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
                        item1.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
                        item1.SubItems.Add(Hopp2TextBox.Text); // Lägger till vilket hopp man valt //
                        item1.SubItems.Add(str2);

                        //Rad 3//
                        double doub3 = double.Parse(mapObj[Hopp3TextBox.Text], CultureInfo.InvariantCulture) * 30;
                        String str3 = doub3.ToString();
                        ListViewItem item3 = new ListViewItem();
                        item3.Text = namn_input.Text; // Deltagarens namn //
                        item3.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
                        item3.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
                        item3.SubItems.Add(Hopp3TextBox.Text); // Lägger till vilket hopp man valt //
                        item3.SubItems.Add(str3);

                        //Rad 4//
                        double doub4 = double.Parse(mapObj[Hopp4TextBox.Text], CultureInfo.InvariantCulture) * 30;
                        String str4 = doub4.ToString();
                        ListViewItem item4 = new ListViewItem();
                        item4.Text = namn_input.Text; // Deltagarens namn //
                        item4.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
                        item4.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
                        item4.SubItems.Add(Hopp4TextBox.Text); // Lägger till vilket hopp man valt //
                        item4.SubItems.Add(str4);

                        //Rad 5//
                        double doub5 = double.Parse(mapObj[Hopp5TextBox.Text], CultureInfo.InvariantCulture) * 30;
                        String str5 = doub5.ToString();
                        ListViewItem item5 = new ListViewItem();
                        item5.Text = namn_input.Text; // Deltagarens namn //
                        item5.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
                        item5.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
                        item5.SubItems.Add(Hopp5TextBox.Text); // Lägger till vilket hopp man valt //
                        item5.SubItems.Add(str5);

                        //Rad 6//
                        double doub6 = double.Parse(mapObj[Hopp6TextBox.Text], CultureInfo.InvariantCulture) * 30;
                        String str6 = doub6.ToString();
                        ListViewItem item6 = new ListViewItem();
                        item6.Text = namn_input.Text; // Deltagarens namn //
                        item6.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
                        item6.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
                        item6.SubItems.Add(Hopp6TextBox.Text); // Lägger till vilket hopp man valt //
                        item6.SubItems.Add(str6);

                        //Rad 7//
                        double doub7 = double.Parse(mapObj[Hopp7TextBox.Text], CultureInfo.InvariantCulture) * 30;
                        String str7 = doub7.ToString();
                        ListViewItem item7 = new ListViewItem();
                        item7.Text = namn_input.Text; // Deltagarens namn //
                        item7.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
                        item7.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
                        item7.SubItems.Add(Hopp7TextBox.Text); // Lägger till vilket hopp man valt //
                        item7.SubItems.Add(str7);

                        //Rad 8
                        ListViewItem item8 = new ListViewItem();
                        item8.Text = string.Empty;
                        item8.SubItems.Add("");
                        item8.SubItems.Add("");
                        item8.SubItems.Add("");
                        item8.SubItems.Add("");

                        //Lägger till alla ovan till vår listview //
                        listView1.Items.Add(item);
                        listView1.Items.Add(item1);
                        listView1.Items.Add(item3);
                        listView1.Items.Add(item4);
                        listView1.Items.Add(item5);
                        listView1.Items.Add(item6);
                        listView1.Items.Add(item7);
                        listView1.Items.Add(item8);

                        checkConflictID.Add(idThatTheAdminIsTryingToGiveToTheContender);

                        //Tömmer alla input options //
                        namn_input.Clear();
                        deltagare_id_input.Value = 1;
                        nat_input.Text = "";
                        Hopp1TextBox.SelectedIndex = -1;
                        Hopp2TextBox.SelectedIndex = -1;
                        Hopp3TextBox.SelectedIndex = -1;
                        Hopp4TextBox.SelectedIndex = -1;
                        Hopp5TextBox.SelectedIndex = -1;
                        Hopp6TextBox.SelectedIndex = -1;
                        Hopp7TextBox.SelectedIndex = -1;
                    }
                }

                if (allowedID == true)
                {
                    using (StreamWriter sw = File.AppendText(cName))
                    {
                        sw.WriteLine(line);
                    }
                    namn_input.Text = "";
                    deltagare_id_input.Text = "";
                    nat_input.Text = "";
                    Hopp1TextBox.Text = "";
                    Hopp2TextBox.Text = "";
                    Hopp3TextBox.Text = "";
                    Hopp4TextBox.Text = "";
                    Hopp5TextBox.Text = "";
                    Hopp6TextBox.Text = "";
                    Hopp7TextBox.Text = "";
                }
                else { allowedID = true; }

            }
            else
            {
                MessageBox.Show("Alla rutor är inte ifyllda", "Lägg till deltagare", MessageBoxButtons.OK);
            }
            
        }
            


        //private void buttonAddAnotherContender_Click(object sender, EventArgs e)
        //{

        //    //Första raden!//
        //    ListViewItem item = new ListViewItem();
        //    item.Text = namn_input.Text; // Deltagarens namn //
        //    item.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
        //    item.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
        //    item.SubItems.Add(metroComboBox1.Text); // Lägger till vilket hopp man valt //
        //    item.SubItems.Add("MaxPoints");
        //    //Funktion för att läsa av combobox val (hopp) och hämta avårighetsgrad till det!

        //    //Rad 2 //
        //    ListViewItem item1 = new ListViewItem();
        //    item1.Text = namn_input.Text; // Deltagarens namn //
        //    item1.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
        //    item1.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
        //    item1.SubItems.Add(metroComboBox2.Text); // Lägger till vilket hopp man valt //
        //    item1.SubItems.Add("MaxPoints");

        //    //Rad 3//
        //    ListViewItem item3 = new ListViewItem();
        //    item3.Text = namn_input.Text; // Deltagarens namn //
        //    item3.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
        //    item3.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
        //    item3.SubItems.Add(metroComboBox3.Text); // Lägger till vilket hopp man valt //
        //    item3.SubItems.Add("MaxPoints");

        //    //Rad 4//
        //    ListViewItem item4 = new ListViewItem();
        //    item4.Text = namn_input.Text; // Deltagarens namn //
        //    item4.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
        //    item4.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
        //    item4.SubItems.Add(metroComboBox4.Text); // Lägger till vilket hopp man valt //
        //    item4.SubItems.Add("MaxPoints");

        //    //Rad 5//
        //    ListViewItem item5 = new ListViewItem();
        //    item5.Text = namn_input.Text; // Deltagarens namn //
        //    item5.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
        //    item5.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
        //    item5.SubItems.Add(metroComboBox5.Text); // Lägger till vilket hopp man valt //
        //    item5.SubItems.Add("MaxPoints");

        //    //Rad 6//
        //    ListViewItem item6 = new ListViewItem();
        //    item6.Text = namn_input.Text; // Deltagarens namn //
        //    item6.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
        //    item6.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
        //    item6.SubItems.Add(metroComboBox6.Text); // Lägger till vilket hopp man valt //
        //    item6.SubItems.Add("MaxPoints");

        //    //Rad 7//
        //    ListViewItem item7 = new ListViewItem();
        //    item7.Text = namn_input.Text; // Deltagarens namn //
        //    item7.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
        //    item7.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
        //    item7.SubItems.Add(metroComboBox7.Text); // Lägger till vilket hopp man valt //
        //    item7.SubItems.Add("MaxPoints");


        //    //Lägger till alla ovan till vår listview //
        //    listView1.Items.Add(item);
        //    listView1.Items.Add(item1);
        //    listView1.Items.Add(item3);
        //    listView1.Items.Add(item4);
        //    listView1.Items.Add(item5);
        //    listView1.Items.Add(item6);
        //    listView1.Items.Add(item7);

        //    //Tömmer alla input options //
        //    namn_input.Clear();
        //    deltagare_id_input.Clear();
        //    nat_input.Clear();
        //    metroComboBox1.Items.Clear();
        //    metroComboBox2.Items.Clear();
        //    metroComboBox3.Items.Clear();
        //    metroComboBox4.Items.Clear();
        //    metroComboBox5.Items.Clear();
        //    metroComboBox6.Items.Clear();
        //    metroComboBox7.Items.Clear();

        //}



        #endregion

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddContenders_Window_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            //Testa en knapp som lägger till deltagare till vår lista i GUI //

        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e) //Knappen som lägger till allt till vår lista!
        {

        }


        //string test = (metroComboBox1.Text); //,Här sätter du variabeln för svårighetsgrad// ;
        //listView1.Items.Add(test);


        //ListViewItem lv1 = listView1.SelectedItems[0].SubItems[4];
        //ListViewItem lv1 = listView1.SelectedItems[1].SubItems[4];
        //ListViewItem lv1 = listView1.SelectedItems[2].SubItems[4];
        //ListViewItem lv1 = listView1.SelectedItems[3].SubItems[4];
        //ListViewItem lv1 = listView1.SelectedItems[4].SubItems[4];
        //ListViewItem lv1 = listView1.SelectedItems[5].SubItems[4];
        //ListViewItem lv1 = listView1.SelectedItems[6].SubItems[4];

        //string[] column = new string[6];
        //column[0] = metroComboBox1.Text;
        //column[1] = metroComboBox2.Text;
        //column[2] = metroComboBox3.Text;
        //column[3] = metroComboBox4.Text;
        //column[4] = metroComboBox5.Text;
        //column[5] = metroComboBox6.Text;

        //for (int j = 0; j < 6; j++)
        //{
        //    var listViewItem2 = new ListViewItem(column[j]);
        //    listView1.Items.Add(listViewItem2);

        //}



        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




