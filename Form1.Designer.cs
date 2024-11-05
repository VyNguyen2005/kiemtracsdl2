
namespace OnTapSINHVIENKETQUA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.chkPhai = new System.Windows.Forms.CheckBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblSTT = new System.Windows.Forms.Label();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.bdnSinhVien = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHocBong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnSinhVien)).BeginInit();
            this.bdnSinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // chkPhai
            // 
            this.chkPhai.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPhai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPhai.Location = new System.Drawing.Point(19, 126);
            this.chkPhai.Margin = new System.Windows.Forms.Padding(4);
            this.chkPhai.Name = "chkPhai";
            this.chkPhai.Size = new System.Drawing.Size(125, 36);
            this.chkPhai.TabIndex = 193;
            this.chkPhai.Text = "Giới tính";
            this.chkPhai.UseVisualStyleBackColor = true;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colTenMon,
            this.colDiem});
            this.dgvKetQua.Location = new System.Drawing.Point(0, 302);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(666, 223);
            this.dgvKetQua.TabIndex = 192;
            this.dgvKetQua.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvKetQua_RowValidating);
            this.dgvKetQua.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvKetQua_UserDeletedRow);
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MaMH";
            this.colMaMon.HeaderText = "Mã Môn";
            this.colMaMon.MinimumWidth = 6;
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.Width = 125;
            // 
            // colTenMon
            // 
            this.colTenMon.DataPropertyName = "TenMH";
            this.colTenMon.HeaderText = "Tên Môn";
            this.colTenMon.MinimumWidth = 6;
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.Width = 200;
            // 
            // colDiem
            // 
            this.colDiem.DataPropertyName = "Diem";
            this.colDiem.HeaderText = "Điểm";
            this.colDiem.MinimumWidth = 6;
            this.colDiem.Name = "colDiem";
            this.colDiem.Width = 125;
            // 
            // btnKhong
            // 
            this.btnKhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.ForeColor = System.Drawing.Color.Maroon;
            this.btnKhong.Location = new System.Drawing.Point(536, 238);
            this.btnKhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(84, 42);
            this.btnKhong.TabIndex = 189;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.ForeColor = System.Drawing.Color.Maroon;
            this.btnGhi.Location = new System.Drawing.Point(448, 238);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(84, 42);
            this.btnGhi.TabIndex = 188;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Maroon;
            this.btnHuy.Location = new System.Drawing.Point(358, 238);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 42);
            this.btnHuy.TabIndex = 187;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Maroon;
            this.btnThem.Location = new System.Drawing.Point(270, 238);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 42);
            this.btnThem.TabIndex = 186;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblSTT
            // 
            this.lblSTT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.Location = new System.Drawing.Point(102, 247);
            this.lblSTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(73, 42);
            this.lblSTT.TabIndex = 185;
            this.lblSTT.Text = "00/00";
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.ForeColor = System.Drawing.Color.Maroon;
            this.btnSau.Location = new System.Drawing.Point(180, 238);
            this.btnSau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(84, 42);
            this.btnSau.TabIndex = 184;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.ForeColor = System.Drawing.Color.Maroon;
            this.btnTruoc.Location = new System.Drawing.Point(12, 238);
            this.btnTruoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(84, 42);
            this.btnTruoc.TabIndex = 183;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTongDiem.Location = new System.Drawing.Point(420, 195);
            this.txtTongDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new System.Drawing.Size(183, 22);
            this.txtTongDiem.TabIndex = 182;
            // 
            // bdnSinhVien
            // 
            this.bdnSinhVien.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdnSinhVien.CountItem = this.bindingNavigatorCountItem;
            this.bdnSinhVien.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdnSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnSinhVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnSinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bdnSinhVien.Location = new System.Drawing.Point(0, 529);
            this.bdnSinhVien.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnSinhVien.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnSinhVien.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnSinhVien.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnSinhVien.Name = "bdnSinhVien";
            this.bdnSinhVien.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnSinhVien.Size = new System.Drawing.Size(666, 27);
            this.bdnSinhVien.TabIndex = 191;
            this.bdnSinhVien.Text = "bdnSinhVien";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 21);
            this.label9.TabIndex = 190;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 181;
            this.label8.Text = "Tổng điểm";
            // 
            // txtHocBong
            // 
            this.txtHocBong.Location = new System.Drawing.Point(123, 198);
            this.txtHocBong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHocBong.Name = "txtHocBong";
            this.txtHocBong.Size = new System.Drawing.Size(156, 22);
            this.txtHocBong.TabIndex = 180;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 179;
            this.label7.Text = "Học bổng";
            // 
            // cboMaKH
            // 
            this.cboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(422, 161);
            this.cboMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(181, 24);
            this.cboMaKH.TabIndex = 178;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 177;
            this.label6.Text = "Khoa";
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(126, 167);
            this.txtNoiSinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(156, 22);
            this.txtNoiSinh.TabIndex = 176;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 175;
            this.label5.Text = "Nơi sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(422, 129);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(183, 22);
            this.dtpNgaySinh.TabIndex = 174;
            this.dtpNgaySinh.Value = new System.DateTime(2024, 9, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 173;
            this.label4.Text = "Ngày sinh";
            // 
            // txtHoSV
            // 
            this.txtHoSV.Location = new System.Drawing.Point(126, 97);
            this.txtHoSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(321, 22);
            this.txtHoSV.TabIndex = 171;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 170;
            this.label3.Text = "Họ tên SV";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(126, 65);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(480, 22);
            this.txtMaSV.TabIndex = 169;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 168;
            this.label2.Text = "Mã SV";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 50);
            this.label1.TabIndex = 167;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(456, 99);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(149, 22);
            this.txtTenSV.TabIndex = 172;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 556);
            this.Controls.Add(this.chkPhai);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.bdnSinhVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHocBong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenSV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnSinhVien)).EndInit();
            this.bdnSinhVien.ResumeLayout(false);
            this.bdnSinhVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.CheckBox chkPhai;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.BindingNavigator bdnSinhVien;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHocBong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSV;
    }
}

