using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormManHinhChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormManHinhChinh()
        {
            InitializeComponent();
            HienThiDangNhap();
            XuLyBanDau();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
                
            return null;
        }

        private void HienThiDangNhap()
        {
            FormDangNhap frmDangNhap = new FormDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.Show();
        }

        public void VoHieuHoaDangNhap(FormDangNhap frmDangNhap)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormDangNhap))
                {
                    frmDangNhap.Enabled = false;
                }
            }
        }

        public void MoDangNhap()
        {
            this.frmDangNhap = new FormDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.Show();
        }

        public void LuuDangNhap(FormDangNhap frmDangNhapTemp)
        {
            this.frmDangNhap = frmDangNhapTemp;
            //this.frmDangNhap.txtTenDangNhap.Text = "";
            //this.frmDangNhap.txtMatKhau.Text = "";
        }

        public FormDangNhap LayDangNhap()
        {
            return this.frmDangNhap;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormDangNhap));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormDangNhap frmDangNhap = new FormDangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Show();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormLop));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormLop frmLop = new FormLop();
                frmLop.MdiParent = this;
                frmLop.Show();

                btnSinhVien.Enabled = false;
                btnMonHoc.Enabled = false;
                btnDiem.Enabled = false;
                btnDangXuat.Enabled = false;

                groupBaoCao.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }

            
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormSinhVien));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormSinhVien frmSinhVien = new FormSinhVien();
                frmSinhVien.MdiParent = this;
                frmSinhVien.Show();

                btnLop.Enabled = false;
                btnMonHoc.Enabled = false;
                btnDiem.Enabled = false;
                btnDangXuat.Enabled = false;

                groupBaoCao.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormDiem));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormDiem frmDiem = new FormDiem();
                frmDiem.MdiParent = this;
                frmDiem.Show();

                btnLop.Enabled = false;
                btnSinhVien.Enabled = false;
                btnMonHoc.Enabled = false;
                btnDangXuat.Enabled = false;

                groupBaoCao.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormMonHoc));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormMonHoc frmMonHoc = new FormMonHoc();
                frmMonHoc.MdiParent = this;
                frmMonHoc.Show();

                btnLop.Enabled = false;
                btnSinhVien.Enabled = false;
                btnDiem.Enabled = false;
                btnDangXuat.Enabled = false;

                groupBaoCao.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormHocPhi));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormHocPhi frmHocPhi = new FormHocPhi();
                frmHocPhi.MdiParent = this;
                frmHocPhi.Show();

                btnDangXuat.Enabled = false;

                groupBaoCao.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.LamMoi();
        }

        private void btnDanhSachSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormDanhSachSinhVienTheoLop));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormDanhSachSinhVienTheoLop frmDanhSachSinhVienTheoLop = new FormDanhSachSinhVienTheoLop();
                frmDanhSachSinhVienTheoLop.MdiParent = this;
                frmDanhSachSinhVienTheoLop.Show();

                btnDanhSachThiHetMon.Enabled = false;
                btnBangDiemMonHoc.Enabled = false;
                btnBangDiemTongKet.Enabled = false;
                btnPhieuDiemSinhVien.Enabled = false;

                groupDoiTuong.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnDanhSachThiHetMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormDanhSachThiHetMon));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormDanhSachThiHetMon frmDanhSachThiHetMon = new FormDanhSachThiHetMon();
                frmDanhSachThiHetMon.MdiParent = this;
                frmDanhSachThiHetMon.Show();

                btnDanhSachSinhVien.Enabled = false;
                btnBangDiemMonHoc.Enabled = false;
                btnBangDiemTongKet.Enabled = false;
                btnPhieuDiemSinhVien.Enabled = false;

                groupDoiTuong.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnBangDiemMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormBangDiemMonHoc));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormBangDiemMonHoc frmBangDiemMonHoc = new FormBangDiemMonHoc();
                frmBangDiemMonHoc.MdiParent = this;
                frmBangDiemMonHoc.Show();

                btnDanhSachSinhVien.Enabled = false;
                btnDanhSachThiHetMon.Enabled = false;
                btnBangDiemTongKet.Enabled = false;
                btnPhieuDiemSinhVien.Enabled = false;

                groupDoiTuong.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnDanhSachDongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormDanhSachDongHocPhiCuaLop));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormDanhSachDongHocPhiCuaLop frmDanhSachDongHocPhi = new FormDanhSachDongHocPhiCuaLop();
                frmDanhSachDongHocPhi.MdiParent = this;
                frmDanhSachDongHocPhi.Show();

                groupDoiTuong.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnBangDiemTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormBangDiemTongKet));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormBangDiemTongKet frmBangDiemTongKet = new FormBangDiemTongKet();
                frmBangDiemTongKet.MdiParent = this;
                frmBangDiemTongKet.Show();

                btnDanhSachSinhVien.Enabled = false;
                btnDanhSachThiHetMon.Enabled = false;
                btnBangDiemMonHoc.Enabled = false;
                btnPhieuDiemSinhVien.Enabled = false;

                groupDoiTuong.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnPhieuDiemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormPhieuDiemSinhVien));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormPhieuDiemSinhVien frmPhieuDiemSinhVien = new FormPhieuDiemSinhVien();
                frmPhieuDiemSinhVien.MdiParent = this;
                frmPhieuDiemSinhVien.Show();

                btnDanhSachSinhVien.Enabled = false;
                btnDanhSachThiHetMon.Enabled = false;
                btnBangDiemMonHoc.Enabled = false;
                btnBangDiemTongKet.Enabled = false;

                groupDoiTuong.Enabled = false;
                groupTaiKhoan.Enabled = false;
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAction = CheckExists(typeof(FormTaoTaiKhoan));
            if (frmAction != null)
            {
                frmAction.Activate();
            }
            else
            {
                FormTaoTaiKhoan frmTaoTaiKhoan = new FormTaoTaiKhoan();
                frmTaoTaiKhoan.MdiParent = this;
                frmTaoTaiKhoan.Show();

                groupDoiTuong.Enabled = false;
                groupBaoCao.Enabled = false;
            }
        }
    }
}
