﻿namespace Formmain.GUI
{
    partial class frmSuaSV
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMacu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radsNu = new System.Windows.Forms.RadioButton();
            this.radsNam = new System.Windows.Forms.RadioButton();
            this.txtsNgaySinh = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtSHoTen = new System.Windows.Forms.TextBox();
            this.txtSMaSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXacNhan1 = new System.Windows.Forms.Button();
            this.imgsTrain = new Emgu.CV.UI.ImageBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgsTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 35;
            this.button1.Text = "Hủy ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMacu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radsNu);
            this.groupBox2.Controls.Add(this.radsNam);
            this.groupBox2.Controls.Add(this.txtsNgaySinh);
            this.groupBox2.Controls.Add(this.txtLop);
            this.groupBox2.Controls.Add(this.txtSHoTen);
            this.groupBox2.Controls.Add(this.txtSMaSV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(290, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 409);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sinh viên";
            // 
            // txtMacu
            // 
            this.txtMacu.Location = new System.Drawing.Point(333, 100);
            this.txtMacu.Name = "txtMacu";
            this.txtMacu.ReadOnly = true;
            this.txtMacu.Size = new System.Drawing.Size(138, 22);
            this.txtMacu.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "(dd/mm/yyyy)";
            // 
            // radsNu
            // 
            this.radsNu.AutoSize = true;
            this.radsNu.Location = new System.Drawing.Point(276, 347);
            this.radsNu.Name = "radsNu";
            this.radsNu.Size = new System.Drawing.Size(47, 21);
            this.radsNu.TabIndex = 10;
            this.radsNu.TabStop = true;
            this.radsNu.Text = "Nữ";
            this.radsNu.UseVisualStyleBackColor = true;
            // 
            // radsNam
            // 
            this.radsNam.AutoSize = true;
            this.radsNam.Location = new System.Drawing.Point(173, 347);
            this.radsNam.Name = "radsNam";
            this.radsNam.Size = new System.Drawing.Size(58, 21);
            this.radsNam.TabIndex = 9;
            this.radsNam.TabStop = true;
            this.radsNam.Text = "Nam";
            this.radsNam.UseVisualStyleBackColor = true;
            // 
            // txtsNgaySinh
            // 
            this.txtsNgaySinh.Location = new System.Drawing.Point(173, 290);
            this.txtsNgaySinh.Name = "txtsNgaySinh";
            this.txtsNgaySinh.Size = new System.Drawing.Size(136, 22);
            this.txtsNgaySinh.TabIndex = 8;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(173, 227);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(136, 22);
            this.txtLop.TabIndex = 7;
            // 
            // txtSHoTen
            // 
            this.txtSHoTen.Location = new System.Drawing.Point(173, 167);
            this.txtSHoTen.Name = "txtSHoTen";
            this.txtSHoTen.Size = new System.Drawing.Size(292, 22);
            this.txtSHoTen.TabIndex = 6;
            // 
            // txtSMaSV
            // 
            this.txtSMaSV.Location = new System.Drawing.Point(173, 101);
            this.txtSMaSV.Name = "txtSMaSV";
            this.txtSMaSV.Size = new System.Drawing.Size(136, 22);
            this.txtSMaSV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // btnXacNhan1
            // 
            this.btnXacNhan1.Location = new System.Drawing.Point(43, 288);
            this.btnXacNhan1.Name = "btnXacNhan1";
            this.btnXacNhan1.Size = new System.Drawing.Size(130, 45);
            this.btnXacNhan1.TabIndex = 34;
            this.btnXacNhan1.Text = "Xác nhận";
            this.btnXacNhan1.UseVisualStyleBackColor = true;
            this.btnXacNhan1.Click += new System.EventHandler(this.btnXacNhan1_Click);
            // 
            // imgsTrain
            // 
            this.imgsTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgsTrain.Location = new System.Drawing.Point(13, 21);
            this.imgsTrain.Name = "imgsTrain";
            this.imgsTrain.Size = new System.Drawing.Size(200, 200);
            this.imgsTrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgsTrain.TabIndex = 32;
            this.imgsTrain.TabStop = false;
            // 
            // frmSuaSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXacNhan1);
            this.Controls.Add(this.imgsTrain);
            this.Name = "frmSuaSV";
            this.Text = "frmSuaSV";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgsTrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtMacu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton radsNu;
        public System.Windows.Forms.RadioButton radsNam;
        public System.Windows.Forms.TextBox txtsNgaySinh;
        public System.Windows.Forms.TextBox txtLop;
        public System.Windows.Forms.TextBox txtSHoTen;
        public System.Windows.Forms.TextBox txtSMaSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXacNhan1;
        public Emgu.CV.UI.ImageBox imgsTrain;
    }
}