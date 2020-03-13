namespace IBS_OTIF
{
    partial class uc_OTIF_TinhToan
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnThayDoiTuan = new DevExpress.XtraEditors.SimpleButton();
            this.dtpTuanNam = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblTuanHienTai = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuanNam.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuanNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnThayDoiTuan);
            this.groupControl1.Controls.Add(this.dtpTuanNam);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblTuanHienTai);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1192, 170);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thay đổi tuần làm việc";
            // 
            // btnThayDoiTuan
            // 
            this.btnThayDoiTuan.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnThayDoiTuan.Appearance.Options.UseFont = true;
            this.btnThayDoiTuan.Location = new System.Drawing.Point(389, 50);
            this.btnThayDoiTuan.Name = "btnThayDoiTuan";
            this.btnThayDoiTuan.Size = new System.Drawing.Size(75, 25);
            this.btnThayDoiTuan.TabIndex = 11;
            this.btnThayDoiTuan.Text = "Xác nhận";
            this.btnThayDoiTuan.Click += new System.EventHandler(this.btnThayDoiTuan_Click);
            // 
            // dtpTuanNam
            // 
            this.dtpTuanNam.EditValue = null;
            this.dtpTuanNam.Location = new System.Drawing.Point(182, 51);
            this.dtpTuanNam.Name = "dtpTuanNam";
            this.dtpTuanNam.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dtpTuanNam.Properties.Appearance.Options.UseFont = true;
            this.dtpTuanNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTuanNam.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTuanNam.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpTuanNam.Properties.ShowWeekNumbers = true;
            this.dtpTuanNam.Size = new System.Drawing.Size(201, 24);
            this.dtpTuanNam.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(140, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Chọn 1 ngày trong tuần:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(36, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(325, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "*Lưu ý:  Thay đổi tuần làm việc chỉ để hiện thị dữ liệu.";
            // 
            // lblTuanHienTai
            // 
            this.lblTuanHienTai.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblTuanHienTai.Appearance.Options.UseFont = true;
            this.lblTuanHienTai.Location = new System.Drawing.Point(36, 83);
            this.lblTuanHienTai.Name = "lblTuanHienTai";
            this.lblTuanHienTai.Size = new System.Drawing.Size(178, 22);
            this.lblTuanHienTai.TabIndex = 0;
            this.lblTuanHienTai.Text = "Tuần hiện tại: 44/2020";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 170);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1192, 170);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Tính OTIF";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 340);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1192, 356);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "ABC";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(456, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "OTIF được tính tự động vào lúc 10:00:00 thứ 2 hằng tuần.";
            // 
            // uc_CaiDatChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "uc_CaiDatChung";
            this.Size = new System.Drawing.Size(1192, 696);
            this.Load += new System.EventHandler(this.uc_CaiDatChung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuanNam.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuanNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblTuanHienTai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtpTuanNam;
        private DevExpress.XtraEditors.SimpleButton btnThayDoiTuan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
