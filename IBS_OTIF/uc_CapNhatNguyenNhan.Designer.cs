namespace IBS_OTIF
{
    partial class uc_CapNhatNguyenNhan
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVietTat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSanLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKetThucThucTe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcOTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNguyenNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riglueNguyenNhan = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDVGayRa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueNguyenNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riglueNguyenNhan});
            this.gridControl.Size = new System.Drawing.Size(1192, 696);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcID,
            this.gcVietTat,
            this.gcLSX,
            this.gcMaSP,
            this.gcNgayBatDau,
            this.gcNgayKetThuc,
            this.gcSanLuong,
            this.gcKetThucThucTe,
            this.gcOT,
            this.gcIF,
            this.gcOTIF,
            this.gcNguyenNhan,
            this.gcDVGayRa});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // gcID
            // 
            this.gcID.Caption = "ID";
            this.gcID.FieldName = "ID";
            this.gcID.Name = "gcID";
            this.gcID.OptionsColumn.AllowEdit = false;
            this.gcID.OptionsColumn.AllowFocus = false;
            this.gcID.Width = 120;
            // 
            // gcVietTat
            // 
            this.gcVietTat.Caption = "Đơn Vị";
            this.gcVietTat.FieldName = "TEN_DV";
            this.gcVietTat.Name = "gcVietTat";
            this.gcVietTat.OptionsColumn.AllowEdit = false;
            this.gcVietTat.OptionsColumn.AllowFocus = false;
            this.gcVietTat.Visible = true;
            this.gcVietTat.VisibleIndex = 0;
            this.gcVietTat.Width = 120;
            // 
            // gcLSX
            // 
            this.gcLSX.Caption = "Số LSX";
            this.gcLSX.FieldName = "SOLSX";
            this.gcLSX.Name = "gcLSX";
            this.gcLSX.OptionsColumn.AllowEdit = false;
            this.gcLSX.OptionsColumn.AllowFocus = false;
            this.gcLSX.Visible = true;
            this.gcLSX.VisibleIndex = 1;
            // 
            // gcMaSP
            // 
            this.gcMaSP.Caption = "Mã SP";
            this.gcMaSP.FieldName = "MASP";
            this.gcMaSP.Name = "gcMaSP";
            this.gcMaSP.OptionsColumn.AllowEdit = false;
            this.gcMaSP.OptionsColumn.AllowFocus = false;
            this.gcMaSP.Visible = true;
            this.gcMaSP.VisibleIndex = 2;
            // 
            // gcNgayBatDau
            // 
            this.gcNgayBatDau.Caption = "Ngày bắt đầu";
            this.gcNgayBatDau.FieldName = "NGAYBATDAU";
            this.gcNgayBatDau.Name = "gcNgayBatDau";
            this.gcNgayBatDau.OptionsColumn.AllowEdit = false;
            this.gcNgayBatDau.OptionsColumn.AllowFocus = false;
            this.gcNgayBatDau.Visible = true;
            this.gcNgayBatDau.VisibleIndex = 3;
            // 
            // gcNgayKetThuc
            // 
            this.gcNgayKetThuc.Caption = "Ngày kết thúc";
            this.gcNgayKetThuc.FieldName = "NGAYKETTHUC";
            this.gcNgayKetThuc.Name = "gcNgayKetThuc";
            this.gcNgayKetThuc.OptionsColumn.AllowEdit = false;
            this.gcNgayKetThuc.OptionsColumn.AllowFocus = false;
            this.gcNgayKetThuc.Visible = true;
            this.gcNgayKetThuc.VisibleIndex = 4;
            // 
            // gcSanLuong
            // 
            this.gcSanLuong.Caption = "SLTH";
            this.gcSanLuong.FieldName = "SANLUONGTHUCTE";
            this.gcSanLuong.Name = "gcSanLuong";
            this.gcSanLuong.OptionsColumn.AllowEdit = false;
            this.gcSanLuong.OptionsColumn.AllowFocus = false;
            this.gcSanLuong.Visible = true;
            this.gcSanLuong.VisibleIndex = 5;
            // 
            // gcKetThucThucTe
            // 
            this.gcKetThucThucTe.Caption = "Kết thúc thực tế";
            this.gcKetThucThucTe.FieldName = "NGAYKETTHUCTHUCTE";
            this.gcKetThucThucTe.Name = "gcKetThucThucTe";
            this.gcKetThucThucTe.OptionsColumn.AllowEdit = false;
            this.gcKetThucThucTe.OptionsColumn.AllowFocus = false;
            this.gcKetThucThucTe.Visible = true;
            this.gcKetThucThucTe.VisibleIndex = 6;
            // 
            // gcOT
            // 
            this.gcOT.Caption = "OT";
            this.gcOT.FieldName = "OT";
            this.gcOT.Name = "gcOT";
            this.gcOT.OptionsColumn.AllowEdit = false;
            this.gcOT.OptionsColumn.AllowFocus = false;
            this.gcOT.Visible = true;
            this.gcOT.VisibleIndex = 7;
            // 
            // gcIF
            // 
            this.gcIF.Caption = "IF";
            this.gcIF.FieldName = "IF";
            this.gcIF.Name = "gcIF";
            this.gcIF.OptionsColumn.AllowEdit = false;
            this.gcIF.OptionsColumn.AllowFocus = false;
            this.gcIF.Visible = true;
            this.gcIF.VisibleIndex = 8;
            // 
            // gcOTIF
            // 
            this.gcOTIF.Caption = "OTIF";
            this.gcOTIF.FieldName = "OTIF";
            this.gcOTIF.Name = "gcOTIF";
            this.gcOTIF.OptionsColumn.AllowEdit = false;
            this.gcOTIF.OptionsColumn.AllowFocus = false;
            this.gcOTIF.Visible = true;
            this.gcOTIF.VisibleIndex = 9;
            // 
            // gcNguyenNhan
            // 
            this.gcNguyenNhan.Caption = "Nguyên nhân / Diễn giải";
            this.gcNguyenNhan.ColumnEdit = this.riglueNguyenNhan;
            this.gcNguyenNhan.FieldName = "MaNN";
            this.gcNguyenNhan.Name = "gcNguyenNhan";
            this.gcNguyenNhan.Visible = true;
            this.gcNguyenNhan.VisibleIndex = 10;
            this.gcNguyenNhan.Width = 130;
            // 
            // riglueNguyenNhan
            // 
            this.riglueNguyenNhan.AutoHeight = false;
            this.riglueNguyenNhan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riglueNguyenNhan.Name = "riglueNguyenNhan";
            this.riglueNguyenNhan.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gcDVGayRa
            // 
            this.gcDVGayRa.Caption = "Đơn vị gây ra";
            this.gcDVGayRa.FieldName = "DonViGayRa";
            this.gcDVGayRa.Name = "gcDVGayRa";
            this.gcDVGayRa.Visible = true;
            this.gcDVGayRa.VisibleIndex = 11;
            this.gcDVGayRa.Width = 100;
            // 
            // uc_CapNhatNguyenNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Name = "uc_CapNhatNguyenNhan";
            this.Size = new System.Drawing.Size(1192, 696);
            this.Load += new System.EventHandler(this.uc_CapNhatNguyenNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueNguyenNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gcID;
        private DevExpress.XtraGrid.Columns.GridColumn gcVietTat;
        private DevExpress.XtraGrid.Columns.GridColumn gcLSX;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn gcSanLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gcKetThucThucTe;
        private DevExpress.XtraGrid.Columns.GridColumn gcOT;
        private DevExpress.XtraGrid.Columns.GridColumn gcIF;
        private DevExpress.XtraGrid.Columns.GridColumn gcOTIF;
        private DevExpress.XtraGrid.Columns.GridColumn gcNguyenNhan;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit riglueNguyenNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gcDVGayRa;
    }
}
