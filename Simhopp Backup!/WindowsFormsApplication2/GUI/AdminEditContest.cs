using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class AdminEditContest_window : Form
    {
        List<string> contestNameFiles = new List<string>();
        Thread th;
        public AdminEditContest_window()
        {
            InitializeComponent();

            if (File.Exists("ListOfContest.txt"))
            {
                using (StreamReader sr = new StreamReader("ListOfContest.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        contestNameFiles.Add(line);
                    }
                    int q = 0;
                    contestNameFiles.Sort();
                    foreach (var x in contestNameFiles)
                    {
                        contestNameComboBox.Items.Insert(q, x);
                        q++;
                    }
                }
            }
        }

        #region buttonClicks
        private void buttonCancelEditContest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditContest_Click(object sender, EventArgs e)
        {
            //Kod här som öppnar fönster som säger att tävling inte existerar eller redan är avslutad(OK)
            //Om tävling inte är under dömning eller avslutad så har vi tillåtelse att ändra den
            string cName = contestNameComboBox.Text + ".txt";

            if (File.Exists(contestNameComboBox.Text + ".txt"))
            {
                DialogResult dialogResult = MessageBox.Show("Vill du verkligen ändra tävlingen: " + contestNameComboBox.Text + "?", "Radera Tävling", MessageBoxButtons.YesNo);
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
                        this.Close();
                        AddContenders_Window acw = new AddContenders_Window(contestNameComboBox.Text); // ersätter threadfunktionen
                        acw.ShowDialog();
                    }
                    else if (contestFinished == 1)
                    {
                        MessageBox.Show("Tävlingen är redan avslutad!", "Redigera tävling", MessageBoxButtons.OK);
                    }
                    else if (underJuding == 1)
                    {
                        MessageBox.Show("Tävlingen är redan startad!", "Redigera tävling", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Något gick tokigt\nFörsök igen!", "Redigera tävling", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tävlingen existerar inte", "Radera tävling", MessageBoxButtons.OK);
            }
            contestNameComboBox.Text = "";
        }
        //private void buttonEditContest_Click(object sender, EventArgs e)
        //{
        //    //Kod här som läser in vald fil till contenderobjekt in i en contenderList
        //    //..
        //    //Kod här som öppnar fönster som säger att tävling inte existerar eller redan är avslutad(OK)
        //    //..
        //    this.Close();
        //    th = new Thread(openAddContendersWindowW);
        //    th.SetApartmentState(ApartmentState.STA);
        //    th.Start();
        //}
        //private void openAddContendersWindowW()
        //{
        //    Application.Run(new AddContenders_Window());
        //}
        #endregion
    }
}
