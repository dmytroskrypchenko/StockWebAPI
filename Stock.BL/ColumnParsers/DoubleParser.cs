namespace Stock.BL.ColumnParsers
{
    using Models;

    public class DoubleParser<TColumnName> : BaseParser<double?, TColumnName> where TColumnName : struct
    {
        public DoubleParser(TColumnName column) : base(column)
        {
        }

        protected override double? Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];
            double value;

            if (!double.TryParse(data, out value) || value < 0)
            {
                return null;
            }
            return value;
        }
    }
}