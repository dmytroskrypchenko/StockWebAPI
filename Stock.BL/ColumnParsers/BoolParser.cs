namespace Stock.BL.ColumnParsers
{
    using Models;

    public class BoolParser<TColumnName> : BaseParser<bool?, TColumnName> where TColumnName : struct
    {
        public BoolParser(TColumnName column) : base(column)
        {
        }

        protected override bool? Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];
            bool value;

            if (!bool.TryParse(data, out value))
            {
                return null;
            }
            return value;
        }
    }
}