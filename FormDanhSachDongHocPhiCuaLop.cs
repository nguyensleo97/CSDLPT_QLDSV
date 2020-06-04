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
    public partial class FormDanhSachDongHocPhiCuaLop : Form
    {
        public FormDanhSachDongHocPhiCuaLop()
        {
            InitializeComponent();
        }

        private void ChonViTri()
        {
            cmbLop.SelectedIndex = 1;
            cmbLop.SelectedIndex = 0;
            cmbNienKhoa.SelectedIndex = 1;
            cmbNienKhoa.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 1;
            cmbHocKy.SelectedIndex = 0;
        }

        private void GanDuLieuNienKhoa()
        {
            int nam = 2007;
            while(nam <= 2025)
            {
                nam += 1;
                string nienKhoa = nam + "-" + (nam + 5);
                cmbNienKhoa.Items.Add(nienKhoa);
            }
        }

        private void FormDanhSachDongHocPhiCuaLop_Load(object sender, EventArgs e)
        {
            this.ds_KETOAN.EnforceConstraints = false;

            this.LOPTableAdapter.Fill(this.ds_KETOAN.LOP);

            GanDuLieuNienKhoa();
            ChonViTri();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ReportDanhSachDongHocPhiCuaLop obj = new ReportDanhSachDongHocPhiCuaLop();

            string lenh = "EXEC sp_INDANHSACHDONGHOCPHICUALOP '" + cmbLop.SelectedValue.ToString().Trim() + "', '" +
                cmbNienKhoa.Text + "', " + cmbHocKy.Text;

            DataTable dataTable = Program.ExecSqlDataTable(lenh);
            obj.SetDataSource(dataTable);
            obj.SetParameterValue("TENLOP", cmbLop.Text);
            obj.SetParameterValue("NIENKHOA", cmbNienKhoa.Text);
            obj.SetParameterValue("HOCKY", cmbHocKy.Text);

            crvDanhSachDongHocPhiCuaLop.ReportSource = obj;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
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
