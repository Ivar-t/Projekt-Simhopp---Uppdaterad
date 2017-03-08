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
        Thread th;      //Skapar tråd objekt så vi kan skapa nya fönster
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
            //Fil-funktions koder här
            //..
            //skriver in tävlings info i början av filen
            string line = contestNameTextBox.Text + "; " + dateTextBox.Text + "; " + genderTextBox.Text + "; " + jumpheightTextBox.Text + "m;";
            string cName = contestNameTextBox.Text + ".htm"; 

            FileStream fs = new FileStream(cName,FileMode.CreateNew,FileAccess.ReadWrite); //skapar fil
            fs.Close();

            using (StreamWriter sw = new StreamWriter(cName))   //öppnar, gör sitt skit och stänger filen efter sig 
            {
                sw.Write(line);
            }

            this.Close();
            th = new Thread(openAddContender2ContestW);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openAddContender2ContestW(object obj)
        {
            Application.Run(new AddContenders_Window());
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
    }
}
