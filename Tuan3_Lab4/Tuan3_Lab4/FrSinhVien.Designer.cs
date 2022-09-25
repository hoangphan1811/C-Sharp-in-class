namespace Tuan3_Lab4
{
    partial class FrSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncn = new System.Windows.Forms.Button();
            this.btnsangtrai = new System.Windows.Forms.Button();
            this.btntst = new System.Windows.Forms.Button();
            this.btntsp = new System.Windows.Forms.Button();
            this.btnsp = new System.Windows.Forms.Button();
            this.btnkt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.bntquit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(185, 82);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(278, 22);
            this.txtnhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách sinh viên";
            // 
            // btncn
            // 
            this.btncn.Location = new System.Drawing.Point(480, 74);
            this.btncn.Name = "btncn";
            this.btncn.Size = new System.Drawing.Size(100, 39);
            this.btncn.TabIndex = 3;
            this.btncn.Text = "Cập nhật";
            this.btncn.UseVisualStyleBackColor = true;
            this.btncn.Click += new System.EventHandler(this.btncn_Click);
            // 
            // btnsangtrai
            // 
            this.btnsangtrai.Location = new System.Drawing.Point(355, 191);
            this.btnsangtrai.Name = "btnsangtrai";
            this.btnsangtrai.Size = new System.Drawing.Size(69, 44);
            this.btnsangtrai.TabIndex = 4;
            this.btnsangtrai.Text = "<";
            this.btnsangtrai.UseVisualStyleBackColor = true;
            this.btnsangtrai.Click += new System.EventHandler(this.btnsangtrai_Click);
            // 
            // btntst
            // 
            this.btntst.Location = new System.Drawing.Point(355, 270);
            this.btntst.Name = "btntst";
            this.btntst.Size = new System.Drawing.Size(69, 44);
            this.btntst.TabIndex = 5;
            this.btntst.Text = "<<";
            this.btntst.UseVisualStyleBackColor = true;
            this.btntst.Click += new System.EventHandler(this.btntst_Click);
            // 
            // btntsp
            // 
            this.btntsp.Location = new System.Drawing.Point(269, 270);
            this.btntsp.Name = "btntsp";
            this.btntsp.Size = new System.Drawing.Size(69, 44);
            this.btntsp.TabIndex = 6;
            this.btntsp.Text = ">>";
            this.btntsp.UseVisualStyleBackColor = true;
            this.btntsp.Click += new System.EventHandler(this.btntsp_Click);
            // 
            // btnsp
            // 
            this.btnsp.Location = new System.Drawing.Point(269, 191);
            this.btnsp.Name = "btnsp";
            this.btnsp.Size = new System.Drawing.Size(69, 44);
            this.btnsp.TabIndex = 7;
            this.btnsp.Text = ">";
            this.btnsp.UseVisualStyleBackColor = true;
            this.btnsp.Click += new System.EventHandler(this.btnsp_Click);
            // 
            // btnkt
            // 
            this.btnkt.Location = new System.Drawing.Point(308, 394);
            this.btnkt.Name = "btnkt";
            this.btnkt.Size = new System.Drawing.Size(85, 44);
            this.btnkt.TabIndex = 8;
            this.btnkt.Text = "Kết thúc";
            this.btnkt.UseVisualStyleBackColor = true;
            this.btnkt.Click += new System.EventHandler(this.btnkt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstA);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 275);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstB);
            this.groupBox2.Location = new System.Drawing.Point(441, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 275);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 16;
            this.lstA.Location = new System.Drawing.Point(19, 21);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(219, 228);
            this.lstA.TabIndex = 0;
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 16;
            this.lstB.Location = new System.Drawing.Point(13, 21);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(219, 228);
            this.lstB.TabIndex = 1;
            // 
            // bntquit
            // 
            this.bntquit.Location = new System.Drawing.Point(383, 394);
            this.bntquit.Name = "bntquit";
            this.bntquit.Size = new System.Drawing.Size(10, 10);
            this.bntquit.TabIndex = 12;
            this.bntquit.Text = "           ";
            this.bntquit.UseVisualStyleBackColor = true;
            this.bntquit.Click += new System.EventHandler(this.bntquit_Click);
            // 
            // FrSinhVien
            // 
            this.AcceptButton = this.btncn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntquit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntquit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnkt);
            this.Controls.Add(this.btnsp);
            this.Controls.Add(this.btntsp);
            this.Controls.Add(this.btntst);
            this.Controls.Add(this.btnsangtrai);
            this.Controls.Add(this.btncn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.label1);
            this.Name = "FrSinhVien";
            this.Text = "FrSinhVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncn;
        private System.Windows.Forms.Button btnsangtrai;
        private System.Windows.Forms.Button btntst;
        private System.Windows.Forms.Button btntsp;
        private System.Windows.Forms.Button btnsp;
        private System.Windows.Forms.Button btnkt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.Button bntquit;
    }
}