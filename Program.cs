using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace QLDSV
{
    static class Program
    {
        public static SqlConnection ketNoi = new SqlConnection();
        public static string chuoiKetNoi = "";
        public static string database = "QLDSV";

        public static string servername = "";
        public static string tenDangNhap = "";
        public static string matKhau = "";
        public static string hoten = "";
        public static string nhom = "";

        public static int donvi = 0;
        public static string saveTenDangNhap = "";
        public static string saveMatKhau = "";
        public static BindingSource bds_DONVI = new BindingSource();

        public static string remoteTenDangNhap = "HTKN";
        public static string remoteMatKhau = "123";

        public static FormManHinhChinh frmManHinhChinh;

        public static bool KetNoi()
        {
            if (ketNoi != null && ketNoi.State == ConnectionState.Open)
            {
                ketNoi.Close();
            }

            try
            {
                chuoiKetNoi = "Data Source=" + servername
                            + ";Initial Catalog=" + database
                            + ";User ID=" + tenDangNhap
                            + ";Password=" + matKhau;
                ketNoi.ConnectionString = chuoiKetNoi;
                ketNoi.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu\n\n" + e.Message, "Thông báo", MessageBoxButtons.OK);
                return false;
            }
        }

        public static void LamMoi()
        {
            bds_DONVI.RemoveFilter();

            donvi = 0;
            saveTenDangNhap = "";
            saveMatKhau = "";
            hoten = "";
            nhom = "";

            tenDangNhap = "";
            matKhau = "";
            chuoiKetNoi = "";

            foreach (Form f in frmManHinhChinh.MdiChildren)
            {
                f.Close();
                f.Dispose();
            }

            frmManHinhChinh.MoDangNhap();
            frmManHinhChinh.KhoiPhucHienThi();
            frmManHinhChinh.XuLyThoat();
        }

        public static void ThoatForm(bool loai)
        {
            frmManHinhChinh.KhoiPhucTrangHienTai(loai);
        }

        public static void ThoatFormBaoCao()
        {
            frmManHinhChinh.KhoiPhucTrangBaoCaoHienTai();
        }

        public static SqlDataReader ExecSqlDataReader(string lenh)
        {
            if (ketNoi.State == ConnectionState.Closed)
            {
                ketNoi.Open();
            }

            SqlCommand sqlCommand = new SqlCommand(lenh, ketNoi);
            sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandTimeout = 600;

            SqlDataReader sqlDataReader;

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                return sqlDataReader;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ketNoi.Close();
                return null;
            }
        }

        public static SqlDataReader ExecProcedureScore(DataTable dt, string maMonHoc, int lanThi)
        {
            if (ketNoi.State == ConnectionState.Closed)
            {
                ketNoi.Open();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string giatri = dt.Rows[i][j].ToString();
                    Console.WriteLine(giatri);
                }
            }

            SqlCommand sqlCommand = ketNoi.CreateCommand();
            sqlCommand.CommandText = "sp_GHIDIEM";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@thongtindiem";
            parameter.Value = dt;
            parameter.SqlDbType = SqlDbType.Structured;
            parameter.TypeName = "dbo.DiemTableType";

            sqlCommand.Parameters.Add(parameter);
            sqlCommand.Parameters.AddWithValue("@mamonhoc", maMonHoc);
            sqlCommand.Parameters.AddWithValue("@lanthi", lanThi);

            SqlDataReader sqlDataReader;

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                return sqlDataReader;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ketNoi.Close();
                return null;
            }
        }

        public static SqlDataReader ExecProcedureFee(DataTable dt, string maSinhVien)
        {
            if (ketNoi.State == ConnectionState.Closed)
            {
                ketNoi.Open();
            }


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string giatri = dt.Rows[i][j].ToString();
                }
            }

            SqlCommand sqlCommand = ketNoi.CreateCommand();
            sqlCommand.CommandText = "sp_GHIHOCPHI";
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@thongtinhocphi";
            parameter.Value = dt;
            parameter.SqlDbType = SqlDbType.Structured;
            parameter.TypeName = "dbo.HocPhiTableType";

            sqlCommand.Parameters.Add(parameter);
            sqlCommand.Parameters.AddWithValue("@masinhvien", maSinhVien);

            SqlDataReader sqlDataReader;

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                return sqlDataReader;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ketNoi.Close();
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(string lenh)
        {
            DataTable dataTable = new DataTable();
            if(ketNoi.State == ConnectionState.Closed)
            {
                ketNoi.Open();
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(lenh, ketNoi);
            sqlDataAdapter.Fill(dataTable);

            ketNoi.Close();
            return dataTable;
        }

        public static SqlDataReader TaoTaiKhoan(string lenh, string tenDangNhap, TextBox txtTenDangNhap)
        {
            if (ketNoi.State == ConnectionState.Closed)
            {
                ketNoi.Open();
            }

            SqlCommand sqlCommand = new SqlCommand(lenh, ketNoi);
            sqlCommand.CommandType = CommandType.Text;

            SqlDataReader sqlDataReader;

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                return sqlDataReader;
            }
            catch (Exception e)
            {
                MessageBox.Show("Tên đăng nhập " + tenDangNhap + " đã tồn tại\n\n" + e.Message, "Thông báo", MessageBoxButtons.OK);

                txtTenDangNhap.Focus();
                txtTenDangNhap.SelectionStart = 0;
                txtTenDangNhap.SelectionLength = txtTenDangNhap.Text.Length;

                ketNoi.Close();
                return null;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmManHinhChinh = new FormManHinhChinh();
            Application.Run(frmManHinhChinh);
        }
    }
}
