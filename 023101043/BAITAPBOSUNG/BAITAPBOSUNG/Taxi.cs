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
    public partial class Taxi : Form
    {
        public Taxi()
        {
            InitializeComponent();
        }
        void xoa()
        {
            lblmuc1.Text = "";
            lblmuc2.Text = "";
            lblmuc3.Text = "";
            lblmuc4.Text = "";
            lbltongtien.Text = "";
            lbltongtien.ForeColor = Color.Red;
            lbltongtien.Font = new Font("Arial", 14, FontStyle.Bold);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float n;
            float sotien = 0;
            xoa();
            n = float.Parse(txtkm.Text);
            if (n <= 1)
            {
                sotien = 20000;
                lblmuc1.Text = "Số tiền mức 1 là:" + sotien.ToString("#,###");
                lbltongtien.Text = "Tổng tiền phải trả là: " + sotien.ToString("#,###");
            }
            if (n > 1 && n <= 12)
            {
                sotien = 20000;
                lblmuc1.Text = "Số tiền mức 1 là:" + sotien.ToString("#,###");
                sotien += (n - 1) * 16000;
                lblmuc2.Text= "Số tiền mức 2 là:"+((n-1)*16000).ToString("#,###");
                lbltongtien.Text = "Tổng tiền phải trả là: " + sotien.ToString("#,###");
            }
            if (n > 12 && n <= 26)
            {
                sotien = 20000;
                lblmuc1.Text = "Số tiền mức 1 là:" + sotien.ToString("#,###");
                sotien += 11 * 16000;
                lblmuc2.Text = "Số tiền mức 2 là:" + (11 * 16000).ToString("#,###");
                sotien += (n - 12) * 15500;
                lblmuc3.Text = "Số tiền mức 3 là:" + ((n - 12) * 15500).ToString("#,###");
                lbltongtien.Text="Tổng tiền phải trả lại là: "+sotien.ToString("#,###");
            }
            if (n > 26)
            {
                sotien = 20000;
                lblmuc1.Text = "Số tiền mức 1 là:" + sotien.ToString("#,###");
                sotien += 11 * 16000;
                lblmuc2.Text = "Số tiền mức 2 là:" + (11 * 16000).ToString("#,###");
                sotien += 13 * 15500;
                lblmuc3.Text = "Số tiền mức 3 là:" + (13 * 15500).ToString("#,###");
                sotien += (n - 26) * 15500;
                lblmuc4.Text = "Số tiền mức 4 là:" + ((n - 26) * 13500).ToString("#,###");
                lbltongtien.Text = "Tổng tiền phải trả lại là: " + sotien.ToString("#,###");
            }
        }

        private void Taxi_Load(object sender, EventArgs e)
        {
            xoa();
        }
    }
}
