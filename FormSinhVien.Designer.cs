namespace QLDSV
{
    partial class FormSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblMaSV;
            System.Windows.Forms.Label lblHo;
            System.Windows.Forms.Label lblTen;
            System.Windows.Forms.Label lblPhai;
            System.Windows.Forms.Label lblNgaySinh;
            System.Windows.Forms.Label lblNoiSinh;
            System.Windows.Forms.Label lblDiaChi;
            System.Windows.Forms.Label lblGhiChu;
            System.Windows.Forms.Label lblNghiHoc;
            System.Windows.Forms.Label lblMaLop;
            System.Windows.Forms.Label lblLop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSinhVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThemDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.bds_LOP = new System.Windows.Forms.BindingSource(this.components);
            this.ds_CNTT = new QLDSV.DS_CNTT();
            this.cmbDonVi = new System.Windows.Forms.ComboBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.bds_SINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.SINHVIENTableAdapter = new QLDSV.DS_CNTTTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_CNTTTableAdapters.TableAdapterManager();
            this.gc_SINHVIEN = new DevExpress.XtraGrid.GridControl();
            this.gv_SINHVIEN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.chkNghiHoc = new DevExpress.XtraEditors.CheckEdit();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.datNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.chkPhai = new DevExpress.XtraEditors.CheckEdit();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.gc_SINHVIENTHEM = new DevExpress.XtraGrid.GridControl();
            this.gv_SINHVIENTHEM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASVTHEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASVTHEM_EDIT = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colHOTHEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTHEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAITHEM = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINHTHEM = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colNOISINHTHEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHITHEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHUTHEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIHOCTHEM = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMALOPTHEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOPTableAdapter = new QLDSV.DS_CNTTTableAdapters.LOPTableAdapter();
            this.bds_DIEM = new System.Windows.Forms.BindingSource(this.components);
            this.DIEMTableAdapter = new QLDSV.DS_CNTTTableAdapters.DIEMTableAdapter();
            lblMaSV = new System.Windows.Forms.Label();
            lblHo = new System.Windows.Forms.Label();
            lblTen = new System.Windows.Forms.Label();
            lblPhai = new System.Windows.Forms.Label();
            lblNgaySinh = new System.Windows.Forms.Label();
            lblNoiSinh = new System.Windows.Forms.Label();
            lblDiaChi = new System.Windows.Forms.Label();
            lblGhiChu = new System.Windows.Forms.Label();
            lblNghiHoc = new System.Windows.Forms.Label();
            lblMaLop = new System.Windows.Forms.Label();
            lblLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CNTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SINHVIEN)).BeginInit();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNghiHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SINHVIENTHEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SINHVIENTHEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMASVTHEM_EDIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colPHAITHEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNGAYSINHTHEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNGAYSINHTHEM.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNGHIHOCTHEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DIEM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new System.Drawing.Point(22, 22);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new System.Drawing.Size(56, 19);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã SV:";
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new System.Drawing.Point(316, 22);
            lblHo.Name = "lblHo";
            lblHo.Size = new System.Drawing.Size(31, 19);
            lblHo.TabIndex = 2;
            lblHo.Text = "Họ:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new System.Drawing.Point(745, 22);
            lblTen.Name = "lblTen";
            lblTen.Size = new System.Drawing.Size(35, 19);
            lblTen.TabIndex = 4;
            lblTen.Text = "Tên:";
            // 
            // lblPhai
            // 
            lblPhai.AutoSize = true;
            lblPhai.Location = new System.Drawing.Point(22, 76);
            lblPhai.Name = "lblPhai";
            lblPhai.Size = new System.Drawing.Size(38, 19);
            lblPhai.TabIndex = 6;
            lblPhai.Text = "Phái:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new System.Drawing.Point(275, 76);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new System.Drawing.Size(72, 19);
            lblNgaySinh.TabIndex = 8;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblNoiSinh
            // 
            lblNoiSinh.AutoSize = true;
            lblNoiSinh.Location = new System.Drawing.Point(718, 77);
            lblNoiSinh.Name = "lblNoiSinh";
            lblNoiSinh.Size = new System.Drawing.Size(62, 19);
            lblNoiSinh.TabIndex = 10;
            lblNoiSinh.Text = "Nơi sinh:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new System.Drawing.Point(22, 134);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new System.Drawing.Size(54, 19);
            lblDiaChi.TabIndex = 12;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new System.Drawing.Point(450, 130);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new System.Drawing.Size(58, 19);
            lblGhiChu.TabIndex = 14;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // lblNghiHoc
            // 
            lblNghiHoc.AutoSize = true;
            lblNghiHoc.Location = new System.Drawing.Point(713, 134);
            lblNghiHoc.Name = "lblNghiHoc";
            lblNghiHoc.Size = new System.Drawing.Size(67, 19);
            lblNghiHoc.TabIndex = 16;
            lblNghiHoc.Text = "Nghỉ học:";
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new System.Drawing.Point(877, 134);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new System.Drawing.Size(56, 19);
            lblMaLop.TabIndex = 18;
            lblMaLop.Text = "Mã lớp:";
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new System.Drawing.Point(623, 21);
            lblLop.Name = "lblLop";
            lblLop.Size = new System.Drawing.Size(37, 19);
            lblLop.TabIndex = 2;
            lblLop.Text = "Lớp:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnThoat,
            this.btnThemDong,
            this.btnXoaDong,
            this.btnHoanTat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnThemDong
            // 
            this.btnThemDong.Caption = "Thêm dòng";
            this.btnThemDong.Id = 6;
            this.btnThemDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDong.ImageOptions.Image")));
            this.btnThemDong.Name = "btnThemDong";
            this.btnThemDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemDong_ItemClick);
            // 
            // btnXoaDong
            // 
            this.btnXoaDong.Caption = "Xóa dòng";
            this.btnXoaDong.Id = 7;
            this.btnXoaDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDong.ImageOptions.Image")));
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaDong_ItemClick);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Caption = "Hoàn tất";
            this.btnHoanTat.Id = 8;
            this.btnHoanTat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTat.ImageOptions.Image")));
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoanTat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1200, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 631);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1200, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 578);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1200, 53);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 578);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(lblLop);
            this.panel1.Controls.Add(this.cmbLop);
            this.panel1.Controls.Add(this.cmbDonVi);
            this.panel1.Controls.Add(this.lblDonVi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 56);
            this.panel1.TabIndex = 4;
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.bds_LOP;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(687, 13);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(472, 27);
            this.cmbLop.TabIndex = 3;
            this.cmbLop.ValueMember = "MALOP";
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // bds_LOP
            // 
            this.bds_LOP.DataMember = "LOP";
            this.bds_LOP.DataSource = this.ds_CNTT;
            // 
            // ds_CNTT
            // 
            this.ds_CNTT.DataSetName = "DS_CNTT";
            this.ds_CNTT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonVi.FormattingEnabled = true;
            this.cmbDonVi.Location = new System.Drawing.Point(129, 13);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Size = new System.Drawing.Size(411, 27);
            this.cmbDonVi.TabIndex = 1;
            this.cmbDonVi.SelectedIndexChanged += new System.EventHandler(this.cmbDonVi_SelectedIndexChanged);
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(45, 21);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(52, 19);
            this.lblDonVi.TabIndex = 0;
            this.lblDonVi.Text = "Đơn vị:";
            // 
            // bds_SINHVIEN
            // 
            this.bds_SINHVIEN.DataMember = "SINHVIEN";
            this.bds_SINHVIEN.DataSource = this.ds_CNTT;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.SINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_CNTTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gc_SINHVIEN
            // 
            this.gc_SINHVIEN.DataMember = null;
            this.gc_SINHVIEN.DataSource = this.bds_SINHVIEN;
            this.gc_SINHVIEN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_SINHVIEN.Location = new System.Drawing.Point(0, 109);
            this.gc_SINHVIEN.MainView = this.gv_SINHVIEN;
            this.gc_SINHVIEN.MenuManager = this.barManager1;
            this.gc_SINHVIEN.Name = "gc_SINHVIEN";
            this.gc_SINHVIEN.Size = new System.Drawing.Size(1200, 117);
            this.gc_SINHVIEN.TabIndex = 6;
            this.gc_SINHVIEN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SINHVIEN});
            // 
            // gv_SINHVIEN
            // 
            this.gv_SINHVIEN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colMALOP,
            this.colPHAI,
            this.colNGAYSINH,
            this.colNOISINH,
            this.colDIACHI,
            this.colGHICHU,
            this.colNGHIHOC});
            this.gv_SINHVIEN.GridControl = this.gc_SINHVIEN;
            this.gv_SINHVIEN.Name = "gv_SINHVIEN";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colNOISINH
            // 
            this.colNOISINH.Caption = "Nơi sinh";
            this.colNOISINH.FieldName = "NOISINH";
            this.colNOISINH.Name = "colNOISINH";
            this.colNOISINH.OptionsColumn.AllowEdit = false;
            this.colNOISINH.Visible = true;
            this.colNOISINH.VisibleIndex = 6;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 7;
            // 
            // colGHICHU
            // 
            this.colGHICHU.Caption = "Ghi chú";
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.OptionsColumn.AllowEdit = false;
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 8;
            // 
            // colNGHIHOC
            // 
            this.colNGHIHOC.Caption = "Nghỉ học";
            this.colNGHIHOC.FieldName = "NGHIHOC";
            this.colNGHIHOC.Name = "colNGHIHOC";
            this.colNGHIHOC.OptionsColumn.AllowEdit = false;
            this.colNGHIHOC.Visible = true;
            this.colNGHIHOC.VisibleIndex = 9;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(lblMaLop);
            this.grpThongTin.Controls.Add(this.txtMaLop);
            this.grpThongTin.Controls.Add(lblNghiHoc);
            this.grpThongTin.Controls.Add(this.chkNghiHoc);
            this.grpThongTin.Controls.Add(lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Controls.Add(lblDiaChi);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(lblNoiSinh);
            this.grpThongTin.Controls.Add(this.txtNoiSinh);
            this.grpThongTin.Controls.Add(lblNgaySinh);
            this.grpThongTin.Controls.Add(this.datNgaySinh);
            this.grpThongTin.Controls.Add(lblPhai);
            this.grpThongTin.Controls.Add(this.chkPhai);
            this.grpThongTin.Controls.Add(lblTen);
            this.grpThongTin.Controls.Add(this.txtTen);
            this.grpThongTin.Controls.Add(lblHo);
            this.grpThongTin.Controls.Add(this.txtHo);
            this.grpThongTin.Controls.Add(lblMaSV);
            this.grpThongTin.Controls.Add(this.txtMaSV);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Location = new System.Drawing.Point(0, 226);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1200, 167);
            this.grpThongTin.TabIndex = 7;
            this.grpThongTin.TabStop = false;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_SINHVIEN, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(949, 127);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(210, 26);
            this.txtMaLop.TabIndex = 19;
            // 
            // chkNghiHoc
            // 
            this.chkNghiHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_SINHVIEN, "NGHIHOC", true));
            this.chkNghiHoc.Location = new System.Drawing.Point(796, 134);
            this.chkNghiHoc.MenuManager = this.barManager1;
            this.chkNghiHoc.Name = "chkNghiHoc";
            this.chkNghiHoc.Properties.Caption = "Nghỉ";
            this.chkNghiHoc.Size = new System.Drawing.Size(75, 19);
            this.chkNghiHoc.TabIndex = 17;
            this.chkNghiHoc.TextChanged += new System.EventHandler(this.chkNghiHoc_TextChanged);
            this.chkNghiHoc.Click += new System.EventHandler(this.chkNghiHoc_Clicked);
            this.chkNghiHoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkNghiHoc_KeyUp);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_SINHVIEN, "GHICHU", true));
            this.txtGhiChu.Location = new System.Drawing.Point(514, 127);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(185, 26);
            this.txtGhiChu.TabIndex = 15;
            this.txtGhiChu.Click += new System.EventHandler(this.txtGhiChu_Clicked);
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            this.txtGhiChu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGhiChu_KeyUp);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_SINHVIEN, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(102, 127);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(316, 26);
            this.txtDiaChi.TabIndex = 13;
            this.txtDiaChi.Click += new System.EventHandler(this.txtDiaChi_Clicked);
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            this.txtDiaChi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiaChi_KeyUp);
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_SINHVIEN, "NOISINH", true));
            this.txtNoiSinh.Location = new System.Drawing.Point(796, 69);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(363, 26);
            this.txtNoiSinh.TabIndex = 11;
            this.txtNoiSinh.Click += new System.EventHandler(this.txtNoiSinh_Clicked);
            this.txtNoiSinh.TextChanged += new System.EventHandler(this.txtNoiSinh_TextChanged);
            this.txtNoiSinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNoiSinh_KeyUp);
            // 
            // datNgaySinh
            // 
            this.datNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_SINHVIEN, "NGAYSINH", true));
            this.datNgaySinh.EditValue = null;
            this.datNgaySinh.Location = new System.Drawing.Point(353, 76);
            this.datNgaySinh.MenuManager = this.barManager1;
            this.datNgaySinh.Name = "datNgaySinh";
            this.datNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datNgaySinh.Size = new System.Drawing.Size(295, 20);
            this.datNgaySinh.TabIndex = 9;
            this.datNgaySinh.TextChanged += new System.EventHandler(this.datNgaySinh_TextChanged);
            this.datNgaySinh.Click += new System.EventHandler(this.datNgaySinh_Clicked);
            this.datNgaySinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.datNgaySinh_KeyUp);
            // 
            // chkPhai
            // 
            this.chkPhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_SINHVIEN, "PHAI", true));
            this.chkPhai.Location = new System.Drawing.Point(102, 77);
            this.chkPhai.MenuManager = this.barManager1;
            this.chkPhai.Name = "chkPhai";
            this.chkPhai.Properties.Caption = "Nam";
            this.chkPhai.Size = new System.Drawing.Size(75, 19);
            this.chkPhai.TabIndex = 7;
            this.chkPhai.TextChanged += new System.EventHandler(this.chkPhai_TextChanged);
            this.chkPhai.Click += new System.EventHandler(this.chkPhai_Clicked);
            this.chkPhai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkPhai_KeyUp);
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_SINHVIEN, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(796, 15);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(363, 26);
            this.txtTen.TabIndex = 5;
            this.txtTen.Click += new System.EventHandler(this.txtTen_Clicked);
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            this.txtTen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTen_KeyUp);
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_SINHVIEN, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(353, 15);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(373, 26);
            this.txtHo.TabIndex = 3;
            this.txtHo.Click += new System.EventHandler(this.txtHo_Clicked);
            this.txtHo.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            this.txtHo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHo_KeyUp);
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_SINHVIEN, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(102, 15);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(194, 26);
            this.txtMaSV.TabIndex = 1;
            // 
            // gc_SINHVIENTHEM
            // 
            this.gc_SINHVIENTHEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SINHVIENTHEM.Location = new System.Drawing.Point(0, 393);
            this.gc_SINHVIENTHEM.MainView = this.gv_SINHVIENTHEM;
            this.gc_SINHVIENTHEM.MenuManager = this.barManager1;
            this.gc_SINHVIENTHEM.Name = "gc_SINHVIENTHEM";
            this.gc_SINHVIENTHEM.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colPHAITHEM,
            this.colNGAYSINHTHEM,
            this.colNGHIHOCTHEM,
            this.colMASVTHEM_EDIT});
            this.gc_SINHVIENTHEM.Size = new System.Drawing.Size(1200, 238);
            this.gc_SINHVIENTHEM.TabIndex = 8;
            this.gc_SINHVIENTHEM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SINHVIENTHEM});
            // 
            // gv_SINHVIENTHEM
            // 
            this.gv_SINHVIENTHEM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASVTHEM,
            this.colHOTHEM,
            this.colTENTHEM,
            this.gridColumn1,
            this.gridColumn2,
            this.colNOISINHTHEM,
            this.colDIACHITHEM,
            this.colGHICHUTHEM,
            this.gridColumn3,
            this.colMALOPTHEM});
            this.gv_SINHVIENTHEM.GridControl = this.gc_SINHVIENTHEM;
            this.gv_SINHVIENTHEM.Name = "gv_SINHVIENTHEM";
            this.gv_SINHVIENTHEM.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_SINHVIENTHEM_CellValueChanging);
            this.gv_SINHVIENTHEM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gv_SINHVIENTHEM_KeyUp);
            // 
            // colMASVTHEM
            // 
            this.colMASVTHEM.Caption = "Mã SV";
            this.colMASVTHEM.ColumnEdit = this.colMASVTHEM_EDIT;
            this.colMASVTHEM.FieldName = "MASVTHEM";
            this.colMASVTHEM.Name = "colMASVTHEM";
            this.colMASVTHEM.Visible = true;
            this.colMASVTHEM.VisibleIndex = 0;
            // 
            // colMASVTHEM_EDIT
            // 
            this.colMASVTHEM_EDIT.AutoHeight = false;
            this.colMASVTHEM_EDIT.Name = "colMASVTHEM_EDIT";
            // 
            // colHOTHEM
            // 
            this.colHOTHEM.Caption = "Họ";
            this.colHOTHEM.FieldName = "HOTHEM";
            this.colHOTHEM.Name = "colHOTHEM";
            this.colHOTHEM.Visible = true;
            this.colHOTHEM.VisibleIndex = 1;
            // 
            // colTENTHEM
            // 
            this.colTENTHEM.Caption = "Tên";
            this.colTENTHEM.FieldName = "TENTHEM";
            this.colTENTHEM.Name = "colTENTHEM";
            this.colTENTHEM.Visible = true;
            this.colTENTHEM.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Phái";
            this.gridColumn1.ColumnEdit = this.colPHAITHEM;
            this.gridColumn1.FieldName = "PHAITHEM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // colPHAITHEM
            // 
            this.colPHAITHEM.AutoHeight = false;
            this.colPHAITHEM.Name = "colPHAITHEM";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày sinh";
            this.gridColumn2.ColumnEdit = this.colNGAYSINHTHEM;
            this.gridColumn2.FieldName = "NGAYSINHTHEM";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // colNGAYSINHTHEM
            // 
            this.colNGAYSINHTHEM.AutoHeight = false;
            this.colNGAYSINHTHEM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colNGAYSINHTHEM.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colNGAYSINHTHEM.Name = "colNGAYSINHTHEM";
            // 
            // colNOISINHTHEM
            // 
            this.colNOISINHTHEM.Caption = "Nơi sinh";
            this.colNOISINHTHEM.FieldName = "NOISINHTHEM";
            this.colNOISINHTHEM.Name = "colNOISINHTHEM";
            this.colNOISINHTHEM.Visible = true;
            this.colNOISINHTHEM.VisibleIndex = 5;
            // 
            // colDIACHITHEM
            // 
            this.colDIACHITHEM.Caption = "Địa chỉ";
            this.colDIACHITHEM.FieldName = "DIACHITHEM";
            this.colDIACHITHEM.Name = "colDIACHITHEM";
            this.colDIACHITHEM.Visible = true;
            this.colDIACHITHEM.VisibleIndex = 6;
            // 
            // colGHICHUTHEM
            // 
            this.colGHICHUTHEM.Caption = "Ghi chú";
            this.colGHICHUTHEM.FieldName = "GHICHUTHEM";
            this.colGHICHUTHEM.Name = "colGHICHUTHEM";
            this.colGHICHUTHEM.Visible = true;
            this.colGHICHUTHEM.VisibleIndex = 7;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nghỉ học";
            this.gridColumn3.ColumnEdit = this.colNGHIHOCTHEM;
            this.gridColumn3.FieldName = "NGHIHOCTHEM";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            // 
            // colNGHIHOCTHEM
            // 
            this.colNGHIHOCTHEM.AutoHeight = false;
            this.colNGHIHOCTHEM.Name = "colNGHIHOCTHEM";
            // 
            // colMALOPTHEM
            // 
            this.colMALOPTHEM.Caption = "Mã lớp";
            this.colMALOPTHEM.FieldName = "MALOPTHEM";
            this.colMALOPTHEM.Name = "colMALOPTHEM";
            this.colMALOPTHEM.OptionsColumn.ReadOnly = true;
            this.colMALOPTHEM.Visible = true;
            this.colMALOPTHEM.VisibleIndex = 9;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // bds_DIEM
            // 
            this.bds_DIEM.DataMember = "FK_DIEM_SINHVIEN";
            this.bds_DIEM.DataSource = this.bds_SINHVIEN;
            // 
            // DIEMTableAdapter
            // 
            this.DIEMTableAdapter.ClearBeforeFill = true;
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.gc_SINHVIENTHEM);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.gc_SINHVIEN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSinhVien";
            this.Text = "Sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CNTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_SINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SINHVIEN)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNghiHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SINHVIENTHEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SINHVIENTHEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMASVTHEM_EDIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colPHAITHEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNGAYSINHTHEM.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNGAYSINHTHEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNGHIHOCTHEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DIEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThemDong;
        private DevExpress.XtraBars.BarButtonItem btnXoaDong;
        private DevExpress.XtraBars.BarButtonItem btnHoanTat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDonVi;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.BindingSource bds_SINHVIEN;
        private DS_CNTT ds_CNTT;
        private DS_CNTTTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DS_CNTTTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gc_SINHVIEN;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SINHVIEN;
        private DevExpress.XtraGrid.GridControl gc_SINHVIENTHEM;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SINHVIENTHEM;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaLop;
        private DevExpress.XtraEditors.CheckEdit chkNghiHoc;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private DevExpress.XtraEditors.DateEdit datNgaySinh;
        private DevExpress.XtraEditors.CheckEdit chkPhai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMASVTHEM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTHEM;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTHEM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit colPHAITHEM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit colNGAYSINHTHEM;
        private DevExpress.XtraGrid.Columns.GridColumn colNOISINHTHEM;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHITHEM;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHUTHEM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit colNGHIHOCTHEM;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOPTHEM;
        private System.Windows.Forms.BindingSource bds_LOP;
        private DS_CNTTTableAdapters.LOPTableAdapter LOPTableAdapter;
        private System.Windows.Forms.ComboBox cmbLop;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colMASVTHEM_EDIT;
        private System.Windows.Forms.BindingSource bds_DIEM;
        private DS_CNTTTableAdapters.DIEMTableAdapter DIEMTableAdapter;
    }
}