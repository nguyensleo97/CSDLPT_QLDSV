namespace QLDSV
{
    partial class FormDiem
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
            System.Windows.Forms.Label lblLop;
            System.Windows.Forms.Label lblMonHoc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiem));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBatDau = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnGhiDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDonVi = new System.Windows.Forms.ComboBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.bds_MONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.ds_CNTT = new QLDSV.DS_CNTT();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.bds_LOP = new System.Windows.Forms.BindingSource(this.components);
            this.txtLanThi = new System.Windows.Forms.TextBox();
            this.lblLanThi = new System.Windows.Forms.Label();
            this.LOPTableAdapter = new QLDSV.DS_CNTTTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_CNTTTableAdapters.TableAdapterManager();
            this.MONHOCTableAdapter = new QLDSV.DS_CNTTTableAdapters.MONHOCTableAdapter();
            this.gc_DIEM = new DevExpress.XtraGrid.GridControl();
            this.gv_DIEM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            lblLop = new System.Windows.Forms.Label();
            lblMonHoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_MONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CNTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DIEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DIEM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new System.Drawing.Point(273, 45);
            lblLop.Name = "lblLop";
            lblLop.Size = new System.Drawing.Size(37, 19);
            lblLop.TabIndex = 4;
            lblLop.Text = "Lớp:";
            // 
            // lblMonHoc
            // 
            lblMonHoc.AutoSize = true;
            lblMonHoc.Location = new System.Drawing.Point(273, 108);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new System.Drawing.Size(67, 19);
            lblMonHoc.TabIndex = 5;
            lblMonHoc.Text = "Môn học:";
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
            this.btnBatDau,
            this.btnThoat,
            this.btnGhiDiem,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBatDau, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Caption = "Bắt đầu";
            this.btnBatDau.Id = 0;
            this.btnBatDau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBatDau.ImageOptions.Image")));
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBatDau_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 1;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiDiem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnGhiDiem
            // 
            this.btnGhiDiem.Caption = "Ghi điểm";
            this.btnGhiDiem.Id = 2;
            this.btnGhiDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiDiem.ImageOptions.Image")));
            this.btnGhiDiem.Name = "btnGhiDiem";
            this.btnGhiDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiDiem_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 3;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            this.panel1.Controls.Add(this.cmbDonVi);
            this.panel1.Controls.Add(this.lblDonVi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 55);
            this.panel1.TabIndex = 4;
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonVi.FormattingEnabled = true;
            this.cmbDonVi.Location = new System.Drawing.Point(375, 14);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Size = new System.Drawing.Size(425, 27);
            this.cmbDonVi.TabIndex = 1;
            this.cmbDonVi.SelectedIndexChanged += new System.EventHandler(this.cmbDonVi_SelectedIndexChanged);
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(273, 22);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(52, 19);
            this.lblDonVi.TabIndex = 0;
            this.lblDonVi.Text = "Đơn vị:";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(lblMonHoc);
            this.grpThongTin.Controls.Add(this.cmbMonHoc);
            this.grpThongTin.Controls.Add(lblLop);
            this.grpThongTin.Controls.Add(this.cmbLop);
            this.grpThongTin.Controls.Add(this.txtLanThi);
            this.grpThongTin.Controls.Add(this.lblLanThi);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Location = new System.Drawing.Point(0, 108);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1200, 220);
            this.grpThongTin.TabIndex = 5;
            this.grpThongTin.TabStop = false;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.bds_MONHOC;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(375, 100);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(425, 27);
            this.cmbMonHoc.TabIndex = 6;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // bds_MONHOC
            // 
            this.bds_MONHOC.DataMember = "MONHOC";
            this.bds_MONHOC.DataSource = this.ds_CNTT;
            // 
            // ds_CNTT
            // 
            this.ds_CNTT.DataSetName = "DS_CNTT";
            this.ds_CNTT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.bds_LOP;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(375, 37);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(425, 27);
            this.cmbLop.TabIndex = 5;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // bds_LOP
            // 
            this.bds_LOP.DataMember = "LOP";
            this.bds_LOP.DataSource = this.ds_CNTT;
            // 
            // txtLanThi
            // 
            this.txtLanThi.Location = new System.Drawing.Point(375, 163);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.Size = new System.Drawing.Size(222, 26);
            this.txtLanThi.TabIndex = 1;
            // 
            // lblLanThi
            // 
            this.lblLanThi.AutoSize = true;
            this.lblLanThi.Location = new System.Drawing.Point(273, 170);
            this.lblLanThi.Name = "lblLanThi";
            this.lblLanThi.Size = new System.Drawing.Size(53, 19);
            this.lblLanThi.TabIndex = 0;
            this.lblLanThi.Text = "Lần thi:";
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_CNTTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gc_DIEM
            // 
            this.gc_DIEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_DIEM.Location = new System.Drawing.Point(0, 328);
            this.gc_DIEM.MainView = this.gv_DIEM;
            this.gc_DIEM.MenuManager = this.barManager1;
            this.gc_DIEM.Name = "gc_DIEM";
            this.gc_DIEM.Size = new System.Drawing.Size(1200, 303);
            this.gc_DIEM.TabIndex = 6;
            this.gc_DIEM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DIEM});
            // 
            // gv_DIEM
            // 
            this.gv_DIEM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colDIEM});
            this.gv_DIEM.GridControl = this.gc_DIEM;
            this.gv_DIEM.Name = "gv_DIEM";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.ReadOnly = true;
            this.colHOTEN.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colDIEM
            // 
            this.colDIEM.Caption = "Điểm";
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.gc_DIEM);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDiem";
            this.Text = "Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_MONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CNTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DIEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DIEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnBatDau;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnGhiDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDonVi;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.BindingSource bds_LOP;
        private DS_CNTT ds_CNTT;
        private System.Windows.Forms.TextBox txtLanThi;
        private System.Windows.Forms.Label lblLanThi;
        private DS_CNTTTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DS_CNTTTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbLop;
        private DS_CNTTTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bds_MONHOC;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private DevExpress.XtraGrid.GridControl gc_DIEM;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
    }
}