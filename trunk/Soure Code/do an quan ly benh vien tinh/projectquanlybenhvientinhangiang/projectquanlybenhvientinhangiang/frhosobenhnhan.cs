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
    public partial class frhosobenhnhan : Form
    {
        public frhosobenhnhan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        string strcon = "";
        string strcmd = "";
        string strsql = "";
        DataTable dt;
        SqlConnection objcon;
        SqlCommand objcmd;
        SqlDataReader objrdr = null;
        DataSet dsbenhnhan;
        SqlDataAdapter dabenhnhan;
        Boolean kt;
        private void Ketnoi()
        {
            strcon = "Server=4738G-PC\\SQLEXPRESS;DataBase=quanlybenhvientinh;Integrated Security=SSPI";
            objcon = new SqlConnection(strcon);
            objcon.Open();
        }
        private void Hienthi()
        {
            dsbenhnhan = new DataSet();
            dabenhnhan = new SqlDataAdapter("select*from tbbenhnhan", objcon);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(dabenhnhan);
            dabenhnhan.Fill(dsbenhnhan, "tbbenhnhan");
            dgwbenhnhan.DataSource = dsbenhnhan;
            dgwbenhnhan.DataMember = "tbbenhnhan";
        }
        private bool kiemtra() //ham kiem tra 
        {
            kt = true;
            if (txtmabn.Text == "")
            {
                MessageBox.Show("Mã Số Bệnh Nhân Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmabn.Focus();
                kt = false;
            }
            else if (txtmadk.Text == "")
            {
                MessageBox.Show("Mã Đợt Khám Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmadk.Focus();
                kt = false;
            }
            else if (txthobn.Text == "")
            {
                MessageBox.Show("Họ Bệnh Nhân Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthobn.Focus();
                kt = false;
            }
            else if (txttenbn.Text == "")
            {
                MessageBox.Show("Tên Bệnh Nhân Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenbn.Focus();
                kt = false;
            }
            else if (txtngaysinh.Text == "")
            {
                MessageBox.Show("Ngày Sinh Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngaysinh.Focus();
                kt = false;
            }
            else if (txttuoi.Text == "")
            {
                MessageBox.Show("Tuổi Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttuoi.Focus();
                kt = false;
            }
            else if (cbogioitinh.Text == "")
            {
                MessageBox.Show("Giới Tính Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbogioitinh.Focus();
                kt = false;
            }
            else if (cbodiachi.Text == "")
            {
                MessageBox.Show("Địa Chỉ Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbodiachi.Focus();
                kt = false;
            }
            else if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Điện Thoại Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdienthoai.Focus();
                kt = false;
            }
            else if (txtchuandoan.Text == "")
            {
                MessageBox.Show("Chuẩn Đoán Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtchuandoan.Focus();
                kt = false;
            }
            else if (cbobhyt.Text == "")
            {
                MessageBox.Show("Bảo Hiểm Y Tế Không Được Rỗng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbobhyt.Focus();
                kt = false;
            }
            else
            {
                try
                {
                    strsql = "insert into tbbenhnhan values('" + txtmabn.Text + "',N'" + txtmadk.Text + "',N'" + txthobn.Text + "', N'" + txttenbn.Text + "', N'" + txtngaysinh.Text + "', N'" + txttuoi.Text + "', N'" + cbogioitinh.Text + "', N'" + cbodiachi.Text + "', N'" + txtdienthoai.Text + "', N'" + txtchuandoan.Text + "', N'" + cbobhyt.Text + "')";
                    objcmd = new SqlCommand(strsql, objcon);
                    objcmd.ExecuteNonQuery();
                    Hienthi();
                    txtmabn.Text = "";
                    txtmadk.Text= "";
                    txthobn.Text = "";
                    txttenbn.Text = "";
                    txtngaysinh.Text = "";
                    txttuoi.Text = "";
                    cbogioitinh.Text = "";
                    cbodiachi.Text = "";
                    txtdienthoai.Text = "";
                    txtchuandoan.Text = "";
                    cbobhyt.Text = "";

                    txtmabn.Focus();
                }
                catch (Exception)
                {

                }
            }

            return kt;
        } 

        private void frhosobenhnhan_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Ketnoi();
            Hienthi();
            txtmabn.Focus();
            cbogioitinh.Items.Add("Nam");
            cbogioitinh.Items.Add("Nữ");

            //cbobhyt.Items.Add("co");
            //cbobhyt.Items.Add("khong");

            cbodiachi.Items.Add("An Giang");
            cbodiachi.Items.Add("Vĩnh Long");
            cbodiachi.Items.Add("Trà Vinh");
            cbodiachi.Items.Add("Cần Thơ");
            cbodiachi.Items.Add("Hậu Giang");
            cbodiachi.Items.Add("Cà Mau");
            cbodiachi.Items.Add("Đồng Tháp");
            cbodiachi.Items.Add("Nhập Địa Chỉ Khác");
        }

        private void dgwbenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmabn.Text = dgwbenhnhan.CurrentRow.Cells[0].Value.ToString();
            txtmadk.Text = dgwbenhnhan.CurrentRow.Cells[1].Value.ToString();
            txthobn.Text = dgwbenhnhan.CurrentRow.Cells[2].Value.ToString();
            txttenbn.Text = dgwbenhnhan.CurrentRow.Cells[3].Value.ToString();
            txtngaysinh.Text = dgwbenhnhan.CurrentRow.Cells[4].Value.ToString();
            cbogioitinh.Text = dgwbenhnhan.CurrentRow.Cells[5].Value.ToString();
            cbodiachi.Text = dgwbenhnhan.CurrentRow.Cells[8].Value.ToString();
            txtdienthoai.Text = dgwbenhnhan.CurrentRow.Cells[6].Value.ToString();
            txtchuandoan.Text = dgwbenhnhan.CurrentRow.Cells[7].Value.ToString();
            txttuoi.Text = dgwbenhnhan.CurrentRow.Cells[9].Value.ToString();
            cbobhyt.Text = dgwbenhnhan.CurrentRow.Cells[10].Value.ToString();
            //// txtManhom.ReadOnly = true;
            // btnThe.Enabled = false;
            // btnXoa.Enabled = true;
            // btnSua.Enabled = true;
        }
        private void InsertByAdapter()
        {
            Hienthi();
            kiemtra();
            if (kt == true)
            {
                strsql = "insert into tbbenhnhan values(@mabn, @madotkham, @hobn, @tenbn, @ngaysinh, @gioitinh, @dienthoai, @chuandoan, @diachi, @tuoi, @BHYT)";
                objcmd = new SqlCommand(strsql, objcon);

                SqlParameter mabn = new SqlParameter();
                mabn.ParameterName = "@mabn";
                mabn.Value = txtmabn.Text;
                objcmd.Parameters.Add(mabn);

                SqlParameter madotkham = new SqlParameter();
                madotkham.ParameterName = "@madotkham";
                madotkham.Value = txtmadk.Text;
                objcmd.Parameters.Add(madotkham);

                SqlParameter hobn = new SqlParameter();
                hobn.ParameterName = "@hobn";
                hobn.Value = txthobn.Text;
                objcmd.Parameters.Add(hobn);

                SqlParameter tenbn = new SqlParameter();
                tenbn.ParameterName = "@tenbn";
                tenbn.Value = txttenbn.Text;
                objcmd.Parameters.Add(tenbn);

                SqlParameter ngaysinh = new SqlParameter();
                ngaysinh.ParameterName = "@ngaysinh";
                ngaysinh.Value = txtngaysinh.Text;
                objcmd.Parameters.Add(ngaysinh);

                SqlParameter gioitinh = new SqlParameter();
                gioitinh.ParameterName = "@gioitinh";
                gioitinh.Value = cbogioitinh.Text;
                objcmd.Parameters.Add(gioitinh);

                SqlParameter dienthoai = new SqlParameter();
                dienthoai.ParameterName = "@dienthoai";
                dienthoai.Value = txtdienthoai.Text;
                objcmd.Parameters.Add(dienthoai);

                SqlParameter chuandoan = new SqlParameter();
                chuandoan.ParameterName = "@chuandoan";
                chuandoan.Value = txtchuandoan.Text;
                objcmd.Parameters.Add(chuandoan);

                SqlParameter diachi = new SqlParameter();
                diachi.ParameterName = "@diachi";
                diachi.Value = cbodiachi.Text;
                objcmd.Parameters.Add(diachi);

                SqlParameter tuoi = new SqlParameter();
                tuoi.ParameterName = "@tuoi";
                tuoi.Value = txttuoi.Text;
                objcmd.Parameters.Add(tuoi);

                SqlParameter BHYT = new SqlParameter();
                BHYT.ParameterName = "@BHYT";
                BHYT.Value = cbobhyt.Text;
                objcmd.Parameters.Add(BHYT);

                objcmd.ExecuteScalar();
                objcon.Close();
                Hienthi();
                MessageBox.Show("Bạn Đã Thêm Thông Tin Bệnh Nhân Thành Công !", "THÔNG BÁO", MessageBoxButtons.OK);
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
                MessageBox.Show("Mã Số Bệnh Nhân Này Hiện Tồn Tại!!Vui Lòng Kiểm Tra Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmabn.Text.Length > 0) //kt xem co sinhvien_id trong csdl hay k
            {
                kiemtra();
                if (kt == true)
                {
                    Ketnoi();
                    SqlCommand objcmd = new SqlCommand();
                    objcmd.Connection = objcon;
                    objcmd.CommandType = CommandType.Text;
                    objcmd.CommandText = "Update tbbenhnhan " +
                                   "Set madotkham=@madotkham,hobn=@hobn,tenbn=@tenbn,ngaysinh=@ngaysinh, gioitinh=@gioitinh, dienthoai=@dienthoai, chuandoan=@chuandoan, diachi=@diachi, tuoi=@tuoi, BHYT=@BHYT " +
                                             "Where mabn=@mabn";
                    objcmd.Parameters.Add("@mabn", SqlDbType.NVarChar).Value = txtmabn.Text;
                    objcmd.Parameters.Add("@madotkham", SqlDbType.NVarChar).Value = txtmadk.Text;
                    objcmd.Parameters.Add("@hobn", SqlDbType.NVarChar).Value = txthobn.Text;
                    objcmd.Parameters.Add("@tenbn", SqlDbType.NVarChar).Value = txttenbn.Text;
                    objcmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = txtngaysinh.Text;
                    objcmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = cbogioitinh.Text;
                    objcmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = txtdienthoai.Text;
                    objcmd.Parameters.Add("@chuandoan", SqlDbType.NVarChar).Value = txtchuandoan.Text;
                    objcmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = cbodiachi.Text;
                    objcmd.Parameters.Add("@tuoi", SqlDbType.NVarChar).Value = txttuoi.Text;
                    objcmd.Parameters.Add("@BHYT", SqlDbType.NVarChar).Value = cbobhyt.Text;

                    objcmd.ExecuteNonQuery();
                    //Hủy đối tượng
                    objcmd.Dispose();
                    objcmd = null;
                    Hienthi();
                    MessageBox.Show("Bạn Đã Sửa Thông Tin Bệnh Nhân Thành Công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
             string strmabn = txtmabn.Text;
            DialogResult tl;
            tl = MessageBox.Show("Bạn Có Muốn Xóa Thông Tin Bệnh Nhân Có Mã Số  " + strmabn + "  Không ? ", "Cảnh Báo Xóa Dữ Liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
               strsql = "delete from tbbenhnhan where mabn='" + txtmabn.Text + "'";
               objcmd = new SqlCommand(strsql, objcon);
               objcmd.ExecuteNonQuery();
               Hienthi();
               MessageBox.Show("Bạn Đã Xóa Thông Tin Bệnh Nhân Thành Công !", "THÔNG BÁO", MessageBoxButtons.OK);
           
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From Hồ Sơ Bệnh Nhân không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtmabn.Text = "";
            txtmadk.Text = "";
            txthobn.Text="";
            txttenbn.Text = "";
            txtngaysinh.Text = "";
            txttuoi.Text = "";
            cbogioitinh.Text = "";
            cbodiachi.Text = "";
            txtdienthoai.Text = "";
            txtchuandoan.Text = "";
            cbobhyt.Text = "";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
