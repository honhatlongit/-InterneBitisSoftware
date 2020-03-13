namespace IBS_QuanTri
{
    partial class uc_PhanQuyenMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridChuongTrinh = new DevExpress.XtraGrid.GridControl();
            this.gvChuongTrinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcChTrID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridNhomMenu = new DevExpress.XtraGrid.GridControl();
            this.gvNhomMenu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMenu = new DevExpress.XtraGrid.GridControl();
            this.gvMenu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChuongTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuongTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridNhanVien);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1064, 672);
            this.splitContainerControl1.SplitterPosition = 175;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridNhanVien.MainView = this.gvNhanVien;
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.Size = new System.Drawing.Size(175, 672);
            this.gridNhanVien.TabIndex = 0;
            this.gridNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            this.gridNhanVien.Click += new System.EventHandler(this.gridNhanVien_Click);
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaNV});
            this.gvNhanVien.GridControl = this.gridNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.OptionsBehavior.Editable = false;
            this.gvNhanVien.OptionsView.ShowAutoFilterRow = true;
            this.gvNhanVien.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvNhanVien_RowCellStyle);
            // 
            // gcMaNV
            // 
            this.gcMaNV.Caption = "Nhân viên";
            this.gcMaNV.FieldName = "MaNV";
            this.gcMaNV.Name = "gcMaNV";
            this.gcMaNV.Visible = true;
            this.gcMaNV.VisibleIndex = 0;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridChuongTrinh);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(884, 672);
            this.splitContainerControl2.SplitterPosition = 224;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridChuongTrinh
            // 
            this.gridChuongTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChuongTrinh.Location = new System.Drawing.Point(0, 0);
            this.gridChuongTrinh.MainView = this.gvChuongTrinh;
            this.gridChuongTrinh.Name = "gridChuongTrinh";
            this.gridChuongTrinh.Size = new System.Drawing.Size(224, 672);
            this.gridChuongTrinh.TabIndex = 1;
            this.gridChuongTrinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChuongTrinh});
            this.gridChuongTrinh.Click += new System.EventHandler(this.gridChuongTrinh_Click);
            // 
            // gvChuongTrinh
            // 
            this.gvChuongTrinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcChTrID,
            this.gridColumn3});
            this.gvChuongTrinh.GridControl = this.gridChuongTrinh;
            this.gvChuongTrinh.Name = "gvChuongTrinh";
            this.gvChuongTrinh.OptionsBehavior.Editable = false;
            this.gvChuongTrinh.OptionsView.ShowAutoFilterRow = true;
            this.gvChuongTrinh.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvChuongTrinh_RowCellStyle);
            // 
            // gcChTrID
            // 
            this.gcChTrID.Caption = "ID";
            this.gcChTrID.FieldName = "ID";
            this.gcChTrID.Name = "gcChTrID";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chương trình";
            this.gridColumn3.FieldName = "TenChuongTrinh";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.gridNhomMenu);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.gridMenu);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(655, 672);
            this.splitContainerControl3.SplitterPosition = 201;
            this.splitContainerControl3.TabIndex = 0;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // gridNhomMenu
            // 
            this.gridNhomMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNhomMenu.Location = new System.Drawing.Point(0, 0);
            this.gridNhomMenu.MainView = this.gvNhomMenu;
            this.gridNhomMenu.Name = "gridNhomMenu";
            this.gridNhomMenu.Size = new System.Drawing.Size(201, 672);
            this.gridNhomMenu.TabIndex = 1;
            this.gridNhomMenu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomMenu});
            this.gridNhomMenu.Click += new System.EventHandler(this.gridNhomMenu_Click);
            // 
            // gvNhomMenu
            // 
            this.gvNhomMenu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvNhomMenu.GridControl = this.gridNhomMenu;
            this.gvNhomMenu.Name = "gvNhomMenu";
            this.gvNhomMenu.OptionsBehavior.Editable = false;
            this.gvNhomMenu.OptionsView.ShowAutoFilterRow = true;
            this.gvNhomMenu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvNhomMenu_RowCellStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhóm";
            this.gridColumn2.FieldName = "TenNhom";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridMenu
            // 
            this.gridMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMenu.Location = new System.Drawing.Point(0, 0);
            this.gridMenu.MainView = this.gvMenu;
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.Size = new System.Drawing.Size(449, 672);
            this.gridMenu.TabIndex = 1;
            this.gridMenu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMenu});
            // 
            // gvMenu
            // 
            this.gvMenu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvMenu.GridControl = this.gridMenu;
            this.gvMenu.Name = "gvMenu";
            this.gvMenu.OptionsView.ShowAutoFilterRow = true;
            this.gvMenu.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvMenu_CellValueChanged);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nhóm ID";
            this.gridColumn4.FieldName = "NhomID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Menu ID";
            this.gridColumn5.FieldName = "MenuID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên menu";
            this.gridColumn6.FieldName = "TenMenu";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Sử dụng";
            this.gridColumn7.FieldName = "SuDung";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // uc_PhanQuyenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "uc_PhanQuyenMenu";
            this.Size = new System.Drawing.Size(1064, 672);
            this.Load += new System.EventHandler(this.uc_PhanQuyenMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChuongTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuongTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridChuongTrinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChuongTrinh;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraGrid.GridControl gridNhomMenu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomMenu;
        private DevExpress.XtraGrid.GridControl gridMenu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMenu;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn gcChTrID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}
