namespace MiniMes.LotTraceSample.Forms
{
    partial class LotTraceForm
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.PanelControl panelSearch;
        private System.Windows.Forms.TableLayoutPanel tableSearch;
        private DevExpress.XtraEditors.LabelControl lblLotNo;
        private DevExpress.XtraEditors.TextEdit txtLotNo;
        private DevExpress.XtraEditors.LabelControl lblWorkOrderNo;
        private DevExpress.XtraEditors.TextEdit txtWorkOrderNo;
        private DevExpress.XtraEditors.LabelControl lblItemCode;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.LabelControl lblProcessCode;
        private DevExpress.XtraEditors.TextEdit txtProcessCode;
        private DevExpress.XtraEditors.LabelControl lblCustomerCode;
        private DevExpress.XtraEditors.TextEdit txtCustomerCode;
        private DevExpress.XtraEditors.LabelControl lblShipmentNo;
        private DevExpress.XtraEditors.TextEdit txtShipmentNo;
        private DevExpress.XtraEditors.LabelControl lblDateFrom;
        private DevExpress.XtraEditors.DateEdit dtFrom;
        private DevExpress.XtraEditors.LabelControl lblDateTo;
        private DevExpress.XtraEditors.DateEdit dtTo;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraGrid.GridControl gridLotTrace;
        private DevExpress.XtraGrid.Views.Grid.GridView viewLotTrace;
        private DevExpress.XtraEditors.PanelControl panelStatus;
        private DevExpress.XtraEditors.LabelControl lblCount;
        private DevExpress.XtraEditors.LabelControl lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelSearch = new DevExpress.XtraEditors.PanelControl();
            this.tableSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblLotNo = new DevExpress.XtraEditors.LabelControl();
            this.txtLotNo = new DevExpress.XtraEditors.TextEdit();
            this.lblWorkOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.txtWorkOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.lblItemCode = new DevExpress.XtraEditors.LabelControl();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.lblProcessCode = new DevExpress.XtraEditors.LabelControl();
            this.txtProcessCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomerCode = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerCode = new DevExpress.XtraEditors.TextEdit();
            this.lblShipmentNo = new DevExpress.XtraEditors.LabelControl();
            this.txtShipmentNo = new DevExpress.XtraEditors.TextEdit();
            this.lblDateFrom = new DevExpress.XtraEditors.LabelControl();
            this.dtFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblDateTo = new DevExpress.XtraEditors.LabelControl();
            this.dtTo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.gridLotTrace = new DevExpress.XtraGrid.GridControl();
            this.viewLotTrace = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelStatus = new DevExpress.XtraEditors.PanelControl();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.tableSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipmentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLotTrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLotTrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelStatus)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.tableSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1424, 150);
            this.panelSearch.TabIndex = 0;
            // 
            // tableSearch
            // 
            this.tableSearch.ColumnCount = 6;
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableSearch.Controls.Add(this.lblLotNo, 0, 0);
            this.tableSearch.Controls.Add(this.txtLotNo, 1, 0);
            this.tableSearch.Controls.Add(this.lblWorkOrderNo, 2, 0);
            this.tableSearch.Controls.Add(this.txtWorkOrderNo, 3, 0);
            this.tableSearch.Controls.Add(this.lblItemCode, 4, 0);
            this.tableSearch.Controls.Add(this.txtItemCode, 5, 0);
            this.tableSearch.Controls.Add(this.lblProcessCode, 0, 1);
            this.tableSearch.Controls.Add(this.txtProcessCode, 1, 1);
            this.tableSearch.Controls.Add(this.lblCustomerCode, 2, 1);
            this.tableSearch.Controls.Add(this.txtCustomerCode, 3, 1);
            this.tableSearch.Controls.Add(this.lblShipmentNo, 4, 1);
            this.tableSearch.Controls.Add(this.txtShipmentNo, 5, 1);
            this.tableSearch.Controls.Add(this.lblDateFrom, 0, 2);
            this.tableSearch.Controls.Add(this.dtFrom, 1, 2);
            this.tableSearch.Controls.Add(this.lblDateTo, 2, 2);
            this.tableSearch.Controls.Add(this.dtTo, 3, 2);
            this.tableSearch.Controls.Add(this.btnSearch, 4, 2);
            this.tableSearch.Controls.Add(this.btnReset, 5, 2);
            this.tableSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSearch.Location = new System.Drawing.Point(2, 2);
            this.tableSearch.Name = "tableSearch";
            this.tableSearch.Padding = new System.Windows.Forms.Padding(10);
            this.tableSearch.RowCount = 3;
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableSearch.Size = new System.Drawing.Size(1420, 146);
            this.tableSearch.TabIndex = 0;
            // 
            // lblLotNo
            // 
            this.lblLotNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLotNo.Location = new System.Drawing.Point(13, 21);
            this.lblLotNo.Name = "lblLotNo";
            this.lblLotNo.Size = new System.Drawing.Size(45, 15);
            this.lblLotNo.TabIndex = 0;
            this.lblLotNo.Text = "LOT 번호";
            // 
            // txtLotNo
            // 
            this.txtLotNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLotNo.Location = new System.Drawing.Point(133, 17);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(280, 24);
            this.txtLotNo.TabIndex = 1;
            // 
            // lblWorkOrderNo
            // 
            this.lblWorkOrderNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorkOrderNo.Location = new System.Drawing.Point(419, 21);
            this.lblWorkOrderNo.Name = "lblWorkOrderNo";
            this.lblWorkOrderNo.Size = new System.Drawing.Size(71, 15);
            this.lblWorkOrderNo.TabIndex = 2;
            this.lblWorkOrderNo.Text = "작업지시번호";
            // 
            // txtWorkOrderNo
            // 
            this.txtWorkOrderNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkOrderNo.Location = new System.Drawing.Point(539, 17);
            this.txtWorkOrderNo.Name = "txtWorkOrderNo";
            this.txtWorkOrderNo.Size = new System.Drawing.Size(280, 24);
            this.txtWorkOrderNo.TabIndex = 3;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemCode.Location = new System.Drawing.Point(825, 21);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(45, 15);
            this.lblItemCode.TabIndex = 4;
            this.lblItemCode.Text = "품목코드";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCode.Location = new System.Drawing.Point(945, 17);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(462, 24);
            this.txtItemCode.TabIndex = 5;
            // 
            // lblProcessCode
            // 
            this.lblProcessCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProcessCode.Location = new System.Drawing.Point(13, 59);
            this.lblProcessCode.Name = "lblProcessCode";
            this.lblProcessCode.Size = new System.Drawing.Size(45, 15);
            this.lblProcessCode.TabIndex = 6;
            this.lblProcessCode.Text = "공정코드";
            // 
            // txtProcessCode
            // 
            this.txtProcessCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcessCode.Location = new System.Drawing.Point(133, 55);
            this.txtProcessCode.Name = "txtProcessCode";
            this.txtProcessCode.Size = new System.Drawing.Size(280, 24);
            this.txtProcessCode.TabIndex = 7;
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerCode.Location = new System.Drawing.Point(419, 59);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(57, 15);
            this.lblCustomerCode.TabIndex = 8;
            this.lblCustomerCode.Text = "거래처코드";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerCode.Location = new System.Drawing.Point(539, 55);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(280, 24);
            this.txtCustomerCode.TabIndex = 9;
            // 
            // lblShipmentNo
            // 
            this.lblShipmentNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShipmentNo.Location = new System.Drawing.Point(825, 59);
            this.lblShipmentNo.Name = "lblShipmentNo";
            this.lblShipmentNo.Size = new System.Drawing.Size(45, 15);
            this.lblShipmentNo.TabIndex = 10;
            this.lblShipmentNo.Text = "출하번호";
            // 
            // txtShipmentNo
            // 
            this.txtShipmentNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShipmentNo.Location = new System.Drawing.Point(945, 55);
            this.txtShipmentNo.Name = "txtShipmentNo";
            this.txtShipmentNo.Size = new System.Drawing.Size(462, 24);
            this.txtShipmentNo.TabIndex = 11;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateFrom.Location = new System.Drawing.Point(13, 97);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(81, 15);
            this.lblDateFrom.TabIndex = 12;
            this.lblDateFrom.Text = "생산시작일 From";
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.EditValue = null;
            this.dtFrom.Location = new System.Drawing.Point(133, 93);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dtFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtFrom.Properties.NullDate = "";
            this.dtFrom.Properties.NullText = "";
            this.dtFrom.Size = new System.Drawing.Size(280, 24);
            this.dtFrom.TabIndex = 13;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateTo.Location = new System.Drawing.Point(419, 97);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(68, 15);
            this.lblDateTo.TabIndex = 14;
            this.lblDateTo.Text = "생산시작일 To";
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.EditValue = null;
            this.dtTo.Location = new System.Drawing.Point(539, 93);
            this.dtTo.Name = "dtTo";
            this.dtTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dtTo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtTo.Properties.NullDate = "";
            this.dtTo.Properties.NullText = "";
            this.dtTo.Size = new System.Drawing.Size(280, 24);
            this.dtTo.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Location = new System.Drawing.Point(825, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "조회";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReset.Location = new System.Drawing.Point(945, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 30);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "초기화";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gridLotTrace
            // 
            this.gridLotTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLotTrace.Location = new System.Drawing.Point(0, 150);
            this.gridLotTrace.MainView = this.viewLotTrace;
            this.gridLotTrace.Name = "gridLotTrace";
            this.gridLotTrace.Size = new System.Drawing.Size(1424, 507);
            this.gridLotTrace.TabIndex = 1;
            this.gridLotTrace.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewLotTrace});
            // 
            // viewLotTrace
            // 
            this.viewLotTrace.GridControl = this.gridLotTrace;
            this.viewLotTrace.Name = "viewLotTrace";
            this.viewLotTrace.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.viewLotTrace_CustomDrawRowIndicator);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Controls.Add(this.lblCount);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 657);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1424, 40);
            this.panelStatus.TabIndex = 2;
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(15, 13);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(84, 15);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "조회건수: 0건";
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Location = new System.Drawing.Point(1119, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(290, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "대기 중";
            // 
            // LotTraceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 697);
            this.Controls.Add(this.gridLotTrace);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelSearch);
            this.KeyPreview = true;
            this.Name = "LotTraceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LOT Trace 통합조회";
            this.Load += new System.EventHandler(this.LotTraceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.tableSearch.ResumeLayout(false);
            this.tableSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipmentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLotTrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLotTrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelStatus)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
