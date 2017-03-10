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
using ClassLibrary1;
using WindowsFormsApplication2.Klasser;
using System.Globalization;

namespace WindowsFormsApplication2
{
    public partial class AdminMeny_window : Form
    {
        List<string> contestNameFiles = new List<string>();
        Thread th;      //Skapar tråd objekt så vi kan skapa nya fönster
        public AdminMeny_window()
        {
            InitializeComponent();
                using (StreamReader sr = new StreamReader("ListOfContest.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        contestNameFiles.Add(line);
                    }
                    int q = 0;
                    foreach (var x in contestNameFiles)
                    {
                        contestComboBox.Items.Insert(q, x);
                        q++;
                    }
            }
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

        private void buttonStartContest_Click(object sender, EventArgs e)   // hämtar all tävlingsinformation och lägger det i contest objekt till judgeclient
        {
            Contest _contest = new Contest();
            int underJuding;
            int contestFinished = 0;
            String infoStringforJudges = String.Empty, PointString= String.Empty;

            if (File.Exists(contestComboBox.Text + ".txt"))
            {
                using (StreamReader sr = new StreamReader(contestComboBox.Text + ".txt"))
                {
                    string line = "";
                    line = sr.ReadLine();
                    string[] holder = line.Split(';');
                    _contest.Name = holder[0];
                    _contest.Date = holder[1];
                    _contest.GenderContest = holder[2];
                    _contest.Jumpheight = Convert.ToInt32(holder[3]);
                    underJuding = Convert.ToInt32(holder[4]);
                    contestFinished = Convert.ToInt32(holder[5]);

                    while ((line = sr.ReadLine()) != null && line.CompareTo("") != 0)
                    {
                        Contender _contender = new Contender();
                        holder = line.Split(';');
                        _contender.Name = holder[0];
                        _contender.Id = Convert.ToInt32(holder[1]);
                        _contender.Nationality = holder[2];
                        for (int i = 3; i < holder.Length; i=i+2)
                        {
                            Jump _jump = new Jump();
                            _jump.Jumpstyle = holder[i];
                            _jump.jumpDifficulty = double.Parse(holder[i+1], CultureInfo.InvariantCulture);
                            _contender.add_jump(_jump);
                        }
                        _contest.add_contender(_contender);
                    }
                    _contest.printContest();
                }
            }
            else
            {
                MessageBox.Show("Tävling finns inte", "Starta tävling", MessageBoxButtons.OK);
            }
            HandleTcpClient.TcpServer server = HandleTcpClient.TcpServer.Instance(); // mio Startar servern och börjar lyssna efter domarklienter
            int j = 0;

            StartContest start = new StartContest();
            while (contestFinished == 0)
            {
                start.gogogo(server, _contest, infoStringforJudges, PointString, contestFinished);
            }
        }
        #endregion

        private void Backgroundpicture_adminmeny_Click(object sender, EventArgs e)
        {
           
        }


    }
}
