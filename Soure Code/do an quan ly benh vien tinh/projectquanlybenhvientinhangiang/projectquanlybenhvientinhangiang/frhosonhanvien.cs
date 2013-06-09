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
    public partial class frhosonhanvien : Form
    {
        public frhosonhanvien()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void InsertByAdapter()
        {
            Hienthi();
            kiemtra();
            if (kt == true)
            {
                strsql = "insert into tbnhanvien values(@manv, @honv, @tennv, @ngaysinh, @diachi, @madv, @tendv, @macm, @tencm, @macv, @tencv, @email, @dienthoai, @gioitinh) ";
                objcmd = new SqlCommand(strsql, objcon);

                SqlParameter manv = new SqlParameter();
                manv.ParameterName = "@manv";
                manv.Value = txtmanv.Text;
                objcmd.Parameters.Add(manv);

                SqlParameter honv = new SqlParameter();
                honv.ParameterName = "@honv";
                honv.Value = txthonv.Text;
                objcmd.Parameters.Add(honv);

                SqlParameter tennv = new SqlParameter();
                tennv.ParameterName = "@tennv";
                tennv.Value = txttennv.Text;
                objcmd.Parameters.Add(tennv);

                SqlParameter ngaysinh = new SqlParameter();
                ngaysinh.ParameterName = "@ngaysinh";
                ngaysinh.Value = txtngaysinh.Text;
                objcmd.Parameters.Add(ngaysinh);

                SqlParameter diachi = new SqlParameter();
                diachi.ParameterName = "@diachi";
                diachi.Value = cbodiachi.Text;
                objcmd.Parameters.Add(diachi);

                SqlParameter madv = new SqlParameter();
                madv.ParameterName = "@madv";
                madv.Value = txtmadv.Text;
                objcmd.Parameters.Add(madv);

                SqlParameter tendv = new SqlParameter();
                tendv.ParameterName = "@tendv";
                tendv.Value = cbotendv.Text;
                objcmd.Parameters.Add(tendv);

                SqlParameter macm = new SqlParameter();
                macm.ParameterName = "@macm";
                macm.Value = txtmacm.Text;
                objcmd.Parameters.Add(macm);

                SqlParameter tencm = new SqlParameter();
                tencm.ParameterName = "@tencm";
                tencm.Value = cbotencm.Text;
                objcmd.Parameters.Add(tencm);

                SqlParameter macv = new SqlParameter();
                macv.ParameterName = "@macv";
                macv.Value = txtmacv.Text;
                objcmd.Parameters.Add(macv);

                SqlParameter tencv = new SqlParameter();
                tencv.ParameterName = "@tencv";
                tencv.Value = cbotencv.Text;
                objcmd.Parameters.Add(tencv);

                SqlParameter email = new SqlParameter();
                email.ParameterName = "@email";
                email.Value = txtemail.Text;
                objcmd.Parameters.Add(email);

                SqlParameter dienthoai = new SqlParameter();
                dienthoai.ParameterName = "@dienthoai";
                dienthoai.Value = txtdienthoai.Text;
                objcmd.Parameters.Add(dienthoai);

                SqlParameter gioitinh = new SqlParameter();
                gioitinh.ParameterName = "@gioitinh";
                gioitinh.Value = cbogioitinh.Text;
                objcmd.Parameters.Add(gioitinh);

                objcmd.ExecuteScalar();
                objcon.Close();
                Hienthi();
                MessageBox.Show("Bạn Đã Thêm Thông Tin Nhân Viên Thành Công !", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InsertByAdapter();
                Hienthi();

            }
            catch (SqlException)
            {
                MessageBox.Show("Mã Số Nhân Viên Này Hiện Tồn Tại!!Vui Lòng Kiểm Tra Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text.Length > 0) //kt xem co sinhvien_id trong csdl hay k
            {
                kiemtra();
                if (kt == true)
                {
                    Ketnoi();
                    SqlCommand objcmd = new SqlCommand();
                    objcmd.Connection = objcon;
                    objcmd.CommandType = CommandType.Text;
                    objcmd.CommandText = "Update tbnhanvien " +
                                   "Set honv=@honv,tennv=@tennv,ngaysinh=@ngaysinh, diachi=@diachi, madv=@madv, tendv=@tendv, macm=@macm, tencm=@tencm, macv=@macv, tencv=@tencv, email=@email,dienthoai=@dienthoai, gioitinh=@gioitinh " +
                                             "Where manv=@manv";
                    objcmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = txtmanv.Text;
                    objcmd.Parameters.Add("@honv", SqlDbType.NVarChar).Value = txthonv.Text;
                    objcmd.Parameters.Add("@tennv", SqlDbType.NVarChar).Value = txttennv.Text;
                    objcmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = txtngaysinh.Text;
                    objcmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = cbodiachi.Text;
                    objcmd.Parameters.Add("@madv", SqlDbType.NVarChar).Value = txtmadv.Text;
                    objcmd.Parameters.Add("@tendv", SqlDbType.NVarChar).Value = cbotendv.Text;
                    objcmd.Parameters.Add("@macm", SqlDbType.NVarChar).Value = txtmacm.Text;
                    objcmd.Parameters.Add("@tencm", SqlDbType.NVarChar).Value = cbotencm.Text;
                    objcmd.Parameters.Add("@macv", SqlDbType.NVarChar).Value = txtmacv.Text;
                    objcmd.Parameters.Add("@tencv", SqlDbType.NVarChar).Value = cbotencv.Text;
                    objcmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtemail.Text;
                    objcmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = txtdienthoai.Text;
                    objcmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = cbogioitinh.Text;

                    objcmd.ExecuteNonQuery();
                    //Hủy đối tượng
                    objcmd.Dispose();
                    objcmd = null;
                    Hienthi();
                    MessageBox.Show("Bạn Đã Sửa Thông Tin Nhân Viên Thành Công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        string strcon = "";
        string strcmd = "";
        string strsql = "";
        DataTable dt;
        SqlConnection objcon;
        SqlCommand objcmd;
        SqlDataReader objrdr = null;
        DataSet dsnhanvien;
        SqlDataAdapter danhanvien;
        Boolean kt;
        private void Ketnoi()
        {
            strcon = "Server=4738G-PC\\SQLEXPRESS;DataBase=quanlybenhvientinh;Integrated Security=SSPI";
            objcon = new SqlConnection(strcon);
            objcon.Open();
        }
        private void Hienthi()
        {
            dsnhanvien = new DataSet();
            danhanvien = new SqlDataAdapter("select*from tbnhanvien", objcon);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(danhanvien);
            danhanvien.Fill(dsnhanvien, "tbnhanvien");
            dgwnhanvien.DataSource = dsnhanvien;
            dgwnhanvien.DataMember = "tbnhanvien";
        }
        private bool kiemtra() //ham kiem tra 
        {
            kt = true;
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Mã Số Nhân Viên Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
                kt = false;
            }
            else if (txthonv.Text == "")
            {
                MessageBox.Show("Họ Nhân Viên Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthonv.Focus();
                kt = false;
            }
           
            else if (txttennv.Text == "")
            {
                MessageBox.Show("Tên Nhân Viên Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttennv.Focus();
                kt = false;
            }
            else if (cbotendv.Text == "")
            {
                MessageBox.Show("Tên Đơn Vị Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbotendv.Focus();
                kt = false;
            }
            else if (cbotencv.Text == "")
            {
                MessageBox.Show("Tên Chức Vụ Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbotencv.Focus();
                kt = false;
            }
            else if (cbotencm.Text == "")
            {
                MessageBox.Show("Tên Chuyên Môn Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbotencm.Focus();
                kt = false;
            }
            else if (txtngaysinh.Text == "")
            {
                MessageBox.Show("Ngày Sinh Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngaysinh.Focus();
                kt = false;
            }
            else if (cbodiachi.Text == "")
            {
                MessageBox.Show("Địa Chỉ Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbodiachi.Focus();
                kt = false;
            }
            else if (cbogioitinh.Text == "")
            {
                MessageBox.Show("Giới Tính Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbogioitinh.Focus();
                kt = false;
            }
            else if (txtmadv.Text == "")
            {
                MessageBox.Show("Mã Đơn Vị Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmadv.Focus();
                kt = false;
            }
            else if (txtmacv.Text == "")
            {
                MessageBox.Show("Mã Chức Vụ Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmacv.Focus();
                kt = false;
            }
            else if (txtmacm.Text == "")
            {
                MessageBox.Show("Mã Chuyên Môn Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmacm.Focus();
                kt = false;
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Email Nhân Viên Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
                kt = false;
            }
            else if (txtdienthoai.Text == "")
            {
                MessageBox.Show(" Điện Thoại Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttennv.Focus();
                kt = false;
            }
            else
            {
                try
                {
                    strsql = "insert into tbnhanvien values('" + txtmanv.Text + "',N'" + txthonv.Text + "',N'" + txttennv.Text + "', N'" + cbotendv.Text + "', N'" + cbotencv.Text + "', N'" + cbotencm.Text + "', N'" + txtngaysinh.Text + "', N'" + cbodiachi.Text + "', N'" + cbogioitinh.Text + "', N'" + txtmadv.Text + "', N'" + txtmacv.Text + "', N'" + txtmacm.Text + "', N'" + txtemail.Text + "', N'" + txtdienthoai.Text + "')";
                    objcmd = new SqlCommand(strsql, objcon);
                    objcmd.ExecuteNonQuery();
                    Hienthi();
                    txtmanv.Text = "";
                    txthonv.Text = "";
                    txttennv.Text = "";
                    cbotendv.Text = "";
                    cbotencv.Text = "";
                    cbotencm.Text = "";
                    txtngaysinh.Text = "";
                    cbodiachi.Text = "";
                    cbogioitinh.Text = "";
                    txtmadv.Text = "";
                    txtmacv.Text = "";
                    txtmacm.Text = "";
                    txtemail.Text = "";
                    txtdienthoai.Text = "";
                    txtmanv.Focus();
                }
                catch (Exception)
                {

                }
            }

            return kt;
        } 
        private void frhosonhanvien_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Ketnoi();
            Hienthi();
            txtmanv.Focus();
            cbotendv.Items.Add("Khoa Nội");
            cbotendv.Items.Add("Khoa Ngoại");
            cbotendv.Items.Add("Khoa Nhi");
            cbotendv.Items.Add("Khoa Sản");
            cbotendv.Items.Add("Khoa Tai Mũi Họng");
            cbotendv.Items.Add("Khoa Răng Hàm Mặt");
            cbotendv.Items.Add("Khoa Lao");

            cbotencv.Items.Add("Giám Đốc Bệnh Viện");
            cbotencv.Items.Add("Phó Giám Đốc Chuyên Môn");
            cbotencv.Items.Add("Phó Giám Đốc CSVC");
            cbotencv.Items.Add("Trưởng Phòng Tổ Chức");
            cbotencv.Items.Add("Trưởng Khoa Nội");
            cbotencv.Items.Add("Trưởng Khoa Ngoại");
            cbotencv.Items.Add("Trưởng Khoa Nhi");
            cbotencv.Items.Add("Trưởng Khoa Sản");
            cbotencv.Items.Add("Trưởng Khoa Tai Mũi Họng");
            cbotencv.Items.Add("Trưởng Khoa Răng Hàm Mặt");
            cbotencv.Items.Add("Trưởng Khoa Lao");

            cbotencm.Items.Add("Cấp Cứu");
            cbotencm.Items.Add("Siêu Âm");
            cbotencm.Items.Add("Chụp XQuang");
            cbotencm.Items.Add("Chụp CT");
            cbotencm.Items.Add("Nội Soi");
            cbotencm.Items.Add("Phẫu Thuật");
            cbotencm.Items.Add("Đo Điện Tim");

            cbogioitinh.Items.Add("Nam");
            cbogioitinh.Items.Add("Nữ");

            cbodiachi.Items.Add("An Giang");
            cbodiachi.Items.Add("Vĩnh Long");
            cbodiachi.Items.Add("Kiên Giang");
            cbodiachi.Items.Add("Cà Mau");
            cbodiachi.Items.Add("Hậu Giang");
            cbodiachi.Items.Add("Cần Thơ");
            cbodiachi.Items.Add("Đồng Tháp");
            cbodiachi.Items.Add("Trà Vinh");
            cbodiachi.Items.Add("Nhập Địa Chỉ Khác");
        }

        private void dgwnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dgwnhanvien.CurrentRow.Cells[0].Value.ToString();
            txthonv.Text = dgwnhanvien.CurrentRow.Cells[1].Value.ToString();
            txttennv.Text = dgwnhanvien.CurrentRow.Cells[2].Value.ToString();
            txtngaysinh.Text = dgwnhanvien.CurrentRow.Cells[3].Value.ToString();
            cbodiachi.Text = dgwnhanvien.CurrentRow.Cells[4].Value.ToString();
            txtmadv.Text = dgwnhanvien.CurrentRow.Cells[5].Value.ToString();
            cbotendv.Text = dgwnhanvien.CurrentRow.Cells[6].Value.ToString();
            txtmacm.Text = dgwnhanvien.CurrentRow.Cells[7].Value.ToString();
            cbotencm.Text = dgwnhanvien.CurrentRow.Cells[8].Value.ToString();
            txtmacv.Text = dgwnhanvien.CurrentRow.Cells[9].Value.ToString();
            cbotencv.Text = dgwnhanvien.CurrentRow.Cells[10].Value.ToString();
            txtemail.Text = dgwnhanvien.CurrentRow.Cells[11].Value.ToString();
            txtdienthoai.Text = dgwnhanvien.CurrentRow.Cells[12].Value.ToString();
            cbogioitinh.Text = dgwnhanvien.CurrentRow.Cells[13].Value.ToString();
            //// txtManhom.ReadOnly = true;
            // btnThe.Enabled = false;
            // btnXoa.Enabled = true;
            // btnSua.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            string strmanv = txtmanv.Text;
            DialogResult tl;
            tl = MessageBox.Show("Bạn Có Muốn Xóa Thông Tin  Nhân Viên Có Mã Số  " + strmanv + "  Không ? ", "Cảnh Báo Xóa Dữ Liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                strsql = "delete from tbnhanvien where manv='" + txtmanv.Text + "'";
                objcmd = new SqlCommand(strsql, objcon);
                objcmd.ExecuteNonQuery();
                Hienthi();
                MessageBox.Show("Bạn Đã Xóa Thông Tin Nhân Viên Thành Công !", "THÔNG BÁO", MessageBoxButtons.OK);

            }
           
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From Hồ Sơ Nhân Viên  không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtmanv.Text = "";
            txthonv.Text = "";
            txttennv.Text = "";
            cbotendv.Text = "";
            cbotencv.Text = "";
            cbotencm.Text = "";
            txtngaysinh.Text = "";
            cbodiachi.Text = "";
            cbogioitinh.Text = "";
            txtmadv.Text = "";
            txtmacv.Text = "";
            txtmacm.Text = "";
            txtemail.Text = "";
            txtdienthoai.Text = "";

        }
    }
}
