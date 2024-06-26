using System;
using System.Data;

namespace EmployeeClock.Utils
{
    internal class ConverterUtils
    {
        public static string GetByKey(DataRow row, string key)
        {
            return row[key].ToString();
        }
    }
}
