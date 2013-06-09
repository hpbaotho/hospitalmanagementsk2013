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
    public partial class frvienphibenhnhan : Form
    {
        public frvienphibenhnhan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbobhyt.Text=="co")
            {
                clvienphicobhyt cl = new clvienphicobhyt();
                float tienkham, soluongthuoc, dongiathuoc;
                float kq = 0;
                tienkham = cl.chuyensangso(txttienkham.Text);
                soluongthuoc = cl.chuyensangso(txtsoluongthuoc.Text);
                dongiathuoc = cl.chuyensangso(txtdongiathuoc.Text);
                kq = cl.tinhvienphi(tienkham, soluongthuoc, dongiathuoc);
                txttinhvienphi.Text = cl.chuyensangchuoi(kq);
                strsql = "update tbvienphi set tongtienvienphi='" + txttinhvienphi.Text + "' where mabn='" + cbomabn.Text + "'";
                objcmd = new SqlCommand(strsql, objcon);

                objcmd.ExecuteNonQuery();
                Hienthi();
            }
            else if (cbobhyt.Text=="khong")
            {
                clvienphicobhyt cl = new clvienphicobhyt();
                float tienkham, soluongthuoc, dongiathuoc;
                float kq = 0;
                tienkham = cl.chuyensangso(txttienkham.Text);
                soluongthuoc = cl.chuyensangso(txtsoluongthuoc.Text);
                dongiathuoc = cl.chuyensangso(txtdongiathuoc.Text);
                kq = cl.tinhvienphi1(tienkham, soluongthuoc, dongiathuoc);
                txttinhvienphi.Text = cl.chuyensangchuoi(kq);
                strsql = "update tbvienphi set tongtienvienphi='" + txttinhvienphi.Text + "' where mabn='" + cbomabn.Text + "'";
                objcmd = new SqlCommand(strsql, objcon);

                objcmd.ExecuteNonQuery();
                Hienthi();
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
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
        DataSet dsvienphi;
        SqlDataAdapter davienphi;
      
        private void Ketnoi()
        {
            strcon = "Server=4738-PC\\SQLEXPRESS;DataBase=quanlybenhvientinh;Integrated Security=SSPI";
            objcon = new SqlConnection(strcon);
            objcon.Open();
        }
        private void Hienthi()
        {
            dsvienphi = new DataSet();
            davienphi = new SqlDataAdapter("select*from tbvienphi", objcon);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(davienphi);
            davienphi.Fill(dsvienphi, "tbvienphi");
            dgwvienphi.DataSource = dsvienphi;
            dgwvienphi.DataMember = "tbvienphi";
        }
      
        private void frvienphibenhnhan_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Ketnoi();
            Hienthi();
            cbomabn.Focus();
            cbobhyt.Items.Add("co ");
            cbobhyt.Items.Add("khong");

            strsql = "select mabn, madotkham, hobn,tenbn, BHYT from tbbenhnhan";
            objcmd = new SqlCommand(strsql, objcon);
            objrdr = objcmd.ExecuteReader();
            while (objrdr.Read())
            {
                cbomabn.Items.Add(objrdr[0].ToString());
                cbomadk.Items.Add(objrdr[1].ToString());
                cbohobn.Items.Add(objrdr[2].ToString());
                cbotenbn.Items.Add(objrdr[3].ToString());
                cbobhyt.Items.Add(objrdr[4].ToString());
            }
            objrdr.Close();
           
        }

        private void dgwvienphi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cbomabn.Text = dgwvienphi.CurrentRow.Cells[0].Value.ToString();
            //cbomadk.Text = dgwvienphi.CurrentRow.Cells[1].Value.ToString();
            //cbohobn.Text = dgwvienphi.CurrentRow.Cells[2].Value.ToString();
            //cbotenbn.Text = dgwvienphi.CurrentRow.Cells[3].Value.ToString();
            //txttienkham.Text = dgwvienphi.CurrentRow.Cells[4].Value.ToString();
            //txtsoluongthuoc.Text = dgwvienphi.CurrentRow.Cells[5].Value.ToString();
            //txtdongiathuoc.Text = dgwvienphi.CurrentRow.Cells[6].Value.ToString();
            //cbobhyt.Text = dgwvienphi.CurrentRow.Cells[7].Value.ToString();

            ////// txtManhom.ReadOnly = true;
            //// btnThe.Enabled = false;
            //// btnXoa.Enabled = true;
            //// btnSua.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From Viện Phí Bệnh Nhân không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            cbomabn.Text = "";
            cbomadk.Text = "";
            cbohobn.Text = "";
            cbotenbn.Text = "";
            txttienkham.Text = "";
            txtsoluongthuoc.Text = "";
            txtdongiathuoc.Text = "";
            cbobhyt.Text = "";
            txttinhvienphi.Text = "";
        }
    }
}
