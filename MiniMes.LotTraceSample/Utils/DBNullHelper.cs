using System;

namespace MiniMes.LotTraceSample.Utils
{
    public static class DBNullHelper
    {
        public static object ToDbValue(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? DBNull.Value : (object)value.Trim();
        }

        public static object ToDbValue(DateTime? value)
        {
            return value.HasValue ? (object)value.Value : DBNull.Value;
        }
    }
}
