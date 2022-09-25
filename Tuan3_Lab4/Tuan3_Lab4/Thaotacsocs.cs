using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_Lab4
{
    public partial class Thaotacsocs : Form
    {
        public Thaotacsocs()
        {
            InitializeComponent();
  
        }

   
        private void txtnhap_TextChanged(object sender, EventArgs e)
        {
        //    Control ctrSN = (Control)sender;
        //    if (ctrSN.Text.Length > 0)
        //    {
        //        if (!Char.IsDigit(ctrSN.Text[ctrSN.Text.Length - 1]))
        //        {
        //            this.errSN.SetError(ctrSN, "Vui lòng nhập số nguyên");
        //        }
        //        else
        //            this.errSN.Clear();
        //    }
        }

        private void Thaotacsocs_Load(object sender, EventArgs e)
        {
          
        }

        private void lstKq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Thaotacsocs_KeyDown(object sender, KeyEventArgs e)
        {
  
        }

        private void Thaotacsocs_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    e.Cancel =true;
            
        }

        private void btncn_Click(object sender, EventArgs e)
        {
         
            lstKq.Items.Add(txtnhap.Text);
            txtnhap.Text = "";
            txtnhap.Focus();
        }

        private void btnt2pt_Click(object sender, EventArgs e)
        {
            int n = lstKq.Items.Count;
            for(int i=0;i<n;i++)
            {
                if (lstKq.Items[i].ToString()=="")
                {
                    MessageBox.Show("Trong danh sách có phần không phải số nguyên\nVui long kết thúc và nhập lại!!");
                }    
                else
                {
                    int temp = int.Parse(lstKq.Items[i].ToString()) + 2;
                    lstKq.Items.RemoveAt(i);
                    lstKq.Items.Insert(i, temp.ToString());
                }
            }    
            
        }

        private void btnqiut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncscd_Click(object sender, EventArgs e)
        {
            int n = lstKq.Items.Count;
            for(int i=0;i<n;i++)
            {
                if(int.Parse(lstKq.Items[i].ToString())%2==0)
                {
                    string s = lstKq.Items[i].ToString();
                    lstKq.SelectedItem = s;
                    break;
                }    
            }    
        }

        private void btncslc_Click(object sender, EventArgs e)
        {
            int n = lstKq.Items.Count;
            for(int i =n-1;i>=0;i--)
            {
                if (int.Parse(lstKq.Items[i].ToString())%2!=0)
                {
                    string s = lstKq.Items[i].ToString();
                    lstKq.SelectedItem = s;  
                    break;
                }    
            }    
        }

        private void btnkt_Click(object sender, EventArgs e)
        {
            lstKq.Items.Clear();
        }

        private void txtnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            if (e.KeyChar == 32 && e.KeyChar == 13)
            {
                e.Handled = true;

            }
        }

        private void btnxptc_Click(object sender, EventArgs e)
        {
            int n = lstKq.SelectedItems.Count;
            for (int i =n-1 ; i >=0;i--)
            {
                lstKq.Items.Remove(lstKq.SelectedItems[i].ToString());
            }    
        }

        private void btnxd_Click(object sender, EventArgs e)
        {
            lstKq.Items.Remove(lstKq.Items [0].ToString());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int n = lstKq.Items.Count;
            lstKq.Items.Remove(lstKq.Items[n - 1].ToString());
        }

    }
}
