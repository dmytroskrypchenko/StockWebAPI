namespace Stock.BL.ColumnParsers
{
    using System;
    using Models;
    using System.Linq;
    using Repositories.Abstract;

    public class ManufacturerParser<TColumnName> : BaseParser<int, TColumnName> where TColumnName : struct
    {
        private readonly IDataRepository _repository;
        public ManufacturerParser(TColumnName column, IDataRepository repository) : base(column)
        {
            _repository = repository;
        }

        protected override int Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];

            var manufacturer = _repository.Manufacturers.FirstOrDefault(x => string.Equals(x.Name, data, StringComparison.OrdinalIgnoreCase));

            return manufacturer?.Id ?? 0;
        }
    }
}