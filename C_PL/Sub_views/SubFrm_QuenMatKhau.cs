using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Sub_views
{
    public partial class SubFrm_QuenMatKhau : Form
    {
        private INhanVienServices _nhanVienServices;
        int otp = 0;
        Random rd = new Random();
        public SubFrm_QuenMatKhau()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            NhanVien nv = _nhanVienServices.GetNhanVien(txt_email.Text);
            if (nv == null)
            {
                MessageBox.Show("Không có tài khoản nào liên kết với email này.");
            }
            else
            {
                try
                {
                    otp = rd.Next(100000, 1000000);
                    var fromadress = new MailAddress("nhamtuandat.first@gmail.com");//mail gửi
                    var toaddress = new MailAddress(txt_email.ToString());//mail nhận
                    const string frompass = "qpoagvokegkkfbhb";//mã xác thực 2 lớp
                    const string subject = "Mã xác thực";
                    string body = otp.ToString();
                    var stmp = new SmtpClient()
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromadress.Address, frompass),
                        Timeout = 20000,
                    };
                    using (
                        var message = new MailMessage(fromadress, toaddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                    {
                        stmp.Send(message);
                    }
                    MessageBox.Show($"Mã xác thực OTP đã được gửi tới email:{txt_email.Text}", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_xacthuc_Click(object sender, EventArgs e)
        {
            NhanVien nv = _nhanVienServices.GetNhanVien(txt_email.Text);
            if (otp != Convert.ToInt32(txt_otp.Text))
            {
                MessageBox.Show("Mã OTP không chính xác");
            }
            else
            {
                MessageBox.Show("Xác thực thành công");
                SubFrm_DoiMatKhau subFrm_DoiMatKhau = new SubFrm_DoiMatKhau();
                subFrm_DoiMatKhau._nv = nv;
                //subFrm_DoiMatKhau.Closed += (s, args) => this.Close();
                subFrm_DoiMatKhau.ShowDialog();
            }
        }
    }
}
