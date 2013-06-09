using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projectquanlybenhvientinhangiang
{
    public partial class frdangnhap : Form
    {
        public frdangnhap()
        {
            InitializeComponent();
        }
        string strcon = "";
        string strcmd = "";
        string strsql = "";
        DataTable dt;
        SqlConnection objcon;
       
        #region "Kiểm tra tài khoản và quyền truy cập"
        public string CheckLogin(string name, string pass)
        {
            strcon = "Server=4738G-PC\\SQLEXPRESS;DataBase=quanlybenhvientinh;Integrated Security=SSPI";
            objcon = new SqlConnection(strcon);
            objcon.Open();
            string phanquyen = "";
            // Tạo Command
            SqlCommand objcmd = new SqlCommand("select phanquyen from tbtaikhoan where tendangnhap='" + name + "' and matkhau='" + pass + "'", objcon);
            SqlDataReader dr = objcmd.ExecuteReader();
            if (dr.Read())
            {
                phanquyen = dr["phanquyen"].ToString();
                objcon.Close();
                return phanquyen;
            }
            objcon.Close();
            return phanquyen;
        }
        // Kiểm tra user nếu tồn tại thì trả về quyền của user đó nếu không tồn tại thì trả về rỗng.
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txtdangnhap.Text, txtmatkhau.Text) != "")
            {
                if (CheckLogin(txtdangnhap.Text, txtmatkhau.Text) == "admin")
                {
                    frchinh fra = (frchinh)this.MdiParent;
                    fra.admin();
                    this.Close();
                    MessageBox.Show("Bạn đã đăng nhập bằng quyền Admin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (CheckLogin(txtdangnhap.Text, txtmatkhau.Text) == "Nhân Viên")
                {
                    frchinh frmmain = (frchinh)this.MdiParent;
                    frmmain.EnableNhanvien();
                    this.Close();
                    MessageBox.Show("Bạn đã đăng nhập với quyền Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (CheckLogin(txtdangnhap.Text, txtmatkhau.Text) == "Bệnh Án")
                {
                    frchinh frmmain = (frchinh)this.MdiParent;
                    frmmain.EnableKhach();
                    this.Close();
                    MessageBox.Show("Bạn đã đăng nhập với quyền Bệnh Án", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }
            else
            {
                MessageBox.Show("Nhập sai Tên Đăng Nhập Và Mật Khẩu", "THÔNG BÁO LỖI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi Form Đăng Nhập không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void frdangnhap_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }
    }
}
