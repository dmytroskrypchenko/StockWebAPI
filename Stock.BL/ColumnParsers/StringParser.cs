namespace Stock.BL.ColumnParsers
{
    using Models;

    public class StringParser<TColumnName> : BaseParser<string, TColumnName> where TColumnName : struct
    {
        public StringParser(TColumnName column) : base(column)
        {
        }
        protected override string Parse(ExcelData<TColumnName> excelData, int i)
        {
            return excelData.GetColumnValues(column)[i];
        }
    }
}