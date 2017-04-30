namespace Stock.BL.ColumnParsers
{
    using Models;

    public class IntParser<TColumnName> : BaseParser<int?, TColumnName> where TColumnName : struct
    {
        public IntParser(TColumnName column) : base(column)
        {
        }

        protected override int? Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];
            int value;

            if (!int.TryParse(data, out value) || value < 0)
            {
                return null;
            }
            return value;
        }
    }
}