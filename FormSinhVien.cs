using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormSinhVien : Form
    {
        private string maLop = "";
        private int viTriDongThem = 0;
        private BindingSource bds = new BindingSource();
        private DataTable dt = new DataTable();
        private SqlDataReader sqlDataReader;

        private int vitri = 0;
        private string maSinhVienSua = "";
        private string hoSua = "";
        private string tenSua = "";
        private string maLopSua = "";
        private bool phaiSua = false;
        private DateTime ngaySinhSua = DateTime.Today;
        private string noiSinhSua = "";
        private string diaChiSua = "";
        private string ghiChuSua = "";
        private bool nghiHocSua = false;

        private string maSinhVienCu = "";
        private string hoCu = "";
        private string tenCu = "";
        private string maLopCu = "";
        private bool phaiCu = false;
        private DateTime ngaySinhCu = DateTime.Today;
        private string noiSinhCu = "";
        private string diaChiCu = "";
        private string ghiChuCu = "";
        private bool nghiHocCu = false;

        private bool danhDauHo = false;
        private bool danhDauTen = false;
        private bool danhDauPhai = false;
        private bool danhDauNgaySinh = false;
        private bool danhDauNoiSinh = false;
        private bool danhDauDiaChi = false;
        private bool danhDauGhiChu = false;
        private bool danhDauNghiHoc = false;

        private Stack nganXepMa = new Stack();
        private Stack nganXepGiaTri = new Stack();
        private Stack nganXepMaGhi = new Stack();
        private Stack nganXepGiaTriGhi = new Stack();

        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void ChonViTri()
        {
            cmbLop.SelectedIndex = 1;
            cmbLop.SelectedIndex = 0;
            maLop = cmbLop.SelectedValue.ToString();
        }

        private void TuyChinhThem(bool them)
        {
            if (them)
            {
                cmbDonVi.Enabled = false;
                cmbLop.Enabled = false;

                gc_SINHVIEN.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
                btnXoa.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnThoat.Enabled = false;

                gc_SINHVIENTHEM.Enabled = true;
                btnThemDong.Enabled = true;
                btnXoaDong.Enabled = true;
                btnHoanTat.Enabled = true;
            }
            else
            {
                cmbDonVi.Enabled = true;
                cmbLop.Enabled = true;

                gc_SINHVIEN.Enabled = true;
                btnThem.Enabled = true;
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnThoat.Enabled = true;

                Console.WriteLine(bds_SINHVIEN.Count);
                if (bds_SINHVIEN.Count == 0)
                {
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }

                gc_SINHVIENTHEM.DataSource = null;
                gc_SINHVIENTHEM.Enabled = false;
                gv_SINHVIENTHEM.RefreshData();
                btnThemDong.Enabled = false;
                btnXoaDong.Enabled = false;
                btnHoanTat.Enabled = false;

                dt = new DataTable();
                bds = new BindingSource();
                
            }
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Sinh viên xin chào");

            // Bỏ cơ chế kiểm tra khóa ngoại
            this.ds_CNTT.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
            this.LOPTableAdapter.Fill(this.ds_CNTT.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
            this.SINHVIENTableAdapter.Fill(this.ds_CNTT.SINHVIEN);
            this.DIEMTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
            this.DIEMTableAdapter.Fill(this.ds_CNTT.DIEM);

            ChonViTri();

            viTriDongThem = bds_SINHVIEN.Count;

            bds_SINHVIEN.Filter = "MALOP='" + maLop + "'";
            Console.WriteLine(bds_SINHVIEN.Count);
            if(bds_SINHVIEN.Count == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }

            grpThongTin.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;

            gc_SINHVIENTHEM.Enabled = false;
            btnThemDong.Enabled = false;
            btnXoaDong.Enabled = false;
            btnHoanTat.Enabled = false;

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

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("tui sv trong lớp nè");
            Console.WriteLine(bds_LOP.Count);
            Console.WriteLine(cmbLop.Items.Count);
            if (cmbLop.SelectedValue != null)
            {
                maLop = cmbLop.SelectedValue.ToString();
                bds_SINHVIEN.Filter = "MALOP='" + maLop + "'";

                Console.WriteLine(bds_SINHVIEN.Count);
                if (bds_SINHVIEN.Count == 0)
                {
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }

                nganXepMa.Clear();
                nganXepMaGhi.Clear();
                nganXepGiaTri.Clear();
                nganXepGiaTriGhi.Clear();

                btnPhucHoi.Enabled = false;
            }
        }

        private void cmbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("tui sv nè");
            Console.WriteLine(Program.bds_DONVI);
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
                    nganXepMa.Clear();
                    nganXepMaGhi.Clear();
                    nganXepGiaTri.Clear();
                    nganXepGiaTriGhi.Clear();

                    btnPhucHoi.Enabled = false;

                    this.LOPTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
                    this.LOPTableAdapter.Fill(this.ds_CNTT.LOP);
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
                    this.SINHVIENTableAdapter.Fill(this.ds_CNTT.SINHVIEN);

                    ChonViTri();
                    bds_SINHVIEN.Filter = "MALOP='" + maLop + "'";
                    //if (bds_LOP != null)
                    //{
                    //    maKhoa = ((DataRowView)bds_LOP[0])["MAKH"].ToString();
                    //}

                }
            }
        }

        private void gv_SINHVIENTHEM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                if (gv_SINHVIENTHEM.DataRowCount > 0)
                {
                    int dongChon = gv_SINHVIENTHEM.FocusedRowHandle;
                    string maSVThem = gv_SINHVIENTHEM.GetRowCellValue(dongChon, "MASVTHEM").ToString().Trim();

                    for (int i = 0; i < gv_SINHVIENTHEM.DataRowCount; i++)
                    {
                        if(i != dongChon)
                        {
                            if (maSVThem.Equals(gv_SINHVIENTHEM.GetRowCellValue(i, "MASVTHEM").ToString().Trim()))
                            {
                                MessageBox.Show("Mã " + maSVThem + " đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }

        //private void gv_SINHVIENTHEM_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (gv_SINHVIENTHEM.GetRowCellValue(0, "MASVTHEM").ToString().Equals("n15"))
        //    {
        //        MessageBox.Show("Trùng mã rồi ba");
        //    }
        //}

        private void gv_SINHVIENTHEM_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            string maSVThem = e.Value.ToString().Trim();
            if (gv_SINHVIENTHEM.DataRowCount > 0)
            {
                for (int i = 0; i < gv_SINHVIENTHEM.DataRowCount; i++)
                {
                    if(maSVThem.Equals(gv_SINHVIENTHEM.GetRowCellValue(i, "MASVTHEM").ToString().Trim()))
                    {
                        MessageBox.Show("Mã " + maSVThem + " đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }

            //if (e.Value.ToString().Equals("n15"))
            //{
            //    MessageBox.Show("Trùng mã rồi ba");
            //}
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TuyChinhThem(true);

            foreach (GridColumn column in gv_SINHVIENTHEM.VisibleColumns)
            {
                dt.Columns.Add(column.FieldName, column.ColumnType);
            }
        }

        private void btnThemDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //gc_SINHVIENTHEM.DataSource = bds;

            //DataTable db = new DataTable();
            //DataRow dr = db.NewRow();
            //dr["MASVTHEM"] = "D15DCCN156";
            //dr["HOTHEM"] = "VIP";
            //dr["TENTHEM"] = "VIP";
            //db.Rows.Add(dr);

            //bds.DataSource = db;
            //gc_SINHVIENTHEM.DataSource = bds;

            
            //for (int i = 0; i < gv_SINHVIENTHEM.DataRowCount; i++)
            //{
            //    DataRow row = dt.NewRow();
            //    foreach (GridColumn column in gv_SINHVIENTHEM.VisibleColumns)
            //    {
            //        row[column.FieldName] = gv_SINHVIENTHEM.GetRowCellValue(i, column);
            //    }
            //    dt.Rows.Add(row);
            //}

            DataRow dr = dt.NewRow();
            dr["MALOPTHEM"] = maLop;
            dt.Rows.Add(dr);

            bds.DataSource = dt;
            gc_SINHVIENTHEM.DataSource = bds;
        }

        private void btnHoanTat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Console.WriteLine(dt.Rows.Count);
            //Console.WriteLine(dt.Columns.Count);
            //Console.WriteLine(bds.Count);
            //for (int i = 0; i < gv_SINHVIENTHEM.DataRowCount; i++)
            //{
            //    DataRow row = dt.NewRow();
            //    foreach (GridColumn column in gv_SINHVIENTHEM.VisibleColumns)
            //    {
            //        row[column.FieldName] = gv_SINHVIENTHEM.GetRowCellValue(i, column);

            //        if (column.FieldName.Equals("PHAITHEM") && row[column.FieldName].ToString().Equals("") ||
            //            column.FieldName.Equals("NGHIHOCTHEM") && row[column.FieldName].ToString().Equals(""))
            //        {
            //            row[column.FieldName] = false;
            //        }

            //        gv_SINHVIENTHEM.FocusedColumn = gv_SINHVIENTHEM.VisibleColumns[9];
            //        Console.WriteLine(row[column.FieldName]);
            //    }
            //}

            if(bds.Count > 0)
            {
                for (int i = 0; i < gv_SINHVIENTHEM.DataRowCount; i++)
                {
                    string maSVThem = gv_SINHVIENTHEM.GetRowCellValue(i, "MASVTHEM").ToString().Trim();
                    string lenh = "EXEC sp_KIEMTRAMASINHVIEN '" + maSVThem + "'";
                    Console.WriteLine(lenh);
                    sqlDataReader = Program.ExecSqlDataReader(lenh);

                    if (sqlDataReader == null)
                    {
                        return;
                    }
                    else
                    {
                        sqlDataReader.Read();

                        string ketQua = sqlDataReader.GetString(0);
                        sqlDataReader.Close();
                        if (ketQua == "TON TAI")
                        {
                            MessageBox.Show("Mã " + maSVThem +  " đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
                    

                for (int i = 0; i < gv_SINHVIENTHEM.DataRowCount; i++)
                {
                    DataRow row = dt.NewRow();
                    DataRow rowDS = ds_CNTT.SINHVIEN.NewRow();
                    foreach (GridColumn column in gv_SINHVIENTHEM.VisibleColumns)
                    {
                        row[column.FieldName] = gv_SINHVIENTHEM.GetRowCellValue(i, column);

                        if (column.FieldName.Equals("PHAITHEM") && row[column.FieldName].ToString().Equals("") ||
                            column.FieldName.Equals("NGHIHOCTHEM") && row[column.FieldName].ToString().Equals(""))
                        {
                            row[column.FieldName] = false;
                        }

                        gv_SINHVIENTHEM.FocusedColumn = gv_SINHVIENTHEM.VisibleColumns[9];
                    }

                    rowDS["MASV"] = row["MASVTHEM"];
                    rowDS["HO"] = row["HOTHEM"];
                    rowDS["TEN"] = row["TENTHEM"];
                    rowDS["MALOP"] = row["MALOPTHEM"];
                    rowDS["PHAI"] = row["PHAITHEM"];
                    rowDS["NGAYSINH"] = row["NGAYSINHTHEM"];
                    rowDS["NOISINH"] = row["NOISINHTHEM"];
                    rowDS["DIACHI"] = row["DIACHITHEM"];
                    rowDS["GHICHU"] = row["GHICHUTHEM"];
                    rowDS["NGHIHOC"] = row["NGHIHOCTHEM"];

                    ds_CNTT.SINHVIEN.Rows.InsertAt(rowDS, viTriDongThem);
                    bds_SINHVIEN.DataSource = ds_CNTT.SINHVIEN;
                    bds_SINHVIEN.EndEdit();
                    this.SINHVIENTableAdapter.Update(this.ds_CNTT.SINHVIEN);

                    bds_SINHVIEN.Position = viTriDongThem;

                    viTriDongThem++;
                    Console.WriteLine(viTriDongThem);
                }

                TuyChinhThem(false);
            }
            else
            {
                TuyChinhThem(false);
            }
        }

        private void btnXoaDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bds.Count > 0)
            {
                bds.RemoveCurrent();
            }
            else
            {
                return;
            }
            //Console.WriteLine(bds.Count);
            //Console.WriteLine(dt.Rows.Count);
            //Console.WriteLine(gv_SINHVIENTHEM.DataRowCount);

            //for (int i = 0; i < gv_SINHVIENTHEM.DataRowCount; i++)
            //{
            //    DataRow row = dt.NewRow();
            //    foreach (GridColumn column in gv_SINHVIENTHEM.VisibleColumns)
            //    {
            //        row[column.FieldName] = gv_SINHVIENTHEM.GetRowCellValue(i, column);

            //        if (column.FieldName.Equals("PHAITHEM") && row[column.FieldName].ToString().Equals("") ||
            //            column.FieldName.Equals("NGHIHOCTHEM") && row[column.FieldName].ToString().Equals(""))
            //        {
            //            row[column.FieldName] = false;
            //        }

            //        gv_SINHVIENTHEM.FocusedColumn = gv_SINHVIENTHEM.VisibleColumns[9];
            //        Console.WriteLine(row[column.FieldName]);
            //    }
            //}
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maSinhVienSua = txtMaSV.Text;
            tenSua = txtTen.Text;
            hoSua = txtHo.Text;
            maLopSua = txtMaLop.Text;
            phaiSua = Convert.ToBoolean(chkPhai.EditValue);
            ngaySinhSua = Convert.ToDateTime(datNgaySinh.EditValue);
            noiSinhSua = txtNoiSinh.Text;
            diaChiSua = txtDiaChi.Text;
            ghiChuSua = txtGhiChu.Text;
            nghiHocSua = Convert.ToBoolean(chkNghiHoc.EditValue);

            Console.WriteLine(maSinhVienSua);
            Console.WriteLine(tenSua);
            Console.WriteLine(hoSua);
            Console.WriteLine(maLopSua);
            Console.WriteLine(phaiSua);
            Console.WriteLine(ngaySinhSua);
            Console.WriteLine(noiSinhSua);
            Console.WriteLine(diaChiSua);
            Console.WriteLine(ghiChuSua);
            Console.WriteLine(nghiHocSua);

            lblDonVi.Focus();

            nganXepMa.Push("Sửa");
            MessageBox.Show(nganXepMa.Count.ToString());
            btnPhucHoi.Enabled = true;

            cmbDonVi.Enabled = false;
            cmbLop.Enabled = false;
            grpThongTin.Enabled = true;
            vitri = bds_SINHVIEN.Position;

            txtMaSV.Enabled = false;
            txtMaLop.Enabled = false;       
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            //btnPhucHoi.Enabled = true;

            gc_SINHVIEN.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nganXepMaGhi.Push("Ghi sửa");
            nganXepGiaTriGhi.Push(vitri + "," + maSinhVienSua + "," + hoSua + "," + tenSua + "," + maLopSua 
                                + "," + phaiSua + "," + ngaySinhSua + "," + noiSinhSua + "," + diaChiSua
                                + "," + ghiChuSua + "," + nghiHocSua);

            if (nganXepMa.Count > 0)
            {
                btnPhucHoi.Enabled = true;
            }

            bds_SINHVIEN.EndEdit();
            this.SINHVIENTableAdapter.Update(this.ds_CNTT.SINHVIEN);

            MessageBox.Show("Sửa sinh viên thành công", "Thông báo", MessageBoxButtons.OK);

            Console.WriteLine(nganXepMaGhi.Count);
            Console.WriteLine(nganXepGiaTriGhi.Count);

            nganXepMa.Clear();
            nganXepGiaTri.Clear();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = true;

            cmbDonVi.Enabled = true;
            cmbLop.Enabled = true;
            grpThongTin.Enabled = false;
            gc_SINHVIEN.Enabled = true;

            danhDauHo = false;
            danhDauTen = false;
            danhDauPhai = false;
            danhDauNgaySinh = false;
            danhDauNoiSinh = false;
            danhDauDiaChi = false;
            danhDauGhiChu = false;
            danhDauNghiHoc = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            danhDauHo = false;
            danhDauTen = false;
            danhDauPhai = false;
            danhDauNgaySinh = false;
            danhDauNoiSinh = false;
            danhDauDiaChi = false;
            danhDauGhiChu = false;
            danhDauNghiHoc = false;

            if (nganXepMa.Count != 0)
            {
                if (nganXepMa.Peek().Equals("Sửa"))
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThoat.Enabled = true;
                    btnGhi.Enabled = false;
                    btnPhucHoi.Enabled = false;

                    cmbDonVi.Enabled = true;
                    cmbLop.Enabled = true;
                    grpThongTin.Enabled = false;
                    gc_SINHVIEN.Enabled = true;

                    bds_SINHVIEN.Position = vitri;
                    bds_SINHVIEN.EndEdit();
                    this.SINHVIENTableAdapter.Update(this.ds_CNTT.SINHVIEN);
                    Console.WriteLine(gv_SINHVIEN.DataRowCount);
                    Console.WriteLine(bds_SINHVIEN.Count);

                    nganXepMa.Clear();
                    nganXepGiaTri.Clear();

                    if (nganXepMaGhi.Count == 0)
                    {
                        btnPhucHoi.Enabled = false;
                    }
                    else
                    {
                        btnPhucHoi.Enabled = true;
                    }

                    return;
                }

                if (nganXepMa.Peek().Equals("Thay đổi"))
                {
                    string giaTri = nganXepGiaTri.Peek().ToString();

                    string[] giaTriThayDoi = giaTri.Split(',');

                    if (giaTriThayDoi[0].Equals("txtHo"))
                    {
                        txtHo.Text = giaTriThayDoi[1];

                        lblDonVi.Focus();
                        txtHo.SelectionStart = txtHo.TextLength;
                        txtHo.SelectionLength = 0;

                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    if (giaTriThayDoi[0].Equals("txtTen"))
                    {
                        txtTen.Text = giaTriThayDoi[1];

                        lblDonVi.Focus();
                        txtTen.SelectionStart = txtTen.TextLength;
                        txtTen.SelectionLength = 0;

                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    if (giaTriThayDoi[0].Equals("chkPhai"))
                    {
                        chkPhai.EditValue = Convert.ToBoolean(giaTriThayDoi[1]);

                        lblDonVi.Focus();

                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    if (giaTriThayDoi[0].Equals("datNgaySinh"))
                    {
                        datNgaySinh.EditValue = Convert.ToDateTime(giaTriThayDoi[1]);

                        lblDonVi.Focus();

                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    if (giaTriThayDoi[0].Equals("txtNoiSinh"))
                    {
                        txtNoiSinh.Text = giaTriThayDoi[1];

                        lblDonVi.Focus();
                        txtNoiSinh.SelectionStart = txtNoiSinh.TextLength;
                        txtNoiSinh.SelectionLength = 0;

                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    if (giaTriThayDoi[0].Equals("txtDiaChi"))
                    {
                        txtDiaChi.Text = giaTriThayDoi[1];

                        lblDonVi.Focus();
                        txtDiaChi.SelectionStart = txtDiaChi.TextLength;
                        txtDiaChi.SelectionLength = 0;

                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    if (giaTriThayDoi[0].Equals("txtGhiChu"))
                    {
                        txtGhiChu.Text = giaTriThayDoi[1];

                        lblDonVi.Focus();
                        txtGhiChu.SelectionStart = txtGhiChu.TextLength;
                        txtGhiChu.SelectionLength = 0;

                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    if (giaTriThayDoi[0].Equals("chkNghiHoc"))
                    {
                        chkNghiHoc.EditValue = Convert.ToBoolean(giaTriThayDoi[1]);

                        lblDonVi.Focus();

                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    nganXepMa.Pop();
                    nganXepGiaTri.Pop();
                    Console.WriteLine(nganXepMa.Count);
                    Console.WriteLine(nganXepGiaTri.Count);
                }
            }

            if (nganXepMaGhi.Count != 0 && nganXepMa.Count == 0)
            {
                Console.WriteLine(nganXepMaGhi.Count);
                Console.WriteLine(nganXepGiaTriGhi.Count);
                if (nganXepMaGhi.Peek().Equals("Ghi sửa"))
                {
                    string giaTri = nganXepGiaTriGhi.Peek().ToString();
                    string[] giaTriThayDoi = giaTri.Split(',');
                    Console.WriteLine(giaTriThayDoi[0]);
                    Console.WriteLine(giaTriThayDoi[1]);
                    Console.WriteLine(giaTriThayDoi[2]);
                    Console.WriteLine(giaTriThayDoi[3]);
                    Console.WriteLine(giaTriThayDoi[4]);
                    Console.WriteLine(giaTriThayDoi[5]);
                    Console.WriteLine(giaTriThayDoi[6]);
                    Console.WriteLine(giaTriThayDoi[7]);
                    Console.WriteLine(giaTriThayDoi[8]);
                    Console.WriteLine(giaTriThayDoi[9]);
                    Console.WriteLine(giaTriThayDoi[10]);

                    bds_SINHVIEN.RemoveAt(Convert.ToInt32(giaTriThayDoi[0]));
                    bds_SINHVIEN.EndEdit();
                    this.SINHVIENTableAdapter.Update(this.ds_CNTT.SINHVIEN);

                    DataRow row = ds_CNTT.SINHVIEN.NewRow();
                    row["MASV"] = giaTriThayDoi[1];
                    row["HO"] = giaTriThayDoi[2];
                    row["TEN"] = giaTriThayDoi[3];
                    row["MALOP"] = giaTriThayDoi[4];
                    row["PHAI"] = giaTriThayDoi[5];
                    row["NGAYSINH"] = giaTriThayDoi[6];
                    row["NOISINH"] = giaTriThayDoi[7];
                    row["DIACHI"] = giaTriThayDoi[8];
                    row["GHICHU"] = giaTriThayDoi[9];
                    row["NGHIHOC"] = giaTriThayDoi[10];

                    int pos = Convert.ToInt32(giaTriThayDoi[0]);
                    ds_CNTT.SINHVIEN.Rows.InsertAt(row, pos);
                    bds_SINHVIEN.DataSource = ds_CNTT.SINHVIEN;
                    bds_SINHVIEN.EndEdit();
                    this.SINHVIENTableAdapter.Update(this.ds_CNTT.SINHVIEN);

                    bds_SINHVIEN.Position = pos;
                    txtMaSV.Text = giaTriThayDoi[1];
                    txtHo.Text = giaTriThayDoi[2];
                    txtTen.Text = giaTriThayDoi[3];
                    txtMaLop.Text = giaTriThayDoi[4];
                    chkPhai.EditValue = Convert.ToBoolean(giaTriThayDoi[5]);
                    datNgaySinh.EditValue = Convert.ToDateTime(giaTriThayDoi[6]);
                    txtNoiSinh.Text = giaTriThayDoi[7];
                    txtDiaChi.Text = giaTriThayDoi[8];
                    txtGhiChu.Text = giaTriThayDoi[9];
                    chkNghiHoc.EditValue = Convert.ToBoolean(giaTriThayDoi[10]);

                    Console.WriteLine(gv_SINHVIEN.DataRowCount);
                    Console.WriteLine(bds_SINHVIEN.Count);

                    Console.WriteLine(nganXepMaGhi.Count);
                    Console.WriteLine(nganXepGiaTriGhi.Count);

                    nganXepMaGhi.Pop();
                    nganXepGiaTriGhi.Pop();

                    if (nganXepMaGhi.Count == 0)
                    {
                        cmbDonVi.Enabled = true;
                        cmbLop.Enabled = true;
                        grpThongTin.Enabled = false;
                        gc_SINHVIEN.Enabled = true;

                        btnPhucHoi.Enabled = false;
                        nganXepMaGhi.Clear();
                        nganXepGiaTriGhi.Clear();
                    }

                    return;
                }
            }

            if (nganXepMaGhi.Count != 0 && nganXepMa.Count == 0)
            {
                Console.WriteLine(nganXepMaGhi.Count);
                Console.WriteLine(nganXepGiaTriGhi.Count);
                if (nganXepMaGhi.Peek().Equals("Xóa"))
                {
                    string giaTri = nganXepGiaTriGhi.Peek().ToString();
                    string[] giaTriThayDoi = giaTri.Split(',');
                    Console.WriteLine(giaTriThayDoi[0]);
                    Console.WriteLine(giaTriThayDoi[1]);
                    Console.WriteLine(giaTriThayDoi[2]);
                    Console.WriteLine(giaTriThayDoi[3]);
                    Console.WriteLine(giaTriThayDoi[4]);
                    Console.WriteLine(giaTriThayDoi[5]);
                    Console.WriteLine(giaTriThayDoi[6]);
                    Console.WriteLine(giaTriThayDoi[7]);
                    Console.WriteLine(giaTriThayDoi[8]);
                    Console.WriteLine(giaTriThayDoi[9]);
                    Console.WriteLine(giaTriThayDoi[10]);

                    DataRow row = ds_CNTT.SINHVIEN.NewRow();
                    row["MASV"] = giaTriThayDoi[1];
                    row["HO"] = giaTriThayDoi[2];
                    row["TEN"] = giaTriThayDoi[3];
                    row["MALOP"] = giaTriThayDoi[4];
                    row["PHAI"] = giaTriThayDoi[5];
                    row["NGAYSINH"] = giaTriThayDoi[6];
                    row["NOISINH"] = giaTriThayDoi[7];
                    row["DIACHI"] = giaTriThayDoi[8];
                    row["GHICHU"] = giaTriThayDoi[9];
                    row["NGHIHOC"] = giaTriThayDoi[10];

                    int pos = Convert.ToInt32(giaTriThayDoi[0]);
                    ds_CNTT.SINHVIEN.Rows.InsertAt(row, pos);
                    bds_SINHVIEN.DataSource = ds_CNTT.SINHVIEN;
                    bds_SINHVIEN.EndEdit();
                    this.SINHVIENTableAdapter.Update(this.ds_CNTT.SINHVIEN);

                    bds_SINHVIEN.Position = pos;

                    Console.WriteLine(gv_SINHVIEN.DataRowCount);
                    Console.WriteLine(bds_SINHVIEN.Count);

                    Console.WriteLine(nganXepMaGhi.Count);
                    Console.WriteLine(nganXepGiaTriGhi.Count);

                    Console.WriteLine(bds_SINHVIEN.Count);
                    if (bds_SINHVIEN.Count == 0)
                    {
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                    }
                    else
                    {
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }

                    nganXepMaGhi.Pop();
                    nganXepGiaTriGhi.Pop();

                    if (nganXepMaGhi.Count == 0)
                    {
                        cmbDonVi.Enabled = true;
                        cmbLop.Enabled = true;
                        grpThongTin.Enabled = false;
                        gc_SINHVIEN.Enabled = true;

                        btnPhucHoi.Enabled = false;
                        nganXepMaGhi.Clear();
                        nganXepGiaTriGhi.Clear();
                    }

                    return;
                }
            }
        }

        // Họ

        private void txtHo_Clicked(object sender, EventArgs e)
        {
            danhDauHo = true;
            hoCu = txtHo.Text;

        }

        private void txtHo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauHo = true;
                hoCu = txtHo.Text;
            }

        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {
            if (danhDauHo)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtHo," + hoCu);
                    hoCu = txtHo.Text;
                }
            }

        }

        // Tên

        private void txtTen_Clicked(object sender, EventArgs e)
        {
            danhDauTen = true;
            tenCu = txtTen.Text;
        }

        private void txtTen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauTen = true;
                tenCu = txtTen.Text;
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (danhDauTen)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtTen," + tenCu);
                    tenCu = txtTen.Text;
                }
            }
        }

        // Phái

        private void chkPhai_Clicked(object sender, EventArgs e)
        {
            danhDauPhai = true;
            phaiCu = Convert.ToBoolean(chkPhai.EditValue);
        }

        private void chkPhai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauPhai = true;
                phaiCu = Convert.ToBoolean(chkPhai.EditValue);
            }
        }

        private void chkPhai_TextChanged(object sender, EventArgs e)
        {
            if (danhDauPhai)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("chkPhai," + phaiCu);
                    phaiCu = Convert.ToBoolean(chkPhai.EditValue);
                }
            }
        }

        // Ngày sinh

        private void datNgaySinh_Clicked(object sender, EventArgs e)
        {
            danhDauNgaySinh = true;
            ngaySinhCu = Convert.ToDateTime(datNgaySinh.EditValue);
        }

        private void datNgaySinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauNgaySinh = true;
                ngaySinhCu = Convert.ToDateTime(datNgaySinh.EditValue);
            }
        }

        private void datNgaySinh_TextChanged(object sender, EventArgs e)
        {
            if (danhDauNgaySinh)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("datNgaySinh," + ngaySinhCu);
                    ngaySinhCu = Convert.ToDateTime(datNgaySinh.EditValue);
                }
            }
        }

        // Nơi sinh

        private void txtNoiSinh_Clicked(object sender, EventArgs e)
        {
            danhDauNoiSinh = true;
            noiSinhCu = txtNoiSinh.Text;
        }

        private void txtNoiSinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauNoiSinh = true;
                noiSinhCu = txtNoiSinh.Text;
            }
        }

        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {
            if (danhDauNoiSinh)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtNoiSinh," + noiSinhCu);
                    noiSinhCu = txtNoiSinh.Text;
                }
            }
        }

        // Địa chỉ

        private void txtDiaChi_Clicked(object sender, EventArgs e)
        {
            danhDauDiaChi = true;
            diaChiCu = txtDiaChi.Text;
        }

        private void txtDiaChi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauDiaChi = true;
                diaChiCu = txtDiaChi.Text;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (danhDauDiaChi)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtDiaChi," + diaChiCu);
                    diaChiCu = txtDiaChi.Text;
                }
            }
        }

        // Ghi chú

        private void txtGhiChu_Clicked(object sender, EventArgs e)
        {
            danhDauGhiChu = true;
            ghiChuCu = txtGhiChu.Text;
        }

        private void txtGhiChu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauGhiChu = true;
                ghiChuCu = txtGhiChu.Text;
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (danhDauGhiChu)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtGhiChu," + ghiChuCu);
                    ghiChuCu = txtGhiChu.Text;
                }
            }
        }

        // Nghỉ học

        private void chkNghiHoc_Clicked(object sender, EventArgs e)
        {
            danhDauNghiHoc = true;
            nghiHocCu = Convert.ToBoolean(chkNghiHoc.EditValue);
        }

        private void chkNghiHoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauNghiHoc = true;
                nghiHocCu = Convert.ToBoolean(chkNghiHoc.EditValue);
            }
        }

        private void chkNghiHoc_TextChanged(object sender, EventArgs e)
        {
            if (danhDauNghiHoc)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("chkNghiHoc," + nghiHocCu);
                    nghiHocCu = Convert.ToBoolean(chkNghiHoc.EditValue);
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = bds_SINHVIEN.Position;
            maSinhVienSua = txtMaSV.Text;
            tenSua = txtTen.Text;
            hoSua = txtHo.Text;
            maLopSua = txtMaLop.Text;
            phaiSua = Convert.ToBoolean(chkPhai.EditValue);
            ngaySinhSua = Convert.ToDateTime(datNgaySinh.EditValue);
            noiSinhSua = txtNoiSinh.Text;
            diaChiSua = txtDiaChi.Text;
            ghiChuSua = txtGhiChu.Text;
            nghiHocSua = Convert.ToBoolean(chkNghiHoc.EditValue);

            bds_DIEM.Filter = "MASV = '" + txtMaSV.Text.Trim() + "'";
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(bds_DIEM.Count > 0)
                {
                    MessageBox.Show("Không thể xóa sinh viên có điểm", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                string kiemTraHocPhi = "EXEC sp_KIEMTRAHOCPHISINHVIEN '" + txtMaSV.Text.Trim() + "'";
                SqlDataReader sqlDataReader = Program.ExecSqlDataReader(kiemTraHocPhi);

                if (sqlDataReader == null)
                {
                    return;
                }
                else
                {
                    sqlDataReader.Read();

                    string ketQua = sqlDataReader.GetString(0);
                    sqlDataReader.Close();

                    if (ketQua.Equals("TON TAI"))
                    {
                        MessageBox.Show("Không thể xóa sinh viên đang có học phí", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ketQua.Equals("CHUA TON TAI"))
                    {
                        try
                        {
                            bds_SINHVIEN.RemoveCurrent();
                            bds_SINHVIEN.EndEdit();
                            this.SINHVIENTableAdapter.Update(this.ds_CNTT.SINHVIEN);
                            Console.WriteLine(gv_SINHVIEN.DataRowCount);
                            Console.WriteLine(bds_SINHVIEN.Count);

                            nganXepMaGhi.Push("Xóa");
                            nganXepGiaTriGhi.Push(vitri + "," + maSinhVienSua + "," + hoSua + "," + tenSua + "," + maLopSua
                                        + "," + phaiSua + "," + ngaySinhSua + "," + noiSinhSua + "," + diaChiSua
                                        + "," + ghiChuSua + "," + nghiHocSua);

                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);

                            Console.WriteLine(bds_SINHVIEN.Count);
                            if (bds_SINHVIEN.Count == 0)
                            {
                                btnSua.Enabled = false;
                                btnXoa.Enabled = false;
                            }
                            else
                            {
                                btnSua.Enabled = true;
                                btnXoa.Enabled = true;
                            }

                            btnPhucHoi.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xóa thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nganXepMa.Clear();
                nganXepMaGhi.Clear();
                nganXepGiaTri.Clear();
                nganXepGiaTriGhi.Clear();

                this.Close();
                cmbLop.DataSource = null;
                cmbDonVi.DataSource = null;

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
