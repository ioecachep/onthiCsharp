namespace TinhTienDien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChiSoDienCu = new System.Windows.Forms.TextBox();
            this.txtChiSoDienMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThueBaoDienKe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTinhTien = new System.Windows.Forms.Panel();
            this.lbTongCong = new System.Windows.Forms.Label();
            this.lbTienNgoaiDinhMuc = new System.Windows.Forms.Label();
            this.lbTienTrongDinhMuc = new System.Windows.Forms.Label();
            this.lbSoDien = new System.Windows.Forms.Label();
            this.lbKhacHang = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtDuoiDinhMuc = new System.Windows.Forms.TextBox();
            this.txtDuoi50 = new System.Windows.Forms.TextBox();
            this.txtDuoi100 = new System.Windows.Forms.TextBox();
            this.txtTren100 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTinhTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChiSoDienCu
            // 
            this.txtChiSoDienCu.Location = new System.Drawing.Point(188, 96);
            this.txtChiSoDienCu.Name = "txtChiSoDienCu";
            this.txtChiSoDienCu.Size = new System.Drawing.Size(100, 23);
            this.txtChiSoDienCu.TabIndex = 0;
            this.txtChiSoDienCu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtChiSoDienMoi
            // 
            this.txtChiSoDienMoi.Location = new System.Drawing.Point(188, 125);
            this.txtChiSoDienMoi.Name = "txtChiSoDienMoi";
            this.txtChiSoDienMoi.Size = new System.Drawing.Size(100, 23);
            this.txtChiSoDienMoi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chỉ số điện cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chỉ số điện mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền thuê bao điện kế";
            // 
            // txtThueBaoDienKe
            // 
            this.txtThueBaoDienKe.Location = new System.Drawing.Point(188, 154);
            this.txtThueBaoDienKe.Name = "txtThueBaoDienKe";
            this.txtThueBaoDienKe.Size = new System.Drawing.Size(100, 23);
            this.txtThueBaoDienKe.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTinhTien);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(340, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 275);
            this.panel1.TabIndex = 6;
            // 
            // pnlTinhTien
            // 
            this.pnlTinhTien.Controls.Add(this.lbTongCong);
            this.pnlTinhTien.Controls.Add(this.lbTienNgoaiDinhMuc);
            this.pnlTinhTien.Controls.Add(this.lbTienTrongDinhMuc);
            this.pnlTinhTien.Controls.Add(this.lbSoDien);
            this.pnlTinhTien.Controls.Add(this.lbKhacHang);
            this.pnlTinhTien.Location = new System.Drawing.Point(142, 45);
            this.pnlTinhTien.Name = "pnlTinhTien";
            this.pnlTinhTien.Size = new System.Drawing.Size(200, 178);
            this.pnlTinhTien.TabIndex = 6;
            this.pnlTinhTien.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbTongCong
            // 
            this.lbTongCong.AutoSize = true;
            this.lbTongCong.Location = new System.Drawing.Point(16, 134);
            this.lbTongCong.Name = "lbTongCong";
            this.lbTongCong.Size = new System.Drawing.Size(72, 15);
            this.lbTongCong.TabIndex = 4;
            this.lbTongCong.Text = "lbTongCong";
            // 
            // lbTienNgoaiDinhMuc
            // 
            this.lbTienNgoaiDinhMuc.AutoSize = true;
            this.lbTienNgoaiDinhMuc.Location = new System.Drawing.Point(16, 105);
            this.lbTienNgoaiDinhMuc.Name = "lbTienNgoaiDinhMuc";
            this.lbTienNgoaiDinhMuc.Size = new System.Drawing.Size(120, 15);
            this.lbTienNgoaiDinhMuc.TabIndex = 3;
            this.lbTienNgoaiDinhMuc.Text = "lbTienNgoaiDinhMuc";
            // 
            // lbTienTrongDinhMuc
            // 
            this.lbTienTrongDinhMuc.AutoSize = true;
            this.lbTienTrongDinhMuc.Location = new System.Drawing.Point(16, 76);
            this.lbTienTrongDinhMuc.Name = "lbTienTrongDinhMuc";
            this.lbTienTrongDinhMuc.Size = new System.Drawing.Size(118, 15);
            this.lbTienTrongDinhMuc.TabIndex = 2;
            this.lbTienTrongDinhMuc.Text = "lbTienTrongDinhMuc";
            // 
            // lbSoDien
            // 
            this.lbSoDien.AutoSize = true;
            this.lbSoDien.Location = new System.Drawing.Point(16, 47);
            this.lbSoDien.Name = "lbSoDien";
            this.lbSoDien.Size = new System.Drawing.Size(54, 15);
            this.lbSoDien.TabIndex = 1;
            this.lbSoDien.Text = "lbSoDien";
            // 
            // lbKhacHang
            // 
            this.lbKhacHang.AutoSize = true;
            this.lbKhacHang.Location = new System.Drawing.Point(16, 18);
            this.lbKhacHang.Name = "lbKhacHang";
            this.lbKhacHang.Size = new System.Drawing.Size(72, 15);
            this.lbKhacHang.TabIndex = 0;
            this.lbKhacHang.Text = "lbKhacHang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Số điện tiêu thụ:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tổng cộng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 150);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tiền ngoài định mức:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tiền trong định mức:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khách hàng:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(188, 67);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(100, 23);
            this.txtKhachHang.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Khách hàng";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(100, 211);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 9;
            this.btnTinh.Text = "Tính tiền";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(188, 211);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtDuoiDinhMuc
            // 
            this.txtDuoiDinhMuc.Location = new System.Drawing.Point(92, 321);
            this.txtDuoiDinhMuc.Name = "txtDuoiDinhMuc";
            this.txtDuoiDinhMuc.Size = new System.Drawing.Size(100, 23);
            this.txtDuoiDinhMuc.TabIndex = 11;
            // 
            // txtDuoi50
            // 
            this.txtDuoi50.Location = new System.Drawing.Point(199, 321);
            this.txtDuoi50.Name = "txtDuoi50";
            this.txtDuoi50.Size = new System.Drawing.Size(100, 23);
            this.txtDuoi50.TabIndex = 12;
            // 
            // txtDuoi100
            // 
            this.txtDuoi100.Location = new System.Drawing.Point(306, 321);
            this.txtDuoi100.Name = "txtDuoi100";
            this.txtDuoi100.Size = new System.Drawing.Size(100, 23);
            this.txtDuoi100.TabIndex = 13;
            // 
            // txtTren100
            // 
            this.txtTren100.Location = new System.Drawing.Point(412, 321);
            this.txtTren100.Name = "txtTren100";
            this.txtTren100.Size = new System.Drawing.Size(100, 23);
            this.txtTren100.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "<= 50Kw";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "<= 100Kw";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "< 150Kw";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(412, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = ">= 150Kw";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(92, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 15);
            this.label15.TabIndex = 19;
            this.label15.Text = "450Đ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(199, 347);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 20;
            this.label16.Text = "700Đ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(306, 347);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 15);
            this.label17.TabIndex = 21;
            this.label17.Text = "910Đ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(412, 347);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 22;
            this.label18.Text = "1200Đ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 380);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTren100);
            this.Controls.Add(this.txtDuoi100);
            this.Controls.Add(this.txtDuoi50);
            this.Controls.Add(this.txtDuoiDinhMuc);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtThueBaoDienKe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChiSoDienMoi);
            this.Controls.Add(this.txtChiSoDienCu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTinhTien.ResumeLayout(false);
            this.pnlTinhTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChiSoDienCu;
        private System.Windows.Forms.TextBox txtChiSoDienMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThueBaoDienKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlTinhTien;
        private System.Windows.Forms.Label lbTongCong;
        private System.Windows.Forms.Label lbTienNgoaiDinhMuc;
        private System.Windows.Forms.Label lbTienTrongDinhMuc;
        private System.Windows.Forms.Label lbSoDien;
        private System.Windows.Forms.Label lbKhacHang;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtDuoiDinhMuc;
        private System.Windows.Forms.TextBox txtDuoi50;
        private System.Windows.Forms.TextBox txtDuoi100;
        private System.Windows.Forms.TextBox txtTren100;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

