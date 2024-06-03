using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_tinhtong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txt1.Text);
            so2 = Convert.ToDouble(txt2.Text);
            ketqua = so1 + so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();

        }

        private void btntinhtich_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txt1.Text);
            so2 = Convert.ToDouble(txt2.Text);
            ketqua = so1 + so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();
        }

        private void btntinhhieu_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txt1.Text);
            so2 = Convert.ToDouble(txt2.Text);
            ketqua = so1 + so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();
        }

        private void btntinhthuong_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txt1.Text);
            so2 = Convert.ToDouble(txt2.Text);
            if (so2 == 0)
            {
                //báo lỗi
                //txtKQ.Text="không thể chia cho 0";
                MessageBox.Show("không thể chia cho 0", "thông báo lỗi", MessageBoxButtons.OKCancel);
            }
            else
            {
                ketqua = so1 / so2;
                txtKQ.Text = ketqua.ToString();
                lblKQ.Text = ketqua.ToString();
            }


        }
    }
}