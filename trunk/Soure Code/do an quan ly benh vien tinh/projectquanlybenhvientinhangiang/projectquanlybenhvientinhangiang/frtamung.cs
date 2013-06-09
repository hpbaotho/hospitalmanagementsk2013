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
    public partial class frtamung : Form
    {
        public frtamung()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string strcon = "";
        string strcmd = "";
        string strsql = "";
        DataTable dt;
        SqlConnection objcon;
        SqlCommand objcmd;
        SqlDataReader objrdr = null;
        DataSet dstamung;
        SqlDataAdapter datamung;
        Boolean kt;
        private void Ketnoi()
        {
            strcon = "Server=4738-PC\\SQLEXPRESS;DataBase=quanlybenhvientinh;Integrated Security=SSPI";
            objcon = new SqlConnection(strcon);
            objcon.Open();
        }
        private void Hienthi()
        {
            dstamung = new DataSet();
            datamung = new SqlDataAdapter("select*from tbtamung", objcon);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(datamung);
            datamung.Fill(dstamung, "tbtamung");
            dgwtamung.DataSource = dstamung;
            dgwtamung.DataMember = "tbtamung";
        }
        private bool kiemtra() //ham kiem tra 
        {
            kt = true;
            if (cbomabn.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập tên của Bệnh Nhân !", "Thông Báo", MessageBoxButtons.OK);
                kt = false;
            }
            else if (cbotenbn.Text == "")
            {
                MessageBox.Show(" Bạn chưa chọn giới tính!", "Thông Báo", MessageBoxButtons.OK);
                kt = false;
            }
            return kt;
        } 
        private void frtamung_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Ketnoi();
            Hienthi();
            cbomabn.Focus();
            //strsql = "select manv from tbnhanvien";
            //objcmd = new SqlCommand(strsql, objcon);
            //objrdr = objcmd.ExecuteReader();
            //objcon.Close();
            //while (objrdr.Read())
            //{
            //    cbManv.Items.Add(objrdr[0].ToString());
            //}
        }

        private void dgwtamung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbomabn.Text = dgwtamung.CurrentRow.Cells[0].Value.ToString();
            cbohobn.Text = dgwtamung.CurrentRow.Cells[1].Value.ToString();
            cbotenbn.Text = dgwtamung.CurrentRow.Cells[2].Value.ToString();
            txtchuandoan.Text = dgwtamung.CurrentRow.Cells[3].Value.ToString();
            txttientamung.Text = dgwtamung.CurrentRow.Cells[4].Value.ToString();
            txttienkham.Text = dgwtamung.CurrentRow.Cells[5].Value.ToString();
            txttienphaitra.Text = dgwtamung.CurrentRow.Cells[6].Value.ToString();
           
        }

        private void cbomabn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntienhoanlai_Click(object sender, EventArgs e)
        {
            cltamung cl = new cltamung();
            float tientamung, tienphaitra;
            float kq = 0;
            tientamung = cl.chuyensangso(txttientamung.Text);
            tienphaitra = cl.chuyensangso(txttienphaitra.Text);
           
            kq = cl.tinhtienhoanlai(tientamung,tienphaitra);
            txttienhoanlai.Text = cl.chuyensangchuoi(kq);
            strsql = "update tbtamung set tongtienhoanlai='" + txttienhoanlai.Text + "' where mabn='" + cbomabn.Text + "'";
            objcmd = new SqlCommand(strsql, objcon);

            objcmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From Tạm Ứng Viện Phí không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }
    }
}
