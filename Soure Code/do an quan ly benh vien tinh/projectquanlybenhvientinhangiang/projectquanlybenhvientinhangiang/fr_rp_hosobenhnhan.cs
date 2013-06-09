using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectquanlybenhvientinhangiang
{
    public partial class fr_rp_hosobenhnhan : Form
    {
        public fr_rp_hosobenhnhan()
        {
            InitializeComponent();
        }

        private void fr_rp_hosobenhnhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dshosobenhnhan.tbbenhnhan' table. You can move, or remove it, as needed.
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbbenhnhanTableAdapter.Fill(this.dshosobenhnhan.tbbenhnhan,txtmabn.Text);

            this.reportViewer1.RefreshReport();
 
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From In Báo Cáo Bệnh Nhân  không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }
    }
}
