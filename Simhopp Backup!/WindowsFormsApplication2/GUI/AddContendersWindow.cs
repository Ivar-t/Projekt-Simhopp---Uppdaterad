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



namespace WindowsFormsApplication2
{
    public partial class AddContenders_Window : Form
    {
        public ListViewItem lv1;

        Thread th; //Skapar tråd objekt så vi kan skapa nya fönster

        public AddContenders_Window()
        {
            InitializeComponent();
        }

        #region buttonClicks

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Kod för ruta som frågar om den är säker på att avbryta (OK/CANCEL)
            //..
            this.Close();
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

            //Första raden!//
            ListViewItem item = new ListViewItem();
            item.Text = namn_input.Text; // Deltagarens namn //
            item.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
            item.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
            item.SubItems.Add(metroComboBox1.Text); // Lägger till vilket hopp man valt //
            item.SubItems.Add("MaxPoints");
            //Funktion för att läsa av combobox val (hopp) och hämta avårighetsgrad till det!

            //Rad 2 //
            ListViewItem item1 = new ListViewItem();
            item1.Text = namn_input.Text; // Deltagarens namn //
            item1.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
            item1.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
            item1.SubItems.Add(metroComboBox2.Text); // Lägger till vilket hopp man valt //
            item1.SubItems.Add("MaxPoints");

            //Rad 3//
            ListViewItem item3 = new ListViewItem();
            item3.Text = namn_input.Text; // Deltagarens namn //
            item3.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
            item3.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
            item3.SubItems.Add(metroComboBox3.Text); // Lägger till vilket hopp man valt //
            item3.SubItems.Add("MaxPoints");

            //Rad 4//
            ListViewItem item4 = new ListViewItem();
            item4.Text = namn_input.Text; // Deltagarens namn //
            item4.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
            item4.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
            item4.SubItems.Add(metroComboBox4.Text); // Lägger till vilket hopp man valt //
            item4.SubItems.Add("MaxPoints");

            //Rad 5//
            ListViewItem item5 = new ListViewItem();
            item5.Text = namn_input.Text; // Deltagarens namn //
            item5.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
            item5.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
            item5.SubItems.Add(metroComboBox5.Text); // Lägger till vilket hopp man valt //
            item5.SubItems.Add("MaxPoints");

            //Rad 6//
            ListViewItem item6 = new ListViewItem();
            item6.Text = namn_input.Text; // Deltagarens namn //
            item6.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
            item6.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
            item6.SubItems.Add(metroComboBox6.Text); // Lägger till vilket hopp man valt //
            item6.SubItems.Add("MaxPoints");

            //Rad 7//
            ListViewItem item7 = new ListViewItem();
            item7.Text = namn_input.Text; // Deltagarens namn //
            item7.SubItems.Add(deltagare_id_input.Text); //Lägger till deltagar ID//
            item7.SubItems.Add(nat_input.Text); //Lägger till nationalitet //
            item7.SubItems.Add(metroComboBox7.Text); // Lägger till vilket hopp man valt //
            item7.SubItems.Add("MaxPoints");


            //Lägger till alla ovan till vår listview //
            listView1.Items.Add(item);
            listView1.Items.Add(item1);
            listView1.Items.Add(item3);
            listView1.Items.Add(item4);
            listView1.Items.Add(item5);
            listView1.Items.Add(item6);
            listView1.Items.Add(item7);

            //Tömmer alla input options //
            namn_input.Clear();
            deltagare_id_input.Clear();
            nat_input.Clear();
            metroComboBox1.Items.Clear();
            metroComboBox2.Items.Clear();
            metroComboBox3.Items.Clear();
            metroComboBox4.Items.Clear();
            metroComboBox5.Items.Clear();
            metroComboBox6.Items.Clear();
            metroComboBox7.Items.Clear();

            this.Close();
            th = new Thread(openNewAddContendersWindowW);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewAddContendersWindowW()
        {
            Application.Run(new AddContenders_Window());
        }

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
    }
}




