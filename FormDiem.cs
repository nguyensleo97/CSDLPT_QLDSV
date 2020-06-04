using DevExpress.XtraGrid.Columns;
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
    public partial class FormDiem : Form
    {
        private string lanThi = "";
        private string maLop = "";
        private string maMonHoc = "";
        

        private BindingSource bds = new BindingSource();
        private DataTable dt = new DataTable();
        private SqlDataReader sqlDataReader;

        public FormDiem()
        {
            InitializeComponent();
        }

        private void ChonViTri()
        {
            cmbLop.SelectedIndex = 1;
            cmbLop.SelectedIndex = 0;
            cmbMonHoc.SelectedIndex = 1;
            cmbMonHoc.SelectedIndex = 0;
        }

        private void TuyChinhGhiDiem(bool ghi)
        {
            if (ghi)
            {
                cmbDonVi.Enabled = false;
                grpThongTin.Enabled = false;
                btnBatDau.Enabled = false;
                btnThoat.Enabled = false;

                gc_DIEM.Enabled = true;
                btnGhiDiem.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                txtLanThi.Text = "";
                cmbLop.SelectedIndex = 0;
                cmbMonHoc.SelectedIndex = 0;

                cmbDonVi.Enabled = true;
                grpThongTin.Enabled = true;
                btnBatDau.Enabled = true;
                btnThoat.Enabled = true;

                gc_DIEM.DataSource = null;
                gc_DIEM.Enabled = false;
                btnGhiDiem.Enabled = false;
                btnHuy.Enabled = false;

                dt = new DataTable();
                bds = new BindingSource();
            }
        }

        private void FormDiem_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Điểm xin chào");

            this.ds_CNTT.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
            this.LOPTableAdapter.Fill(this.ds_CNTT.LOP);
            this.MONHOCTableAdapter.Fill(this.ds_CNTT.MONHOC);

            ChonViTri();

            gc_DIEM.Enabled = false;
            btnGhiDiem.Enabled = false;
            btnHuy.Enabled = false;

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

        private void cmbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("tui điểm nè");
            Console.WriteLine(Program.bds_DONVI.Count);
            Console.WriteLine(cmbDonVi.Items.Count);
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
                }
            }
        }

        private void btnBatDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maLop = cmbLop.SelectedValue.ToString();
            maMonHoc = cmbMonHoc.SelectedValue.ToString();
            lanThi = txtLanThi.Text;

            if (lanThi.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập lần thi", "Thông báo", MessageBoxButtons.OK);
                txtLanThi.Focus();
                return;
            }
            else
            {
                if (Regex.IsMatch(lanThi, "\\D"))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo", MessageBoxButtons.OK);
                    txtLanThi.Focus();
                    txtLanThi.SelectionStart = 0;
                    txtLanThi.SelectionLength = txtLanThi.Text.Length;
                    return;
                }
                else
                {
                    if (Convert.ToInt32(lanThi) < 1 || Convert.ToInt32(lanThi) > 2)
                    {
                        MessageBox.Show("Vui lòng nhập lần thi 1 hoặc 2", "Thông báo", MessageBoxButtons.OK);
                        txtLanThi.Focus();
                        txtLanThi.SelectionStart = 0;
                        txtLanThi.SelectionLength = txtLanThi.Text.Length;
                        return;
                    }
                    else
                    {
                        //foreach (GridColumn column in gv_DIEM.VisibleColumns)
                        //{
                        //    dt.Columns.Add(column.FieldName, column.ColumnType);
                        //}

                        dt.Columns.Add("MASV", typeof(string));
                        dt.Columns.Add("HOTEN", typeof(string));
                        dt.Columns.Add("DIEM", typeof(string));

                        if (Convert.ToInt32(lanThi) == 1)
                        {
                            string kiemTraThongTinLanThi = "EXEC sp_KIEMTRATHONGTINLANTHI " +
                                                            Convert.ToInt32(lanThi) + ", " + 
                                                            maMonHoc + ", " + 
                                                            maLop;
                            sqlDataReader = Program.ExecSqlDataReader(kiemTraThongTinLanThi);

                            if (sqlDataReader == null)
                            {
                                dt = new DataTable();
                                return;
                            }
                            else
                            {
                                sqlDataReader.Read();

                                int ketQua = sqlDataReader.GetInt32(0);
                                sqlDataReader.Close();

                                if (ketQua > 0)
                                {
                                    MessageBox.Show(ketQua + " Có điểm rồi");

                                    string lanThiThuNhat = "EXEC sp_LAYTHONGTINDIEMCACLANTHI " +
                                                            Convert.ToInt32(lanThi) + ", " +
                                                            maMonHoc + ", " +
                                                            maLop;
                                    sqlDataReader = Program.ExecSqlDataReader(lanThiThuNhat);

                                    while (sqlDataReader.Read())
                                    {
                                        string maSV = sqlDataReader.GetString(0);
                                        string hoTen = sqlDataReader.GetString(1);
                                        double diem = sqlDataReader.GetDouble(2);

                                        DataRow dr = dt.NewRow();
                                        dr["MASV"] = maSV;
                                        dr["HOTEN"] = hoTen;
                                        dr["DIEM"] = diem;
                                        dt.Rows.Add(dr);
                                    }

                                    sqlDataReader.Close();
                                    bds.DataSource = dt;
                                    gc_DIEM.DataSource = bds;
                                }
                                else
                                {
                                    MessageBox.Show(ketQua + " Chưa đâu con ạ");

                                    string thongTinLanThiThuNhat = "EXEC sp_LAYTHONGTINLANTHI " +
                                                                    maLop;
                                    sqlDataReader = Program.ExecSqlDataReader(thongTinLanThiThuNhat);

                                    while (sqlDataReader.Read())
                                    {
                                        string maSV = sqlDataReader.GetString(0);
                                        string hoTen = sqlDataReader.GetString(1);

                                        DataRow dr = dt.NewRow();
                                        dr["MASV"] = maSV;
                                        dr["HOTEN"] = hoTen;
                                        dt.Rows.Add(dr);
                                    }

                                    sqlDataReader.Close();
                                    bds.DataSource = dt;
                                    gc_DIEM.DataSource = bds;
                                }
                            }
                        }
                        else if(Convert.ToInt32(lanThi) == 2)
                        {
                            int lanKiemTra = 1;
                            string kiemTraThongTinLanThi = "EXEC sp_KIEMTRATHONGTINLANTHI " +
                                                            lanKiemTra + ", " + maMonHoc + ", " + maLop;
                            sqlDataReader = Program.ExecSqlDataReader(kiemTraThongTinLanThi);

                            if (sqlDataReader == null)
                            {
                                dt = new DataTable();
                                return;
                            }
                            else
                            {
                                sqlDataReader.Read();

                                int ketQua = sqlDataReader.GetInt32(0);
                                sqlDataReader.Close();

                                if (ketQua > 0)
                                {
                                    MessageBox.Show(ketQua + " OK Lần thi thứ 2 được chấp nhận");
                                    lanKiemTra = 2;

                                    kiemTraThongTinLanThi = "EXEC sp_KIEMTRATHONGTINLANTHI " +
                                                            lanKiemTra + ", " + maMonHoc + ", " + maLop;
                                    sqlDataReader = Program.ExecSqlDataReader(kiemTraThongTinLanThi);

                                    if (sqlDataReader == null)
                                    {
                                        dt = new DataTable();
                                        return;
                                    }
                                    else
                                    {
                                        sqlDataReader.Read();

                                        ketQua = sqlDataReader.GetInt32(0);
                                        sqlDataReader.Close();

                                        if(ketQua > 0)
                                        {
                                            string lanThiThuHai = "EXEC sp_LAYTHONGTINDIEMCACLANTHI " +
                                                            Convert.ToInt32(lanThi) + ", " +
                                                            maMonHoc + ", " +
                                                            maLop;
                                            sqlDataReader = Program.ExecSqlDataReader(lanThiThuHai);

                                            while (sqlDataReader.Read())
                                            {
                                                string maSV = sqlDataReader.GetString(0);
                                                string hoTen = sqlDataReader.GetString(1);
                                                double diem = sqlDataReader.GetDouble(2);

                                                DataRow dr = dt.NewRow();
                                                dr["MASV"] = maSV;
                                                dr["HOTEN"] = hoTen;
                                                dr["DIEM"] = diem;
                                                dt.Rows.Add(dr);
                                            }

                                            sqlDataReader.Close();
                                            bds.DataSource = dt;
                                            gc_DIEM.DataSource = bds;
                                        }
                                        else
                                        {
                                            string thongTinLanThiThuHai = "EXEC sp_LAYTHONGTINLANTHI " +
                                                                           maLop;
                                            sqlDataReader = Program.ExecSqlDataReader(thongTinLanThiThuHai);

                                            while (sqlDataReader.Read())
                                            {
                                                string maSV = sqlDataReader.GetString(0);
                                                string hoTen = sqlDataReader.GetString(1);

                                                DataRow dr = dt.NewRow();
                                                dr["MASV"] = maSV;
                                                dr["HOTEN"] = hoTen;
                                                dt.Rows.Add(dr);
                                            }

                                            sqlDataReader.Close();
                                            bds.DataSource = dt;
                                            gc_DIEM.DataSource = bds;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Môn học này chưa có điểm lần 1.\nVui lòng nhập điểm lần 1 trước",
                                        "Thông báo", MessageBoxButtons.OK);

                                    txtLanThi.Focus();
                                    txtLanThi.SelectionStart = 0;
                                    txtLanThi.SelectionLength = txtLanThi.Text.Length;

                                    dt = new DataTable();
                                    return;
                                }
                            }
                        }

                        TuyChinhGhiDiem(true);
                    }
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TuyChinhGhiDiem(false);

        }

        private void btnGhiDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Console.WriteLine(dt.Rows.Count);
            //Console.WriteLine(dt.Columns.Count);

            //for(int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for(int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        string giatri = dt.Rows[i][j].ToString();
            //        Console.WriteLine(giatri);
            //    }
            //}

            //string nhapDiem = "EXEC sp_NHAPDIEM " + dt + ", " + maMonHoc + ", " + lanThi;

            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string diem = dt.Rows[i][2].ToString();
                if (diem.Trim().Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ điểm trước khi ghi", 
                                    "Thông báo", 
                                    MessageBoxButtons.OK);

                    return;
                }

                if (!Regex.IsMatch(diem, "^(-?)[0-9]+(\\.[0-9]+)?$"))
                {
                    MessageBox.Show("Điểm nhập vào không hợp lệ",
                                    "Thông báo",
                                    MessageBoxButtons.OK);

                    return;
                }

                if (Convert.ToDouble(diem) < 0 || Convert.ToDouble(diem) > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong đoạn [0, 10]",
                                    "Thông báo",
                                    MessageBoxButtons.OK);

                    return;
                }

            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Lớp chưa có sinh viên.\nVui lòng thêm sinh viên trước khi nhập điểm",
                                "Thông báo", MessageBoxButtons.OK);

                TuyChinhGhiDiem(false);
                return;
            }

            sqlDataReader = Program.ExecProcedureScore(dt, maMonHoc, Convert.ToInt32(lanThi));

            if(sqlDataReader == null)
            {
                return;
            }
            else
            {
                sqlDataReader.Read();

                string ketQua = sqlDataReader.GetString(0);
                sqlDataReader.Close();
                if(ketQua == "GHI THANH CONG")
                {
                    MessageBox.Show("Ghi điểm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else if(ketQua == "GHI THAT BAI")
                {
                    MessageBox.Show("Ghi điểm thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }

            TuyChinhGhiDiem(false);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                cmbDonVi.DataSource = null;
                cmbLop.DataSource = null;
                cmbMonHoc.DataSource = null;

                Program.bds_DONVI.Position = Program.donvi;
                Program.ThoatForm(true);
            }
            else
            {
                return;
            }
        }
    }
}
