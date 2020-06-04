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
    public partial class FormPhieuDiemSinhVien : Form
    {
        private string maLop = "";

        public FormPhieuDiemSinhVien()
        {
            InitializeComponent();
        }

        //private void ChonViTri()
        //{
        //    cmbLop.SelectedIndex = 1;
        //    cmbLop.SelectedIndex = 0;
        //    maLop = cmbLop.SelectedValue.ToString().Trim();
        //}

        private void GanGiaTriMaSV()
        {
            string lenh = "EXEC sp_LAYDANHSACHMASINHVIEN '" + maLop + "'";
            DataTable dataTable = Program.ExecSqlDataTable(lenh);

            cmbMaSinhVien.DataSource = dataTable;
            cmbMaSinhVien.ValueMember = "MASV";
            cmbMaSinhVien.DisplayMember = "MASV";

            if(cmbMaSinhVien.Items.Count > 0)
            {
                cmbMaSinhVien.SelectedIndex = 0;
            }
        }

        private void FormPhieuDiemSinhVien_Load(object sender, EventArgs e)
        {
            this.ds_CNTT.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
            this.LOPTableAdapter.Fill(this.ds_CNTT.LOP);

            Console.WriteLine(cmbLop.Items.Count);

            //ChonViTri();
            //GanGiaTriMaSV();

            //cmbLop.SelectedIndex = 0;
            //maLop = cmbLop.SelectedValue.ToString().Trim();
            //GanGiaTriMaSV();

            cmbDonVi.DisplayMember = "TENDONVI";
            cmbDonVi.ValueMember = "TENSERVER";
            if (Program.nhom.Equals("PGV"))
            {
                Program.bds_DONVI.Filter = "TENDONVI <> 'PHÒNG KẾ TOÁN'";
            }
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            ReportPhieuDiemSinhVien obj = new ReportPhieuDiemSinhVien();

            string lenh = "EXEC sp_INPHIEUDIEM '" + cmbMaSinhVien.Text + "'";

            DataTable dataTable = Program.ExecSqlDataTable(lenh);
            obj.SetDataSource(dataTable);
            obj.SetParameterValue("TENLOP", cmbLop.Text);
            obj.SetParameterValue("MASV", cmbMaSinhVien.Text);

            crvPhieuDiemSinhVien.ReportSource = obj;
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

                    cmbLop.SelectedIndex = 0;
                    maLop = cmbLop.SelectedValue.ToString().Trim();
                    GanGiaTriMaSV();
                    //ChonViTri();
                }
            }
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!maLop.Equals(""))
            //{
            //Console.WriteLine(cmbLop.Items.Count);
            //if (maLop.Equals(""))
            //{
            //    maLop = " ";
            //    cmbLop.SelectedIndex = 0;
            //}
            //maLop = cmbLop.SelectedValue.ToString().Trim();

            //GanGiaTriMaSV();
            //}

            if(cmbLop.SelectedValue != null)
            {
                maLop = cmbLop.SelectedValue.ToString();
                Console.WriteLine(cmbLop.SelectedValue.ToString());
                GanGiaTriMaSV();
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                cmbDonVi.DataSource = null;
                cmbLop.DataSource = null;
                cmbMaSinhVien.DataSource = null;

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
