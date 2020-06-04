namespace QLDSV
{
    partial class FormDanhSachDongHocPhiCuaLop
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
            this.mALOPTextBox = new System.Windows.Forms.TextBox();
            this.bds_LOP = new System.Windows.Forms.BindingSource(this.components);
            this.ds_KETOAN = new QLDSV.DS_KETOAN();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LOPTableAdapter = new QLDSV.DS_KETOANTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_KETOANTableAdapters.TableAdapterManager();
            this.crvDanhSachDongHocPhiCuaLop = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            lblLop = new System.Windows.Forms.Label();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_KETOAN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new System.Drawing.Point(12, 22);
            lblLop.Name = "lblLop";
            lblLop.Size = new System.Drawing.Size(37, 19);
            lblLop.TabIndex = 0;
            lblLop.Text = "Lớp:";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnThoat);
            this.grpThongTin.Controls.Add(this.btnXem);
            this.grpThongTin.Controls.Add(this.mALOPTextBox);
            this.grpThongTin.Controls.Add(this.cmbHocKy);
            this.grpThongTin.Controls.Add(this.lblHocKy);
            this.grpThongTin.Controls.Add(this.cmbNienKhoa);
            this.grpThongTin.Controls.Add(this.lblNienKhoa);
            this.grpThongTin.Controls.Add(lblLop);
            this.grpThongTin.Controls.Add(this.cmbLop);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1200, 104);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1114, 61);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(1114, 12);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 33);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // mALOPTextBox
            // 
            this.mALOPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_LOP, "MALOP", true));
            this.mALOPTextBox.Location = new System.Drawing.Point(462, 18);
            this.mALOPTextBox.Name = "mALOPTextBox";
            this.mALOPTextBox.ReadOnly = true;
            this.mALOPTextBox.Size = new System.Drawing.Size(180, 26);
            this.mALOPTextBox.TabIndex = 7;
            // 
            // bds_LOP
            // 
            this.bds_LOP.DataMember = "LOP";
            this.bds_LOP.DataSource = this.ds_KETOAN;
            // 
            // ds_KETOAN
            // 
            this.ds_KETOAN.DataSetName = "DS_KETOAN";
            this.ds_KETOAN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cmbHocKy.Location = new System.Drawing.Point(1024, 19);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(59, 27);
            this.cmbHocKy.TabIndex = 3;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(948, 27);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(57, 19);
            this.lblHocKy.TabIndex = 2;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(739, 18);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(191, 27);
            this.cmbNienKhoa.TabIndex = 3;
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(648, 26);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(75, 19);
            this.lblNienKhoa.TabIndex = 2;
            this.lblNienKhoa.Text = "Niên khóa:";
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.bds_LOP;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(55, 17);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(401, 27);
            this.cmbLop.TabIndex = 1;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_KETOANTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crvDanhSachDongHocPhiCuaLop
            // 
            this.crvDanhSachDongHocPhiCuaLop.ActiveViewIndex = -1;
            this.crvDanhSachDongHocPhiCuaLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDanhSachDongHocPhiCuaLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDanhSachDongHocPhiCuaLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDanhSachDongHocPhiCuaLop.Location = new System.Drawing.Point(0, 104);
            this.crvDanhSachDongHocPhiCuaLop.Name = "crvDanhSachDongHocPhiCuaLop";
            this.crvDanhSachDongHocPhiCuaLop.Size = new System.Drawing.Size(1200, 554);
            this.crvDanhSachDongHocPhiCuaLop.TabIndex = 1;
            // 
            // FormDanhSachDongHocPhiCuaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.crvDanhSachDongHocPhiCuaLop);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDanhSachDongHocPhiCuaLop";
            this.Text = "Danh sách đóng học phí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDanhSachDongHocPhiCuaLop_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_KETOAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DS_KETOAN ds_KETOAN;
        private System.Windows.Forms.BindingSource bds_LOP;
        private DS_KETOANTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DS_KETOANTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox mALOPTextBox;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label lblNienKhoa;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDanhSachDongHocPhiCuaLop;
    }
}