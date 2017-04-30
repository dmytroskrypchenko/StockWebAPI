namespace Stock.BL.ColumnParsers
{
    using Models;

    public class PriceParser<TColumnName> : BaseParser<decimal?, TColumnName> where TColumnName : struct
    {
        public PriceParser(TColumnName column) : base(column)
        {
        }

        protected override decimal? Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];
            decimal value;

            if (!decimal.TryParse(data, out value) || value < 0)
            {
                return null;
            }
            return value;
        }
    }
}