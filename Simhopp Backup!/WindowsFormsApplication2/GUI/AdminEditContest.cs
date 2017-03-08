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
        Thread th;
        public AdminEditContest_window()
        {
            InitializeComponent();
        }

        #region buttonClicks
        private void buttonCancelEditContest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void buttonEditContest_Click(object sender, EventArgs e)
        //{
        //    //Kod här som öppnar fönster som säger att tävling inte existerar eller redan är avslutad(OK)
        //    //Om tävling inte är under dömning eller avslutad så har vi tillåtelse att ändra den
        //    string cName = contestNameTextBox.Text + ".txt";

        //    if (File.Exists(contestNameTextBox.Text + ".txt"))
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Vill du verkligen ändra tävlingen: " + contestNameTextBox.Text + "?", "Radera Tävling", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            int underJuding = 0;
        //            int contestFinished = 0;
        //            using (StreamReader sr = new StreamReader(cName))
        //            {
        //                string line = "";
        //                line = sr.ReadLine();
        //                string[] holder = line.Split(';');
        //                underJuding = Convert.ToInt32(holder[4]);
        //                contestFinished = Convert.ToInt32(holder[5]);
        //            }

        //            if ((contestFinished == 0) && (underJuding == 0))
        //            {
        //                this.Close();
        //                AddContendersWindow acw = new AddContendersWindow(contestNameTextBox.Text); // ersätter threadfunktionen
        //                acw.ShowDialog();
        //            }
        //            else if (contestFinished == 1)
        //            {
        //                MessageBox.Show("Tävlingen är redan avslutad!", "Redigera tävling", MessageBoxButtons.OK);
        //            }
        //            else if (underJuding == 1)
        //            {
        //                MessageBox.Show("Tävlingen är redan startad!", "Redigera tävling", MessageBoxButtons.OK);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Något gick tokigt\nFörsök igen!", "Redigera tävling", MessageBoxButtons.OK);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Tävlingen existerar inte", "Radera tävling", MessageBoxButtons.OK);
        //    }
        //    this.Close();
        //}
        private void buttonEditContest_Click(object sender, EventArgs e)
        {
            //Kod här som läser in vald fil till contenderobjekt in i en contenderList
            //..
            //Kod här som öppnar fönster som säger att tävling inte existerar eller redan är avslutad(OK)
            //..
            this.Close();
            th = new Thread(openAddContendersWindowW);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openAddContendersWindowW()
        {
            Application.Run(new AddContenders_Window());
        }
        #endregion
    }
}
