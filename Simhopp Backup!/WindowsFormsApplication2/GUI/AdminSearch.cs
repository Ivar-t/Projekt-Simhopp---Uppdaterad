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
    public partial class AdminSearch_window : Form
    {
        Thread th;
        string allText = "";
        public AdminSearch_window()
        {
            InitializeComponent();
        }

        #region buttonClicks
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void buttonSearch_Click(object sender, EventArgs e)
        //{
        //    //Läser in vald fil och skickar filnamsinfon till AdminSelectedContest fönstret
        //    string cName = contestNameTextBox.Text + ".txt";

        //    if (File.Exists(contestNameTextBox.Text + ".txt"))
        //    {
        //        int underJuding = 0;
        //        using (StreamReader sr = new StreamReader(cName))
        //        {
        //            string line = "";
        //            line = sr.ReadLine();
        //            string[] holder = line.Split(';');
        //            underJuding = Convert.ToInt32(holder[4]);
        //            allText += line + "\n";
        //            while ((line = sr.ReadLine()) != null)
        //            {
        //                allText += line + "\n";
        //            }
        //        }
        //        if (underJuding == 0)
        //        {
        //            this.Close();
        //            AdminSelectedContest asc = new AdminSelectedContest(allText);
        //            asc.ShowDialog();
        //        }
        //        else if (underJuding == 1)
        //        {
        //            MessageBox.Show("Tävlingen är redan startad!", "Sök tävling", MessageBoxButtons.OK);
        //            contestNameTextBox.Text = "";
        //        }
        //        else
        //        {
        //            MessageBox.Show("Något gick tokigt\nKontaka ansvarige!", "Sök tävling", MessageBoxButtons.OK);
        //            contestNameTextBox.Text = "";
        //        }
        //    }
        //}
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Kod här som läser in vald fil och skriver ut det på fönstret AdminSelectedContest
            //..
            //Kod här för ruta om programmet inte hittar vald tävling(OK)
            //..
            this.Close();
            th = new Thread(openAdminSelectedContestW);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAdminSelectedContestW()
        {
            Application.Run(new AdminSelectedContest_window());
        }
        #endregion
    }
}
