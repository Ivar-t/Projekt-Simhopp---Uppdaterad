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
        String str = "";
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
            labelinfodeltagare.Text = str;
            
          
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
                labelinfodeltagare.Text = clientobj.streamReader.ReadLine();
                str = labelinfodeltagare.Text;
                if (str.StartsWith("Vinn"))
                {
                    labelinfodeltagare.Font = new Font("Latin", 22);
                    labelinfodeltagare.ForeColor = System.Drawing.Color.Green;
                    label2.Visible = false;
                    label3.Visible = false;
                    buttonSubmitScore.Text = "Avsluta";
                }
                else if (str.StartsWith("quit"))
                {
                    clientobj.networkStream.Close();
                    clientobj.socketForServer.Close();
                    this.Close();
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
