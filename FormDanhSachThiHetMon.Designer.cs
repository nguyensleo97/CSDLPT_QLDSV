namespace QLDSV
{
    partial class FormDanhSachThiHetMon
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
            System.Windows.Forms.Label tENMHLabel;
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.datNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.bds_MONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.ds_CNTT = new QLDSV.DS_CNTT();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.bds_LOP = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDonVi = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.lblLanThi = new System.Windows.Forms.Label();
            this.lblNgayThi = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.LOPTableAdapter = new QLDSV.DS_CNTTTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_CNTTTableAdapters.TableAdapterManager();
            this.MONHOCTableAdapter = new QLDSV.DS_CNTTTableAdapters.MONHOCTableAdapter();
            this.crvDanhSachThiHetMon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            lblLop = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_MONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CNTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new System.Drawing.Point(396, 22);
            lblLop.Name = "lblLop";
            lblLop.Size = new System.Drawing.Size(37, 19);
            lblLop.TabIndex = 7;
            lblLop.Text = "Lớp:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(815, 22);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(67, 19);
            tENMHLabel.TabIndex = 9;
            tENMHLabel.Text = "Môn học:";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.cmbLanThi);
            this.grpThongTin.Controls.Add(this.datNgayThi);
            this.grpThongTin.Controls.Add(this.cmbHocKy);
            this.grpThongTin.Controls.Add(tENMHLabel);
            this.grpThongTin.Controls.Add(this.cmbMonHoc);
            this.grpThongTin.Controls.Add(lblLop);
            this.grpThongTin.Controls.Add(this.cmbLop);
            this.grpThongTin.Controls.Add(this.cmbDonVi);
            this.grpThongTin.Controls.Add(this.btnThoat);
            this.grpThongTin.Controls.Add(this.btnXem);
            this.grpThongTin.Controls.Add(this.lblLanThi);
            this.grpThongTin.Controls.Add(this.lblNgayThi);
            this.grpThongTin.Controls.Add(this.lblHocKy);
            this.grpThongTin.Controls.Add(this.lblDonVi);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1208, 120);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLanThi.Location = new System.Drawing.Point(888, 70);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(121, 27);
            this.cmbLanThi.TabIndex = 13;
            // 
            // datNgayThi
            // 
            this.datNgayThi.EditValue = null;
            this.datNgayThi.Location = new System.Drawing.Point(465, 74);
            this.datNgayThi.Name = "datNgayThi";
            this.datNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datNgayThi.Size = new System.Drawing.Size(326, 20);
            this.datNgayThi.TabIndex = 12;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbHocKy.Location = new System.Drawing.Point(64, 69);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(316, 27);
            this.cmbHocKy.TabIndex = 11;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.bds_MONHOC;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(888, 14);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(320, 27);
            this.cmbMonHoc.TabIndex = 10;
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
            this.cmbLop.Location = new System.Drawing.Point(439, 14);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(370, 27);
            this.cmbLop.TabIndex = 8;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // bds_LOP
            // 
            this.bds_LOP.DataMember = "LOP";
            this.bds_LOP.DataSource = this.ds_CNTT;
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonVi.FormattingEnabled = true;
            this.cmbDonVi.Location = new System.Drawing.Point(64, 14);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Size = new System.Drawing.Size(316, 27);
            this.cmbDonVi.TabIndex = 2;
            this.cmbDonVi.SelectedIndexChanged += new System.EventHandler(this.cmbDonVi_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1144, 69);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 31);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(1055, 69);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(69, 31);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lblLanThi
            // 
            this.lblLanThi.AutoSize = true;
            this.lblLanThi.Location = new System.Drawing.Point(815, 73);
            this.lblLanThi.Name = "lblLanThi";
            this.lblLanThi.Size = new System.Drawing.Size(53, 19);
            this.lblLanThi.TabIndex = 0;
            this.lblLanThi.Text = "Lần thi:";
            // 
            // lblNgayThi
            // 
            this.lblNgayThi.AutoSize = true;
            this.lblNgayThi.Location = new System.Drawing.Point(396, 75);
            this.lblNgayThi.Name = "lblNgayThi";
            this.lblNgayThi.Size = new System.Drawing.Size(63, 19);
            this.lblNgayThi.TabIndex = 0;
            this.lblNgayThi.Text = "Ngày thi:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(6, 75);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(57, 19);
            this.lblHocKy.TabIndex = 0;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(6, 22);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(52, 19);
            this.lblDonVi.TabIndex = 0;
            this.lblDonVi.Text = "Đơn vị:";
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
            // crvDanhSachThiHetMon
            // 
            this.crvDanhSachThiHetMon.ActiveViewIndex = -1;
            this.crvDanhSachThiHetMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDanhSachThiHetMon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDanhSachThiHetMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDanhSachThiHetMon.Location = new System.Drawing.Point(0, 120);
            this.crvDanhSachThiHetMon.Name = "crvDanhSachThiHetMon";
            this.crvDanhSachThiHetMon.Size = new System.Drawing.Size(1208, 538);
            this.crvDanhSachThiHetMon.TabIndex = 1;
            // 
            // FormDanhSachThiHetMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 658);
            this.Controls.Add(this.crvDanhSachThiHetMon);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDanhSachThiHetMon";
            this.Text = "Danh sách thi hết môn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDanhSachThiHetMon_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_MONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CNTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblLanThi;
        private System.Windows.Forms.Label lblNgayThi;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cmbDonVi;
        private DS_CNTT ds_CNTT;
        private System.Windows.Forms.BindingSource bds_LOP;
        private DS_CNTTTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DS_CNTTTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbLop;
        private DS_CNTTTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bds_MONHOC;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private DevExpress.XtraEditors.DateEdit datNgayThi;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDanhSachThiHetMon;
    }
}