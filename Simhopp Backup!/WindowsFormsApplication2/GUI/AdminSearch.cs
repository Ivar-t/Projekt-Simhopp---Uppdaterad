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
    public partial class AdminSearch_window : Form
    {
        Thread th;
        public AdminSearch_window()
        {
            InitializeComponent();
        }

        #region buttonClicks
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Kod här som läser in vald fil och skriver ut det på fönstret AdminSelectedContest
            //..
            //Kod här för ruta om programmet inte hittar vald tävling(OK)
            //..
            this.Close();
            th = new Thread(openAdminSelectedContestW);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAdminSelectedContestW()
        {
            Application.Run(new AdminSelectedContest_window());
        }
        #endregion
    }
}
