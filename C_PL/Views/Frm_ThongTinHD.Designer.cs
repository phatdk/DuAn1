namespace C_PL.Views
{
    partial class Frm_ThongTinHD
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
            label6 = new Label();
            dtg_InHoaDon = new DataGridView();
            lbNV = new Label();
            lbTongTien = new Label();
            btn_InHD = new Button();
            lbNgayThanhToan = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_InHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 18);
            label1.Name = "label1";
            label1.Size = new Size(311, 41);
            label1.TabIndex = 0;
            label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 81);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày bán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 121);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "NVBH:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 421);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 5;
            label6.Text = "Tổng tiền:";
            // 
            // dtg_InHoaDon
            // 
            dtg_InHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_InHoaDon.Location = new Point(30, 186);
            dtg_InHoaDon.Name = "dtg_InHoaDon";
            dtg_InHoaDon.RowHeadersWidth = 51;
            dtg_InHoaDon.RowTemplate.Height = 29;
            dtg_InHoaDon.Size = new Size(443, 232);
            dtg_InHoaDon.TabIndex = 6;
            // 
            // lbNV
            // 
            lbNV.AutoSize = true;
            lbNV.Location = new Point(140, 121);
            lbNV.Name = "lbNV";
            lbNV.Size = new Size(50, 20);
            lbNV.TabIndex = 7;
            lbNV.Text = "label4";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(150, 421);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(50, 20);
            lbTongTien.TabIndex = 8;
            lbTongTien.Text = "label7";
            // 
            // btn_InHD
            // 
            btn_InHD.BackColor = Color.FromArgb(255, 192, 128);
            btn_InHD.Location = new Point(479, 231);
            btn_InHD.Name = "btn_InHD";
            btn_InHD.Size = new Size(94, 71);
            btn_InHD.TabIndex = 10;
            btn_InHD.Text = "In";
            btn_InHD.UseVisualStyleBackColor = false;
            btn_InHD.Click += btn_InHD_Click;
            // 
            // lbNgayThanhToan
            // 
            lbNgayThanhToan.AutoSize = true;
            lbNgayThanhToan.Location = new Point(140, 81);
            lbNgayThanhToan.Name = "lbNgayThanhToan";
            lbNgayThanhToan.Size = new Size(50, 20);
            lbNgayThanhToan.TabIndex = 11;
            lbNgayThanhToan.Text = "label4";
            // 
            // Frm_ThongTinHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(580, 450);
            Controls.Add(lbNgayThanhToan);
            Controls.Add(btn_InHD);
            Controls.Add(lbTongTien);
            Controls.Add(lbNV);
            Controls.Add(dtg_InHoaDon);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_ThongTinHD";
            Text = "Frm_ThongTinHD";
            Load += Frm_ThongTinHD_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_InHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private DataGridView dtg_InHoaDon;
        private Label lbNV;
        private Label lbTongTien;
        private Button btn_InHD;
        private Label lbNgayThanhToan;
    }
}