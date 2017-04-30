namespace Stock.BL.ColumnParsers
{
    using System;
    using Models;

    public abstract class BaseParser<T, TColumnName> where TColumnName : struct
    {
        protected TColumnName column;
        
        protected BaseParser(TColumnName column)
        {
            this.column = column;
        }

        private bool ValidateCell(ExcelData<TColumnName> excelData, int i)
        {
            if (string.IsNullOrWhiteSpace(excelData.GetColumnValues(column)[i]) ||
                excelData.GetColumnValues(column)[i].Equals("ERROR", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }

            return true;
        }

        public T TryParse(ExcelData<TColumnName> excelData, int i)
        {
            if (ValidateCell(excelData, i))
                return Parse(excelData, i);

            return default(T);
        }

        protected abstract T Parse(ExcelData<TColumnName> excelData, int i);
    }
}