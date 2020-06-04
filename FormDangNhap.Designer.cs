namespace QLDSV
{
    partial class FormDangNhap
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
            System.Windows.Forms.Label tENDONVILabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDonVi = new System.Windows.Forms.ComboBox();
            this.bds_DSPM = new System.Windows.Forms.BindingSource(this.components);
            this.ds_DSPM = new QLDSV.DS_DSPM();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.v_DANHSACHPHANMANHTableAdapter = new QLDSV.DS_DSPMTableAdapters.v_DANHSACHPHANMANHTableAdapter();
            this.tableAdapterManager = new QLDSV.DS_DSPMTableAdapters.TableAdapterManager();
            tENDONVILabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_DSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // tENDONVILabel
            // 
            tENDONVILabel.AutoSize = true;
            tENDONVILabel.Location = new System.Drawing.Point(69, 62);
            tENDONVILabel.Name = "tENDONVILabel";
            tENDONVILabel.Size = new System.Drawing.Size(52, 19);
            tENDONVILabel.TabIndex = 6;
            tENDONVILabel.Text = "Đơn vị:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tENDONVILabel);
            this.groupBox1.Controls.Add(this.cmbDonVi);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.lblMatKhau);
            this.groupBox1.Controls.Add(this.lblTenDangNhap);
            this.groupBox1.Location = new System.Drawing.Point(103, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.DataSource = this.bds_DSPM;
            this.cmbDonVi.DisplayMember = "TENDONVI";
            this.cmbDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonVi.FormattingEnabled = true;
            this.cmbDonVi.Location = new System.Drawing.Point(211, 54);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Size = new System.Drawing.Size(390, 27);
            this.cmbDonVi.TabIndex = 0;
            this.cmbDonVi.ValueMember = "TENSERVER";
            this.cmbDonVi.SelectedIndexChanged += new System.EventHandler(this.cmbDonVi_SelectedIndexChanged);
            // 
            // bds_DSPM
            // 
            this.bds_DSPM.DataMember = "v_DANHSACHPHANMANH";
            this.bds_DSPM.DataSource = this.ds_DSPM;
            // 
            // ds_DSPM
            // 
            this.ds_DSPM.DataSetName = "DS_DSPM";
            this.ds_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(454, 284);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 39);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(253, 284);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(113, 39);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(211, 217);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(390, 26);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyUp);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(211, 132);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(390, 26);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenDangNhap_KeyUp);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(69, 224);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(70, 19);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(69, 135);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(101, 19);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // v_DANHSACHPHANMANHTableAdapter
            // 
            this.v_DANHSACHPHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_DSPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.BindingSource bds_DSPM;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox txtTenDangNhap;
        public System.Windows.Forms.TextBox txtMatKhau;
        public DS_DSPM ds_DSPM;
        public DS_DSPMTableAdapters.v_DANHSACHPHANMANHTableAdapter v_DANHSACHPHANMANHTableAdapter;
        private System.Windows.Forms.ComboBox cmbDonVi;
    }
}