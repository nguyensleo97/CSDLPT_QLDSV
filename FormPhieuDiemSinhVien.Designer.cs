namespace QLDSV
{
    partial class FormPhieuDiemSinhVien
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.cmbMaSinhVien = new System.Windows.Forms.ComboBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.bds_LOP = new System.Windows.Forms.BindingSource(this.components);
            this.ds_CNTT = new QLDSV.DS_CNTT();
            this.cmbDonVi = new System.Windows.Forms.ComboBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.LOPTableAdapter = new QLDSV.DS_CNTTTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_CNTTTableAdapters.TableAdapterManager();
            this.crvPhieuDiemSinhVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            lblLop = new System.Windows.Forms.Label();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CNTT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new System.Drawing.Point(401, 22);
            lblLop.Name = "lblLop";
            lblLop.Size = new System.Drawing.Size(37, 19);
            lblLop.TabIndex = 2;
            lblLop.Text = "Lớp:";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnThoat);
            this.grpThongTin.Controls.Add(this.btnXem);
            this.grpThongTin.Controls.Add(this.cmbMaSinhVien);
            this.grpThongTin.Controls.Add(this.lblMaSV);
            this.grpThongTin.Controls.Add(lblLop);
            this.grpThongTin.Controls.Add(this.cmbLop);
            this.grpThongTin.Controls.Add(this.cmbDonVi);
            this.grpThongTin.Controls.Add(this.lblDonVi);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1200, 98);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1113, 61);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(1113, 14);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 34);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbMaSinhVien
            // 
            this.cmbMaSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaSinhVien.FormattingEnabled = true;
            this.cmbMaSinhVien.Location = new System.Drawing.Point(905, 14);
            this.cmbMaSinhVien.Name = "cmbMaSinhVien";
            this.cmbMaSinhVien.Size = new System.Drawing.Size(184, 27);
            this.cmbMaSinhVien.TabIndex = 5;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(841, 22);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(56, 19);
            this.lblMaSV.TabIndex = 4;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.bds_LOP;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(444, 14);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(391, 27);
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
            this.cmbDonVi.Location = new System.Drawing.Point(64, 14);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Size = new System.Drawing.Size(317, 27);
            this.cmbDonVi.TabIndex = 1;
            this.cmbDonVi.SelectedIndexChanged += new System.EventHandler(this.cmbDonVi_SelectedIndexChanged);
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
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_CNTTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crvPhieuDiemSinhVien
            // 
            this.crvPhieuDiemSinhVien.ActiveViewIndex = -1;
            this.crvPhieuDiemSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPhieuDiemSinhVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPhieuDiemSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPhieuDiemSinhVien.Location = new System.Drawing.Point(0, 98);
            this.crvPhieuDiemSinhVien.Name = "crvPhieuDiemSinhVien";
            this.crvPhieuDiemSinhVien.Size = new System.Drawing.Size(1200, 560);
            this.crvPhieuDiemSinhVien.TabIndex = 1;
            // 
            // FormPhieuDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.crvPhieuDiemSinhVien);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPhieuDiemSinhVien";
            this.Text = "Phiếu điểm sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPhieuDiemSinhVien_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CNTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.ComboBox cmbDonVi;
        private System.Windows.Forms.Label lblDonVi;
        private DS_CNTT ds_CNTT;
        private System.Windows.Forms.BindingSource bds_LOP;
        private DS_CNTTTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DS_CNTTTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbMaSinhVien;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPhieuDiemSinhVien;
    }
}