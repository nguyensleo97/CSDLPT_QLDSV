using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace QLDSV
{
    public partial class FormLop : Form
    {
        private int vitri = 0;
        private string maKhoa = "";
        private bool danhDauMaLop = false;
        private bool danhDauTenLop = false;
        private bool danhDauMaKhoa = false;
        private string maLopCu = "";
        private string tenLopCu = "";
        private string maKhoaCu = "";
        private string maLopSua = "";
        private string tenLopSua = "";
        private string maKhoaSua = "";
        private bool ghiThem = false;
        private Stack nganXepMa = new Stack();
        private Stack nganXepGiaTri = new Stack();
        private Stack nganXepMaGhi = new Stack();
        private Stack nganXepGiaTriGhi = new Stack();

        public FormLop()
        {
            InitializeComponent();

        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            // Bỏ cơ chế kiểm tra khóa ngoại
            this.ds_CNTT.EnforceConstraints = false;


            this.LOPTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
            this.LOPTableAdapter.Fill(this.ds_CNTT.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
            this.SINHVIENTableAdapter.Fill(this.ds_CNTT.SINHVIEN);


            maKhoa = ((DataRowView)bds_LOP[0])["MAKH"].ToString();
            grpThongTin.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;

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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nganXepMa.Clear();
                nganXepMaGhi.Clear();
                nganXepGiaTri.Clear();
                nganXepGiaTriGhi.Clear();

                this.Close();
                bds_LOP.DataSource = null;
                cmbDonVi.DataSource = null;

                Program.bds_DONVI.Position = Program.donvi;
                Program.ThoatForm(true);
            }
            else
            {
                return;
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
                    MessageBox.Show(Program.tenDangNhap);
                    MessageBox.Show(Program.matKhau);
                }
                else
                {

                    Program.servername = cmbDonVi.SelectedValue.ToString();
                    Program.tenDangNhap = Program.saveTenDangNhap;
                    Program.matKhau = Program.saveMatKhau;
                    MessageBox.Show(Program.tenDangNhap);
                    MessageBox.Show(Program.matKhau);
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
                    MessageBox.Show(this.LOPTableAdapter.Connection.ConnectionString);
                    this.LOPTableAdapter.Fill(this.ds_CNTT.LOP);
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.chuoiKetNoi;
                    this.SINHVIENTableAdapter.Fill(this.ds_CNTT.SINHVIEN);
                    if (bds_LOP != null)
                    {
                        maKhoa = ((DataRowView)bds_LOP[0])["MAKH"].ToString();
                    }
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ghiThem = true;
            lblDonVi.Focus();

            nganXepMa.Push("Thêm");

            btnPhucHoi.Enabled = true;

            cmbDonVi.Enabled = false;
            grpThongTin.Enabled = true;
            vitri = bds_LOP.Position;

            bds_LOP.AddNew();
            txtMaLop.Enabled = true;
            txtMaKhoa.Text = maKhoa;
            txtMaKhoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            //btnPhucHoi.Enabled = true;

            gc_LOP.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maLopSua = txtMaLop.Text;
            tenLopSua = txtTenLop.Text;
            maKhoaSua = txtMaKhoa.Text;

            ghiThem = false;
            lblDonVi.Focus();

            nganXepMa.Push("Sửa");

            btnPhucHoi.Enabled = true;

            cmbDonVi.Enabled = false;
            grpThongTin.Enabled = true;
            vitri = bds_LOP.Position;

            txtMaLop.Enabled = false;
            txtMaKhoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;
            //btnPhucHoi.Enabled = true;

            gc_LOP.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            if (ghiThem)
            {
                nganXepMaGhi.Push("Ghi thêm");
                nganXepGiaTriGhi.Push(bds_LOP.Count - 1);
            }
            else
            {
                nganXepMaGhi.Push("Ghi sửa");
                nganXepGiaTriGhi.Push(vitri + "," + maLopSua + "," + tenLopSua + "," + maKhoaSua);
            }

            if (nganXepMa.Count > 0)
            {
                btnPhucHoi.Enabled = true;
            }

            if (txtMaLop.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã lớp không được để trống", "Thông báo", MessageBoxButtons.OK);
                lblDonVi.Focus();

                nganXepMaGhi.Pop();
                nganXepGiaTriGhi.Pop();

                return;
            }
            if (txtTenLop.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên lớp không được để trống", "Thông báo", MessageBoxButtons.OK);
                lblDonVi.Focus();

                nganXepMaGhi.Pop();
                nganXepGiaTriGhi.Pop();

                return;
            }
            if (txtMaKhoa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã khoa không được để trống", "Thông báo", MessageBoxButtons.OK);
                lblDonVi.Focus();

                nganXepMaGhi.Pop();
                nganXepGiaTriGhi.Pop();

                return;
            }
            if (txtMaLop.Text.Length > 8)
            {
                MessageBox.Show("Mã lớp không lớn hơn 8 ký tự", "Thông báo", MessageBoxButtons.OK);
                lblDonVi.Focus();

                nganXepMaGhi.Pop();
                nganXepGiaTriGhi.Pop();

                return;
            }
            if (txtMaKhoa.Text.Length > 4)
            {
                MessageBox.Show("Mã khoa không lớn hơn 4 ký tự", "Thông báo", MessageBoxButtons.OK);
                lblDonVi.Focus();

                nganXepMaGhi.Pop();
                nganXepGiaTriGhi.Pop();

                return;
            }

            if (ghiThem)
            {
                //for(int i = 0; i < gv_LOP.DataRowCount; i++)
                //{
                //    string maLopThem = txtMaLop.Text.Trim();
                //    string maLopHienTai = gv_LOP.GetRowCellValue(i, "MALOP").ToString().Trim();
                //    if (maLopThem.Equals(maLopHienTai))
                //    {
                //        MessageBox.Show("Mã lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                //        lblDonVi.Focus();

                //        nganXepMaGhi.Pop();
                //        nganXepGiaTriGhi.Pop();

                //        return;
                //    }
                //}

                //bds_LOP.EndEdit();
                //this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                //Console.WriteLine(gv_LOP.DataRowCount);
                //Console.WriteLine(bds_LOP.Count);
                //MessageBox.Show("Thêm lớp thành công", "Thông báo", MessageBoxButtons.OK);

                //Console.WriteLine(nganXepMaGhi.Count);
                //Console.WriteLine(nganXepGiaTriGhi.Count);

                //nganXepMa.Clear();
                //nganXepGiaTri.Clear();

                //btnThem.Enabled = true;
                //btnSua.Enabled = true;
                //btnXoa.Enabled = true;
                //btnThoat.Enabled = true;
                //btnGhi.Enabled = false;
                //btnPhucHoi.Enabled = true;

                //cmbDonVi.Enabled = true;
                //grpThongTin.Enabled = false;
                //gc_LOP.Enabled = true;

                //danhDauMaLop = false;
                //danhDauTenLop = false;
                //danhDauMaKhoa = false;

                string lenh = "EXEC sp_KIEMTRAMALOP " + txtMaLop.Text;
                MessageBox.Show(lenh);
                SqlDataReader sqlDataReader = Program.ExecSqlDataReader(lenh);

                if (sqlDataReader == null)
                {
                    return;
                }
                else
                {
                    sqlDataReader.Read();

                    string ketQua = sqlDataReader.GetString(0);
                    if (ketQua == "TON TAI")
                    {
                        MessageBox.Show("Mã lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        lblDonVi.Focus();

                        nganXepMaGhi.Pop();
                        nganXepGiaTriGhi.Pop();

                    }
                    else
                    {
                        try
                        {
                            bds_LOP.EndEdit();
                            this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                            Console.WriteLine(gv_LOP.DataRowCount);
                            Console.WriteLine(bds_LOP.Count);
                            MessageBox.Show("Thêm lớp thành công", "Thông báo", MessageBoxButtons.OK);
                            sqlDataReader.Close();

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
                            grpThongTin.Enabled = false;
                            gc_LOP.Enabled = true;

                            danhDauMaLop = false;
                            danhDauTenLop = false;
                            danhDauMaKhoa = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Thêm lớp thất bại\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                            lblDonVi.Focus();
                            sqlDataReader.Close();

                            nganXepMaGhi.Pop();
                            nganXepGiaTriGhi.Pop();
                        }
                    }
                }
            }
            else
            {
                //if (txtTenLop.Text.Equals(""))
                //{
                //    MessageBox.Show("Tên lớp không được để trống", "Thông báo", MessageBoxButtons.OK);
                //    lblDonVi.Focus();

                //    nganXepMaGhi.Pop();
                //    nganXepGiaTriGhi.Pop();
                //}
                //else
                //{
                bds_LOP.EndEdit();
                this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                Console.WriteLine(gv_LOP.DataRowCount);
                Console.WriteLine(bds_LOP.Count);
                MessageBox.Show("Sửa lớp thành công", "Thông báo", MessageBoxButtons.OK);

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
                grpThongTin.Enabled = false;
                gc_LOP.Enabled = true;

                danhDauMaLop = false;
                danhDauTenLop = false;
                danhDauMaKhoa = false;

            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = bds_LOP.Position;
            maLopSua = txtMaLop.Text;
            tenLopSua = txtTenLop.Text;
            maKhoaSua = txtMaKhoa.Text;


            // Kiểm tra lớp có tồn tại sinh viên chưa?
            bds_SINHVIEN.Filter = "MALOP = '" + txtMaLop.Text.Trim() + "'";
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bds_SINHVIEN.Count > 0)
                {
                    MessageBox.Show("Không thể xóa lớp có sinh viên", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        bds_LOP.RemoveCurrent();
                        bds_LOP.EndEdit();
                        this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                        Console.WriteLine(gv_LOP.DataRowCount);
                        Console.WriteLine(bds_LOP.Count);

                        nganXepMaGhi.Push("Xóa");
                        nganXepGiaTriGhi.Push(vitri + "," + maLopSua + "," + tenLopSua + "," + maKhoaSua);
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);

                        btnPhucHoi.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void txtMaLop_Clicked(object sender, EventArgs e)
        {
            danhDauMaLop = true;
            maLopCu = txtMaLop.Text;

        }

        //protected override bool ProcessDialogKey(Keys keyData)
        //{
        //    if (keyData == Keys.Tab) return false;
        //    return base.ProcessDialogKey(keyData);
        //}

        //private void txtMaLop_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.Equals(Keys.Tab))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("KeyDown: " + e.KeyCode);
        //    }

        //}

        private void txtMaLop_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                //e.Handled = true;
                //MessageBox.Show("KeyUp: " + e.KeyCode);
                danhDauMaLop = true;
                maLopCu = txtMaLop.Text;
            }

        }

        //private void txtMaLop_Tab(object sender, KeyPressEventArgs e)
        //{
        //    if(e.KeyChar == '\t')
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("Nè");
        //    }
        //}

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {
            if (danhDauMaLop)
            {
                nganXepMa.Push("Thay đổi");
                //MessageBox.Show(nganXepMa.Count.ToString());

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtMaLop," + maLopCu);
                    maLopCu = txtMaLop.Text;
                }
            }

        }

        private void txtTenLop_Clicked(object sender, EventArgs e)
        {
            danhDauTenLop = true;
            tenLopCu = txtTenLop.Text;
        }

        private void txtTenLop_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                //e.Handled = true;
                //MessageBox.Show("KeyUp: " + e.KeyCode);
                danhDauTenLop = true;
                tenLopCu = txtTenLop.Text;
            }

        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {
            if (danhDauTenLop)
            {
                nganXepMa.Push("Thay đổi");
                //MessageBox.Show(nganXepMa.Count.ToString());

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtTenLop," + tenLopCu);
                    tenLopCu = txtTenLop.Text;
                }
            }
        }

        private void txtMaKhoa_Clicked(object sender, EventArgs e)
        {
            danhDauMaKhoa = true;
            maKhoaCu = txtMaKhoa.Text;
        }

        private void txtMaKhoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                //e.Handled = true;
                //MessageBox.Show("KeyUp: " + e.KeyCode);
                danhDauMaKhoa = true;
                maKhoaCu = txtMaKhoa.Text;
            }

        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {
            if (danhDauMaKhoa)
            {
                nganXepMa.Push("Thay đổi");
                //MessageBox.Show(nganXepMa.Count.ToString());

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtMaKhoa," + maKhoaCu);
                    maKhoaCu = txtMaKhoa.Text;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bds_LOP.CancelEdit();
            Console.WriteLine(nganXepMa.Count);
            Console.WriteLine(nganXepGiaTri.Count);

            danhDauMaLop = false;
            danhDauTenLop = false;
            danhDauMaKhoa = false;

            if (nganXepMa.Count != 0)
            {
                Console.WriteLine(nganXepMa.Count);
                Console.WriteLine(nganXepGiaTri.Count);
                if (nganXepMa.Peek().Equals("Thêm"))
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThoat.Enabled = true;
                    btnGhi.Enabled = false;

                    cmbDonVi.Enabled = true;
                    grpThongTin.Enabled = false;
                    gc_LOP.Enabled = true;


                    //int viTriXoa = bds_LOP.Count - 1;
                    //Console.WriteLine(viTriXoa);
                    //bds_LOP.RemoveAt(viTriXoa);
                    //bds_LOP.EndEdit();
                    //this.LOPTableAdapter.Update(this.ds_CNTT.LOP);

                    bds_LOP.CancelEdit();
                    //bds_LOP.RemoveCurrent();
                    bds_LOP.EndEdit();
                    this.LOPTableAdapter.Update(this.ds_CNTT.LOP);

                    Console.WriteLine(vitri);
                    bds_LOP.Position = vitri;


                    Console.WriteLine(gv_LOP.DataRowCount);
                    Console.WriteLine(bds_LOP.Count);

                    nganXepMa.Clear();
                    nganXepGiaTri.Clear();


                    //Console.WriteLine(nganXepMaGhi.Count);
                    //Console.WriteLine(nganXepGiaTriGhi.Count);
                    //if (nganXepMaGhi.Count > 1)
                    //{

                    //    nganXepMaGhi.Pop();
                    //    nganXepGiaTriGhi.Pop();
                    //    Console.WriteLine(nganXepMaGhi.Count);
                    //    Console.WriteLine(nganXepGiaTriGhi.Count);
                    //}

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
                if (nganXepMa.Peek().Equals("Sửa"))
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThoat.Enabled = true;
                    btnGhi.Enabled = false;
                    btnPhucHoi.Enabled = false;

                    cmbDonVi.Enabled = true;
                    grpThongTin.Enabled = false;
                    gc_LOP.Enabled = true;

                    bds_LOP.Position = vitri;
                    bds_LOP.EndEdit();
                    this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                    Console.WriteLine(gv_LOP.DataRowCount);
                    Console.WriteLine(bds_LOP.Count);

                    nganXepMa.Clear();
                    nganXepGiaTri.Clear();

                    //Console.WriteLine(nganXepMaGhi.Count);
                    //Console.WriteLine(nganXepGiaTriGhi.Count);
                    //if (nganXepMaGhi.Count > 1)
                    //{
                    //    nganXepMaGhi.Pop();
                    //    nganXepGiaTriGhi.Pop();
                    //    Console.WriteLine(nganXepMaGhi.Count);
                    //    Console.WriteLine(nganXepGiaTriGhi.Count);
                    //}

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

                    if (giaTriThayDoi[0].Equals("txtMaLop"))
                    {
                        txtMaLop.Text = giaTriThayDoi[1];

                        // SelectionStart đặt vị trí con trỏ trong hộp văn bản
                        // SelectionLength đặt số lượng ký tự được chọn. 
                        //txtMaLop.Focus();
                        lblDonVi.Focus();
                        txtMaLop.SelectionStart = txtMaLop.TextLength;
                        txtMaLop.SelectionLength = 0;

                        //nganXepMa.Pop();
                        //nganXepGiaTri.Pop();
                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    if (giaTriThayDoi[0].Equals("txtTenLop"))
                    {
                        txtTenLop.Text = giaTriThayDoi[1];

                        //txtTenLop.Focus();
                        lblDonVi.Focus();

                        txtTenLop.SelectionStart = txtTenLop.TextLength;
                        txtTenLop.SelectionLength = 0;

                        //nganXepMa.Pop();
                        //nganXepGiaTri.Pop();
                        Console.WriteLine(nganXepMa.Count);
                        Console.WriteLine(nganXepGiaTri.Count);
                    }

                    if (giaTriThayDoi[0].Equals("txtMaKhoa"))
                    {
                        txtMaKhoa.Text = giaTriThayDoi[1];

                        //txtMaKhoa.Focus();
                        lblDonVi.Focus();
                        txtMaKhoa.SelectionStart = txtMaKhoa.TextLength;
                        txtMaKhoa.SelectionLength = 0;


                        //nganXepMa.Pop();
                        //nganXepGiaTri.Pop();
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
                if (nganXepMaGhi.Peek().Equals("Ghi thêm"))
                {
                    int viTriXoa = Convert.ToInt32(nganXepGiaTriGhi.Peek());
                    //gv_LOP.DeleteRow(viTriXoa);
                    bds_LOP.RemoveAt(viTriXoa);
                    //bds_LOP.EndEdit();

                    //gv_LOP.CloseEditForm();
                    bds_LOP.EndEdit();
                    this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                    Console.WriteLine(gv_LOP.DataRowCount);
                    Console.WriteLine(bds_LOP.Count);

                    Console.WriteLine(nganXepMaGhi.Count);
                    Console.WriteLine(nganXepGiaTriGhi.Count);

                    nganXepMaGhi.Pop();
                    nganXepGiaTriGhi.Pop();

                    if (nganXepMaGhi.Count == 0)
                    {
                        cmbDonVi.Enabled = true;
                        grpThongTin.Enabled = false;
                        gc_LOP.Enabled = true;

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
                if (nganXepMaGhi.Peek().Equals("Ghi sửa"))
                {
                    string giaTri = nganXepGiaTriGhi.Peek().ToString();
                    string[] giaTriThayDoi = giaTri.Split(',');
                    Console.WriteLine(giaTriThayDoi[0]);
                    Console.WriteLine(giaTriThayDoi[1]);
                    Console.WriteLine(giaTriThayDoi[2]);
                    Console.WriteLine(giaTriThayDoi[3]);

                    //gv_LOP.SetRowCellValue(Convert.ToInt32(giaTriThayDoi[0]), "MALOP", giaTriThayDoi[1]);
                    //gv_LOP.SetRowCellValue(Convert.ToInt32(giaTriThayDoi[0]), "TENLOP", giaTriThayDoi[2]);

                    bds_LOP.RemoveAt(Convert.ToInt32(giaTriThayDoi[0]));
                    bds_LOP.EndEdit();
                    this.LOPTableAdapter.Update(this.ds_CNTT.LOP);

                    DataRow row = ds_CNTT.LOP.NewRow();
                    row["MALOP"] = giaTriThayDoi[1];
                    row["TENLOP"] = giaTriThayDoi[2];
                    row["MAKH"] = giaTriThayDoi[3];

                    int pos = Convert.ToInt32(giaTriThayDoi[0]);
                    ds_CNTT.LOP.Rows.InsertAt(row, pos);
                    bds_LOP.DataSource = ds_CNTT.LOP;
                    bds_LOP.EndEdit();
                    this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                    //ds_CNTT.AcceptChanges();

                    bds_LOP.Position = pos;
                    //gv_LOP.FocusedRowHandle = gv_LOP.GetRowHandle(pos);
                    //bds_LOP.Position = Convert.ToInt32(giaTriThayDoi[0]);
                    txtMaLop.Text = giaTriThayDoi[1];
                    txtTenLop.Text = giaTriThayDoi[2];

                    //gv_LOP.CloseEditForm();
                    //bds_LOP.EndEdit();
                    //this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                    //this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                    Console.WriteLine(gv_LOP.DataRowCount);
                    Console.WriteLine(bds_LOP.Count);

                    Console.WriteLine(nganXepMaGhi.Count);
                    Console.WriteLine(nganXepGiaTriGhi.Count);

                    nganXepMaGhi.Pop();
                    nganXepGiaTriGhi.Pop();

                    if (nganXepMaGhi.Count == 0)
                    {
                        cmbDonVi.Enabled = true;
                        grpThongTin.Enabled = false;
                        gc_LOP.Enabled = true;

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

                    DataRow row = ds_CNTT.LOP.NewRow();
                    row["MALOP"] = giaTriThayDoi[1];
                    row["TENLOP"] = giaTriThayDoi[2];
                    row["MAKH"] = giaTriThayDoi[3];

                    int pos = Convert.ToInt32(giaTriThayDoi[0]);
                    ds_CNTT.LOP.Rows.InsertAt(row, pos);
                    bds_LOP.DataSource = ds_CNTT.LOP;
                    bds_LOP.EndEdit();
                    this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                    //ds_CNTT.AcceptChanges();

                    //gv_LOP.FocusedRowHandle = gv_LOP.GetRowHandle(pos);
                    bds_LOP.Position = pos;

                    //gv_LOP.CloseEditForm();
                    //bds_LOP.EndEdit();
                    //this.LOPTableAdapter.Update(this.ds_CNTT.LOP);
                    Console.WriteLine(gv_LOP.DataRowCount);
                    Console.WriteLine(bds_LOP.Count);

                    Console.WriteLine(nganXepMaGhi.Count);
                    Console.WriteLine(nganXepGiaTriGhi.Count);

                    nganXepMaGhi.Pop();
                    nganXepGiaTriGhi.Pop();

                    if (nganXepMaGhi.Count == 0)
                    {
                        cmbDonVi.Enabled = true;
                        grpThongTin.Enabled = false;
                        gc_LOP.Enabled = true;

                        btnPhucHoi.Enabled = false;
                        nganXepMaGhi.Clear();
                        nganXepGiaTriGhi.Clear();
                    }

                    return;
                }
            }
        }

    }
}
