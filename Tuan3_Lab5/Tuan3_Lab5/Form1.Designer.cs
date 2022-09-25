namespace Tuan3_Lab5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvOrder = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenban = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnpmb = new System.Windows.Forms.Button();
            this.btnpmt = new System.Windows.Forms.Button();
            this.btnpmg = new System.Windows.Forms.Button();
            this.btnpmc = new System.Windows.Forms.Button();
            this.btncgt = new System.Windows.Forms.Button();
            this.btngvc = new System.Windows.Forms.Button();
            this.btngrp = new System.Windows.Forms.Button();
            this.btntvc = new System.Windows.Forms.Button();
            this.btnpepsi = new System.Windows.Forms.Button();
            this.btncoca = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnlipton = new System.Windows.Forms.Button();
            this.btncafe = new System.Windows.Forms.Button();
            this.btncam = new System.Windows.Forms.Button();
            this.btnktc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(208, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "FastFood Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnktc);
            this.groupBox1.Controls.Add(this.btncam);
            this.groupBox1.Controls.Add(this.btncafe);
            this.groupBox1.Controls.Add(this.btnlipton);
            this.groupBox1.Controls.Add(this.btn7up);
            this.groupBox1.Controls.Add(this.btncoca);
            this.groupBox1.Controls.Add(this.btnpepsi);
            this.groupBox1.Controls.Add(this.btncgt);
            this.groupBox1.Controls.Add(this.btngvc);
            this.groupBox1.Controls.Add(this.btngrp);
            this.groupBox1.Controls.Add(this.btntvc);
            this.groupBox1.Controls.Add(this.btnpmc);
            this.groupBox1.Controls.Add(this.btnpmg);
            this.groupBox1.Controls.Add(this.btnpmt);
            this.groupBox1.Controls.Add(this.btnpmb);
            this.groupBox1.Location = new System.Drawing.Point(30, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // dtgvOrder
            // 
            this.dtgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrder.Location = new System.Drawing.Point(12, 406);
            this.dtgvOrder.Name = "dtgvOrder";
            this.dtgvOrder.RowHeadersWidth = 51;
            this.dtgvOrder.RowTemplate.Height = 24;
            this.dtgvOrder.Size = new System.Drawing.Size(694, 303);
            this.dtgvOrder.TabIndex = 2;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(30, 334);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 32);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên bàn";
            // 
            // cbbTenban
            // 
            this.cbbTenban.FormattingEnabled = true;
            this.cbbTenban.Location = new System.Drawing.Point(290, 343);
            this.cbbTenban.Name = "cbbTenban";
            this.cbbTenban.Size = new System.Drawing.Size(177, 24);
            this.cbbTenban.TabIndex = 5;
            this.cbbTenban.SelectedIndexChanged += new System.EventHandler(this.cbbTenban_SelectedIndexChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(589, 334);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 32);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnpmb
            // 
            this.btnpmb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmb.ForeColor = System.Drawing.Color.Red;
            this.btnpmb.Location = new System.Drawing.Point(15, 21);
            this.btnpmb.Name = "btnpmb";
            this.btnpmb.Size = new System.Drawing.Size(200, 42);
            this.btnpmb.TabIndex = 0;
            this.btnpmb.Text = "Burgur Phô mai Bò";
            this.btnpmb.UseVisualStyleBackColor = true;
            this.btnpmb.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btnpmt
            // 
            this.btnpmt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmt.ForeColor = System.Drawing.Color.Red;
            this.btnpmt.Location = new System.Drawing.Point(15, 117);
            this.btnpmt.Name = "btnpmt";
            this.btnpmt.Size = new System.Drawing.Size(200, 42);
            this.btnpmt.TabIndex = 1;
            this.btnpmt.Text = "Burger Phô mai Tôm";
            this.btnpmt.UseVisualStyleBackColor = true;
            this.btnpmt.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btnpmg
            // 
            this.btnpmg.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmg.ForeColor = System.Drawing.Color.Red;
            this.btnpmg.Location = new System.Drawing.Point(15, 69);
            this.btnpmg.Name = "btnpmg";
            this.btnpmg.Size = new System.Drawing.Size(200, 42);
            this.btnpmg.TabIndex = 2;
            this.btnpmg.Text = "Burger Phô mai Gà";
            this.btnpmg.UseVisualStyleBackColor = true;
            this.btnpmg.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btnpmc
            // 
            this.btnpmc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmc.ForeColor = System.Drawing.Color.Red;
            this.btnpmc.Location = new System.Drawing.Point(15, 164);
            this.btnpmc.Name = "btnpmc";
            this.btnpmc.Size = new System.Drawing.Size(200, 42);
            this.btnpmc.TabIndex = 3;
            this.btnpmc.Text = "Burger Phô mai Cá";
            this.btnpmc.UseVisualStyleBackColor = true;
            this.btnpmc.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btncgt
            // 
            this.btncgt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncgt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncgt.Location = new System.Drawing.Point(237, 164);
            this.btncgt.Name = "btncgt";
            this.btncgt.Size = new System.Drawing.Size(200, 42);
            this.btncgt.TabIndex = 7;
            this.btncgt.Text = "Cơm gà Tender";
            this.btncgt.UseVisualStyleBackColor = true;
            this.btncgt.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btngvc
            // 
            this.btngvc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngvc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btngvc.Location = new System.Drawing.Point(237, 69);
            this.btngvc.Name = "btngvc";
            this.btngvc.Size = new System.Drawing.Size(200, 42);
            this.btngvc.TabIndex = 6;
            this.btngvc.Text = "Gà viên Cola";
            this.btngvc.UseVisualStyleBackColor = true;
            this.btngvc.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btngrp
            // 
            this.btngrp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btngrp.Location = new System.Drawing.Point(237, 117);
            this.btngrp.Name = "btngrp";
            this.btngrp.Size = new System.Drawing.Size(200, 42);
            this.btngrp.TabIndex = 5;
            this.btngrp.Text = "Gà rán phần";
            this.btngrp.UseVisualStyleBackColor = true;
            this.btngrp.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btntvc
            // 
            this.btntvc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntvc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btntvc.Location = new System.Drawing.Point(237, 21);
            this.btntvc.Name = "btntvc";
            this.btntvc.Size = new System.Drawing.Size(200, 42);
            this.btntvc.TabIndex = 4;
            this.btntvc.Text = "Tôm viên Cola";
            this.btntvc.UseVisualStyleBackColor = true;
            this.btntvc.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btnpepsi
            // 
            this.btnpepsi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpepsi.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnpepsi.Location = new System.Drawing.Point(460, 26);
            this.btnpepsi.Name = "btnpepsi";
            this.btnpepsi.Size = new System.Drawing.Size(71, 37);
            this.btnpepsi.TabIndex = 8;
            this.btnpepsi.Text = "Pepsi";
            this.btnpepsi.UseVisualStyleBackColor = true;
            this.btnpepsi.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btncoca
            // 
            this.btncoca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncoca.ForeColor = System.Drawing.Color.Fuchsia;
            this.btncoca.Location = new System.Drawing.Point(552, 26);
            this.btncoca.Name = "btncoca";
            this.btncoca.Size = new System.Drawing.Size(71, 37);
            this.btncoca.TabIndex = 9;
            this.btncoca.Text = "Coca";
            this.btncoca.UseVisualStyleBackColor = true;
            this.btncoca.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btn7up
            // 
            this.btn7up.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7up.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn7up.Location = new System.Drawing.Point(460, 72);
            this.btn7up.Name = "btn7up";
            this.btn7up.Size = new System.Drawing.Size(71, 37);
            this.btn7up.TabIndex = 10;
            this.btn7up.Text = "8 up";
            this.btn7up.UseVisualStyleBackColor = true;
            this.btn7up.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btnlipton
            // 
            this.btnlipton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlipton.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnlipton.Location = new System.Drawing.Point(552, 69);
            this.btnlipton.Name = "btnlipton";
            this.btnlipton.Size = new System.Drawing.Size(71, 37);
            this.btnlipton.TabIndex = 11;
            this.btnlipton.Text = "Lipton";
            this.btnlipton.UseVisualStyleBackColor = true;
            this.btnlipton.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btncafe
            // 
            this.btncafe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncafe.ForeColor = System.Drawing.Color.Fuchsia;
            this.btncafe.Location = new System.Drawing.Point(460, 120);
            this.btncafe.Name = "btncafe";
            this.btncafe.Size = new System.Drawing.Size(71, 37);
            this.btncafe.TabIndex = 12;
            this.btncafe.Text = "Cafe";
            this.btncafe.UseVisualStyleBackColor = true;
            this.btncafe.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btncam
            // 
            this.btncam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncam.ForeColor = System.Drawing.Color.Fuchsia;
            this.btncam.Location = new System.Drawing.Point(552, 120);
            this.btncam.Name = "btncam";
            this.btncam.Size = new System.Drawing.Size(71, 37);
            this.btncam.TabIndex = 13;
            this.btncam.Text = "Cam";
            this.btncam.UseVisualStyleBackColor = true;
            this.btncam.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // btnktc
            // 
            this.btnktc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnktc.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnktc.Location = new System.Drawing.Point(470, 164);
            this.btnktc.Name = "btnktc";
            this.btnktc.Size = new System.Drawing.Size(153, 37);
            this.btnktc.TabIndex = 14;
            this.btnktc.Text = "Khoai tây chiên";
            this.btnktc.UseVisualStyleBackColor = true;
            this.btnktc.Click += new System.EventHandler(this.btnpmb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tuan3_Lab5.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 721);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbbTenban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.dtgvOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnktc;
        private System.Windows.Forms.Button btncam;
        private System.Windows.Forms.Button btncafe;
        private System.Windows.Forms.Button btnlipton;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btncoca;
        private System.Windows.Forms.Button btnpepsi;
        private System.Windows.Forms.Button btncgt;
        private System.Windows.Forms.Button btngvc;
        private System.Windows.Forms.Button btngrp;
        private System.Windows.Forms.Button btntvc;
        private System.Windows.Forms.Button btnpmc;
        private System.Windows.Forms.Button btnpmg;
        private System.Windows.Forms.Button btnpmt;
        private System.Windows.Forms.Button btnpmb;
        private System.Windows.Forms.DataGridView dtgvOrder;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTenban;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

