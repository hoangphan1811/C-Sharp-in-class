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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtTinh_Click(object sender, EventArgs e)
        {

            int st1 = int.Parse(txtN.Text);
            int st2 = int.Parse(txtM.Text);
            float kq1;
            float kq2;
            if (rdoUCLN.Checked)
            {
                for (kq1 = st1; kq1 >= 1; kq1--)
                {
                    if (st1 % kq1 == 0 && st2 % kq1 == 0)
                    {

                        break;

                    }

                }
                txtKQ.Text = kq1.ToString();


            }
            if (rdoBCNN.Checked)
            {
                for (kq2 = st1; kq2 <= st1 * st2; kq2++)
                {
                    if (kq2 % st1 == 0 && kq2 % st2 == 0)
                    {
                        break;
                    }
                }
                txtKQ.Text = kq2.ToString();
            }

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
           
            
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
