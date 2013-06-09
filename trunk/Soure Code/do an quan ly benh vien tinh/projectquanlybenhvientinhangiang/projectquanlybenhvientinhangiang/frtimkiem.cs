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
    public partial class frtimkiem : Form
    {
        public frtimkiem()
        {
            InitializeComponent();
        }
        string strcon = "";
        SqlConnection objcon;
        private void Ketnoi()
        {
            strcon = "Server=4738-PC\\SQLEXPRESS;DataBase=quanlybenhvientinh;Integrated Security=SSPI";
            objcon = new SqlConnection(strcon);
            objcon.Open();
        }
        #region "Tìm kiếm dữ liệu dữ liệu"
        private void timkiemtheomabenhnhan() // Tìm kiếm dữ liệu theo mã
        {
            Ketnoi(); // Tạo kết nối file Access
            // Tạo Command
            SqlCommand objcommand = new SqlCommand();
            objcommand.Connection = objcon;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From tbbenhnhan Where mabn LIKE '%" + txttimtheomabn.Text + "%' ORDER BY mabn";
            //Tạo đối tượng Adapter
            SqlDataAdapter objAdapter = new SqlDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            DataTable objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            dgwtim.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối

        }
        private void timtheotenbn() // Tìm kiếm dữ liệu theo mã
        {
            Ketnoi(); // Tạo kết nối file Access
            // Tạo Command
            SqlCommand objcommand = new SqlCommand();
            objcommand.Connection = objcon;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From tbbenhnhan Where tenbn LIKE '%" + txttimtheotenbn.Text + "%' ORDER BY tenbn";
            //Tạo đối tượng Adapter
            SqlDataAdapter objAdapter = new SqlDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            DataTable objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            dgwtim.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối

        }
        private void timtheodiachibn() // Tìm kiếm dữ liệu theo mã
        {
            Ketnoi(); // Tạo kết nối file Access
            // Tạo Command
            SqlCommand objcommand = new SqlCommand();
            objcommand.Connection = objcon;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From tbbenhnhan Where diachi LIKE '%" + txttimtheodiachibn.Text + "%' ORDER BY diachi";
            //Tạo đối tượng Adapter
            SqlDataAdapter objAdapter = new SqlDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            DataTable objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            dgwtim.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối

        }
        private void timtheomanv() // Tìm kiếm dữ liệu theo mã
        {
            Ketnoi(); // Tạo kết nối file Access
            // Tạo Command
            SqlCommand objcommand = new SqlCommand();
            objcommand.Connection = objcon;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From tbnhanvien Where manv LIKE '%" + txttimtheomanv.Text + "%' ORDER BY manv";
            //Tạo đối tượng Adapter
            SqlDataAdapter objAdapter = new SqlDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            DataTable objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            dgwtim.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối

        }
        private void timtheotennv() // Tìm kiếm dữ liệu theo mã
        {
            Ketnoi(); // Tạo kết nối file Access
            // Tạo Command
            SqlCommand objcommand = new SqlCommand();
            objcommand.Connection = objcon;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From tbnhanvien Where tennv LIKE '%" + txttimtheotennv.Text + "%' ORDER BY tennv";
            //Tạo đối tượng Adapter
            SqlDataAdapter objAdapter = new SqlDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            DataTable objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            dgwtim.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối

        }
        private void timtheodiachinv() // Tìm kiếm dữ liệu theo mã
        {
            Ketnoi(); // Tạo kết nối file Access
            // Tạo Command
            SqlCommand objcommand = new SqlCommand();
            objcommand.Connection = objcon;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = "Select * From tbnhanvien Where diachi LIKE '%" + txttimtheodiachinv.Text + "%' ORDER BY diachi";
            //Tạo đối tượng Adapter
            SqlDataAdapter objAdapter = new SqlDataAdapter();
            objAdapter.SelectCommand = objcommand;
            // Tạo DataTable nhận dữ liệu trả về
            DataTable objDataTable = new DataTable("abcd");
            objAdapter.Fill(objDataTable);
            // Gán dữ liệu vào dataGrid
            dgwtim.DataSource = objDataTable;
            // Hủy các đối tượng
            objcommand.Dispose();
            objcommand = null;
            objDataTable.Dispose();
            objDataTable = null;
            objAdapter.Dispose();
            objAdapter = null;
            // hủy kết nối

        }
        #endregion
        private void frtimkiem_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

     

        private void button2_Click(object sender, EventArgs e)
        {

            if (txttimtheotennv.Text == "")
            {
                MessageBox.Show(" Bạn Phải Nhập Tên Nhân Viên Cần Tìm, Không Được Rỗng Textbox Này!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttimtheotennv.Focus();
            }
            else
            {
                timtheotennv();
            }
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntimdiachibn_Click(object sender, EventArgs e)
        {
            
            if (txttimtheodiachibn.Text == "")
            {
                MessageBox.Show(" Bạn Phải Nhập Địa Chỉ Bệnh Nhân Cần Tìm, Không Được Rỗng Textbox Này!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttimtheodiachibn.Focus();
            }
            else
            {
                timtheodiachibn();
            }
            
        }

        private void btntimmanv_Click(object sender, EventArgs e)
        {
          
            if (txttimtheomanv.Text == "")
            {
                MessageBox.Show(" Bạn Phải Nhập Mã Số Nhân Viên Cần Tìm, Không Được Rỗng Textbox Này!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttimtheomanv.Focus();
            }
            else
            {
                timtheomanv();
            }
            
        }

        private void btntimdiachinv_Click(object sender, EventArgs e)
        {
           
            if (txttimtheodiachinv.Text == "")
            {
                MessageBox.Show(" Bạn Phải Nhập Địa Chỉ Nhân Viên Cần Tìm, Không Được Rỗng Textbox Này!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttimtheodiachinv.Focus();
            }
            else
            {
                timtheodiachinv();
            }
           
        }

        private void btntimmabn_Click_1(object sender, EventArgs e)
        {

            if (txttimtheomabn.Text == "")
            {
                MessageBox.Show(" Bạn Phải Nhập Mã Số Bệnh Nhân Cần Tìm, Không Được Rỗng Textbox Này!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttimtheomabn.Focus();
            }
            else
            {
                timkiemtheomabenhnhan();
            }
        }

        private void btntimtenbn_Click_1(object sender, EventArgs e)
        {
          
            if (txttimtheotenbn.Text=="")
            {
                MessageBox.Show(" Bạn Phải Nhập Tên Bệnh Nhân Cần Tìm, Không Được Rỗng Textbox Này!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttimtheotenbn.Focus();
            }
            else
            {
                timtheotenbn();
            }
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From Tìm Kiếm không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void dgwtim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
