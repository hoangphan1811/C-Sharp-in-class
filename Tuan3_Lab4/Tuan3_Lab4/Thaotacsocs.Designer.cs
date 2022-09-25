namespace Tuan3_Lab4
{
    partial class Thaotacsocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.btncn = new System.Windows.Forms.Button();
            this.btnt2pt = new System.Windows.Forms.Button();
            this.lstKq = new System.Windows.Forms.ListBox();
            this.btncscd = new System.Windows.Forms.Button();
            this.btncslc = new System.Windows.Forms.Button();
            this.btnxptc = new System.Windows.Forms.Button();
            this.btnxd = new System.Windows.Forms.Button();
            this.btnxc = new System.Windows.Forms.Button();
            this.btnkt = new System.Windows.Forms.Button();
            this.gpmn = new System.Windows.Forms.GroupBox();
            this.btnqiut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSN = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpmn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(123, 69);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(324, 22);
            this.txtnhap.TabIndex = 1;
            this.txtnhap.TextChanged += new System.EventHandler(this.txtnhap_TextChanged);
            this.txtnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnhap_KeyPress);
            // 
            // btncn
            // 
            this.btncn.Location = new System.Drawing.Point(513, 69);
            this.btncn.Name = "btncn";
            this.btncn.Size = new System.Drawing.Size(101, 25);
            this.btncn.TabIndex = 2;
            this.btncn.Text = "Cập nhật";
            this.btncn.UseVisualStyleBackColor = true;
            this.btncn.Click += new System.EventHandler(this.btncn_Click);
            // 
            // btnt2pt
            // 
            this.btnt2pt.Location = new System.Drawing.Point(45, 33);
            this.btnt2pt.Name = "btnt2pt";
            this.btnt2pt.Size = new System.Drawing.Size(253, 27);
            this.btnt2pt.TabIndex = 3;
            this.btnt2pt.Text = "Tăng mỗi phần tử lên 2";
            this.btnt2pt.UseVisualStyleBackColor = true;
            this.btnt2pt.Click += new System.EventHandler(this.btnt2pt_Click);
            // 
            // lstKq
            // 
            this.lstKq.FormattingEnabled = true;
            this.lstKq.ItemHeight = 16;
            this.lstKq.Location = new System.Drawing.Point(34, 110);
            this.lstKq.Name = "lstKq";
            this.lstKq.Size = new System.Drawing.Size(260, 308);
            this.lstKq.TabIndex = 10;
            this.lstKq.SelectedIndexChanged += new System.EventHandler(this.lstKq_SelectedIndexChanged);
            // 
            // btncscd
            // 
            this.btncscd.Location = new System.Drawing.Point(45, 76);
            this.btncscd.Name = "btncscd";
            this.btncscd.Size = new System.Drawing.Size(253, 27);
            this.btncscd.TabIndex = 11;
            this.btncscd.Text = "Chọn số chẳn đầu";
            this.btncscd.UseVisualStyleBackColor = true;
            this.btncscd.Click += new System.EventHandler(this.btncscd_Click);
            // 
            // btncslc
            // 
            this.btncslc.Location = new System.Drawing.Point(45, 121);
            this.btncslc.Name = "btncslc";
            this.btncslc.Size = new System.Drawing.Size(253, 27);
            this.btncslc.TabIndex = 12;
            this.btncslc.Text = "Chọn số lẻ cuối";
            this.btncslc.UseVisualStyleBackColor = true;
            this.btncslc.Click += new System.EventHandler(this.btncslc_Click);
            // 
            // btnxptc
            // 
            this.btnxptc.Location = new System.Drawing.Point(45, 168);
            this.btnxptc.Name = "btnxptc";
            this.btnxptc.Size = new System.Drawing.Size(253, 27);
            this.btnxptc.TabIndex = 13;
            this.btnxptc.Text = "Xóa phần tử đang chọn";
            this.btnxptc.UseVisualStyleBackColor = true;
            this.btnxptc.Click += new System.EventHandler(this.btnxptc_Click);
            // 
            // btnxd
            // 
            this.btnxd.Location = new System.Drawing.Point(45, 217);
            this.btnxd.Name = "btnxd";
            this.btnxd.Size = new System.Drawing.Size(253, 27);
            this.btnxd.TabIndex = 14;
            this.btnxd.Text = "Xóa phần tử đầu";
            this.btnxd.UseVisualStyleBackColor = true;
            this.btnxd.Click += new System.EventHandler(this.btnxd_Click);
            // 
            // btnxc
            // 
            this.btnxc.Location = new System.Drawing.Point(45, 265);
            this.btnxc.Name = "btnxc";
            this.btnxc.Size = new System.Drawing.Size(253, 27);
            this.btnxc.TabIndex = 15;
            this.btnxc.Text = "Xóa phần tử cuối";
            this.btnxc.UseVisualStyleBackColor = true;
            this.btnxc.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnkt
            // 
            this.btnkt.Location = new System.Drawing.Point(90, 462);
            this.btnkt.Name = "btnkt";
            this.btnkt.Size = new System.Drawing.Size(524, 27);
            this.btnkt.TabIndex = 16;
            this.btnkt.Text = "Kết thúc";
            this.btnkt.UseVisualStyleBackColor = true;
            this.btnkt.Click += new System.EventHandler(this.btnkt_Click);
            // 
            // gpmn
            // 
            this.gpmn.Controls.Add(this.btnqiut);
            this.gpmn.Controls.Add(this.label7);
            this.gpmn.Controls.Add(this.label6);
            this.gpmn.Controls.Add(this.label5);
            this.gpmn.Controls.Add(this.label4);
            this.gpmn.Controls.Add(this.label3);
            this.gpmn.Controls.Add(this.label2);
            this.gpmn.Controls.Add(this.btnt2pt);
            this.gpmn.Controls.Add(this.btncscd);
            this.gpmn.Controls.Add(this.btnxc);
            this.gpmn.Controls.Add(this.btncslc);
            this.gpmn.Controls.Add(this.btnxd);
            this.gpmn.Controls.Add(this.btnxptc);
            this.gpmn.Location = new System.Drawing.Point(326, 120);
            this.gpmn.Name = "gpmn";
            this.gpmn.Size = new System.Drawing.Size(314, 323);
            this.gpmn.TabIndex = 17;
            this.gpmn.TabStop = false;
            this.gpmn.Text = "Menu";
            // 
            // btnqiut
            // 
            this.btnqiut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnqiut.Location = new System.Drawing.Point(288, 33);
            this.btnqiut.Name = "btnqiut";
            this.btnqiut.Size = new System.Drawing.Size(10, 10);
            this.btnqiut.TabIndex = 18;
            this.btnqiut.Text = "              ";
            this.btnqiut.UseVisualStyleBackColor = true;
            this.btnqiut.Click += new System.EventHandler(this.btnqiut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errSN
            // 
            this.errSN.ContainerControl = this;
            // 
            // Thaotacsocs
            // 
            this.AcceptButton = this.btncn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnqiut;
            this.ClientSize = new System.Drawing.Size(706, 526);
            this.Controls.Add(this.gpmn);
            this.Controls.Add(this.btnkt);
            this.Controls.Add(this.lstKq);
            this.Controls.Add(this.btncn);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.label1);
            this.Name = "Thaotacsocs";
            this.Text = "Thaotacsocs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Thaotacsocs_FormClosing);
            this.Load += new System.EventHandler(this.Thaotacsocs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Thaotacsocs_KeyDown);
            this.gpmn.ResumeLayout(false);
            this.gpmn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Button btncn;
        private System.Windows.Forms.Button btnt2pt;
        private System.Windows.Forms.ListBox lstKq;
        private System.Windows.Forms.Button btncscd;
        private System.Windows.Forms.Button btncslc;
        private System.Windows.Forms.Button btnxptc;
        private System.Windows.Forms.Button btnxd;
        private System.Windows.Forms.Button btnxc;
        private System.Windows.Forms.Button btnkt;
        private System.Windows.Forms.GroupBox gpmn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errSN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnqiut;
    }
}