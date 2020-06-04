using DevExpress.XtraGrid.Views.Base;
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
    public partial class FormHocPhi : Form
    {
        private string maSinhVien = "";
        private int demDong = 0;

        private BindingSource bds = new BindingSource();
        private DataTable dt = new DataTable();

        public FormHocPhi()
        {
            InitializeComponent();
        }

        private void XuLyNghiHoc(bool nghiHoc)
        {
            if (nghiHoc)
            {
                gc_HOCPHI.Enabled = false;
                btnThemDong.Enabled = false;
                btnXoaDong.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = true;
            }
            else
            {
                gc_HOCPHI.Enabled = true;
                btnThemDong.Enabled = true;
                btnXoaDong.Enabled = true;
                btnGhi.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void XuLyGhiHocPhi(bool ghiHocPhi)
        {
            if (ghiHocPhi)
            {
                btnBatDau.Enabled = false;
                btnThoat.Enabled = false;
                grpThongTin.Enabled = false;
            }
            else
            {
                btnBatDau.Enabled = true;
                btnThoat.Enabled = true;
                grpThongTin.Enabled = true;

                txtMaSV.Text = "";
                txtHoTen.Text = "";
                txtMaLop.Text = "";

                gc_HOCPHI.DataSource = null;
                gc_HOCPHI.Enabled = false;
                btnThemDong.Enabled = false;
                btnXoaDong.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;

                dt = new DataTable();
                bds = new BindingSource();
            }
        }

        private void FormHocPhi_Load(object sender, EventArgs e)
        {
            gc_HOCPHI.Enabled = false;
            btnThemDong.Enabled = false;
            btnXoaDong.Enabled = false;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnBatDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maSinhVien = txtMaSV.Text.Trim();

            if (maSinhVien.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK);
                txtMaSV.Focus();

                return;
            }

            string kiemTraMaTonTai = "EXEC sp_KIEMTRAMASINHVIENTONTAI '" + maSinhVien + "'";
            SqlDataReader sqlDataReader = Program.ExecSqlDataReader(kiemTraMaTonTai);

            if (sqlDataReader == null)
            {
                return;
            }
            else
            {
                sqlDataReader.Read();

                string ketQua = sqlDataReader.GetString(0);
                sqlDataReader.Close();

                if (ketQua.Equals("KHONG TON TAI"))
                {
                    MessageBox.Show("Mã sinh viên không tồn tại", "Thông báo", MessageBoxButtons.OK);
                    txtMaSV.Focus();
                    txtMaSV.SelectionStart = 0;
                    txtMaSV.SelectionLength = txtMaSV.Text.Length;

                    return;
                }
                else if(ketQua.Equals("NGHI HOC"))
                {
                    MessageBox.Show("Sinh viên đã nghỉ học", "Thông báo", MessageBoxButtons.OK);

                    XuLyGhiHocPhi(true);
                    XuLyNghiHoc(true);

                    string kiemTraThongTinHocPhi = "EXEC sp_KIEMTRATHONGTINHOCPHI '" + maSinhVien + "'";
                    sqlDataReader = Program.ExecSqlDataReader(kiemTraThongTinHocPhi);

                    if (sqlDataReader == null)
                    {
                        return;
                    }
                    else
                    {
                        sqlDataReader.Read();

                        string ketQuaHocPhi = sqlDataReader.GetString(0);
                        sqlDataReader.Close();

                        if (ketQuaHocPhi.Equals("CHUA TON TAI"))
                        {
                            string layThongTinSinhVienDongHocPhi = "EXEC sp_LAYTHONGTINSINHVIENDONGHOCPHI '"
                                                                    + maSinhVien + "'";
                            sqlDataReader = Program.ExecSqlDataReader(layThongTinSinhVienDongHocPhi);

                            if (sqlDataReader == null)
                            {
                                return;
                            }
                            else
                            {
                                sqlDataReader.Read();

                                txtHoTen.Text = sqlDataReader.GetString(0);
                                txtMaLop.Text = sqlDataReader.GetString(1);

                                sqlDataReader.Close();
                            }

                            return;
                        }
                        else if (ketQuaHocPhi.Equals("TON TAI"))
                        {
                            dt.Columns.Add("NIENKHOA", typeof(string));
                            dt.Columns.Add("HOCKY", typeof(string));
                            dt.Columns.Add("HOCPHI", typeof(string));
                            dt.Columns.Add("SOTIENDADONG", typeof(string));

                            string layThongTinHocPhi = "EXEC sp_LAYTHONGTINHOCPHI '" + maSinhVien + "'";
                            sqlDataReader = Program.ExecSqlDataReader(layThongTinHocPhi);

                            if (sqlDataReader == null)
                            {
                                return;
                            }
                            else
                            {
                                while (sqlDataReader.Read())
                                {
                                    string hoTen = sqlDataReader.GetString(0);
                                    string maLop = sqlDataReader.GetString(1);
                                    string nienKhoa = sqlDataReader.GetString(2);
                                    int hocKy = sqlDataReader.GetInt32(3);
                                    int hocPhi = sqlDataReader.GetInt32(4);
                                    int soTienDaDong = sqlDataReader.GetInt32(5);

                                    txtHoTen.Text = hoTen;
                                    txtMaLop.Text = maLop;

                                    DataRow dr = dt.NewRow();
                                    dr["NIENKHOA"] = nienKhoa;
                                    dr["HOCKY"] = hocKy;
                                    dr["HOCPHI"] = hocPhi;
                                    dr["SOTIENDADONG"] = soTienDaDong;
                                    dt.Rows.Add(dr);
                                }

                                sqlDataReader.Close();
                                bds.DataSource = dt;
                                gc_HOCPHI.DataSource = bds;
                            }
                        }
                    }
                }
                else if(ketQua.Equals("CHUA NGHI HOC"))
                {
                    XuLyGhiHocPhi(true);
                    XuLyNghiHoc(false);

                    string kiemTraThongTinHocPhi = "EXEC sp_KIEMTRATHONGTINHOCPHI '" + maSinhVien + "'";
                    sqlDataReader = Program.ExecSqlDataReader(kiemTraThongTinHocPhi);

                    if (sqlDataReader == null)
                    {
                        return;
                    }
                    else
                    {
                        dt.Columns.Add("NIENKHOA", typeof(string));
                        dt.Columns.Add("HOCKY", typeof(string));
                        dt.Columns.Add("HOCPHI", typeof(string));
                        dt.Columns.Add("SOTIENDADONG", typeof(string));

                        //DataColumn dc1 = new DataColumn();
                        //dc1.DataType = System.Type.GetType("System.String");
                        //dc1.ColumnName = "NIENKHOA";
                        //dc1.ReadOnly = true;

                        //DataColumn dc2 = new DataColumn();
                        //dc2.DataType = System.Type.GetType("System.String");
                        //dc2.ColumnName = "HOCKY";
                        //dc2.ReadOnly = true;

                        //DataColumn dc3 = new DataColumn();
                        //dc3.DataType = System.Type.GetType("System.String");
                        //dc3.ColumnName = "HOCPHI";
                        //dc3.ReadOnly = true;

                        //DataColumn dc4 = new DataColumn();
                        //dc4.DataType = System.Type.GetType("System.String");
                        //dc4.ColumnName = "SOTIENDADONG";
                        //dc4.ReadOnly = false;

                        //dt.Columns.Add(dc1);
                        //dt.Columns.Add(dc2);
                        //dt.Columns.Add(dc3);
                        //dt.Columns.Add(dc4);

                        sqlDataReader.Read();

                        string ketQuaHocPhi = sqlDataReader.GetString(0);
                        sqlDataReader.Close();

                        if (ketQuaHocPhi.Equals("CHUA TON TAI"))
                        {
                            string layThongTinSinhVienDongHocPhi= "EXEC sp_LAYTHONGTINSINHVIENDONGHOCPHI '" 
                                                                    + maSinhVien + "'";
                            sqlDataReader = Program.ExecSqlDataReader(layThongTinSinhVienDongHocPhi);

                            if (sqlDataReader == null)
                            {
                                return;
                            }
                            else
                            {
                                sqlDataReader.Read();

                                txtHoTen.Text = sqlDataReader.GetString(0);
                                txtMaLop.Text = sqlDataReader.GetString(1);

                                sqlDataReader.Close();

                                DataRow dr = dt.NewRow();
                                dt.Rows.Add(dr);

                                bds.DataSource = dt;
                                gc_HOCPHI.DataSource = bds;

                                dt.Rows[0][1] = 1;
                                dt.Columns[1].ReadOnly = true;
                                
                                demDong = dt.Rows.Count;
                                Console.WriteLine(demDong);

                                // Cho cột chỉ đọc không chỉnh sửa
                                //gv_HOCPHI.VisibleColumns[0].OptionsColumn.ReadOnly = true;
                            }

                            return;
                        }
                        else if (ketQuaHocPhi.Equals("TON TAI"))
                        {
                            string layThongTinHocPhi = "EXEC sp_LAYTHONGTINHOCPHI '" + maSinhVien + "'";
                            sqlDataReader = Program.ExecSqlDataReader(layThongTinHocPhi);

                            if (sqlDataReader == null)
                            {
                                return;
                            }
                            else
                            {
                                // Cho cột chỉ đọc không chỉnh sửa
                                //gv_HOCPHI.VisibleColumns[0].OptionsColumn.ReadOnly = true;
                                //gv_HOCPHI.VisibleColumns[1].OptionsColumn.ReadOnly = true;
                                //gv_HOCPHI.VisibleColumns[2].OptionsColumn.ReadOnly = true;

                                while (sqlDataReader.Read())
                                {
                                    string hoTen = sqlDataReader.GetString(0);
                                    string maLop = sqlDataReader.GetString(1);
                                    string nienKhoa = sqlDataReader.GetString(2);
                                    int hocKy = sqlDataReader.GetInt32(3);
                                    int hocPhi = sqlDataReader.GetInt32(4);
                                    int soTienDaDong = sqlDataReader.GetInt32(5);

                                    txtHoTen.Text = hoTen;
                                    txtMaLop.Text = maLop;

                                    DataRow dr = dt.NewRow();
                                    dr["NIENKHOA"] = nienKhoa;
                                    dr["HOCKY"] = hocKy;
                                    dr["HOCPHI"] = hocPhi;
                                    dr["SOTIENDADONG"] = soTienDaDong;
                                    dt.Rows.Add(dr);
                                }

                                sqlDataReader.Close();
                                bds.DataSource = dt;
                                gc_HOCPHI.DataSource = bds;

                                dt.Columns[0].ReadOnly = true;
                                dt.Columns[1].ReadOnly = true;

                                demDong = dt.Rows.Count;
                                Console.WriteLine(demDong);
                            }
                        }
                    }
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int dongHienTai = gv_HOCPHI.FocusedRowHandle;

            // Bảng chưa có dữ liệu
            if (gv_HOCPHI.DataRowCount == 0)
            {
                return;
            }

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                // Bảng chưa nhập đủ dữ liệu
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (dt.Rows[i][j].ToString().Trim().Equals(""))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin",
                                        "Thông báo",
                                        MessageBoxButtons.OK);

                        return;
                    }
                }

                // Khuôn mẫu niên khóa không đúng
                if (!Regex.IsMatch(dt.Rows[i][0].ToString().Trim(), "^20[0-9]{2}-20[0-9]{2}$"))
                {
                    MessageBox.Show("Niên khóa không đúng định dạng yyyy-yyyy",
                                        "Thông báo",
                                        MessageBoxButtons.OK);

                    return;
                }
                else
                {
                    string[] nam = dt.Rows[i][0].ToString().Trim().Split('-');
                    if (Convert.ToInt32(nam[1]) - Convert.ToInt32(nam[0]) != 5)
                    {
                        MessageBox.Show("Khóa học tối đa 5 năm",
                                        "Thông báo",
                                        MessageBoxButtons.OK);

                        return;
                    }

                    if(i != dt.Rows.Count - 1)
                    {
                        if (!dt.Rows[i][0].ToString().Trim().Equals(dt.Rows[i + 1][0].ToString().Trim()))
                        {
                            MessageBox.Show("Niên khóa là một khóa học duy nhất",
                                        "Thông báo",
                                        MessageBoxButtons.OK);

                            return;
                        }
                    }
                }

                // Khuôn mẫu học kỳ không đúng
                //if (Regex.IsMatch(dt.Rows[i][1].ToString().Trim(), "\\D"))
                //{
                //    MessageBox.Show("Học kỳ phải là số nguyên",
                //                        "Thông báo",
                //                        MessageBoxButtons.OK);

                //    return;
                //}
                //else
                //{
                //    if (Convert.ToInt32(dt.Rows[i][1].ToString().Trim()) < 1 ||
                //       Convert.ToInt32(dt.Rows[i][1].ToString().Trim()) > 10)
                //    {
                //        MessageBox.Show("Học kỳ nằm trong đoạn [1,10]",
                //                        "Thông báo",
                //                        MessageBoxButtons.OK);

                //        return;
                //    }

                //    if (i != dt.Rows.Count - 1)
                //    {
                //        if (dt.Rows[i][1].ToString().Trim().Equals(dt.Rows[i + 1][1].ToString().Trim()))
                //        {
                //            MessageBox.Show("Học kỳ không được trùng nhau",
                //                        "Thông báo",
                //                        MessageBoxButtons.OK);

                //            return;
                //        }
                //    }
                //}

                // Khuôn mẫu học phí không đúng
                if (Regex.IsMatch(dt.Rows[i][2].ToString().Trim(), "\\D"))
                {
                    MessageBox.Show("Học phí phải là số nguyên",
                                        "Thông báo",
                                        MessageBoxButtons.OK);

                    return;
                }
                else
                {
                    if (Convert.ToInt32(dt.Rows[i][2].ToString().Trim()) < 6000000 ||
                       Convert.ToInt32(dt.Rows[i][2].ToString().Trim()) > 10000000)
                    {
                        MessageBox.Show("Học phí từ 6 triệu đến 10 triệu",
                                        "Thông báo",
                                        MessageBoxButtons.OK);

                        return;
                    }
                }

                // Khuôn mẫu số tiền đã đóng không đúng
                if (Regex.IsMatch(dt.Rows[i][3].ToString().Trim(), "\\D"))
                {
                    MessageBox.Show("Số tiền đã đóng phải là số nguyên",
                                        "Thông báo",
                                        MessageBoxButtons.OK);

                    return;
                }
                else
                {
                    if (Convert.ToInt32(dt.Rows[i][3].ToString().Trim()) != 0 &&
                    Convert.ToInt32(dt.Rows[i][3].ToString().Trim()) != Convert.ToInt32(dt.Rows[i][2].ToString().Trim()))
                    {
                        MessageBox.Show("Số tiền đã đóng bằng 0 hoặc bằng học phí",
                                            "Thông báo",
                                            MessageBoxButtons.OK);

                        return;
                    }
                }
            }

            // Khuôn mẫu niên khóa không đúng
            //if (!Regex.IsMatch(dt.Rows[dongHienTai][0].ToString().Trim(), "^20[0-9]{2}-20[0-9]{2}$"))
            //{
            //    MessageBox.Show("Niên khóa không đúng định dạng yyyy-yyyy",
            //                        "Thông báo",
            //                        MessageBoxButtons.OK);

            //    return;
            //}
            //else
            //{
            //    string[] nam = dt.Rows[dongHienTai][0].ToString().Trim().Split('-');
            //    if(Convert.ToInt32(nam[1]) - Convert.ToInt32(nam[0]) != 5)
            //    {
            //        MessageBox.Show("Khóa học tối đa 5 năm",
            //                        "Thông báo",
            //                        MessageBoxButtons.OK);

            //        return;
            //    }

            //    for (int i = 0; i < dt.Rows.Count - 1; i++)
            //    {
            //        if (dt.Rows[i][0].ToString().Trim().Equals(dt.Rows[i + 1][0].ToString().Trim()))
            //        {
            //            MessageBox.Show("Niên khóa là một khóa học duy nhất",
            //                        "Thông báo",
            //                        MessageBoxButtons.OK);

            //            return;
            //        }
            //    }
            //}

            // Khuôn mẫu học kỳ không đúng
            //if (Regex.IsMatch(dt.Rows[dongHienTai][1].ToString().Trim(), "\\D"))
            //{
            //    MessageBox.Show("Học kỳ phải là số nguyên",
            //                        "Thông báo",
            //                        MessageBoxButtons.OK);

            //    return;
            //}
            //else
            //{
            //    if(Convert.ToInt32(dt.Rows[dongHienTai][1].ToString().Trim()) < 1 ||
            //       Convert.ToInt32(dt.Rows[dongHienTai][1].ToString().Trim()) > 10)
            //    {
            //        MessageBox.Show("Học kỳ nằm trong đoạn [1,10]",
            //                        "Thông báo",
            //                        MessageBoxButtons.OK);

            //        return;
            //    }

            //    for (int i = 0; i < dt.Rows.Count - 1; i++)
            //    {
            //        if (dt.Rows[i][1].ToString().Trim().Equals(dt.Rows[i + 1][1].ToString().Trim()))
            //        {
            //            MessageBox.Show("Học kỳ không được trùng nhau",
            //                        "Thông báo",
            //                        MessageBoxButtons.OK);

            //            return;
            //        }
            //    }
            //}

            // Khuôn mẫu học phí không đúng
            //if (Regex.IsMatch(dt.Rows[dongHienTai][2].ToString().Trim(), "\\D"))
            //{
            //    MessageBox.Show("Học phí phải là số nguyên",
            //                        "Thông báo",
            //                        MessageBoxButtons.OK);

            //    return;
            //}
            //else
            //{
            //    if(Convert.ToInt32(dt.Rows[dongHienTai][2].ToString().Trim()) < 6000000 ||
            //       Convert.ToInt32(dt.Rows[dongHienTai][2].ToString().Trim()) > 10000000)
            //    {
            //        MessageBox.Show("Học phí từ 6 triệu đến 10 triệu",
            //                        "Thông báo",
            //                        MessageBoxButtons.OK);

            //        return;
            //    }
            //}

            // Khuôn mẫu số tiền đã đóng không đúng
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (Regex.IsMatch(dt.Rows[i][3].ToString().Trim(), "\\D"))
            //    {
            //        MessageBox.Show("Số tiền đã đóng phải là số nguyên",
            //                            "Thông báo",
            //                            MessageBoxButtons.OK);

            //        return;
            //    }
            //    else
            //    {
            //        if (Convert.ToInt32(dt.Rows[i][3].ToString().Trim()) != 0 ||
            //        Convert.ToInt32(dt.Rows[i][3].ToString().Trim()) != Convert.ToInt32(dt.Rows[i][2].ToString().Trim()))
            //        {
            //            MessageBox.Show("Số tiền đã đóng bằng 0 hoặc bằng học phí",
            //                                "Thông báo",
            //                                MessageBoxButtons.OK);

            //            return;
            //        }
            //    }
            //}

            SqlDataReader sqlDataReader = Program.ExecProcedureFee(dt, maSinhVien);

            if (sqlDataReader == null)
            {
                return;
            }
            else
            {
                sqlDataReader.Read();

                string ketQua = sqlDataReader.GetString(0);
                sqlDataReader.Close();
                if (ketQua == "GHI THANH CONG")
                {
                    MessageBox.Show("Ghi học phí thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else if (ketQua == "GHI THAT BAI")
                {
                    MessageBox.Show("Ghi học phí thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }

            XuLyGhiHocPhi(false);
        }

        private void btnThemDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRow dr = dt.NewRow();
            if(dt.Rows.Count > 0)
            {
                dr["NIENKHOA"] = dt.Rows[0][0].ToString().Trim();
            }
            dt.Rows.Add(dr);

            bds.DataSource = dt;
            gc_HOCPHI.DataSource = bds;

            demDong++;
            Console.WriteLine(demDong);

            dt.Columns[1].ReadOnly = false;

            for (int i = 0; i < demDong; i++)
            {
                dt.Rows[i][1] = i + 1;
            }

            dt.Columns[1].ReadOnly = true;
        }

        private void btnXoaDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gv_HOCPHI.DataRowCount == 0)
            {
                return;
            }

            string nienKhoa = gv_HOCPHI.GetRowCellValue(gv_HOCPHI.FocusedRowHandle, "NIENKHOA").ToString();
            string hocKy = gv_HOCPHI.GetRowCellValue(gv_HOCPHI.FocusedRowHandle, "HOCKY").ToString();

            if (nienKhoa.Trim().Equals(""))
            {
                gv_HOCPHI.DeleteRow(gv_HOCPHI.FocusedRowHandle);

                demDong--;
                Console.WriteLine(demDong);

                dt.Columns[1].ReadOnly = false;

                for (int i = 0; i < demDong; i++)
                {
                    dt.Rows[i][1] = i + 1;
                }

                dt.Columns[1].ReadOnly = true;
            }
            else
            {
                string kiemTraSuTonTaiHocPhi = "EXEC sp_KIEMTRASUTONTAIHOCPHI '" + maSinhVien + "'" 
                                                + ", " + hocKy;
                SqlDataReader sqlDataReader = Program.ExecSqlDataReader(kiemTraSuTonTaiHocPhi);

                if (sqlDataReader == null)
                {
                    return;
                }
                else
                {
                    sqlDataReader.Read();

                    string ketQua = sqlDataReader.GetString(0);
                    sqlDataReader.Close();
                    if (ketQua == "CHUA TON TAI")
                    {
                        gv_HOCPHI.DeleteRow(gv_HOCPHI.FocusedRowHandle);

                        demDong--;
                        Console.WriteLine(demDong);

                        dt.Columns[1].ReadOnly = false;

                        for (int i = 0; i < demDong; i++)
                        {
                            dt.Rows[i][1] = i + 1;
                        }

                        dt.Columns[1].ReadOnly = true;
                    }
                    else if (ketQua == "TON TAI")
                    {
                        MessageBox.Show("Không thể xóa dòng",
                                        "Thông báo",
                                        MessageBoxButtons.OK);
                        return;
                    }
                }
            }

            
            //if (!hocKy.Equals(""))
            //{
            //    MessageBox.Show("Không thể xóa dòng đang có học kỳ", 
            //        "Thông báo", 
            //        MessageBoxButtons.OK);
            //    return;
            //}

            //gv_HOCPHI.DeleteRow(gv_HOCPHI.FocusedRowHandle);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLyGhiHocPhi(false);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Program.ThoatForm(false);
            }
            else
            {
                return;
            }    
        }
    }
}
