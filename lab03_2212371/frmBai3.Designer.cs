namespace lab03_2212371
{
    partial class frmBai3
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
            txtSoA = new TextBox();
            txtSoB = new TextBox();
            txtsoN = new TextBox();
            groupBox1 = new GroupBox();
            rdTinhTongN = new RadioButton();
            rdTongAB = new RadioButton();
            btnXemKq = new Button();
            label4 = new Label();
            lblKetQua = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 45);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Số a=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 77);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Số b=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 110);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "Số n=";
            // 
            // txtSoA
            // 
            txtSoA.Location = new Point(130, 42);
            txtSoA.Name = "txtSoA";
            txtSoA.Size = new Size(157, 23);
            txtSoA.TabIndex = 1;
            txtSoA.Text = "0";
            // 
            // txtSoB
            // 
            txtSoB.Location = new Point(130, 73);
            txtSoB.Name = "txtSoB";
            txtSoB.Size = new Size(157, 23);
            txtSoB.TabIndex = 1;
            txtSoB.Text = "0";
            // 
            // txtsoN
            // 
            txtsoN.Location = new Point(130, 102);
            txtsoN.Name = "txtsoN";
            txtsoN.Size = new Size(157, 23);
            txtsoN.TabIndex = 1;
            txtsoN.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdTinhTongN);
            groupBox1.Controls.Add(rdTongAB);
            groupBox1.Location = new Point(87, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rdTinhTongN
            // 
            rdTinhTongN.AutoSize = true;
            rdTinhTongN.Location = new Point(54, 64);
            rdTinhTongN.Name = "rdTinhTongN";
            rdTinhTongN.Size = new Size(132, 19);
            rdTinhTongN.TabIndex = 0;
            rdTinhTongN.Text = "Tính tổng từ 1 đến n";
            rdTinhTongN.UseVisualStyleBackColor = true;
            // 
            // rdTongAB
            // 
            rdTongAB.AutoSize = true;
            rdTongAB.Checked = true;
            rdTongAB.Location = new Point(54, 29);
            rdTongAB.Name = "rdTongAB";
            rdTongAB.Size = new Size(95, 19);
            rdTongAB.TabIndex = 0;
            rdTongAB.TabStop = true;
            rdTongAB.Text = "Tính tổng a,b";
            rdTongAB.UseVisualStyleBackColor = true;
            // 
            // btnXemKq
            // 
            btnXemKq.Location = new Point(130, 305);
            btnXemKq.Name = "btnXemKq";
            btnXemKq.Size = new Size(106, 23);
            btnXemKq.TabIndex = 3;
            btnXemKq.Text = "Xem kết quả";
            btnXemKq.UseVisualStyleBackColor = true;
            btnXemKq.Click += btnXemKq_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(84, 356);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 4;
            label4.Text = "Kết quả là:";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 11F);
            lblKetQua.Location = new Point(169, 356);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(12, 20);
            lblKetQua.TabIndex = 4;
            lblKetQua.Text = ".";
            // 
            // frmBai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 450);
            Controls.Add(lblKetQua);
            Controls.Add(label4);
            Controls.Add(btnXemKq);
            Controls.Add(groupBox1);
            Controls.Add(txtsoN);
            Controls.Add(txtSoB);
            Controls.Add(txtSoA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBai3";
            Text = "Bài 3";
            Load += frmBai3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSoA;
        private TextBox txtSoB;
        private TextBox txtsoN;
        private GroupBox groupBox1;
        private RadioButton rdTinhTongN;
        private RadioButton rdTongAB;
        private Button btnXemKq;
        private Label label4;
        private Label lblKetQua;
    }
}