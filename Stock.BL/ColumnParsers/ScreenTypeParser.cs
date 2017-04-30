namespace Stock.BL.ColumnParsers
{
    using Models;
    using System.Linq;
    using System.Collections.Generic;
    using DtoEntities;

    public class ScreenTypeParser<TColumnName> : BaseParser<int, TColumnName> where TColumnName : struct
    {
        private readonly IEnumerable<ScreenTypeDto> _screenTypes;
        public ScreenTypeParser(TColumnName column, IEnumerable<ScreenTypeDto> screenTypes) : base(column)
        {
            _screenTypes = screenTypes;
        }

        protected override int Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];

            var screenType = _screenTypes.FirstOrDefault(x => x.Name == data);

            return screenType?.Id ?? 0;
        }
    }
}