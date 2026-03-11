namespace MiniMes.LotTraceSample.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.SimpleButton btnOpenLotTrace;
        private DevExpress.XtraEditors.PanelControl panelMain;

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
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.btnOpenLotTrace = new DevExpress.XtraEditors.SimpleButton();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnOpenLotTrace);
            this.panelMain.Controls.Add(this.lblDescription);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(584, 221);
            this.panelMain.TabIndex = 0;
            // 
            // btnOpenLotTrace
            // 
            this.btnOpenLotTrace.Location = new System.Drawing.Point(24, 119);
            this.btnOpenLotTrace.Name = "btnOpenLotTrace";
            this.btnOpenLotTrace.Size = new System.Drawing.Size(180, 40);
            this.btnOpenLotTrace.TabIndex = 2;
            this.btnOpenLotTrace.Text = "LOT Trace 통합조회 열기";
            this.btnOpenLotTrace.Click += new System.EventHandler(this.btnOpenLotTrace_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Appearance.Options.UseFont = true;
            this.lblDescription.Location = new System.Drawing.Point(24, 68);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(389, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Oracle MES DB 조회 프로시저 기반 학습용 미니 MES 예제";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(24, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mini MES Main";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 221);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini MES";
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
