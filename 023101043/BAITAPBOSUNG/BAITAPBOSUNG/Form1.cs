using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPBOSUNG
{
    public partial class Form1 : Form
    {
        int tg;
        Color mau;
        bool xanh = false, red = false, vang = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buthienthi_Click(object sender, EventArgs e)
        {
            timer1.Start();
            xanh = true;
            picxanh.Visible = xanh;
            picdo.Visible = red;
            picvang.Visible = vang;
            if  (xanh)
            {
                tg = int.Parse(txtxanh.Text);
                vang = false;
                red = false;
                lblthoigian.ForeColor = Color.Green;
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, picxanh.Width, picvang.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picxanh.Width - 3, picxanh.Height - 3);
            Region rg = new Region(gp);
            picxanh.Region = rg;
            picdo.Region = rg;
            picvang.Region = rg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tg--;
            lblthoigian.Text = tg.ToString();
            lblthoigian.ForeColor = mau;
            if (xanh && tg == 0)
            {
                xanh = false;
                vang = true;
                tg = 5;
                picvang.Visible = vang;
                picxanh.Visible = xanh;
                mau = Color.Yellow;
            }
            if (vang && tg == 0)
            {
                vang = false;
                red = true;
                tg = int.Parse(txtdo.Text);
                picvang.Visible = vang;
                picdo.Visible = red;
                mau = Color.Red;
            }
            if (red && tg == 0)
            {
                red = false;
                xanh = true;
                tg = int.Parse(txtxanh.Text);
                picxanh.Visible = xanh;
                picdo.Visible = red;
                mau = Color.Green;
            }
        }
    }
}
