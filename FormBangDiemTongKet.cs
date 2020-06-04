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
    public partial class FormBangDiemTongKet : Form
    {
        public FormBangDiemTongKet()
        {
            InitializeComponent();
        }

        private void ChonViTri()
        {
            cmbLop.SelectedIndex = 1;
            cmbLop.SelectedIndex = 0;
        }

        private void FormBangDiemTongKet_Load(object sender, EventArgs e)
        {
            this.ds_CNTT.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
            this.LOPTableAdapter.Fill(this.ds_CNTT.LOP);

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

        private void btnXem_Click(object sender, EventArgs e)
        {
            ReportBangDiemTongKetCuaLop obj = new ReportBangDiemTongKetCuaLop();

            string lenh = "EXEC sp_INBANGDIEMTONGKETCUALOP '" + cmbLop.SelectedValue.ToString().Trim() + "'";

            DataTable dataTable = Program.ExecSqlDataTable(lenh);
            obj.SetDataSource(dataTable);
            obj.SetParameterValue("TENLOP", cmbLop.Text);

            crvBangDiemTongKet.ReportSource = obj;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                cmbDonVi.DataSource = null;
                cmbLop.DataSource = null;

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
