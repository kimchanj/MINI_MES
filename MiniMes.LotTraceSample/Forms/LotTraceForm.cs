using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MiniMes.LotTraceSample.Models;
using MiniMes.LotTraceSample.Services;
using Oracle.ManagedDataAccess.Client;

namespace MiniMes.LotTraceSample.Forms
{
    public partial class LotTraceForm : XtraForm
    {
        private readonly LotTraceService _lotTraceService;
        private readonly Dictionary<string, string> _columnCaptions;
        private readonly HashSet<string> _hiddenColumns;
        private readonly HashSet<string> _numericColumns;
        private readonly HashSet<string> _dateColumns;

        public LotTraceForm()
            : this(new LotTraceService())
        {
        }

        public LotTraceForm(LotTraceService lotTraceService)
        {
            _lotTraceService = lotTraceService ?? throw new ArgumentNullException(nameof(lotTraceService));
            _columnCaptions = CreateColumnCaptionMap();
            _hiddenColumns = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "LOT_ID",
                "PROCESS_HIST_ID",
                "DEFECT_ID",
                "MATERIAL_USAGE_ID",
                "SHIPMENT_ID"
            };
            _numericColumns = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "INPUT_QTY",
                "GOOD_QTY",
                "NG_QTY",
                "DEFECT_DETAIL_QTY",
                "USED_QTY",
                "SHIP_QTY"
            };
            _dateColumns = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "START_DT",
                "END_DT"
            };

            InitializeComponent();
            WireSearchKeyEvents(this);
        }

        private void LotTraceForm_Load(object sender, EventArgs e)
        {
            ApplyGridViewOptions();
            ResetSearchControls();
            lblStatus.Text = "대기 중";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchLotTrace();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSearchControls();
        }

        private void SearchControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.SuppressKeyPress = true;
            e.Handled = true;
            SearchLotTrace();
        }

        private void viewLotTrace_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0)
            {
                return;
            }

            e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void SearchLotTrace()
        {
            if (!ValidateDateRange())
            {
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                lblStatus.Text = "조회 중...";

                LotTraceSearchCondition condition = BuildSearchCondition();
                DataTable resultTable = _lotTraceService.GetLotTraceList(condition);

                gridLotTrace.DataSource = resultTable;
                viewLotTrace.PopulateColumns();
                ConfigureGridColumns();

                int rowCount = resultTable?.Rows.Count ?? 0;
                lblCount.Text = $"조회건수: {rowCount}건";
                lblStatus.Text = rowCount > 0 ? "조회 완료" : "조회 결과가 없습니다.";
            }
            catch (OracleException ex)
            {
                HandleSearchError($"Oracle 오류가 발생했습니다.\r\n{ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                HandleSearchError($"설정 오류가 발생했습니다.\r\n{ex.Message}");
            }
            catch (Exception ex)
            {
                HandleSearchError($"조회 중 오류가 발생했습니다.\r\n{ex.Message}");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void HandleSearchError(string message)
        {
            lblStatus.Text = "조회 실패";
            MessageBox.Show(this, message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateDateRange()
        {
            DateTime? dateFrom = dtFrom.EditValue as DateTime?;
            DateTime? dateTo = dtTo.EditValue as DateTime?;

            if (dateFrom.HasValue && dateTo.HasValue && dateFrom.Value.Date > dateTo.Value.Date)
            {
                string message = "생산시작일 From 은 To 보다 클 수 없습니다.";
                lblStatus.Text = message;
                MessageBox.Show(this, message, "입력 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtFrom.Focus();
                return false;
            }

            return true;
        }

        private LotTraceSearchCondition BuildSearchCondition()
        {
            return new LotTraceSearchCondition
            {
                LotNo = txtLotNo.Text,
                WorkOrderNo = txtWorkOrderNo.Text,
                ItemCode = txtItemCode.Text,
                ProcessCode = txtProcessCode.Text,
                CustomerCode = txtCustomerCode.Text,
                ShipmentNo = txtShipmentNo.Text,
                DateFrom = dtFrom.EditValue as DateTime?,
                DateTo = dtTo.EditValue as DateTime?
            };
        }

        private void ResetSearchControls()
        {
            txtLotNo.Text = string.Empty;
            txtWorkOrderNo.Text = string.Empty;
            txtItemCode.Text = string.Empty;
            txtProcessCode.Text = string.Empty;
            txtCustomerCode.Text = string.Empty;
            txtShipmentNo.Text = string.Empty;
            dtFrom.EditValue = null;
            dtTo.EditValue = null;
            gridLotTrace.DataSource = null;
            viewLotTrace.Columns.Clear();
            lblCount.Text = "조회건수: 0건";
            lblStatus.Text = "초기화 완료";
            txtLotNo.Focus();
        }

        private void ApplyGridViewOptions()
        {
            viewLotTrace.OptionsBehavior.Editable = false;
            viewLotTrace.OptionsBehavior.ReadOnly = true;
            viewLotTrace.OptionsView.ColumnAutoWidth = false;
            viewLotTrace.OptionsView.ShowGroupPanel = false;
            viewLotTrace.OptionsView.ShowIndicator = true;
            viewLotTrace.OptionsView.EnableAppearanceEvenRow = true;
            viewLotTrace.OptionsView.ShowHorizontalLines = DefaultBoolean.True;
            viewLotTrace.OptionsView.ShowVerticalLines = DefaultBoolean.True;
            viewLotTrace.OptionsCustomization.AllowFilter = false;
            viewLotTrace.OptionsSelection.EnableAppearanceFocusedCell = false;
            viewLotTrace.OptionsSelection.EnableAppearanceFocusedRow = true;
            viewLotTrace.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            viewLotTrace.IndicatorWidth = 50;
            viewLotTrace.RowHeight = 28;
            viewLotTrace.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            viewLotTrace.Appearance.Row.TextOptions.VAlignment = VertAlignment.Center;
        }

        private void ConfigureGridColumns()
        {
            foreach (GridColumn column in viewLotTrace.Columns)
            {
                if (_columnCaptions.TryGetValue(column.FieldName, out string caption))
                {
                    column.Caption = caption;
                }

                if (_hiddenColumns.Contains(column.FieldName))
                {
                    column.Visible = false;
                    continue;
                }

                column.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                column.AppearanceCell.TextOptions.VAlignment = VertAlignment.Center;
                column.MinWidth = 100;

                if (_dateColumns.Contains(column.FieldName))
                {
                    column.DisplayFormat.FormatType = FormatType.DateTime;
                    column.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
                    column.MinWidth = 150;
                }

                if (_numericColumns.Contains(column.FieldName))
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "#,##0.###";
                    column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
                }
            }

            viewLotTrace.BestFitColumns();
        }

        private void WireSearchKeyEvents(Control parent)
        {
            parent.KeyDown += SearchControl_KeyDown;

            foreach (Control control in parent.Controls)
            {
                WireSearchKeyEvents(control);
            }
        }

        private Dictionary<string, string> CreateColumnCaptionMap()
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "LOT_NO", "LOT 번호" },
                { "WORK_ORDER_NO", "작업지시번호" },
                { "ITEM_CODE", "품목코드" },
                { "ITEM_NAME", "품목명" },
                { "CUSTOMER_CODE", "거래처코드" },
                { "CUSTOMER_NAME", "거래처명" },
                { "PROCESS_CODE", "공정코드" },
                { "PROCESS_NAME", "공정명" },
                { "INPUT_QTY", "투입수량" },
                { "GOOD_QTY", "양품수량" },
                { "NG_QTY", "불량수량" },
                { "DEFECT_CODE", "불량코드" },
                { "DEFECT_NAME", "불량명" },
                { "DEFECT_DETAIL_QTY", "불량상세수량" },
                { "DEFECT_REASON", "불량사유" },
                { "MATERIAL_CODE", "자재코드" },
                { "MATERIAL_NAME", "자재명" },
                { "MATERIAL_LOT_NO", "자재 LOT 번호" },
                { "USED_QTY", "자재사용수량" },
                { "UNIT", "단위" },
                { "SHIPMENT_NO", "출하번호" },
                { "SHIP_QTY", "출하수량" },
                { "LOT_STATUS", "LOT 상태" },
                { "START_DT", "생산시작일시" },
                { "END_DT", "생산종료일시" }
            };
        }
    }
}
