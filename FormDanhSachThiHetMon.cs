using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormDanhSachThiHetMon : Form
    {
        public FormDanhSachThiHetMon()
        {
            InitializeComponent();
        }

        private void ChonViTri()
        {
            cmbLop.SelectedIndex = 1;
            cmbLop.SelectedIndex = 0;
            cmbMonHoc.SelectedIndex = 1;
            cmbMonHoc.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 1;
            cmbHocKy.SelectedIndex = 0;
            cmbLanThi.SelectedIndex = 1;
            cmbLanThi.SelectedIndex = 0;
        }

        private void FormDanhSachThiHetMon_Load(object sender, EventArgs e)
        {
            this.ds_CNTT.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
            this.LOPTableAdapter.Fill(this.ds_CNTT.LOP);
            this.MONHOCTableAdapter.Fill(this.ds_CNTT.MONHOC);

            ChonViTri();

            cmbDonVi.DisplayMember = "TENDONVI";
            cmbDonVi.ValueMember = "TENSERVER";
            Program.bds_DONVI.Filter = "TENDONVI <> 'PHÒNG KẾ TOÁN'";
            cmbDonVi.DataSource = Program.bds_DONVI;
            cmbDonVi.SelectedIndex = Program.donvi;

            if (Program.nhom.Equals("PGV"))
            {
                cmbDonVi.Enabled = true;
            }
            else
            {
                cmbDonVi.Enabled = false;
            }

            datNgayThi.DateTime = DateTime.Today;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ReportDanhSachThiHetMon obj = new ReportDanhSachThiHetMon();

            string lenh = "EXEC sp_INDANHSACHTHIHETMON '" + cmbLop.SelectedValue.ToString().Trim() + "', " + cmbHocKy.Text;

            DataTable dataTable = Program.ExecSqlDataTable(lenh);
            obj.SetDataSource(dataTable);
            obj.SetParameterValue("TENLOP", cmbLop.Text);
            obj.SetParameterValue("TENMONHOC", cmbMonHoc.Text);
            if(Convert.ToInt32(cmbHocKy.Text) % 2 == 0)
            {
                obj.SetParameterValue("HOCKY", "2");
            }
            else
            {
                obj.SetParameterValue("HOCKY", "1");
            }
            obj.SetParameterValue("LANTHI", cmbLanThi.Text);
            obj.SetParameterValue("NGAYTHI", 
                datNgayThi.DateTime.Day + "/" +  
                datNgayThi.DateTime.Month + "/" + 
                datNgayThi.DateTime.Year);

            crvDanhSachThiHetMon.ReportSource = obj;
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

                if (!Program.KetNoi())
                {
                    MessageBox.Show("Lỗi kết nối đến đơn vị mới", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    this.LOPTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
                    this.LOPTableAdapter.Fill(this.ds_CNTT.LOP);

                    ChonViTri();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                cmbDonVi.DataSource = null;
                cmbLop.DataSource = null;
                cmbMonHoc.DataSource = null;

                Program.bds_DONVI.Position = Program.donvi;
                Program.ThoatFormBaoCao();
            }
            else
            {
                return;
            }
        }
    }
}
