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
    public partial class fr_rp_hosonhanvien : Form
    {
        public fr_rp_hosonhanvien()
        {
            InitializeComponent();
        }

        private void fr_rp_hosonhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dshosonhanvien.tbnhanvien' table. You can move, or remove it, as needed.
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbnhanvienTableAdapter.Fill(this.dshosonhanvien.tbnhanvien, textBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi From In Báo Cáo Nhân Viên không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }
    }
}
