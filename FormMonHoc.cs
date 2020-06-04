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
    public partial class FormMonHoc : Form
    {
        private int vitri = 0;

        private string maMonHocCu = "";
        private string tenMonHocCu = "";
        private string maMonHocSua = "";
        private string tenMonHocSua = "";

        private bool danhDauMaMonHoc = false;
        private bool danhDauTenMonHoc = false;

        private bool ghiThem = false;
        private Stack nganXepMa = new Stack();
        private Stack nganXepGiaTri = new Stack();
        private Stack nganXepMaGhi = new Stack();
        private Stack nganXepGiaTriGhi = new Stack();

        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            this.ds_CNTT.EnforceConstraints = false;

            this.MONHOCTableAdapter.Fill(this.ds_CNTT.MONHOC);
            this.DIEMTableAdapter.Fill(this.ds_CNTT.DIEM);

            grpThongTin.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Program.ThoatForm(true);
            }
            else
            {
                return;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ghiThem = true;
            
            
            nganXepMa.Push("Thêm");
            btnPhucHoi.Enabled = true;

            grpThongTin.Enabled = true;
            lblMaMonHoc.Focus();
            vitri = bds_MONHOC.Position;

            Console.WriteLine(bds_MONHOC.Count);
            bds_MONHOC.AddNew();
            Console.WriteLine(bds_MONHOC.Count);

            // Khi vào sửa thì txt này sẽ mờ và khi vào lại để thêm thì txt m=này phải sáng lên
            txtMaMonHoc.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;

            gc_MONHOC.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maMonHocSua = txtMaMonHoc.Text;
            tenMonHocSua = txtTenMonHoc.Text;

            ghiThem = false;
            
            nganXepMa.Push("Sửa");
            btnPhucHoi.Enabled = true;

            grpThongTin.Enabled = true;
            lblTenMonHoc.Focus();
            vitri = bds_MONHOC.Position;

            txtMaMonHoc.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true;

            gc_MONHOC.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ghiThem)
            {
                nganXepMaGhi.Push("Ghi thêm");
                nganXepGiaTriGhi.Push(bds_MONHOC.Count - 1);
            }
            else
            {
                nganXepMaGhi.Push("Ghi sửa");
                nganXepGiaTriGhi.Push(vitri + "," + maMonHocSua + "," + tenMonHocSua);
            }

            if (txtMaMonHoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã môn học không được để trống", "Thông báo", MessageBoxButtons.OK);
                lblMaMonHoc.Focus();

                nganXepMaGhi.Pop();
                nganXepGiaTriGhi.Pop();

                return;
            }

            if (txtTenMonHoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên môn học không được để trống", "Thông báo", MessageBoxButtons.OK);
                lblTenMonHoc.Focus();

                nganXepMaGhi.Pop();
                nganXepGiaTriGhi.Pop();

                return;
            }

            if (txtMaMonHoc.Text.Length > 6)
            {
                MessageBox.Show("Mã môn học không lớn hơn 6 ký tự", "Thông báo", MessageBoxButtons.OK);
                lblMaMonHoc.Focus();

                nganXepMaGhi.Pop();
                nganXepGiaTriGhi.Pop();

                return;
            }

            if (ghiThem)
            {
                Console.WriteLine(Program.chuoiKetNoi);
                string lenh = "EXEC sp_KIEMTRAMAMONHOC '" + txtMaMonHoc.Text + "'";
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
                        MessageBox.Show("Mã môn học đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        lblMaMonHoc.Focus();

                        nganXepMaGhi.Pop();
                        nganXepGiaTriGhi.Pop();

                    }
                    else
                    {
                        try
                        {
                            bds_MONHOC.EndEdit();
                            this.MONHOCTableAdapter.Update(this.ds_CNTT.MONHOC);
                            MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK);
                            sqlDataReader.Close();

                            nganXepMa.Clear();
                            nganXepGiaTri.Clear();

                            btnThem.Enabled = true;
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            btnThoat.Enabled = true;
                            btnGhi.Enabled = false;
                            btnPhucHoi.Enabled = true;

                            grpThongTin.Enabled = false;
                            gc_MONHOC.Enabled = true;

                            danhDauMaMonHoc = false;
                            danhDauTenMonHoc = false;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Thêm môn học thất bại\n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                            lblMaMonHoc.Focus();
                            sqlDataReader.Close();

                            nganXepMaGhi.Pop();
                            nganXepGiaTriGhi.Pop();
                        }
                    }
                }
            }
            else
            {
                bds_MONHOC.EndEdit();
                this.MONHOCTableAdapter.Update(this.ds_CNTT.MONHOC);
                MessageBox.Show("Sửa môn học thành công", "Thông báo", MessageBoxButtons.OK);

                nganXepMa.Clear();
                nganXepGiaTri.Clear();

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThoat.Enabled = true;
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = true;

                grpThongTin.Enabled = false;
                gc_MONHOC.Enabled = true;

                danhDauMaMonHoc = false;
                danhDauTenMonHoc = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = bds_MONHOC.Position;
            maMonHocSua = txtMaMonHoc.Text;
            tenMonHocSua = txtTenMonHoc.Text;

            bds_DIEM.Filter = "MAMH = '" + txtMaMonHoc.Text.Trim() + "'";
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bds_DIEM.Count > 0)
                {
                    MessageBox.Show("Không thể xóa môn học có điểm", "Thông báo", MessageBoxButtons.OK);

                    return;
                }
                else
                {
                    try
                    {
                        bds_MONHOC.RemoveCurrent();
                        bds_MONHOC.EndEdit();
                        this.MONHOCTableAdapter.Update(this.ds_CNTT.MONHOC);

                        nganXepMaGhi.Push("Xóa");
                        nganXepGiaTriGhi.Push(vitri + "," + maMonHocSua + "," + tenMonHocSua);
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

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            danhDauMaMonHoc = false;
            danhDauTenMonHoc = false;

            if (nganXepMa.Count != 0)
            {
                if (nganXepMa.Peek().Equals("Thêm"))
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThoat.Enabled = true;
                    btnGhi.Enabled = false;

                    grpThongTin.Enabled = false;
                    gc_MONHOC.Enabled = true;

                    Console.WriteLine(bds_MONHOC.Count);
                    bds_MONHOC.CancelEdit();
                    bds_MONHOC.EndEdit();
                    Console.WriteLine(bds_MONHOC.Count);
                    bds_MONHOC.Position = vitri;

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
                if (nganXepMa.Peek().Equals("Sửa"))
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThoat.Enabled = true;
                    btnGhi.Enabled = false;
                    btnPhucHoi.Enabled = false;

                    grpThongTin.Enabled = false;
                    gc_MONHOC.Enabled = true;

                    bds_MONHOC.Position = vitri;
                    bds_MONHOC.CancelEdit();
                    bds_MONHOC.EndEdit();
                    //this.MONHOCTableAdapter.Update(this.ds_CNTT.MONHOC);

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
                if(nganXepMa.Peek().Equals("Thay đổi"))
                {
                    string giaTri = nganXepGiaTri.Peek().ToString();
                    string[] giaTriThayDoi = giaTri.Split(',');

                    if (giaTriThayDoi[0].Equals("txtMaMonHoc"))
                    {
                        txtMaMonHoc.Text = giaTriThayDoi[1];

                        lblMaMonHoc.Focus();
                        txtMaMonHoc.SelectionStart = txtMaMonHoc.TextLength;
                        txtMaMonHoc.SelectionLength = 0;
                    }

                    if (giaTriThayDoi[0].Equals("txtTenMonHoc"))
                    {
                        txtTenMonHoc.Text = giaTriThayDoi[1];

                        lblTenMonHoc.Focus();
                        txtTenMonHoc.SelectionStart = txtTenMonHoc.TextLength;
                        txtTenMonHoc.SelectionLength = 0;
                    }

                    nganXepMa.Pop();
                    nganXepGiaTri.Pop();
                }
            }

            if (nganXepMaGhi.Count != 0 && nganXepMa.Count == 0)
            {
                if (nganXepMaGhi.Peek().Equals("Ghi thêm"))
                {
                    int viTriXoa = Convert.ToInt32(nganXepGiaTriGhi.Peek());
                    bds_MONHOC.RemoveAt(viTriXoa);
                    bds_MONHOC.EndEdit();
                    this.MONHOCTableAdapter.Update(this.ds_CNTT.MONHOC);

                    nganXepMaGhi.Pop();
                    nganXepGiaTriGhi.Pop();

                    if (nganXepMaGhi.Count == 0)
                    {
                        grpThongTin.Enabled = false;
                        gc_MONHOC.Enabled = true;

                        btnPhucHoi.Enabled = false;
                        nganXepMaGhi.Clear();
                        nganXepGiaTriGhi.Clear();
                    }

                    return;
                }

                if (nganXepMaGhi.Peek().Equals("Ghi sửa"))
                {
                    string giaTri = nganXepGiaTriGhi.Peek().ToString();
                    string[] giaTriThayDoi = giaTri.Split(',');

                    bds_MONHOC.RemoveAt(Convert.ToInt32(giaTriThayDoi[0]));
                    bds_MONHOC.EndEdit();
                    this.MONHOCTableAdapter.Update(this.ds_CNTT.MONHOC);

                    DataRow row = ds_CNTT.MONHOC.NewRow();
                    row["MAMH"] = giaTriThayDoi[1];
                    row["TENMH"] = giaTriThayDoi[2];

                    int pos = Convert.ToInt32(giaTriThayDoi[0]);

                    ds_CNTT.MONHOC.Rows.InsertAt(row, pos);
                    bds_MONHOC.DataSource = ds_CNTT.MONHOC;
                    bds_MONHOC.EndEdit();
                    this.MONHOCTableAdapter.Update(this.ds_CNTT.MONHOC);

                    bds_MONHOC.Position = pos;

                    txtMaMonHoc.Text = giaTriThayDoi[1];
                    txtTenMonHoc.Text = giaTriThayDoi[2];

                    nganXepMaGhi.Pop();
                    nganXepGiaTriGhi.Pop();

                    if (nganXepMaGhi.Count == 0)
                    {
                        grpThongTin.Enabled = false;
                        gc_MONHOC.Enabled = true;

                        btnPhucHoi.Enabled = false;
                        nganXepMaGhi.Clear();
                        nganXepGiaTriGhi.Clear();
                    }

                    return;
                }

                if (nganXepMaGhi.Peek().Equals("Xóa"))
                {
                    string giaTri = nganXepGiaTriGhi.Peek().ToString();
                    string[] giaTriThayDoi = giaTri.Split(',');

                    DataRow row = ds_CNTT.MONHOC.NewRow();
                    row["MAMH"] = giaTriThayDoi[1];
                    row["TENMH"] = giaTriThayDoi[2];

                    int pos = Convert.ToInt32(giaTriThayDoi[0]);

                    ds_CNTT.MONHOC.Rows.InsertAt(row, pos);
                    bds_MONHOC.DataSource = ds_CNTT.MONHOC;
                    bds_MONHOC.EndEdit();
                    this.MONHOCTableAdapter.Update(this.ds_CNTT.MONHOC);

                    bds_MONHOC.Position = pos;

                    nganXepMaGhi.Pop();
                    nganXepGiaTriGhi.Pop();

                    if (nganXepMaGhi.Count == 0)
                    {
                        grpThongTin.Enabled = false;
                        gc_MONHOC.Enabled = true;

                        btnPhucHoi.Enabled = false;
                        nganXepMaGhi.Clear();
                        nganXepGiaTriGhi.Clear();
                    }

                    return;
                }
            }
        }

        private void txtMaMonHoc_Clicked(object sender, EventArgs e)
        {
            danhDauMaMonHoc = true;
            maMonHocCu = txtMaMonHoc.Text;
        }

        private void txtMaMonHoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauMaMonHoc = true;
                maMonHocCu = txtMaMonHoc.Text;
            }

        }

        private void txtMaMonHoc_TextChanged(object sender, EventArgs e)
        {
            if (danhDauMaMonHoc)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtMaMonHoc," + maMonHocCu);
                    maMonHocCu = txtMaMonHoc.Text;
                }
            }
        }

        private void txtTenMonHoc_Clicked(object sender, EventArgs e)
        {
            danhDauTenMonHoc = true;
            tenMonHocCu = txtTenMonHoc.Text;
        }

        private void txtTenMonHoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                danhDauTenMonHoc = true;
                tenMonHocCu = txtTenMonHoc.Text;
            }

        }

        private void txtTenMonHoc_TextChanged(object sender, EventArgs e)
        {
            if (danhDauTenMonHoc)
            {
                nganXepMa.Push("Thay đổi");

                if (nganXepMa.Count > 0)
                {
                    nganXepGiaTri.Push("txtTenMonHoc," + tenMonHocCu);
                    tenMonHocCu = txtTenMonHoc.Text;
                }
            }
        }
    }
}
