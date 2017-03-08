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
{
    public partial class JudgeScoresContenderWindow : Form
    {
        Thread th;
        private JudgeMenu judgeMenuObj = null; //mio
        public ClassClient clientobj = new ClassClient();
        public JudgeScoresContenderWindow(JudgeMenu instanceOfJudgeConnectionCreatedInJudgeMenu)
        {
            InitializeComponent();
            clientobj.connectToServerfunc();
            judgeMenuObj = instanceOfJudgeConnectionCreatedInJudgeMenu;
            String str = "";
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
            
            clientobj.streamWriter.WriteLine(Judgepointscombobox.Text);
            clientobj.streamWriter.Flush();
            Judgepointscombobox.SelectedIndex = -1;
            labelinfodeltagare.Text = clientobj.streamReader.ReadLine();
            
            
        }
        
        #endregion
    }
}
