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
    public partial class frdoimatkhau : Form
    {
        public frdoimatkhau()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From Đổi Mật Khẩu Tài Khoản  không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        string strcon = "";
        string strcmd = "";
        string strsql = "";
        DataTable dt;
        SqlConnection objcon;
        SqlCommand objcmd;
        SqlDataReader objrdr = null;
        DataSet dsdoimatkhau;
        SqlDataAdapter dadoimatkhau;
        Boolean kt;
        private void Ketnoi()
        {
            strcon = "Server=4738-PC\\SQLEXPRESS;DataBase=quanlybenhvientinh;Integrated Security=SSPI";
            objcon = new SqlConnection(strcon);
            objcon.Open();
        }
        private void Hienthi()
        {
            dsdoimatkhau = new DataSet();
            dadoimatkhau = new SqlDataAdapter("select*from tbtaikhoan", objcon);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(dadoimatkhau);
            dadoimatkhau.Fill(dsdoimatkhau, "tbtaikhoan");
            dgwdoimatkhau.DataSource = dsdoimatkhau;
            dgwdoimatkhau.DataMember = "tbtaikhoan";
        }
        private void frdoimatkhau_Load(object sender, EventArgs e)
        {
            txttendangnhap.Focus();
            Ketnoi();
            Hienthi();
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void Update_dulieu()
        {
            Ketnoi();
            strsql = "Update tbtaikhoan Set tendangnhap='" + txttendangnhap.Text + "',matkhau='" + txtmatkhaumoi.Text + "' Where tendangnhap='" + txttendangnhap.Text + "'";
            objcmd = new SqlCommand(strsql, objcon);
            objcmd.ExecuteNonQuery();

        }
       

        private void dgwdoimatkhau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttendangnhap.Text = dgwdoimatkhau.CurrentRow.Cells[0].Value.ToString();
           
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txttendangnhap.Text = "";
            txtmatkhaucu.Text = "";
            txtmatkhaumoi.Text = "";
            txtnhaplaimatkhau.Text = "";
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmatkhaucu.Text == "" || txtmatkhaumoi.Text == "" || txtnhaplaimatkhau.Text == "")
                {
                    MessageBox.Show("Thông Tin Bạn Điền Chưa Đầy Đủ, Vui Lòng Kiểm Tra Lại", "THÔNG BÁO LỖI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtmatkhaumoi.Text != txtnhaplaimatkhau.Text)
                {
                    MessageBox.Show("Mật Khẩu Mới Phải Giống Nhập Lại Mật Khẩu Mới", "THÔNG BÁO LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Ketnoi();
                    strsql = "SELECT * from tbtaikhoan where tendangnhap = '" + txttendangnhap.Text + "' ";
                    objcmd= new SqlCommand(strsql, objcon);
                    objrdr = objcmd.ExecuteReader();
                    objrdr.Read();

                    if (txtmatkhaucu.Text == objrdr["matkhau"].ToString())
                    {

                        Update_dulieu();
                        MessageBox.Show(" Bạn Đã Đổi Mật Khẩu Thành Công", " THÔNG BÁO");
                        this.Close();

                    }

                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu Cũ", "THÔNG BÁO LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    objrdr.Close();
                    objcon.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Tên Đăng Nhập Và Mật Khẩu Không Hợp Lệ", "THÔNG BÁO LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
         }
    }
}
