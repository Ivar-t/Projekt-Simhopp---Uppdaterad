using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AdminSelectedContest_window : Form
    {
        public AdminSelectedContest_window()
        {
            InitializeComponent();
        }

        public AdminSelectedContest_window(string dataRecieved)
        {
            InitializeComponent();
            contestInfoTextBox.Text = dataRecieved;
        }

        #region buttonClicks
        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
