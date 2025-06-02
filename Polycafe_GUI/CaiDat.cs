using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Polycafe_BUS;
using Polycafe_DTO;
using System.Drawing.Drawing2D;
using System.Diagnostics;
namespace Polycafe_GUI
{

    public partial class CaiDat : UserControl
    {

        private string connectionString = "Data Source=.;Initial Catalog=QLPolycafe;Integrated Security=True;";
        private NhanVienBLL nhanVienBLL;
        private HoSo_BUS bus = new HoSo_BUS(); 
        private string userEmail;

        public CaiDat(string email)
        {
            InitializeComponent();
            nhanVienBLL = new NhanVienBLL(connectionString);
            this.userEmail = email;
            LoadUser();
            LoadGioiThieuPolyCafe(); // Gọi phương thức này khi Form được khởi tạo

        }
        private void LoadGioiThieuPolyCafe()
        {
           
            string gioiThieu = "                  ----------------------------------------------------------------\r\n" +
                               "                            Giới thiệu Hệ thống quản lý PolyCafe\r\n" +
                               "                  ----------------------------------------------------------------\r\n\r\n" +
                               "Chào mừng bạn đến với Hệ thống quản lý PolyCafe – giải pháp phần mềm toàn diện được phát triển bởi Nhóm 2.\r\n\r\n" +
                               "Các thành viên:\r\n" +
                               "        * Nguyễn Huỳnh Kim Ngân\r\n" +
                               "        * Trịnh Minh Uyên\r\n" +
                               "        * Võ Phan Hoàng Dung\r\n\r\n" +
                               "PolyCafe được thiết kế đặc biệt nhằm tối ưu hóa và đơn giản hóa mọi quy trình vận hành trong các quán cà phê, từ quản lý đơn hàng, kho hàng đến chăm sóc khách hàng. Với giao diện trực quan và các tính năng mạnh mẽ, hệ thống hứa hẹn sẽ mang lại hiệu quả vượt trội, giúp chủ quán dễ dàng kiểm soát và phát triển công việc kinh doanh của mình.";

          
            this.richTextBox2.Text = gioiThieu;

            this.richTextBox2.ReadOnly = true;

           
        }
       
       
        private void LoadUser()
        {

            DataTable userInfo = bus.Getuser(userEmail);
            if (userInfo.Rows.Count > 0)
            {
                textBox5.Text = userInfo.Rows[0]["HoTen"].ToString();
                textBox6.Text = userInfo.Rows[0]["Email"].ToString();
                textBox7.Text = Convert.ToBoolean(userInfo.Rows[0]["VaiTro"]) ? "Quản Lý" : "Nhân viên Bán Hàng ";
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkShowOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPassword.PasswordChar = chkShowOldPassword.Checked ? '\0' : '*';
        }

        private void chkShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = chkShowNewPassword.Checked ? '\0' : '*';
        }

        private void chkShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = chkShowConfirmPassword.Checked ? '\0' : '*';
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            ChangePasswordDTO changePassword = new ChangePasswordDTO()
            {
                Email = email,
                OldPassword = oldPassword,
                NewPassword = newPassword,
                ConfirmPassword = confirmPassword
            };

            try
            {
                // Kiểm tra các trường dữ liệu đầu vào
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra tài khoản và mật khẩu hiện tại
                if (!nhanVienBLL.CheckAccount(email, oldPassword))
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra mật khẩu mới và xác nhận mật khẩu
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu không có lỗi nào xảy ra, hiển thị messagebox xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (nhanVienBLL.ChangePassword(changePassword))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtOldPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtConfirmPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi đổi mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Nếu người dùng chọn "No" trong messagebox xác nhận, không thực hiện đổi mật khẩu
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaiDat_Load(object sender, EventArgs e)
        {
            
        }

        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
    }
    
}


