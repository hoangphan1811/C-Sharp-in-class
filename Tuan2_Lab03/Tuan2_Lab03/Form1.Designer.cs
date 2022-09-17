namespace Tuan2_Lab03
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.bntCong = new System.Windows.Forms.Button();
            this.bntTru = new System.Windows.Forms.Button();
            this.bntNhan = new System.Windows.Forms.Button();
            this.bntChia = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(229, 114);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(374, 34);
            this.txtN.TabIndex = 3;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.Location = new System.Drawing.Point(229, 171);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(374, 34);
            this.txtM.TabIndex = 4;
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM_KeyPress);
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(229, 223);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(374, 34);
            this.txtKQ.TabIndex = 5;
            // 
            // bntCong
            // 
            this.bntCong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCong.Location = new System.Drawing.Point(59, 310);
            this.bntCong.Name = "bntCong";
            this.bntCong.Size = new System.Drawing.Size(80, 37);
            this.bntCong.TabIndex = 6;
            this.bntCong.Text = "+";
            this.bntCong.UseVisualStyleBackColor = true;
            this.bntCong.Click += new System.EventHandler(this.bntCong_Click);
            // 
            // bntTru
            // 
            this.bntTru.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTru.Location = new System.Drawing.Point(175, 310);
            this.bntTru.Name = "bntTru";
            this.bntTru.Size = new System.Drawing.Size(80, 37);
            this.bntTru.TabIndex = 7;
            this.bntTru.Text = "-";
            this.bntTru.UseVisualStyleBackColor = true;
            this.bntTru.Click += new System.EventHandler(this.bntTru_Click);
            // 
            // bntNhan
            // 
            this.bntNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhan.Location = new System.Drawing.Point(289, 310);
            this.bntNhan.Name = "bntNhan";
            this.bntNhan.Size = new System.Drawing.Size(80, 37);
            this.bntNhan.TabIndex = 8;
            this.bntNhan.Text = "X";
            this.bntNhan.UseVisualStyleBackColor = true;
            this.bntNhan.Click += new System.EventHandler(this.bntNhan_Click);
            // 
            // bntChia
            // 
            this.bntChia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntChia.Location = new System.Drawing.Point(407, 310);
            this.bntChia.Name = "bntChia";
            this.bntChia.Size = new System.Drawing.Size(80, 37);
            this.bntChia.TabIndex = 9;
            this.bntChia.Text = "/";
            this.bntChia.UseVisualStyleBackColor = true;
            this.bntChia.Click += new System.EventHandler(this.bntChia_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.Location = new System.Drawing.Point(523, 310);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(80, 37);
            this.bntXoa.TabIndex = 10;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(643, 310);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(94, 37);
            this.bntThoat.TabIndex = 11;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(639, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chương trình cộng, trừ, nhân, chia 2 số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntChia);
            this.Controls.Add(this.bntNhan);
            this.Controls.Add(this.bntTru);
            this.Controls.Add(this.bntCong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button bntCong;
        private System.Windows.Forms.Button bntTru;
        private System.Windows.Forms.Button bntNhan;
        private System.Windows.Forms.Button bntChia;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Label label4;
    }
}

