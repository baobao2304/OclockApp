using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using ClassLibraryOfBao;
namespace ClassLibraryOfBao
{
    public partial class UserControlOclock : UserControl
    {
        public UserControlOclock()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
            if(btnStart.Text == "Start")
            {
                btnStart.Text = "Stop";
                timer1.Start();
                
            }
            else if (btnStart.Text == "Stop")
            {
                btnStart.Text = "Start";
                timer1.Stop();

            }
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
String gio = lbGio.Text;
            String dau1 = ":";
            String phut = lbPhut.Text;
            String dau2 = ":";
            String giay = lbGiay.Text;
            String miligiay = lbMiliGiay.Text;
            String chuoi = gio + " " + dau1 + " " + phut + " " + dau2 + " " + giay + " " + miligiay;
            //label1.Text = chuoi;
            //timer1.Start();
            Class1 a = new Class1();
            a.GhiFile(chuoi);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int miligiay = int.Parse(lbMiliGiay.Text);
            int giay = int.Parse(lbGiay.Text);
            int phut = int.Parse(lbPhut.Text);
            int gio = int.Parse(lbGio.Text);
            miligiay++;

            if (miligiay > 100)
            {
                miligiay = 0;
                giay++;
            }
            if (giay > 59)
            {
                giay = 0;
                phut++;
            }
            if (phut > 59)
            {
                phut = 0;
                gio++;
            }
            if (gio > 23)
            {
                gio = 0;
                phut = 0;
                giay = 0;
                miligiay = 0;
            }
            if (miligiay < 10)
                lbMiliGiay.Text = "0" + miligiay;
            else
                lbMiliGiay.Text = miligiay + "";

            if (giay < 10)
                lbGiay.Text = "0" + giay;
            else
                lbGiay.Text = giay + "";

            if (phut < 10)
                lbPhut.Text = "0" + phut;
            else
                lbPhut.Text = phut + "";

            if (gio < 10)
                lbGio.Text = "0" + gio;
            else
                lbGio.Text = gio + "";
        }
    }
}
