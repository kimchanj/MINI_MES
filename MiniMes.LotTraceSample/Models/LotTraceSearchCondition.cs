using System;

namespace MiniMes.LotTraceSample.Models
{
    public class LotTraceSearchCondition
    {
        public string LotNo { get; set; }

        public string WorkOrderNo { get; set; }

        public string ItemCode { get; set; }

        public string ProcessCode { get; set; }

        public string CustomerCode { get; set; }

        public string ShipmentNo { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
    }
}
