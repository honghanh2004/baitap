namespace BAITAPBOSUNG
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
            this.components = new System.ComponentModel.Container();
            this.lblthoigian = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbcauhinh = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtxanh = new System.Windows.Forms.TextBox();
            this.txtdo = new System.Windows.Forms.TextBox();
            this.grbden = new System.Windows.Forms.GroupBox();
            this.picdo = new System.Windows.Forms.PictureBox();
            this.picvang = new System.Windows.Forms.PictureBox();
            this.picxanh = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buthienthi = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.grbcauhinh.SuspendLayout();
            this.grbden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxanh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblthoigian
            // 
            this.lblthoigian.AutoSize = true;
            this.lblthoigian.ForeColor = System.Drawing.Color.Black;
            this.lblthoigian.Location = new System.Drawing.Point(16, 26);
            this.lblthoigian.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(135, 25);
            this.lblthoigian.TabIndex = 0;
            this.lblthoigian.Text = "lbl thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÍNH HIỆU ĐÈN GIAO THÔNG";
            // 
            // grbcauhinh
            // 
            this.grbcauhinh.Controls.Add(this.butthoat);
            this.grbcauhinh.Controls.Add(this.buthienthi);
            this.grbcauhinh.Controls.Add(this.txtdo);
            this.grbcauhinh.Controls.Add(this.txtxanh);
            this.grbcauhinh.Controls.Add(this.label5);
            this.grbcauhinh.Controls.Add(this.label4);
            this.grbcauhinh.Controls.Add(this.label3);
            this.grbcauhinh.Location = new System.Drawing.Point(636, 54);
            this.grbcauhinh.Name = "grbcauhinh";
            this.grbcauhinh.Size = new System.Drawing.Size(565, 563);
            this.grbcauhinh.TabIndex = 2;
            this.grbcauhinh.TabStop = false;
            this.grbcauhinh.Text = "Cấu hình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian xanh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(10, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian vàng: 5 giây";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(10, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời gian đỏ";
            // 
            // txtxanh
            // 
            this.txtxanh.Location = new System.Drawing.Point(188, 57);
            this.txtxanh.Name = "txtxanh";
            this.txtxanh.Size = new System.Drawing.Size(322, 31);
            this.txtxanh.TabIndex = 6;
            // 
            // txtdo
            // 
            this.txtdo.Location = new System.Drawing.Point(188, 256);
            this.txtdo.Name = "txtdo";
            this.txtdo.Size = new System.Drawing.Size(322, 31);
            this.txtdo.TabIndex = 8;
            // 
            // grbden
            // 
            this.grbden.Controls.Add(this.picxanh);
            this.grbden.Controls.Add(this.picvang);
            this.grbden.Controls.Add(this.picdo);
            this.grbden.Location = new System.Drawing.Point(41, 54);
            this.grbden.Name = "grbden";
            this.grbden.Size = new System.Drawing.Size(312, 562);
            this.grbden.TabIndex = 3;
            this.grbden.TabStop = false;
            this.grbden.Text = "ĐÈN";
            // 
            // picdo
            // 
            this.picdo.BackColor = System.Drawing.Color.Red;
            this.picdo.Location = new System.Drawing.Point(69, 57);
            this.picdo.Name = "picdo";
            this.picdo.Size = new System.Drawing.Size(155, 99);
            this.picdo.TabIndex = 0;
            this.picdo.TabStop = false;
            // 
            // picvang
            // 
            this.picvang.BackColor = System.Drawing.Color.Yellow;
            this.picvang.Location = new System.Drawing.Point(69, 241);
            this.picvang.Name = "picvang";
            this.picvang.Size = new System.Drawing.Size(155, 99);
            this.picvang.TabIndex = 1;
            this.picvang.TabStop = false;
            // 
            // picxanh
            // 
            this.picxanh.BackColor = System.Drawing.Color.Green;
            this.picxanh.Location = new System.Drawing.Point(69, 413);
            this.picxanh.Name = "picxanh";
            this.picxanh.Size = new System.Drawing.Size(155, 99);
            this.picxanh.TabIndex = 2;
            this.picxanh.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buthienthi
            // 
            this.buthienthi.ForeColor = System.Drawing.Color.Black;
            this.buthienthi.Location = new System.Drawing.Point(24, 384);
            this.buthienthi.Name = "buthienthi";
            this.buthienthi.Size = new System.Drawing.Size(164, 71);
            this.buthienthi.TabIndex = 9;
            this.buthienthi.Text = "Hiển thị";
            this.buthienthi.UseVisualStyleBackColor = true;
            this.buthienthi.Click += new System.EventHandler(this.buthienthi_Click);
            // 
            // butthoat
            // 
            this.butthoat.ForeColor = System.Drawing.Color.Black;
            this.butthoat.Location = new System.Drawing.Point(346, 384);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(164, 71);
            this.butthoat.TabIndex = 10;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.grbden);
            this.Controls.Add(this.grbcauhinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblthoigian);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbcauhinh.ResumeLayout(false);
            this.grbcauhinh.PerformLayout();
            this.grbden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picxanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbcauhinh;
        private System.Windows.Forms.TextBox txtdo;
        private System.Windows.Forms.TextBox txtxanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbden;
        private System.Windows.Forms.PictureBox picxanh;
        private System.Windows.Forms.PictureBox picvang;
        private System.Windows.Forms.PictureBox picdo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button buthienthi;
    }
}

