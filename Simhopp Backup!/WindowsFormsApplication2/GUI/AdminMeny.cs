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

namespace WindowsFormsApplication2
{
    public partial class AdminMeny_window : Form
    {
        Thread th;      //Skapar tråd objekt så vi kan skapa nya fönster
        public AdminMeny_window()
        {
            InitializeComponent();
        }

        #region buttonClicks
        private void buttonAdminLoggaUt_Click(object sender, EventArgs e)       //Stänger AdminRutan och visar Inloggningsrutan igen
        {
            this.Close();                                                       //Stänger ner AdminMenyn
            th = new Thread(openNewLogInW);                                     //Skapar ett trådobjekt för att starta fönster
            th.SetApartmentState(ApartmentState.STA);                           //Skapar tråd och får ett enkeltrådad tillstånd
            th.Start();                                                         //Låter tråden starta med objektet som sätter igång nya fönstret
        }
        private void openNewLogInW(object obj)                                  //Sammarbetar med buttonAdminLoggaUt_Click funktionen
        {                                                                       //Applikation startar ett nytt fönster, LogInMeny(Form1)
            Application.Run(new Main_Form1());
        }

        private void buttonCreateContest_Click(object sender, EventArgs e)      //Öppnar upp ny AdminCreateContest
        {
            AdminCreateContest_window acc = new AdminCreateContest_window();
            acc.ShowDialog();                                                   //Öppnar upp ny SkapatävlingsFönster(AdminCreateContest)
        }

        private void buttonEraseContestW_Click(object sender, EventArgs e)
        {
            EraseContest_form1 ecw = new EraseContest_form1();
            ecw.ShowDialog();
        }

        private void buttonEditContest_Click(object sender, EventArgs e)
        {
            AdminEditContest_window aec = new AdminEditContest_window();
            aec.ShowDialog();
        }

        private void buttonSearchContest_Click(object sender, EventArgs e)
        {
            AdminSearch_window asw = new AdminSearch_window();
            asw.ShowDialog();
        }
        #endregion

        private void Backgroundpicture_adminmeny_Click(object sender, EventArgs e)
        {
           
        }
    }
}
