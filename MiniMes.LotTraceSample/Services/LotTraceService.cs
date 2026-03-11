using System;
using System.Data;
using MiniMes.LotTraceSample.Data;
using MiniMes.LotTraceSample.Models;
using MiniMes.LotTraceSample.Utils;
using Oracle.ManagedDataAccess.Client;

namespace MiniMes.LotTraceSample.Services
{
    public class LotTraceService
    {
        private readonly OracleDbService _oracleDbService;

        public LotTraceService()
            : this(new OracleDbService())
        {
        }

        public LotTraceService(OracleDbService oracleDbService)
        {
            _oracleDbService = oracleDbService ?? throw new ArgumentNullException(nameof(oracleDbService));
        }

        public DataTable GetLotTraceList(LotTraceSearchCondition condition)
        {
            if (condition == null)
            {
                throw new ArgumentNullException(nameof(condition));
            }

            return _oracleDbService.ExecuteRefCursorProcedure(
                "SP_SEARCH_LOT_TRACE",
                parameters =>
                {
                    parameters.Add("P_LOT_NO", OracleDbType.Varchar2).Value = DBNullHelper.ToDbValue(condition.LotNo);
                    parameters.Add("P_WORK_ORDER_NO", OracleDbType.Varchar2).Value = DBNullHelper.ToDbValue(condition.WorkOrderNo);
                    parameters.Add("P_ITEM_CODE", OracleDbType.Varchar2).Value = DBNullHelper.ToDbValue(condition.ItemCode);
                    parameters.Add("P_PROCESS_CODE", OracleDbType.Varchar2).Value = DBNullHelper.ToDbValue(condition.ProcessCode);
                    parameters.Add("P_CUSTOMER_CODE", OracleDbType.Varchar2).Value = DBNullHelper.ToDbValue(condition.CustomerCode);
                    parameters.Add("P_SHIPMENT_NO", OracleDbType.Varchar2).Value = DBNullHelper.ToDbValue(condition.ShipmentNo);
                    parameters.Add("P_DATE_FROM", OracleDbType.Date).Value = DBNullHelper.ToDbValue(condition.DateFrom);
                    parameters.Add("P_DATE_TO", OracleDbType.Date).Value = DBNullHelper.ToDbValue(condition.DateTo);

                    OracleParameter resultParameter = parameters.Add("P_RESULT", OracleDbType.RefCursor);
                    resultParameter.Direction = ParameterDirection.Output;
                });
        }
    }
}
