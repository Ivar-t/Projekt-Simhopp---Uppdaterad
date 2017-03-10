using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class EraseContest_form1 : Form
    {
        List<string> LOC = new List<string>(); // Tar emot den nya listan av tävlingsnamn efter vi raderat vald fil
        List<string> contestNameFiles = new List<string>();
        public EraseContest_form1()
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
        private void buttonCancelEraseContest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void buttonEraseContest_Click(object sender, EventArgs e)
        {
            string cName = contestNameComboBox.Text + ".txt";
            //frågar om man vill radera tävling(OK/CANCEL) kollar också om tävling existerar
            if (File.Exists(cName))
            {
                DialogResult dialogResult = MessageBox.Show("Vill du verkligen ta bort filen: " + contestNameComboBox.Text + "?", "Radera Tävling", MessageBoxButtons.YesNo);
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
                            while((line = sr.ReadLine()) != null)
                            {
                                if(!(line == contestNameComboBox.Text))
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
                            foreach(var x in LOC)
                            {
                                sw.WriteLine(x);
                            }
                        }

                        File.Delete(contestNameComboBox.Text + ".txt");
                        MessageBox.Show("Tävling är borttagen", "Radera tävling", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else if (contestFinished == 1)
                    {
                        MessageBox.Show("Tävlingen är redan avslutad!", "Radera tävling", MessageBoxButtons.OK);
                    }
                    else if (underJuding == 1)
                    {
                        MessageBox.Show("Tävlingen är redan startad!", "Raderea tävling", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Något gick tokigt\nFörsök igen!", "Radera tävling", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    contestNameComboBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tävlingen existerar inte", "Radera tävling", MessageBoxButtons.OK);
                contestNameComboBox.Text = "";
            }
            contestNameComboBox.Text = "";
        }
    }
}
