namespace Stock.BL.ColumnParsers
{
    using System;
    using Models;
    using System.Linq;
    using Repositories.Abstract;

    public class ConnectionTypeParser<TColumnName> : BaseParser<int, TColumnName> where TColumnName : struct
    {
        private readonly IDataRepository _repository;
        public ConnectionTypeParser(TColumnName column, IDataRepository repository) : base(column)
        {
            _repository = repository;
        }

        protected override int Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];

            var connectionType = _repository.ConectionTypes.FirstOrDefault(x => string.Equals(x.Name, data, StringComparison.OrdinalIgnoreCase));

            return connectionType?.Id ?? 0;
        }
    }
}