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
    public partial class Main_Form1 : Form
    {
        Dictionary<string, string> mapObj = new Dictionary<string, string>();
        Thread th;      //Skapar tråd objekt så vi kan skapa nya fönster
        public Main_Form1()
        {
            InitializeComponent();
            if (File.Exists("Inloggning.txt"))
            {
                using (StreamReader sr = new StreamReader("Inloggning.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] holder = line.Split(';');
                        mapObj.Add(holder[0], holder[1]);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tryToLoginAdmin(int choose)
        {
            foreach (var LogIn in mapObj)
            {
                if (LogIn.Key == UsernameTextBox.Text && LogIn.Value == PasswordTextBox.Text)
                {
                    this.Close();                                                     //Stänger ner InloggningsMenyn
                    if (choose == 1)
                    {
                        th = new Thread(openNewAdminMenuW);                               //Skapar ett trådobjekt för att starta fönster
                    }
                    else if (choose == 2)
                    {
                        th = new Thread(openNewJudgeMenuW);
                    }
                    th.SetApartmentState(ApartmentState.STA);                         //Skapar tråd och får ett enkeltrådad tillstånd
                    th.Start();                                                       //Låter tråden starta med objektet som sätter igång nya fönstret
                }
            }
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            MessageBox.Show("Fel Användarnamn eller Lösenord", "Inloggning", MessageBoxButtons.OK);
        }

        #region ButtonClicks
        private void buttonAvsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogInAdmin_Click(object sender, EventArgs e)       //Stänger inloggningsfönstret och öppnar upp ny AdminMeny
        {
            tryToLoginAdmin(1);
        }
        private void openNewAdminMenuW(object obj)                            //Sammarbetar buttonLogInAdmin_Click funktionen
        {                                                                     //Applikation startar ett nytt fönster, AdminMenyn(AdminMeny)
            Application.Run(new AdminMeny_window());
        }

        private void buttonHelp_Click(object sender, EventArgs e)             //Öppnar upp ny HelpWindow
        {                                              
            HelpWindow_form1 openHelpWindow = new HelpWindow_form1();                     
            openHelpWindow.ShowDialog();                                      //Öppnar upp ny HjälpFönster(HelpWindow)
        }

        private void buttonLogInJudge_Click(object sender, EventArgs e)       //Stänger inloggningsfönstret och öppnar upp ny AdminMeny
        {                                                                     //SE buttonLogInAdmin_Click KOMMENTARERNA FÖR DETALJERAD BESKRIVNING
            tryToLoginAdmin(2);
        }

        private void openNewJudgeMenuW(object obj)                            //Sammarbetar med buttonLogInJudge_Click funktionen
        {                                                                     
            Application.Run(new JudgeMenu());
        }

        #endregion

        private void asdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Judg_picture_box_Click(object sender, EventArgs e)
        {
            tryToLoginAdmin(2);
        }

        private void admin_picture_box_Click(object sender, EventArgs e)
        {
            tryToLoginAdmin(1);
        }

        private void hjälpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow_form1 openHelpWindow = new HelpWindow_form1();
            openHelpWindow.ShowDialog();                                      //Öppnar upp ny HjälpFönster(HelpWindow)
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void divin_logo_Click(object sender, EventArgs e)
        {

        }
    }
}
