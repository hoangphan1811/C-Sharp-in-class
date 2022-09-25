namespace Tuan3_Lab4
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtcv = new System.Windows.Forms.TextBox();
            this.txttt = new System.Windows.Forms.TextBox();
            this.txtchr = new System.Windows.Forms.TextBox();
            this.txttr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntcn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cạo vôi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tẩy trắng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chụp hình răng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trám răng";
            // 
            // txtcv
            // 
            this.txtcv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcv.Location = new System.Drawing.Point(353, 83);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(182, 30);
            this.txtcv.TabIndex = 4;
            this.txtcv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcv_KeyPress);
            // 
            // txttt
            // 
            this.txttt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttt.Location = new System.Drawing.Point(353, 128);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(182, 30);
            this.txttt.TabIndex = 5;
            // 
            // txtchr
            // 
            this.txtchr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchr.Location = new System.Drawing.Point(353, 176);
            this.txtchr.Name = "txtchr";
            this.txtchr.Size = new System.Drawing.Size(182, 30);
            this.txtchr.TabIndex = 6;
            // 
            // txttr
            // 
            this.txttr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttr.Location = new System.Drawing.Point(353, 222);
            this.txttr.Name = "txttr";
            this.txttr.Size = new System.Drawing.Size(182, 30);
            this.txttr.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bảng cập nhật giá";
            // 
            // bntcn
            // 
            this.bntcn.Location = new System.Drawing.Point(353, 303);
            this.bntcn.Name = "bntcn";
            this.bntcn.Size = new System.Drawing.Size(103, 58);
            this.bntcn.TabIndex = 9;
            this.bntcn.Text = "Xác nhận";
            this.bntcn.UseVisualStyleBackColor = true;
            this.bntcn.Click += new System.EventHandler(this.bntcn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntcn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttr);
            this.Controls.Add(this.txtchr);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.TextBox txtchr;
        private System.Windows.Forms.TextBox txttr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntcn;
    }
}