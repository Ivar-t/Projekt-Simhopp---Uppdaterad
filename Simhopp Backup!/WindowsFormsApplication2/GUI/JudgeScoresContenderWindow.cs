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
    public partial class JudgeScoresContenderWindow : Form
    {
        Thread th;
        public JudgeScoresContenderWindow()
        {
            InitializeComponent();
        }

        #region buttonClicks
        private void buttonS0_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 0.5";
        }

        private void buttonS1_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 1";
        }

        private void buttonS1_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 1.5";
        }

        private void buttonS2_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 2";
        }

        private void buttonS2_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 2.5";
        }

        private void buttonS3_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 3";
        }

        private void buttonS3_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 3.5";
        }

        private void buttonS4_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 4";
        }

        private void buttonS4_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 4.5";
        }

        private void buttonS5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 5";
        }

        private void buttonS5_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 5.5";
        }

        private void buttonS6_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 6";
        }

        private void buttonS6_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 6.5";
        }

        private void buttonS7_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 7";
        }

        private void button7_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 7.5";
        }

        private void buttonS8_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 8";
        }

        private void buttonS8_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 8.5";
        }

        private void buttonS9_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 9";
        }

        private void buttonS9_5_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 9.5";
        }

        private void buttonS10_Click(object sender, EventArgs e)
        {
            labelJudgeScore.Text = "Score: 10";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmitScore_Click(object sender, EventArgs e)
        {
            //Kod här som slänger in samlat poäng från domarna till ett av Contenderobjektets hopp, JumpList
            //..
            //Statement för när listan är slut och tävlingen är avslutad, vinnare hittas och listan sparas till fil
            //..
            this.Close();
            th = new Thread(openJudgeScoresContenderWindowW);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openJudgeScoresContenderWindowW(object obj)
        {
            Application.Run(new JudgeScoresContenderWindow());
        }
        #endregion
    }
}
