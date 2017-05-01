namespace Stock.BL.ColumnParsers
{
    using System;
    using Models;
    using System.Linq;
    using Repositories.Abstract;

    public class ScreenTypeParser<TColumnName> : BaseParser<int, TColumnName> where TColumnName : struct
    {
        private readonly IDataRepository _repository;
        public ScreenTypeParser(TColumnName column, IDataRepository repository) : base(column)
        {
            _repository = repository;
        }

        protected override int Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];

            var screenType = _repository.ScreenTypes.FirstOrDefault(x => string.Equals(x.Name, data, StringComparison.OrdinalIgnoreCase));

            return screenType?.Id ?? 0;
        }
    }
}