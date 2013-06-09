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
    public partial class frquanlytaikhoan : Form
    {
        public frquanlytaikhoan()
        {
            InitializeComponent();
        }
        string strcon = "";
        string strcmd = "";
        string strsql = "";
        DataTable dt;
        SqlConnection objcon;
        SqlCommand objcmd;
        SqlDataReader objrdr = null;
        DataSet dstaikhoan;
        SqlDataAdapter dataikhoan;
        Boolean kt;
        private void Ketnoi()
        {
            strcon = "Server=4738-PC\\SQLEXPRESS;DataBase=quanlybenhvientinh;Integrated Security=SSPI";
            objcon = new SqlConnection(strcon);
            objcon.Open();
        }
        private void Hienthi()
        {
            dstaikhoan = new DataSet();
            dataikhoan = new SqlDataAdapter("select * from tbtaikhoan", objcon);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(dataikhoan);
            dataikhoan.Fill(dstaikhoan, "tbtaikhoan");
            dgwtaikhoan.DataSource = dstaikhoan;
            dgwtaikhoan.DataMember = "tbtaikhoan";
        }
        private void frquanlytaikhoan_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Ketnoi();
            Hienthi();
            txttendangnhap.Focus();
            cboquyentruycap.Items.Add("admin");
            cboquyentruycap.Items.Add("Nhân Viên");
            cboquyentruycap.Items.Add("Bệnh Án");
        }
        private bool kiemtra() //ham kiem tra 
        {
            kt = true;
            if (txttendangnhap.Text == "")
            {
                MessageBox.Show("Tên Đăng Nhập không được rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttendangnhap.Focus();
                kt = false;
            }
            else if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Mật Khẩu không được rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmatkhau.Focus();
                kt = false;
            }
            else if (cboquyentruycap.Text == "")
            {
                MessageBox.Show("Quyền Truy Cập không được rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboquyentruycap.Focus();
                kt = false;
            }


            else
            {
                try
                {
                    strsql = "insert into tbtaikhoan values('" + txttendangnhap.Text + "',N'" + txtmatkhau.Text + "',N'" + cboquyentruycap.Text + "')";
                    objcmd = new SqlCommand(strsql, objcon);
                    objcmd.ExecuteNonQuery();
                    Hienthi();
                    txttendangnhap.Text = "";
                    txtmatkhau.Text = "";
                    cboquyentruycap.Text = "";



                    txttendangnhap.Focus();
                }
                catch (Exception)
                {

                }
            }

            return kt;
        }
        private void InsertByAdapter()
        {
            if (txttendangnhap.Text == "" || txtmatkhau.Text == "" || cboquyentruycap.Text == "")
            {
                MessageBox.Show(" Thông Tin Bạn Điền Chưa Đầy Đủ", "THÔNG BÁO LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                strsql = @"INSERT INTO tbtaikhoan(tendangnhap,matkhau,phanquyen)VALUES(@tendangnhap,@matkhau,@phanquyen)";
                objcmd = new SqlCommand(strsql, objcon);
                objcmd.Parameters.Add("@tendangnhap", SqlDbType.NVarChar, 50);
                objcmd.Parameters.Add("@matkhau", SqlDbType.NVarChar, 50);
                objcmd.Parameters.Add("@phanquyen", SqlDbType.NVarChar, 50);

                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                objcmd.Parameters["@tendangnhap"].Value = txttendangnhap.Text;
                objcmd.Parameters["@matkhau"].Value = txtmatkhau.Text;
                objcmd.Parameters["@phanquyen"].Value = cboquyentruycap.Text;
                objcmd.ExecuteNonQuery();
                Hienthi();
                MessageBox.Show("Bạn Đã Thêm Thông Tin Tài Khoản Thành Công !", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        private void dgwtaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttendangnhap.Text = dgwtaikhoan.CurrentRow.Cells[0].Value.ToString();
            txtmatkhau.Text = dgwtaikhoan.CurrentRow.Cells[1].Value.ToString();
            cboquyentruycap.Text = dgwtaikhoan.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txttendangnhap.Text.Length > 0) //kt xem co sinhvien_id trong csdl hay k
            {
                kiemtra();
                if (kt == true)
                {
                    Ketnoi();
                    SqlCommand objcmd = new SqlCommand();
                    objcmd.Connection = objcon;
                    objcmd.CommandType = CommandType.Text;
                    objcmd.CommandText = "Update tbtaikhoan " +
                                   "Set matkhau=@matkhau,phanquyen=@phanquyen " +
                                             "Where tendangnhap=@tendangnhap";
                    objcmd.Parameters.Add("@tendangnhap", SqlDbType.NVarChar).Value = txttendangnhap.Text;
                    objcmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = txtmatkhau.Text;
                    objcmd.Parameters.Add("@phanquyen", SqlDbType.NVarChar).Value = cboquyentruycap.Text;


                    objcmd.ExecuteNonQuery();
                    //Hủy đối tượng
                    objcmd.Dispose();
                    objcmd = null;
                    Hienthi();
                    MessageBox.Show("Bạn Đã Sửa Thông Tin Tài Khoản Thành Công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }

       }  

        private void btnthem_Click(object sender, EventArgs e)
        {
           
            try
            {
                InsertByAdapter();
                Hienthi();
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Tài Khoản Này Đã Có Rồi!!Vui Lòng Kiểm Tra Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string strtendanhnhap = txttendangnhap.Text;
            DialogResult tl;
            tl = MessageBox.Show("Bạn Có Muốn Xóa Tài Khoản " + strtendanhnhap + " Không ? ", "Cảnh Báo Xóa Dữ Liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                strsql = "delete from tbtaikhoan where tendangnhap='" + txttendangnhap.Text + "'";
            objcmd = new SqlCommand(strsql, objcon);
            objcmd.ExecuteNonQuery();
            Hienthi();
            MessageBox.Show("Bạn Đã Xóa Thông Tin Tài Khoản Thành Công !", "THÔNG BÁO", MessageBoxButtons.OK);

            }
          
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From Quản Lý Tài Khoản Này không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txttendangnhap.Text = "";
            txtmatkhau.Text = "";
            cboquyentruycap.Text = "";
        }
    }
}
