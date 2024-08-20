namespace lab03_2212371
{
    partial class frmBai2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbbTenHang = new ComboBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            groupBox1 = new GroupBox();
            rdTienMat = new RadioButton();
            rdChuyenKhoan = new RadioButton();
            btnTinhTien = new Button();
            label4 = new Label();
            lblSoTien = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 52);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 90);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 130);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Số lượng:";
            // 
            // cbbTenHang
            // 
            cbbTenHang.FormattingEnabled = true;
            cbbTenHang.Items.AddRange(new object[] { "Chuột", "Máy in", "Bàn phím" });
            cbbTenHang.Location = new Point(141, 44);
            cbbTenHang.Name = "cbbTenHang";
            cbbTenHang.Size = new Size(202, 23);
            cbbTenHang.TabIndex = 3;
            cbbTenHang.SelectedIndexChanged += cbbTenHang_SelectedIndexChanged;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(141, 90);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(202, 23);
            txtDonGia.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(141, 130);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(202, 23);
            txtSoLuong.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdTienMat);
            groupBox1.Controls.Add(rdChuyenKhoan);
            groupBox1.Location = new Point(49, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hình thức thanh toán";
            // 
            // rdTienMat
            // 
            rdTienMat.AutoSize = true;
            rdTienMat.Checked = true;
            rdTienMat.Location = new Point(45, 75);
            rdTienMat.Name = "rdTienMat";
            rdTienMat.Size = new Size(71, 19);
            rdTienMat.TabIndex = 8;
            rdTienMat.TabStop = true;
            rdTienMat.Text = "Tiền Mặt";
            rdTienMat.UseVisualStyleBackColor = true;
            // 
            // rdChuyenKhoan
            // 
            rdChuyenKhoan.AutoSize = true;
            rdChuyenKhoan.Location = new Point(45, 37);
            rdChuyenKhoan.Name = "rdChuyenKhoan";
            rdChuyenKhoan.Size = new Size(102, 19);
            rdChuyenKhoan.TabIndex = 7;
            rdChuyenKhoan.Text = "Chuyển khoản";
            rdChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(185, 310);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(91, 32);
            btnTinhTien.TabIndex = 7;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(49, 362);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 8;
            label4.Text = "Số tiền thanh toán:";
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Font = new Font("Segoe UI", 12F);
            lblSoTien.Location = new Point(185, 362);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(13, 21);
            lblSoTien.TabIndex = 9;
            lblSoTien.Text = ".";
            // 
            // frmBai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(lblSoTien);
            Controls.Add(label4);
            Controls.Add(btnTinhTien);
            Controls.Add(groupBox1);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(cbbTenHang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBai2";
            Text = "Bài 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbTenHang;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private GroupBox groupBox1;
        private RadioButton rdChuyenKhoan;
        private RadioButton rdTienMat;
        private Button btnTinhTien;
        private Label label4;
        private Label lblSoTien;
    }
}