namespace C_PL.Sub_views
{
    partial class SubFrm_AddSanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.lb_dongia);
            this.groupBox1.Controls.Add(this.lb_tensp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // lb_tensp
            // 
            this.lb_tensp.AutoSize = true;
            this.lb_tensp.Location = new System.Drawing.Point(227, 57);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(98, 25);
            this.lb_tensp.TabIndex = 3;
            this.lb_tensp.Text = "Cà phê lỏd";
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.Location = new System.Drawing.Point(227, 101);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(66, 25);
            this.lb_dongia.TabIndex = 4;
            this.lb_dongia.Text = "0_VND";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(227, 147);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(192, 31);
            this.txt_soluong.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SubFrm_AddSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 282);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubFrm_AddSanPham";
            this.Text = "SubFrm_AddSanPham";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txt_soluong;
        private Label lb_dongia;
        private Label lb_tensp;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}