﻿namespace Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tbMember = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TabPage();
            this.btnReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmReportYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReportBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReportMerry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReportDeath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChange = new System.Windows.Forms.TabPage();
            this.btnAddNewConfig = new System.Windows.Forms.Button();
            this.grvAllQuyDinh = new System.Windows.Forms.DataGridView();
            this.cbLoaiQuyDinh = new System.Windows.Forms.ComboBox();
            this.lblLoaiQuyDinh = new System.Windows.Forms.Label();
            this.lblThayDoiQuyDinh = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.tbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMember)).BeginInit();
            this.tbReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvAllQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1220, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMini
            // 
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(1182, 12);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(32, 32);
            this.btnMini.TabIndex = 1;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ứng dụng quản lý Cây gia phả version 1.0";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbSearch);
            this.tabControl.Controls.Add(this.tbReport);
            this.tabControl.Controls.Add(this.tbChange);
            this.tabControl.Location = new System.Drawing.Point(17, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1235, 619);
            this.tabControl.TabIndex = 3;
            // 
            // tbSearch
            // 
            this.tbSearch.Controls.Add(this.btnAddMember);
            this.tbSearch.Controls.Add(this.btnSearch);
            this.tbSearch.Controls.Add(this.txtSearch);
            this.tbSearch.Controls.Add(this.tbMember);
            this.tbSearch.Controls.Add(this.label2);
            this.tbSearch.Location = new System.Drawing.Point(4, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearch.Size = new System.Drawing.Size(1227, 593);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "TRA CỨU";
            this.tbSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(1115, 80);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(106, 23);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Thêm thành viên";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1003, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 82);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(990, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // tbMember
            // 
            this.tbMember.AllowUserToAddRows = false;
            this.tbMember.AllowUserToDeleteRows = false;
            this.tbMember.AllowUserToResizeColumns = false;
            this.tbMember.AllowUserToResizeRows = false;
            this.tbMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmBirthDay,
            this.clmGender,
            this.clmParent,
            this.clmJob});
            this.tbMember.Location = new System.Drawing.Point(7, 106);
            this.tbMember.MultiSelect = false;
            this.tbMember.Name = "tbMember";
            this.tbMember.ReadOnly = true;
            this.tbMember.RowHeadersVisible = false;
            this.tbMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbMember.Size = new System.Drawing.Size(1214, 481);
            this.tbMember.TabIndex = 1;
            this.tbMember.SelectionChanged += new System.EventHandler(this.tbMember_SelectionChanged);
            // 
            // clmName
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmName.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmName.HeaderText = "Họ và tên";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmName.Width = 300;
            // 
            // clmBirthDay
            // 
            this.clmBirthDay.HeaderText = "Ngày sinh";
            this.clmBirthDay.Name = "clmBirthDay";
            this.clmBirthDay.ReadOnly = true;
            this.clmBirthDay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmBirthDay.Width = 155;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "Giới tính";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            this.clmGender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmGender.Width = 155;
            // 
            // clmParent
            // 
            this.clmParent.HeaderText = "Cha/Mẹ";
            this.clmParent.Name = "clmParent";
            this.clmParent.ReadOnly = true;
            this.clmParent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmParent.Width = 300;
            // 
            // clmJob
            // 
            this.clmJob.HeaderText = "Nghề nghiệp";
            this.clmJob.Name = "clmJob";
            this.clmJob.ReadOnly = true;
            this.clmJob.Width = 300;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1221, 76);
            this.label2.TabIndex = 0;
            this.label2.Text = "TRA CỨU THÀNH VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbReport
            // 
            this.tbReport.Controls.Add(this.btnReport);
            this.tbReport.Controls.Add(this.dataGridView1);
            this.tbReport.Controls.Add(this.textBox3);
            this.tbReport.Controls.Add(this.textBox2);
            this.tbReport.Controls.Add(this.label5);
            this.tbReport.Controls.Add(this.label4);
            this.tbReport.Controls.Add(this.cbReportType);
            this.tbReport.Controls.Add(this.label3);
            this.tbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReport.Location = new System.Drawing.Point(4, 22);
            this.tbReport.Name = "tbReport";
            this.tbReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbReport.Size = new System.Drawing.Size(1227, 593);
            this.tbReport.TabIndex = 1;
            this.tbReport.Text = "BÁO CÁO";
            this.tbReport.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnReport.Location = new System.Drawing.Point(853, 96);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(237, 23);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Lập báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmReportYear,
            this.clmReportBirth,
            this.clmReportMerry,
            this.clmReportDeath});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(6, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 443);
            this.dataGridView1.TabIndex = 6;
            // 
            // clmReportYear
            // 
            this.clmReportYear.HeaderText = "Năm";
            this.clmReportYear.Name = "clmReportYear";
            this.clmReportYear.ReadOnly = true;
            this.clmReportYear.Width = 303;
            // 
            // clmReportBirth
            // 
            this.clmReportBirth.HeaderText = "Số lượng sinh";
            this.clmReportBirth.Name = "clmReportBirth";
            this.clmReportBirth.ReadOnly = true;
            this.clmReportBirth.Width = 303;
            // 
            // clmReportMerry
            // 
            this.clmReportMerry.HeaderText = "Số lượng kết hôn";
            this.clmReportMerry.Name = "clmReportMerry";
            this.clmReportMerry.ReadOnly = true;
            this.clmReportMerry.Width = 303;
            // 
            // clmReportDeath
            // 
            this.clmReportDeath.HeaderText = "Số lượng mất";
            this.clmReportDeath.Name = "clmReportDeath";
            this.clmReportDeath.ReadOnly = true;
            this.clmReportDeath.Width = 303;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(546, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đến năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Từ năm";
            // 
            // cbReportType
            // 
            this.cbReportType.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Items.AddRange(new object[] {
            "TĂNG GIẢM THÀNH VIÊN",
            "THÀNH TÍCH"});
            this.cbReportType.Location = new System.Drawing.Point(290, 24);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(817, 39);
            this.cbReportType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "LẬP BÁO CÁO";
            // 
            // tbChange
            // 
            this.tbChange.Controls.Add(this.btnAddNewConfig);
            this.tbChange.Controls.Add(this.grvAllQuyDinh);
            this.tbChange.Controls.Add(this.cbLoaiQuyDinh);
            this.tbChange.Controls.Add(this.lblLoaiQuyDinh);
            this.tbChange.Controls.Add(this.lblThayDoiQuyDinh);
            this.tbChange.Location = new System.Drawing.Point(4, 22);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(1227, 593);
            this.tbChange.TabIndex = 2;
            this.tbChange.Text = "THAY ĐỔI QUY ĐỊNH";
            this.tbChange.UseVisualStyleBackColor = true;
            // 
            // btnAddNewConfig
            // 
            this.btnAddNewConfig.Location = new System.Drawing.Point(1050, 76);
            this.btnAddNewConfig.Name = "btnAddNewConfig";
            this.btnAddNewConfig.Size = new System.Drawing.Size(174, 24);
            this.btnAddNewConfig.TabIndex = 4;
            this.btnAddNewConfig.Text = "Thêm mới";
            this.btnAddNewConfig.UseVisualStyleBackColor = true;
            this.btnAddNewConfig.Click += new System.EventHandler(this.btnAddNewConfig_Click);
            // 
            // grvAllQuyDinh
            // 
            this.grvAllQuyDinh.AllowUserToAddRows = false;
            this.grvAllQuyDinh.AllowUserToDeleteRows = false;
            this.grvAllQuyDinh.AllowUserToResizeColumns = false;
            this.grvAllQuyDinh.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvAllQuyDinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grvAllQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAllQuyDinh.Location = new System.Drawing.Point(6, 106);
            this.grvAllQuyDinh.Name = "grvAllQuyDinh";
            this.grvAllQuyDinh.ReadOnly = true;
            this.grvAllQuyDinh.RowHeadersVisible = false;
            this.grvAllQuyDinh.Size = new System.Drawing.Size(1218, 484);
            this.grvAllQuyDinh.TabIndex = 3;
            // 
            // cbLoaiQuyDinh
            // 
            this.cbLoaiQuyDinh.FormattingEnabled = true;
            this.cbLoaiQuyDinh.Items.AddRange(new object[] {
            "Loại quan hệ",
            "Quê quán",
            "Nghề nghiệp",
            "Nguyên nhân mất",
            "Địa điểm mai táng"});
            this.cbLoaiQuyDinh.Location = new System.Drawing.Point(81, 78);
            this.cbLoaiQuyDinh.Name = "cbLoaiQuyDinh";
            this.cbLoaiQuyDinh.Size = new System.Drawing.Size(963, 21);
            this.cbLoaiQuyDinh.TabIndex = 2;
            this.cbLoaiQuyDinh.SelectedIndexChanged += new System.EventHandler(this.cbLoaiQuyDinh_SelectedIndexChanged);
            // 
            // lblLoaiQuyDinh
            // 
            this.lblLoaiQuyDinh.AutoSize = true;
            this.lblLoaiQuyDinh.Location = new System.Drawing.Point(3, 82);
            this.lblLoaiQuyDinh.Name = "lblLoaiQuyDinh";
            this.lblLoaiQuyDinh.Size = new System.Drawing.Size(71, 13);
            this.lblLoaiQuyDinh.TabIndex = 1;
            this.lblLoaiQuyDinh.Text = "Loại quy định";
            // 
            // lblThayDoiQuyDinh
            // 
            this.lblThayDoiQuyDinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThayDoiQuyDinh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThayDoiQuyDinh.Location = new System.Drawing.Point(0, 0);
            this.lblThayDoiQuyDinh.Name = "lblThayDoiQuyDinh";
            this.lblThayDoiQuyDinh.Size = new System.Drawing.Size(1227, 73);
            this.lblThayDoiQuyDinh.TabIndex = 0;
            this.lblThayDoiQuyDinh.Text = "THAY ĐỔI QUY ĐỊNH HỆ THỐNG";
            this.lblThayDoiQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(904, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(272, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng quản lý cây giả phả v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tbSearch.ResumeLayout(false);
            this.tbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMember)).EndInit();
            this.tbReport.ResumeLayout(false);
            this.tbReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbChange.ResumeLayout(false);
            this.tbChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvAllQuyDinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbSearch;
        private System.Windows.Forms.DataGridView tbMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbReport;
        private System.Windows.Forms.TabPage tbChange;
        private System.Windows.Forms.Button btnLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJob;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReportYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReportBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReportMerry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReportDeath;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grvAllQuyDinh;
        public System.Windows.Forms.ComboBox cbLoaiQuyDinh;
        private System.Windows.Forms.Label lblLoaiQuyDinh;
        private System.Windows.Forms.Label lblThayDoiQuyDinh;
        private System.Windows.Forms.Button btnAddNewConfig;
    }
}

