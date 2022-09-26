using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Gobal Varible
        string[] ban = new string[] { "B1", "B2", "B3", "B4" };
        DataTable tbOrder;
        #endregion

        #region Event
        private void Form1_Load(object sender, EventArgs e)
        {
           
            tbOrder = new DataTable();
            cbbTenban.Items.AddRange(ban);
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quantity");
            tbOrder.PrimaryKey = new DataColumn[] { tbOrder.Columns["FoodName"] };

           
            dtgvOrder.DataSource = tbOrder;

            dtgvOrder.Columns[0].Width = (int)(dtgvOrder.Width * 0.4);
            dtgvOrder.Columns[1].Width = (int)(dtgvOrder.Width * 0.5);

        }
        private void cbbTenban_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbb = cbbTenban.SelectedItem.ToString();
            MessageBox.Show("Bạn đã chọn bàn: " + cbb, "Thônng báo", MessageBoxButtons.OK);
        }

        private void btnpmb_Click(object sender, EventArgs e)
        { 
            DataRow row;
            Button b = (Button)sender;
            //bool flag = true;
            //row = tbOrder.NewRow();

            //foreach (DataRow item in tbOrder.Rows)
            //{
            //    if (item[0].ToString() == b.Text)
            //    {
            //        flag = false;

            //        item[1] = int.Parse(item[1].ToString()) + 1;
            //        break;
            //    }
            //}
            //if (flag)
            //{
            //    row[0] = b.Text;
            //    row[1] = 1;
            //    tbOrder.Rows.Add(row);

            //}
            row = tbOrder.Rows.Find(b.Text);
            if (row == null)
            {
                DataRow d = tbOrder.NewRow();
                d["FoodName"] = b.Text;
                d["Quantity"] = 1;
                tbOrder.Rows.Add(d);
            }
            else
            {
                row["Quantity"] = int.Parse(row["Quantity"].ToString()) + 1;
            }

        }
        private void btnxoa_Click(object sender, EventArgs e)
        {

            tbOrder.Rows.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (cbbTenban.SelectedIndex + 1 == 0)
            {
                flag = false;
                MessageBox.Show("Vui lòng chọn bàn cần đặt", "Thông báo");
            }
            if (flag)
            {
                StreamWriter sw;
                SaveFileDialog sfd;
                string filename = "";
                sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filename = sfd.FileName;
                }
                else
                {
                    filename = @"D:\FileLog.txt";
                }

                if (!File.Exists(filename))
                {
                    sw = new StreamWriter(filename);

        
                    sw.WriteLine(String.Format("{0,-10}", "Bàn")
                       + String.Format("{0,-30}", dtgvOrder.Columns[0].HeaderText)
                      + String.Format("{0,-20}", dtgvOrder.Columns[1].HeaderText));

                    for (int i = 0; i < dtgvOrder.Rows.Count - 1; i++)
                    {
                        sw.WriteLine(String.Format("{0,-10}", cbbTenban.SelectedItem.ToString())
                           + String.Format("{0,-30}", dtgvOrder.Rows[i].Cells[0].Value)
                           + String.Format("{0,-20}", dtgvOrder.Rows[i].Cells[1].Value));
                    }
                    dtgvOrder.DataSource = null;
                    sw.Close();
                  
                }
                else
                {
                    
                     
                    sw = File.AppendText(filename);
                    sw.WriteLine("-----------------------------------------------------------");
                    for (int i = 0; i < dtgvOrder.Rows.Count - 1; i++)
                    {
                        sw.WriteLine(String.Format("{0,-10}", cbbTenban.SelectedItem.ToString())
                       + String.Format("{0,-30}", dtgvOrder.Rows[i].Cells[0].Value)
                       + String.Format("{0,-20}", dtgvOrder.Rows[i].Cells[1].Value));
                    }
                    sw.Close();
                }

            }
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewCell item in this.dtgvOrder.SelectedCells)
            {
                dtgvOrder.Rows.RemoveAt(item.RowIndex);
            }    
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSinhVien sv = new FrmSinhVien();
            sv.Show();
            this.Hide();
        }
    }
#endregion
}
