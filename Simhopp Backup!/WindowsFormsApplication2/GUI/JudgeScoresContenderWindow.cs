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
using ClassLibrary1;

namespace WindowsFormsApplication2
{ //Viktor was here
    public partial class JudgeScoresContenderWindow : Form
    {
        Thread th;
        double show = 0;
        string str = "";
        int extra = 0;
        string[] AdminInfo = new string[4];
        private JudgeMenu judgeMenuObj = null; //mio
        
        public ClassClient clientobj = new ClassClient();
        public JudgeScoresContenderWindow(JudgeMenu instanceOfJudgeConnectionCreatedInJudgeMenu)
        {
            InitializeComponent();
            clientobj.connectToServerfunc();
            judgepointstrackbar.Minimum = 0;
            judgepointstrackbar.Maximum = 20;
            judgepointstrackbar.TickStyle = TickStyle.BottomRight;
            judgepointstrackbar.TickFrequency = 1;
            labelshowpoint.Text = "0";
            judgeMenuObj = instanceOfJudgeConnectionCreatedInJudgeMenu;

            str = clientobj.streamReader.ReadLine();
            AdminInfo = str.Split(' ');
            labelNamn.Text = AdminInfo[0];
            labelNation.Text = AdminInfo[1];
            labelHoppNamn.Text = AdminInfo[2];
            labelHoppnr.Text = AdminInfo[3];

        }

        #region buttonClicks
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmitScore_Click(object sender, EventArgs e)
        {
            try
            {
                clientobj.streamWriter.WriteLine(show);
                clientobj.streamWriter.Flush();
                str = clientobj.streamReader.ReadLine();
                AdminInfo = str.Split(' ');
                if (str.StartsWith("Vinnare"))
                {
                    MessageBox.Show("Vinnaren är: " + str, "Tävlingen är avslutad", MessageBoxButtons.OK);

                    buttonSubmitScore.Text = "Avsluta";

                    extra = 1;
                }
                else if (AdminInfo[0].Equals("quit") || extra == 1 )
                {
                    clientobj.networkStream.Close();
                    clientobj.socketForServer.Close();
                    this.Close();
                }
                else
                {
                    labelNamn.Text = AdminInfo[0];
                    labelNation.Text = AdminInfo[1];
                    labelHoppNamn.Text = AdminInfo[2];
                    labelHoppnr.Text = AdminInfo[3];
                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
           


        }

        #endregion
        private void judgepointstrackbar_Scroll(object sender, EventArgs e)
        {
            show = judgepointstrackbar.Value;
            show = show * 0.5;
            labelshowpoint.Text = show.ToString();
        }
    }
}
