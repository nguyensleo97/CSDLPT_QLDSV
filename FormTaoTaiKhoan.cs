using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            cmbDonVi.DisplayMember = "TENDONVI";
            cmbDonVi.ValueMember = "TENSERVER";
            if (Program.nhom.Equals("PGV"))
            {
                Program.bds_DONVI.Filter = "TENDONVI <> 'PHÒNG KẾ TOÁN'";
                cmbDonVi.DataSource = Program.bds_DONVI;
                cmbDonVi.SelectedIndex = Program.donvi;

                cmbPhanQuyen.Items.Add("PGV");
                cmbPhanQuyen.Items.Add("KHOA");
                cmbPhanQuyen.Items.Add("USER");
                cmbPhanQuyen.SelectedIndex = 0;
            }
            else if (Program.nhom.Equals("PKETOAN"))
            {
                Program.bds_DONVI.Filter = "TENDONVI <> 'KHOA CÔNG NGHỆ THÔNG TIN' AND TENDONVI <> 'KHOA VIỄN THÔNG'";
                cmbDonVi.DataSource = Program.bds_DONVI;
                cmbDonVi.SelectedIndex = 0;

                cmbPhanQuyen.Items.Add("PKETOAN");
                cmbPhanQuyen.SelectedIndex = 0;
            }
            

            string lenh = "EXEC sp_LAYDANHSACHGIANGVIEN '" + Program.nhom + "'";
            DataTable dataTable = Program.ExecSqlDataTable(lenh);

            cmbGiangVien.DisplayMember = "HOTEN";
            cmbGiangVien.ValueMember = "MAGV";
            cmbGiangVien.DataSource = dataTable;
            cmbGiangVien.SelectedIndex = 0;

            txtMaGiangVien.Text = cmbGiangVien.SelectedValue.ToString().Trim();

            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
            cmbDonVi.Enabled = true;
        }

        private void cmbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDonVi.SelectedValue != null)
            {
                if (cmbDonVi.SelectedIndex != Program.donvi)
                {
                    Program.servername = cmbDonVi.SelectedValue.ToString();
                    Program.tenDangNhap = Program.remoteTenDangNhap;
                    Program.matKhau = Program.remoteMatKhau;
                }
                else
                {
                    Program.servername = cmbDonVi.SelectedValue.ToString();
                    Program.tenDangNhap = Program.saveTenDangNhap;
                    Program.matKhau = Program.saveMatKhau;
                }

                Console.WriteLine(cmbDonVi.SelectedValue.ToString());
                Console.WriteLine(Program.chuoiKetNoi);

                if (!Program.KetNoi())
                {
                    MessageBox.Show("Lỗi kết nối đến đơn vị mới", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string lenh = "EXEC sp_LAYDANHSACHGIANGVIEN '" + Program.nhom + "'";
                    DataTable dataTable = Program.ExecSqlDataTable(lenh);

                    cmbGiangVien.DisplayMember = "HOTEN";
                    cmbGiangVien.ValueMember = "MAGV";
                    cmbGiangVien.DataSource = dataTable;

                    if(cmbGiangVien.SelectedValue != null)
                    {
                        cmbGiangVien.SelectedIndex = 0;

                        txtMaGiangVien.Text = cmbGiangVien.SelectedValue.ToString().Trim();
                    }

                    btnHuy.Enabled = false;
                    btnThoat.Enabled = true;
                    cmbDonVi.Enabled = true;
                }
            }
        }

        private void cmbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGiangVien.SelectedValue != null)
            {
                txtMaGiangVien.Text = cmbGiangVien.SelectedValue.ToString().Trim();
            }

            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
            cmbDonVi.Enabled = false;
        }

        private void cmbPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
            cmbDonVi.Enabled = false;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();
            string tenNguoiDung = txtMaGiangVien.Text.Trim();
            string phanQuyen = cmbPhanQuyen.Text.Trim();

            if (tenDangNhap.Equals(""))
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo", MessageBoxButtons.OK);
                lblTenDangNhap.Focus();

                return;
            }
            else
            {
                if(tenDangNhap.Equals("sa") || tenDangNhap.Equals("SA") || tenDangNhap.Equals("public") || tenDangNhap.Equals("PUBLIC") || Regex.IsMatch(tenDangNhap, "^\\\\."))
                {
                    MessageBox.Show("Tên đăng nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                    lblTenDangNhap.Focus();

                    return;
                }
            }

            if (matKhau.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK);
                lblMatKhau.Focus();

                return;
            }

            if (xacNhanMatKhau.Equals(""))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK);
                lblXacNhanMatKhau.Focus();

                return;
            }
            else
            {
                if (!xacNhanMatKhau.Equals(matKhau))
                {
                    MessageBox.Show("Mật khẩu xác nhận không giống với mật khẩu", "Thông báo", MessageBoxButtons.OK);
                    lblXacNhanMatKhau.Focus();

                    return;
                }
            }

            string lenh = "EXEC sp_TAOTAIKHOAN '" + tenDangNhap + "', '" 
                + matKhau + "', '" 
                + tenNguoiDung + "', '" 
                + phanQuyen + "'";

            SqlDataReader sqlDataReader = Program.TaoTaiKhoan(lenh, tenDangNhap, txtTenDangNhap);

            if (sqlDataReader == null)
            {
                return;
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK);

                LamMoi();

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtXacNhanMatKhau.Text = "";

            if(cmbGiangVien.SelectedValue != null)
            {
                cmbGiangVien.SelectedIndex = 0;
                txtMaGiangVien.Text = cmbGiangVien.SelectedValue.ToString().Trim();
            }

            cmbPhanQuyen.SelectedIndex = 0;

            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
            cmbDonVi.Enabled = true;
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
            cmbDonVi.Enabled = false;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
            cmbDonVi.Enabled = false;
        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnThoat.Enabled = false;
            cmbDonVi.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            cmbDonVi.DataSource = null;
            cmbGiangVien.DataSource = null;

            Program.bds_DONVI.Position = Program.donvi;

            if (Program.nhom.Equals("PGV"))
            {
                Program.ThoatForm(true);
            }
            else if (Program.nhom.Equals("PKETOAN"))
            {
                Program.ThoatForm(false);
            }
        }

        private void LamMoi()
        {
            string lenh = "EXEC sp_LAYDANHSACHGIANGVIEN '" + Program.nhom + "'";
            DataTable dataTable = Program.ExecSqlDataTable(lenh);

            cmbGiangVien.DisplayMember = "HOTEN";
            cmbGiangVien.ValueMember = "MAGV";
            cmbGiangVien.DataSource = dataTable;

            if (cmbGiangVien.SelectedValue != null)
            {
                cmbGiangVien.SelectedIndex = 0;
                txtMaGiangVien.Text = cmbGiangVien.SelectedValue.ToString().Trim();
            }

            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtXacNhanMatKhau.Text = "";

            cmbPhanQuyen.SelectedIndex = 0;

            btnHuy.Enabled = false;
            btnThoat.Enabled = true;
            cmbDonVi.Enabled = true;

            lblDonVi.Focus();
        }
    }
}
