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
    public partial class EraseContest_form1 : Form
    {
        public EraseContest_form1()
        {
            InitializeComponent();
        }

        #region buttonClicks
        private void buttonCancelEraseContest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void buttonEraseContest_Click(object sender, EventArgs e)
        {
            //Kod här som frågar om man vill radera tävling(OK/CANCEL)
            //..

            //Kod här för att slänga bort vald tävlingsfil, if statement.. Släng om click_OK
            //..
            //Kod här som öppnar ruta som förklarar att tävling är raderad
            //..

            this.Close();
        }
    }
}
