namespace Stock.BL.ColumnParsers
{
    using Models;
    using System.Linq;
    using System.Collections.Generic;
    using DtoEntities;

    public class ManufacturerParser<TColumnName> : BaseParser<int, TColumnName> where TColumnName : struct
    {
        private readonly IEnumerable<ManufacturerDto> _manufacturers;
        public ManufacturerParser(TColumnName column, IEnumerable<ManufacturerDto> manufacturers) : base(column)
        {
            _manufacturers = manufacturers;
        }

        protected override int Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];

            var manufacturer = _manufacturers.FirstOrDefault(x => x.Name == data);

            return manufacturer?.Id ?? 0;
        }
    }
}