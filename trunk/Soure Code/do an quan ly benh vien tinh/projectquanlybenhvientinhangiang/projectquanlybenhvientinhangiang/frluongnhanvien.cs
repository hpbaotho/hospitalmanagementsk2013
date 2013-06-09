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
    public partial class frluongnhanvien : Form
    {
        public frluongnhanvien()
        {
            InitializeComponent();
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
        DataSet dsluong;
        SqlDataAdapter daluong;
        Boolean kt;
        private void Ketnoi()
        {
            strcon = "Server=4738G-PC\\SQLEXPRESS;DataBase=quanlybenhvientinh;Integrated Security=SSPI";
            objcon = new SqlConnection(strcon);
            objcon.Open();
        }
        private void Hienthi()
        {
            dsluong = new DataSet();
            daluong = new SqlDataAdapter("select*from tbluongnhanvien", objcon);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(daluong);
            daluong.Fill(dsluong, "tbluongnhanvien");
            dgwluong.DataSource = dsluong;
            dgwluong.DataMember = "tbluongnhanvien";
        }
        private bool kiemtra() //ham kiem tra 
        {
            kt = true;
            if (cbManv.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập tên của Bệnh Nhân !", "Thông Báo", MessageBoxButtons.OK);
                kt = false;
            }
            else if (cbotennv.Text == "")
            {
                MessageBox.Show(" Bạn chưa chọn giới tính!", "Thông Báo", MessageBoxButtons.OK);
                kt = false;
            }
            return kt;
        } 
        private void frluongnhanvien_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Ketnoi();
            Hienthi();
            cbManv.Focus();
            strsql = "select manv, honv,tennv from tbnhanvien";
            objcmd = new SqlCommand(strsql, objcon);
            objrdr = objcmd.ExecuteReader();
            
            cbongachbac.Items.Add("Giáo Sư");
            cbongachbac.Items.Add("Bác Sĩ");
            cbongachbac.Items.Add("Y Tá");

            while (objrdr.Read())
            {
                cbManv.Items.Add(objrdr[0].ToString());
                cbohonv.Items.Add(objrdr[1].ToString());
                cbotennv.Items.Add(objrdr[2].ToString());
            }
            objrdr.Close();
        }

        private void dgwtinhluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cbManv.Text = dgwluong.CurrentRow.Cells[0].Value.ToString();
            ////cbohonv.Text = dgwluong.CurrentRow.Cells[1].Value.ToString();
            ////cbotennv.Text = dgwluong.CurrentRow.Cells[2].Value.ToString();
            //txtmucluong.Text = dgwluong.CurrentRow.Cells[3].Value.ToString();
            //txthesoluong.Text = dgwluong.CurrentRow.Cells[4].Value.ToString();
            //txtphucap.Text = dgwluong.CurrentRow.Cells[5].Value.ToString();
            //txtngaylam.Text = dgwluong.CurrentRow.Cells[6].Value.ToString();
            //txtngaythang.Text = dgwluong.CurrentRow.Cells[7].Value.ToString();
            //cbongachbac.Text = dgwluong.CurrentRow.Cells[8].Value.ToString();
            // //// txtManhom.ReadOnly = true;
            //// btnThe.Enabled = false;
            //// btnXoa.Enabled = true;
            //// btnSua.Enabled = true;
        }

       

      private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From Lương Nhân Viên không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void btntinhluong_Click_1(object sender, EventArgs e)
        {
            cltinhluong cl = new cltinhluong();
            float mucluong, HeSoLuong, phucap, ngaythang, ngaylam;
            float kq = 0;
            mucluong = cl.chuyensangso(txtmucluong.Text);
            HeSoLuong = cl.chuyensangso(txthesoluong.Text);
            phucap = cl.chuyensangso(txtphucap.Text);
            ngaylam = cl.chuyensangso(txtngaylam.Text);
            ngaythang = cl.chuyensangso(txtngaythang.Text);
            kq = cl.tinhluong(mucluong, HeSoLuong, phucap, ngaythang, ngaylam);
            txttinhluong.Text = cl.chuyensangchuoi(kq);
            strsql = "update tbluongnhanvien set tongtienluong='" + txttinhluong.Text + "' where manv='" + cbManv.Text + "'";
            objcmd = new SqlCommand(strsql, objcon);

            objcmd.ExecuteNonQuery();
            Hienthi();
        }

        private void txttinhluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            cbManv.Text = "";
            cbohonv.Text = "";
            cbotennv.Text = "";
            txtmucluong.Text = "";
            txthesoluong.Text = "";
            txtphucap.Text = "";
            txtngaylam.Text = "";
            txtngaythang.Text = "";
            cbongachbac.Text = "";
            txttinhluong.Text = "";
        }

      
    }
}
