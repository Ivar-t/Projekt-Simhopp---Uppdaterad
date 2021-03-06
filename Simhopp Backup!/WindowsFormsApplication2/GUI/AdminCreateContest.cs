﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class AdminCreateContest_window : Form
    { //viktor was here
        string genderVar = "man";
        public AdminCreateContest_window()
        {
            InitializeComponent();
        }

        #region buttonClicks
        private void buttonCancelCreateContest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateContest_Click(object sender, EventArgs e)
        {
            //skapar en fil för tävling
            //skriver in tävlings info i början av filen
            string line = contestNameTextBox.Text + ";" + dateTimePicker1.Text + ";" + genderVar + ";" + JumpHeightTextBox.Text + ";" + 0 + ";" + 0;
            //                 Name                             Date                   GenderContest                Jumpheight      ContestFinished  AreUnderJudging

            string cName = contestNameTextBox.Text + ".txt";

            if (!File.Exists("ListOfContest.txt") && !File.Exists(cName))
            {
                FileStream fileOfContest = new FileStream("ListOfContest.txt", FileMode.CreateNew, FileAccess.ReadWrite); //lägger in tävlingsnamn vi skapat in i en fil
                fileOfContest.Close();

                using (StreamWriter sw = File.AppendText("ListOfContest.txt"))   //öppnar och lägger in tävlingsnamn i filen
                {
                    sw.WriteLine(contestNameTextBox.Text);
                }
            }
            else if(!File.Exists(cName))
            {
                using (StreamWriter sw = File.AppendText("ListOfContest.txt"))   //öppnar och lägger in tävlingsnamn i filen
                {
                    sw.WriteLine(contestNameTextBox.Text);
                }
            }

            if (!File.Exists(cName))
            {

                FileStream fs = new FileStream(cName, FileMode.CreateNew, FileAccess.ReadWrite); //skapar fil
                fs.Close();

                using (StreamWriter sw = new StreamWriter(cName))   //öppnar, gör sitt skit och stänger filen efter sig 
                {
                    sw.WriteLine(line);
                }

                this.Close();
                AddContenders_Window acw = new AddContenders_Window(contestNameTextBox.Text);
                acw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tävling Existerar redan", "Skapa tävling", MessageBoxButtons.OK);
                contestNameTextBox.Text = "";
                dateTimePicker1.Text = "";
                checkBoxman.Checked = false;
                checkBoxwoman.Checked = false;
                JumpHeightTextBox.Value = 3;
            }
        }

        #endregion

        private void contestNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

   
        private void checkBoxwoman_Click(object sender, EventArgs e)
        {
            if (checkBoxwoman.Checked == true)
            {
                checkBoxman.Checked = false;
                genderVar = "Kvinna";
            }
        }

        private void checkBoxman_Click(object sender, EventArgs e)
        {
            if (checkBoxman.Checked == true)
            {
                checkBoxwoman.Checked = false;
                genderVar = "Man";
            }
        }
    }
}
