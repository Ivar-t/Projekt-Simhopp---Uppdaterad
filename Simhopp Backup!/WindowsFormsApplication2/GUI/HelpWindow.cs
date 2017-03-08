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
    public partial class HelpWindow_form1 : Form
    {
        public HelpWindow_form1()
        {
            InitializeComponent();
        }

        private void helpPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics Tutorial = e.Graphics;

            Font drawFont = new Font("Comic Sans MS", 10);
            Font drawFontTot = new Font("Comic Sans MS", 18);
            SolidBrush drawBrush = new SolidBrush(Color.WhiteSmoke);

            Tutorial.DrawString("HJÄLP", drawFontTot, drawBrush, new PointF(170, 8));
            Tutorial.DrawString("HjälpandeTextHjälpandeTextHjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 50));
            Tutorial.DrawString("HjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 70));
            Tutorial.DrawString("HjälpandeTextHjälpandeTextHjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 90));
            Tutorial.DrawString("HjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 110));
            Tutorial.DrawString("HjälpandeTextHjälpandeTextHjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 130));
            Tutorial.DrawString("HjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 150));
            Tutorial.DrawString("HjälpandeTextHjälpandeTextHjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 170));
            Tutorial.DrawString("HjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 190));
            Tutorial.DrawString("HjälpandeTextHjälpandeTextHjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 210));
            Tutorial.DrawString("HjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 230));
            Tutorial.DrawString("HjälpandeTextHjälpandeTextHjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 250));
            Tutorial.DrawString("HjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 270));
            Tutorial.DrawString("HjälpandeTextHjälpandeTextHjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 290));
            Tutorial.DrawString("HjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 310));
            Tutorial.DrawString("HjälpandeTextHjälpandeTextHjälpandeTextHjälpandeText", drawFont, drawBrush, new PointF(15, 330));

        }

        #region buttonClicks
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void HelpWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
