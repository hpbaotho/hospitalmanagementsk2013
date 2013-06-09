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
    public partial class frchinh : Form
    {
        public frchinh()
        {
            InitializeComponent();
        }
        Boolean KiemTraTonTai(string Frmname)
        {
            foreach (frchinh frm in this.MdiChildren)
            {
                if (frm.Name.Equals(Frmname))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }
        #region "Enable và Dis các Tab - Phân Quyền"
        public void DisTab()
        {
            đăngNhậpToolStripMenuItem.Enabled = true;
            hồSơToolStripMenuItem.Enabled = false;
            thanhToánToolStripMenuItem.Enabled = false;
            tamToolStripMenuItem.Enabled = false;
            quanLyToolStripMenuItem.Enabled = false;
            timKiêmToolStripMenuItem.Enabled = false;
            baoCaoToolStripMenuItem.Enabled = false;
            trơGiupToolStripMenuItem.Enabled = false;
            thoatToolStripMenuItem.Enabled = false;
        }
       
        public void admin()
        {
            hồSơToolStripMenuItem.Enabled = true;
            thanhToánToolStripMenuItem.Enabled = true;
            tamToolStripMenuItem.Enabled = true;// Mở khi là Admin
            quanLyToolStripMenuItem.Enabled = true;
            timKiêmToolStripMenuItem.Enabled = true;
            baoCaoToolStripMenuItem.Enabled = true;
            trơGiupToolStripMenuItem.Enabled = true;
            thoatToolStripMenuItem.Enabled = true;
        }
        public void EnableNhanvien()
        {
            đăngNhậpToolStripMenuItem.Enabled = true;
            hồSơToolStripMenuItem.Enabled = true;
            thanhToánToolStripMenuItem.Enabled = true;
            tamToolStripMenuItem.Enabled = true;
            quanLyToolStripMenuItem.Enabled = false;
            timKiêmToolStripMenuItem.Enabled = true;
            baoCaoToolStripMenuItem.Enabled = true;
            trơGiupToolStripMenuItem.Enabled = true;
            thoatToolStripMenuItem.Enabled = true;
        }
        public void EnableKhach()
        {
            đăngNhậpToolStripMenuItem.Enabled = true;
            hồSơToolStripMenuItem.Enabled = true;
            thanhToánToolStripMenuItem.Enabled = false;
            tamToolStripMenuItem.Enabled = false;
            quanLyToolStripMenuItem.Enabled = false;
            timKiêmToolStripMenuItem.Enabled = true;
            baoCaoToolStripMenuItem.Enabled = true;
            trơGiupToolStripMenuItem.Enabled = true;
            thoatToolStripMenuItem.Enabled = true;
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            DisTab();
            this.MaximizeBox = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai("frdangnhap") == false)
            {
                frdangnhap frmqlhdbh1 = new frdangnhap();
               frmqlhdbh1.MdiParent = this;
               
                frmqlhdbh1.Show();
                
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hồSơBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frhosobenhnhan hosobenhnhan = new frhosobenhnhan();
            hosobenhnhan.Show();
        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frluongnhanvien luong = new frluongnhanvien();
            luong.Show();
        }

        private void viênPhíBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frvienphibenhnhan vienphi = new frvienphibenhnhan();
            vienphi.Show();
        }

       
        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frhosonhanvien nhanvien = new frhosonhanvien();
            nhanvien.Show();
        }

        private void tamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frtamung tamung= new frtamung ();
            tamung.Show();
        }

        private void timKiêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frtimkiem timkiem = new frtimkiem();
            timkiem.Show();
        }

        private void baoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void baoCaoHôSơBênhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_rp_hosobenhnhan t = new fr_rp_hosobenhnhan();
            t.Show();
        }

        private void baoCaoHôSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_rp_hosonhanvien nv = new fr_rp_hosonhanvien();
            nv.Show();
        }

        private void qulanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frquanlytaikhoan taikhoan = new frquanlytaikhoan();
            taikhoan.Show();
        }

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frdoimatkhau doimatkhau = new frdoimatkhau();
            doimatkhau.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi Chương Trình Không, Nếu Nhấn OK Chương Trình Sẽ Đóng Hoàn Toàn Và Giao Diện Làm Việc Kết Thúc ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                Dispose();
                //Close();
                //System.Windows.Forms.Application.Exit();
            }
        }

        private void trơGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Đăng Nhập Của Chương Trình: Nếu Bạn Là Người Quản Trị Mới Được Toàn Quyền Khai Thác Ứng Dụng. Những Thành Viên Khác Tùy Theo Cấp Độ Quyền Truy Cập Mà Có Mức Độ Khai Thác Ứng Dụng Phù Hợp!!! Nếu Có Thắc Mắc Gì Khi Sử Dụng Chương Trình Xin Liên Hệ:Gmail:nguyenkia.cntt@gmail.com(Số Điện Thoại:01689431337) Hoặc Gmail:dinhnguyenthanhluan@gmail.com(Số Điện Thoại:01224009042).Những Thành Viên Chúng Tôi Rất Mong Đươc Sự Đóng Góp Ý Kiến Từ Phía Các Bạn!!! Xin Chân Thành Cảm Ơn ", "Trợ Giúp", MessageBoxButtons.OK);
        }
    }
}
