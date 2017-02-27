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
    public partial class JudgeMenu : Form
    {
        Thread th;      //Skapar tråd objekt så vi kan skapa nya fönster
        public JudgeMenu()
        {
            InitializeComponent();
        }

        #region buttonClicks
        private void buttonJudgeLogOut_Click(object sender, EventArgs e)        //Stänger JudgeMenyn och öppnar upp ny LogInMeny(Form1)
        {
            this.Close();                                                       //Stänger ner JudgeMenyn
            th = new Thread(openNewLogInW);                                     //Skapar ett trådobjekt för att starta fönster
            th.SetApartmentState(ApartmentState.STA);                           //Skapar tråd och får ett enkeltrådad tillstånd
            th.Start();                                                         //Låter tråden starta med objektet som sätter igång nya fönstret
        }
        private void openNewLogInW(object obj)                                  //Sammarbetar med buttonJudgeLogOut_Click funktionen
        {                                                                       //Applikation startar ett nytt fönster, AdminMenyn(AdminMeny)
            Application.Run(new Main_Form1());
        }

        private void buttonJudgeContest_Click(object sender, EventArgs e)
        {
            JudgeScoresContenderWindow jscw = new JudgeScoresContenderWindow();
            jscw.ShowDialog();
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void JudgeMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tavlings_id_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
