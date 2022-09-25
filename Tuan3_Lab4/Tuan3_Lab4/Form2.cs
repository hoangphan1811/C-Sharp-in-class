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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
          
        }
        private Form1 mainForm = null;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bntcn_Click(object sender, EventArgs e)
        {

            if (txtcv.Text == "")
            {
                txtcv.Text = this.mainForm.getlbcv;
            }
            else
            {
                this.mainForm.getlbcv = txtcv.Text;
               
            }

            if (txttt.Text == "")
            {
                
                txttt.Text = this.mainForm.getlbtt;
            }
            else
            {
                this.mainForm.getlbtt = txttt.Text;
            }
            if (txtchr.Text == "")
            {
                txtchr.Text = this.mainForm.getlbchr;
            }
            else
            {
                this.mainForm.getlbchr = txtchr.Text;
              
            }
            if (txttr.Text == "")
            {
                txttr.Text = this.mainForm.getlbtr;
               
            }
            else
            {
                this.mainForm.getlbtr = txttr.Text;
            }

            this.Close();
            

        }

        private void txtcv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if(e.KeyChar==8)
            {
                e.Handled = false;
            }    
        }
    }
}
