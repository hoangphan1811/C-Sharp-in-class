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
    public partial class FrSinhVien : Form
    {
        public FrSinhVien()
        {
            InitializeComponent();
        }

        private void btncn_Click(object sender, EventArgs e)
        {
            lstA.Items.Add(txtnhap.Text);
            txtnhap.Text = "";
            txtnhap.Focus();

        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            int n = lstA.SelectedItems.Count;
            for(int i=0; i <= n-1; i++)
            {
                lstB.Items.Add(lstA.SelectedItems[i].ToString());
            } 
            for( int j=n-1;j>=0;j--)
            {
                lstA.Items.RemoveAt(j);
            }    
                
        }

        private void bntquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntsp_Click(object sender, EventArgs e)
        {
            int n = lstA.Items.Count;
            for(int i=0;i<=n-1;i++)
            {
                lstB.Items.Add(lstA.Items[i].ToString());
            }    
            for(int j=n-1;j>=0;j--)
            {
                lstA.Items.RemoveAt(j);
            }    
        }

        private void btnsangtrai_Click(object sender, EventArgs e)
        {
            int n = lstB.SelectedItems.Count; 
            for(int i=0;i<=n-1;i++)
            {
                lstA.Items.Add(lstB.SelectedItems[i].ToString());
            }    
            for(int j=n-1;j>=0;j--)
            {
                lstB.Items.RemoveAt(j);
            }    
        }

        private void btntst_Click(object sender, EventArgs e)
        {
            int n = lstB.Items.Count;
            for(int i=0;i<n-1;i++)
            {
                lstA.Items.Add(lstB.Items[i].ToString());
            }    
            for(int j=n-1;j>=0;j--)
            {
                lstB.Items.RemoveAt(j);
            }    
        }

        private void btnkt_Click(object sender, EventArgs e)
        {
            lstA.Items.Clear();
            lstB.Items.Clear();

        }
    }
}
