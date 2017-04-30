namespace Stock.BL.ColumnParsers
{
    using Models;
    using System.Linq;
    using System.Collections.Generic;
    using DtoEntities;

    public class ConnectionTypeParser<TColumnName> : BaseParser<int, TColumnName> where TColumnName : struct
    {
        private readonly IEnumerable<InterfaceForConnectingDto> _connectionTypes;
        public ConnectionTypeParser(TColumnName column, IEnumerable<InterfaceForConnectingDto> connectionTypes) : base(column)
        {
            _connectionTypes = connectionTypes;
        }

        protected override int Parse(ExcelData<TColumnName> excelData, int i)
        {
            string data = excelData.GetColumnValues(column)[i];

            var connectionType = _connectionTypes.FirstOrDefault(x => x.Name == data);

            return connectionType?.Id ?? 0;
        }
    }
}