namespace IBS_OTIF
{
    partial class uc_TongHopTheoTuan
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.groupTongHop = new DevExpress.XtraEditors.GroupControl();
            this.gridTongHopTuanHT = new DevExpress.XtraGrid.GridControl();
            this.gvTongHopTuanHT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupNDP = new DevExpress.XtraEditors.GroupControl();
            this.gridTongHopDP = new DevExpress.XtraGrid.GridControl();
            this.gvTongHopDP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupTDK = new DevExpress.XtraEditors.GroupControl();
            this.gridTongHopTDK = new DevExpress.XtraGrid.GridControl();
            this.gvTongHopTDK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTongHop)).BeginInit();
            this.groupTongHop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTongHopTuanHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTongHopTuanHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNDP)).BeginInit();
            this.groupNDP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTongHopDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTongHopDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTDK)).BeginInit();
            this.groupTDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTongHopTDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTongHopTDK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.groupTongHop);
            this.panel1.Controls.Add(this.groupNDP);
            this.panel1.Controls.Add(this.groupTDK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 639);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chartControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 401);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1192, 188);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Biểu đồ OTIF tuần hiện tại";
            // 
            // chartControl1
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(2, 20);
            this.chartControl1.Name = "chartControl1";
            series2.Name = "Otif_Dat";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.Size = new System.Drawing.Size(1188, 166);
            this.chartControl1.TabIndex = 0;
            // 
            // groupTongHop
            // 
            this.groupTongHop.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.groupTongHop.AppearanceCaption.Options.UseFont = true;
            this.groupTongHop.Controls.Add(this.gridTongHopTuanHT);
            this.groupTongHop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTongHop.Location = new System.Drawing.Point(0, 307);
            this.groupTongHop.Name = "groupTongHop";
            this.groupTongHop.Size = new System.Drawing.Size(1192, 94);
            this.groupTongHop.TabIndex = 2;
            this.groupTongHop.Text = "Tổng hợp OTIF tuần hiện tại";
            // 
            // gridTongHopTuanHT
            // 
            this.gridTongHopTuanHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTongHopTuanHT.Location = new System.Drawing.Point(2, 24);
            this.gridTongHopTuanHT.MainView = this.gvTongHopTuanHT;
            this.gridTongHopTuanHT.Name = "gridTongHopTuanHT";
            this.gridTongHopTuanHT.Size = new System.Drawing.Size(1188, 68);
            this.gridTongHopTuanHT.TabIndex = 2;
            this.gridTongHopTuanHT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTongHopTuanHT});
            // 
            // gvTongHopTuanHT
            // 
            this.gvTongHopTuanHT.GridControl = this.gridTongHopTuanHT;
            this.gvTongHopTuanHT.Name = "gvTongHopTuanHT";
            this.gvTongHopTuanHT.OptionsBehavior.Editable = false;
            this.gvTongHopTuanHT.OptionsSelection.MultiSelect = true;
            this.gvTongHopTuanHT.OptionsView.ShowGroupPanel = false;
            // 
            // groupNDP
            // 
            this.groupNDP.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.groupNDP.AppearanceCaption.Options.UseFont = true;
            this.groupNDP.Controls.Add(this.gridTongHopDP);
            this.groupNDP.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupNDP.Location = new System.Drawing.Point(0, 207);
            this.groupNDP.Name = "groupNDP";
            this.groupNDP.Size = new System.Drawing.Size(1192, 100);
            this.groupNDP.TabIndex = 1;
            this.groupNDP.Text = "Tính toán OTIF tuần hiện tại (Theo ngày điều phối của phòng kế hoạch)";
            // 
            // gridTongHopDP
            // 
            this.gridTongHopDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTongHopDP.Location = new System.Drawing.Point(2, 24);
            this.gridTongHopDP.MainView = this.gvTongHopDP;
            this.gridTongHopDP.Name = "gridTongHopDP";
            this.gridTongHopDP.Size = new System.Drawing.Size(1188, 74);
            this.gridTongHopDP.TabIndex = 1;
            this.gridTongHopDP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTongHopDP});
            // 
            // gvTongHopDP
            // 
            this.gvTongHopDP.GridControl = this.gridTongHopDP;
            this.gvTongHopDP.Name = "gvTongHopDP";
            this.gvTongHopDP.OptionsBehavior.Editable = false;
            this.gvTongHopDP.OptionsPrint.AutoWidth = false;
            this.gvTongHopDP.OptionsSelection.MultiSelect = true;
            this.gvTongHopDP.OptionsView.ShowGroupPanel = false;
            // 
            // groupTDK
            // 
            this.groupTDK.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.groupTDK.AppearanceCaption.Options.UseFont = true;
            this.groupTDK.Controls.Add(this.gridTongHopTDK);
            this.groupTDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTDK.Location = new System.Drawing.Point(0, 0);
            this.groupTDK.Name = "groupTDK";
            this.groupTDK.Size = new System.Drawing.Size(1192, 207);
            this.groupTDK.TabIndex = 0;
            this.groupTDK.Text = "Tính toán OTIF tuần hiện tại (Theo ngày của TĐK)";
            // 
            // gridTongHopTDK
            // 
            this.gridTongHopTDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTongHopTDK.Location = new System.Drawing.Point(2, 24);
            this.gridTongHopTDK.MainView = this.gvTongHopTDK;
            this.gridTongHopTDK.Name = "gridTongHopTDK";
            this.gridTongHopTDK.Size = new System.Drawing.Size(1188, 181);
            this.gridTongHopTDK.TabIndex = 0;
            this.gridTongHopTDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTongHopTDK});
            // 
            // gvTongHopTDK
            // 
            this.gvTongHopTDK.GridControl = this.gridTongHopTDK;
            this.gvTongHopTDK.Name = "gvTongHopTDK";
            this.gvTongHopTDK.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gvTongHopTDK.OptionsBehavior.Editable = false;
            this.gvTongHopTDK.OptionsSelection.MultiSelect = true;
            this.gvTongHopTDK.OptionsView.ShowGroupPanel = false;
            // 
            // uc_TongHopTheoTuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "uc_TongHopTheoTuan";
            this.Size = new System.Drawing.Size(1192, 639);
            this.Load += new System.EventHandler(this.uc_TongHopTheoTuan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTongHop)).EndInit();
            this.groupTongHop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTongHopTuanHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTongHopTuanHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNDP)).EndInit();
            this.groupNDP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTongHopDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTongHopDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTDK)).EndInit();
            this.groupTDK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTongHopTDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTongHopTDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupTDK;
        private DevExpress.XtraEditors.GroupControl groupNDP;
        private DevExpress.XtraEditors.GroupControl groupTongHop;
        private DevExpress.XtraGrid.GridControl gridTongHopTDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTongHopTDK;
        private DevExpress.XtraGrid.GridControl gridTongHopDP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTongHopDP;
        private DevExpress.XtraGrid.GridControl gridTongHopTuanHT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTongHopTuanHT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}
