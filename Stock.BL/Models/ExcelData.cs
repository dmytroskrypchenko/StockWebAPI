namespace Stock.BL.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Enums;

    public class ExcelData<T> : IEnumerable
    {
        private readonly List<Dictionary<T, string>> _data;

        public List<T> ExistingColumns { get; private set; }

        public ExcelData(List<Dictionary<T, string>> data)
        {
            _data = data;
            if (Length == 0)
                throw new ArgumentException("Cannot create ExcelData with empty data", "data");
            ExistingColumns = data[0].Keys.ToList();
        }

        public int Length
        {
            get
            {
                return _data.Count;
            }
        }
        public string this[T columnName, int row]
        {
            get
            {
                if (row >= 0 && row <= Length)
                {
                    Dictionary<T, string> rowData = _data[row];
                    return SafeGetCellDataFromRow(rowData, columnName);
                }

                return null;
            }
        }
        public List<string> GetColumnValues(T column)
        {
           return _data.Select(row => SafeGetCellDataFromRow(row, column)).ToList();
        }

        public IEnumerator GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        private static string SafeGetCellDataFromRow(Dictionary<T, string> rowData, T columnName)
        {
            string result;
            return rowData.TryGetValue(columnName, out result) ? result : "";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var rows in _data)
            {
                foreach (var cell in rows)
                {
                    sb.Append(cell.Value).Append(", ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }

    public class PhoneExcelData : ExcelData<PhoneColumnNames>
    {
        public PhoneExcelData(List<Dictionary<PhoneColumnNames, string>> data) : base(data)
        {
        }
    }

    public class ElectronicBookExcelData : ExcelData<ElectronicBookColumnNames>
    {
        public ElectronicBookExcelData(List<Dictionary<ElectronicBookColumnNames, string>> data) : base(data)
        {
        }
    }

    public class SmartWatchExcelData : ExcelData<SmartWatchColumnNames>
    {
        public SmartWatchExcelData(List<Dictionary<SmartWatchColumnNames, string>> data) : base(data)
        {
        }
    }
}
