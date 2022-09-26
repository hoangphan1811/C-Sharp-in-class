using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_Lab5
{
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
        }




        #region Methods
        void Add()
        {
            ListViewItem lvst = lwSv.Items.Add(txtname.Text);
            lvst.SubItems.Add(dtpk1.Value.ToShortDateString());
            lvst.SubItems.Add(txtaddres.Text);
            lvst.SubItems.Add(txtNumb.Text);
            txtname.Text = txtaddres.Text = txtNumb.Text = "";   
          
         

        }
        void Del()
        {
            if(lwSv.SelectedItems.Count > 0)
            {
                lwSv.Items.Remove(lwSv.SelectedItems[0]);
            }    
        }   
        void Edit()
        {

            if (lwSv.SelectedItems.Count>0)
            {
                lwSv.SelectedItems[0].SubItems[0].Text = txtname.Text;
                lwSv.SelectedItems[0].SubItems[1].Text = dtpk1.Value.ToShortDateString();
                lwSv.SelectedItems[0].SubItems[2].Text = txtaddres.Text;
                lwSv.SelectedItems[0].SubItems[3].Text = txtNumb.Text;

            }

        }
        #endregion

        #region Event
        private void btnquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            Del();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void lwSv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwSv.SelectedItems.Count > 0)
            {
                txtname.Text = lwSv.SelectedItems[0].SubItems[0].Text;
                dtpk1.Text = lwSv.SelectedItems[0].SubItems[1].Text;
                txtaddres.Text = lwSv.SelectedItems[0].SubItems[2].Text;
                txtNumb.Text = lwSv.SelectedItems[0].SubItems[3].Text;
            }
        }
        #endregion

    
    }
}
