using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tuan3_Lab4
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();


        }
        public string getlbcv
        {
            get { return lbcv.Text; }
            set { lbcv.Text = value; }
        }
        public string getlbtt
        {
            get { return lbtt.Text; }
            set { lbtt.Text = value; }
        }
        public string getlbchr
        {
            get { return lbchr.Text; }
            set { lbchr.Text = value; }
        }
        public string getlbtr
        {
            get { return lbtr.Text; }
            set { lbtr.Text = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public double TinhTien()
        {

            double tinhtien = 0, tiencv = 0, tientt = 0, tienchr = 0, tientr = 0;
            int sl = int.Parse(nbrtr.Value.ToString());
            if (cbcv.Checked)
            {
                tiencv = double.Parse(lbcv.Text);
            }
            if (cbtt.Checked)
            {
                tientt = double.Parse(lbtt.Text);
            }
            if (cbchr.Checked)
            {
                tienchr = double.Parse(lbchr.Text);
            }
            if (sl > 0)
            {
                tientr = double.Parse(lbtr.Text);
            }
            tinhtien = tiencv + tientt + tienchr + tientr;
            return tinhtien;

        }

        private void bntTinh_Click(object sender, EventArgs e)
        {

            lbxKH.Items.Add(txtKH.Text + "  :  " + TinhTien());
            if(txtKH.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên","Thông báo");
            }    
            txtTT.Text = TinhTien().ToString();

        }
        public void WriteFile()
        {
            using(SaveFileDialog sfd  = new SaveFileDialog() {Filter="Text Documents|*.txt" ,ValidateNames = true})
            if(sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                         sw.WriteLine(txtKH.Text + "  :  " + TinhTien());
                        sw.Close();
                        MessageBox.Show("Bạn đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
               }     
        }
        public  void ReadFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true,Multiselect=false })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr= new StreamReader(ofd.FileName))
                    {
                      string  s =  sr.ReadToEnd();
                        lbxKH.Items.Add(s);
                        sr.Close();
                    }
                }
        }    
        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        { 

            Form2 frm2 = new Form2(this);
            frm2.Show();   

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            WriteFile();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           txtKH.Text=txtTT.Text="";
            cbcv.Checked = false;
            cbtt.Checked = false;
            cbchr.Checked = false;
            nbrtr.Value = 0;


        }

        private void lbxKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbxKH.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           ReadFile();
        }

        private void txtKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
