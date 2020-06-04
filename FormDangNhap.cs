using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void ChonViTri()
        {
            cmbDonVi.SelectedIndex = 1;
            cmbDonVi.SelectedIndex = 0;
        }

        private void LuuGiaTri()
        {
            Program.donvi = cmbDonVi.SelectedIndex;
            Program.bds_DONVI = bds_DSPM;

            Program.saveTenDangNhap = Program.tenDangNhap;
            Program.saveMatKhau = Program.matKhau;
        }

        private void LayThongTinNguoiDung()
        {
            string lenh = "EXEC sp_DANGNHAP " + Program.tenDangNhap;

            SqlDataReader sqlDataReader = Program.ExecSqlDataReader(lenh);
            if (sqlDataReader == null)
            {
                return;
            }
            else
            {
                sqlDataReader.Read();
                Program.frmManHinhChinh.lblMa.Text = "Mã: " + sqlDataReader.GetString(0);
                Program.frmManHinhChinh.lblHoTen.Text = "Họ tên: " + sqlDataReader.GetString(1);
                Program.frmManHinhChinh.lblNhom.Text = "Nhóm: " + sqlDataReader.GetString(2);
                Program.nhom = sqlDataReader.GetString(2);

                sqlDataReader.Close();
                Program.ketNoi.Close();
            }

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.v_DANHSACHPHANMANH' table. You can move, or remove it, as needed.
            this.v_DANHSACHPHANMANHTableAdapter.Fill(this.ds_DSPM.v_DANHSACHPHANMANH);
            ChonViTri();
        }

        private void cmbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDonVi.SelectedValue != null)
            {
                Program.servername = cmbDonVi.SelectedValue.ToString();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Equals(""))
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo", MessageBoxButtons.OK);
                txtTenDangNhap.Focus();
                return;
            }

            Program.tenDangNhap = txtTenDangNhap.Text;
            Program.matKhau = txtMatKhau.Text;

            if (!Program.KetNoi())
            {
                return;
            }

            LuuGiaTri();

            LayThongTinNguoiDung();

            
            Program.frmManHinhChinh.XuLyDangNhap();
            Program.frmManHinhChinh.XuLyHienThi();
            Program.frmManHinhChinh.VoHieuHoaDangNhap(this);
            Program.frmManHinhChinh.LuuDangNhap(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnDangNhap.PerformClick();
                lblTenDangNhap.Focus();
            }
        }

        private void txtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnDangNhap.PerformClick();
                lblMatKhau.Focus();
            }
        }
    }
}
