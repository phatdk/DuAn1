namespace C_PL.Views
{
    partial class Frm_Main
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
            panel1 = new Panel();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            cáNhânToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            cửaHàngToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            tms_banhang = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            aDminToolStripMenuItem = new ToolStripMenuItem();
            btn_hide = new Button();
            btn_close = new Button();
            pn_show = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_hide);
            panel1.Controls.Add(btn_close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 44);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 44);
            panel2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SandyBrown;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, aDminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(745, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cáNhânToolStripMenuItem, toolStripSeparator1, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 40);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // cáNhânToolStripMenuItem
            // 
            cáNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem, cửaHàngToolStripMenuItem1 });
            cáNhânToolStripMenuItem.Name = "cáNhânToolStripMenuItem";
            cáNhânToolStripMenuItem.Size = new Size(224, 26);
            cáNhânToolStripMenuItem.Text = "Thông tin";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(224, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // cửaHàngToolStripMenuItem1
            // 
            cửaHàngToolStripMenuItem1.Name = "cửaHàngToolStripMenuItem1";
            cửaHàngToolStripMenuItem1.Size = new Size(224, 26);
            cửaHàngToolStripMenuItem1.Text = "Cửa hàng";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tms_banhang, hóaĐơnToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 40);
            danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // tms_banhang
            // 
            tms_banhang.Name = "tms_banhang";
            tms_banhang.Size = new Size(224, 26);
            tms_banhang.Text = "Bán hàng";
            tms_banhang.Click += tms_banhang_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(224, 26);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // aDminToolStripMenuItem
            // 
            aDminToolStripMenuItem.Name = "aDminToolStripMenuItem";
            aDminToolStripMenuItem.Size = new Size(69, 40);
            aDminToolStripMenuItem.Text = "ADmin";
            aDminToolStripMenuItem.Click += aDminToolStripMenuItem_Click;
            // 
            // btn_hide
            // 
            btn_hide.BackgroundImage = Properties.Resources.icons8_subtract_50;
            btn_hide.BackgroundImageLayout = ImageLayout.Zoom;
            btn_hide.Dock = DockStyle.Right;
            btn_hide.FlatStyle = FlatStyle.Flat;
            btn_hide.Location = new Point(745, 0);
            btn_hide.Margin = new Padding(2);
            btn_hide.Name = "btn_hide";
            btn_hide.Size = new Size(44, 44);
            btn_hide.TabIndex = 2;
            btn_hide.UseVisualStyleBackColor = true;
            btn_hide.Click += btn_hide_Click;
            // 
            // btn_close
            // 
            btn_close.BackgroundImage = Properties.Resources.icons8_close_window_50;
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close.Dock = DockStyle.Right;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.Location = new Point(789, 0);
            btn_close.Margin = new Padding(4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(44, 44);
            btn_close.TabIndex = 1;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // pn_show
            // 
            pn_show.Dock = DockStyle.Fill;
            pn_show.Location = new Point(0, 44);
            pn_show.Margin = new Padding(2);
            pn_show.Name = "pn_show";
            pn_show.Size = new Size(833, 416);
            pn_show.TabIndex = 1;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(833, 460);
            Controls.Add(pn_show);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Frm_Main";
            Text = "Frm_Main";
            WindowState = FormWindowState.Maximized;
            Load += Frm_Main_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private Button btn_hide;
        private Button btn_close;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private Panel panel2;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem aDminToolStripMenuItem;
        private ToolStripMenuItem cáNhânToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem cửaHàngToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem tms_banhang;
        private Panel pn_show;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}