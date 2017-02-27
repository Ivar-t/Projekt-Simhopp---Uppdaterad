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
    public partial class AdminEditContest_window : Form
    {
        Thread th;
        public AdminEditContest_window()
        {
            InitializeComponent();
        }

        #region buttonClicks
        private void buttonCancelEditContest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditContest_Click(object sender, EventArgs e)
        {
            //Kod här som läser in vald fil till contenderobjekt in i en contenderList
            //..
            //Kod här som öppnar fönster som säger att tävling inte existerar eller redan är avslutad(OK)
            //..
            this.Close();
            th = new Thread(openAddContendersWindowW);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openAddContendersWindowW()
        {
            Application.Run(new AddContenders_Window());
        }
        #endregion
    }
}
