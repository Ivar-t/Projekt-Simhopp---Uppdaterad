using System;
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
    {
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
            string line = contestNameTextBox.Text + ";" + dateTextBox.Text + ";" + genderTextBox.Text + ";" + jumpheightTextBox.Text + "m;" + 0 + ";" + 0 + ";";
            //                 Name                             Date                   GenderContest                Jumpheight      ContestFinished  AreUnderJudging

            string cName = contestNameTextBox.Text + ".txt";

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
                dateTextBox.Text = "";
                genderTextBox.Text = "";
                jumpheightTextBox.Text = "";
            }
        }

        #endregion
    }
}
