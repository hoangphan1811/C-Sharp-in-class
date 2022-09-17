using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCong_Click(object sender, EventArgs e)
        {
            float sothu1 = float.Parse(txtN.Text);
            float sothu2 = float.Parse(txtM.Text);
            float rs = sothu1 + sothu2;
            txtKQ.Text = rs.ToString();

        }

        private void bntTru_Click(object sender, EventArgs e)
        {
            float sothu1 = float.Parse(txtN.Text);
            float sothu2 = float.Parse(txtM.Text);
            float rs = sothu1 - sothu2;
            txtKQ.Text = rs.ToString();
        }

        private void bntNhan_Click(object sender, EventArgs e)
        {
            float sothu1 = float.Parse(txtN.Text);
            float sothu2 = float.Parse(txtM.Text);
            float rs = sothu1 * sothu2;
            txtKQ.Text = rs.ToString();
        }

        private void bntChia_Click(object sender, EventArgs e)
        {
            float sothu1 = float.Parse(txtN.Text);
            float sothu2 = float.Parse(txtM.Text);
            float rs = sothu1 / sothu2;
            txtKQ.Text = rs.ToString();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            txtN.Text = txtM.Text = txtKQ.Text = "";
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
    }
}
