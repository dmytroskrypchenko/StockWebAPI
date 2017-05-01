namespace Stock.BL.ImportPipes.Concrete
{
    using System;
    using System.Collections.Generic;
    using ColumnParsers;
    using DtoEntities;
    using Enums;
    using Abstract;
    using Models;
    using Repositories.Abstract;

    public class SmartWatchDataParser : BasePipe<SmartWatchExcelData, List<SmartWatchDto>>
    {
        private StringParser<SmartWatchColumnNames> _nameParser;
        private PriceParser<SmartWatchColumnNames> _priceParser;
        private StringParser<SmartWatchColumnNames> _descriptionParser;
        private ManufacturerParser<SmartWatchColumnNames> _manufacturerParser;
        private ConnectionTypeParser<SmartWatchColumnNames> _connectionTypeParser;
        private DoubleParser<SmartWatchColumnNames> _screenDiagonalParser;
        private BoolParser<SmartWatchColumnNames> _pulsometerParser;
        private BoolParser<SmartWatchColumnNames> _simCardParser;
        private SmartWatchDto currentSmartWatch;

        public SmartWatchDataParser(SmartWatchExcelData fileData, IDataRepository repository) : base(fileData)
        {
            _nameParser = new StringParser<SmartWatchColumnNames>(SmartWatchColumnNames.Name);
            _priceParser = new PriceParser<SmartWatchColumnNames>(SmartWatchColumnNames.Price);
            _descriptionParser = new StringParser<SmartWatchColumnNames>(SmartWatchColumnNames.Description);
            _manufacturerParser = new ManufacturerParser<SmartWatchColumnNames>(SmartWatchColumnNames.Manufacturer, repository);
            _connectionTypeParser = new ConnectionTypeParser<SmartWatchColumnNames>(SmartWatchColumnNames.InterfaceForConnecting, repository);
            _screenDiagonalParser = new DoubleParser<SmartWatchColumnNames>(SmartWatchColumnNames.ScreenDiagonal);
            _pulsometerParser = new BoolParser<SmartWatchColumnNames>(SmartWatchColumnNames.Pulsometer);
            _simCardParser = new BoolParser<SmartWatchColumnNames>(SmartWatchColumnNames.SimCard);
        }

        public override List<SmartWatchDto> Process()
        {
            var result = new List<SmartWatchDto>();

            for (var i = 0; i < _inputData.Length; i++)
            {
                currentSmartWatch = new SmartWatchDto();
                foreach (var column in _inputData.ExistingColumns)
                {
                    Parse(_inputData, column, i);
                }
                result.Add(currentSmartWatch);
            }
            return result;
        }

        private void Parse(SmartWatchExcelData excelData, SmartWatchColumnNames column, int i)
        {
            switch (column)
            {
                case SmartWatchColumnNames.Name:
                    currentSmartWatch.Name = _nameParser.TryParse(excelData, i);
                    break;
                case SmartWatchColumnNames.Price:
                    currentSmartWatch.Price = _priceParser.TryParse(excelData, i);
                    break;
                case SmartWatchColumnNames.Description:
                    currentSmartWatch.Description = _descriptionParser.TryParse(excelData, i);
                    break;
                case SmartWatchColumnNames.Manufacturer:
                    currentSmartWatch.Manufacturer = new ManufacturerDto
                    {
                        Id = _manufacturerParser.TryParse(excelData, i)
                    };
                    break;
                case SmartWatchColumnNames.InterfaceForConnecting:
                    currentSmartWatch.InterfaceForConnecting = new InterfaceForConnectingDto { Id = _connectionTypeParser.TryParse(excelData, i) };
                    break;
                case SmartWatchColumnNames.ScreenDiagonal:
                    currentSmartWatch.ScreenDiagonal = _screenDiagonalParser.TryParse(excelData, i);
                    break;
                case SmartWatchColumnNames.Pulsometer:
                    currentSmartWatch.Pulsometer = _pulsometerParser.TryParse(excelData, i);
                    break;
                case SmartWatchColumnNames.SimCard:
                    currentSmartWatch.SimCard = _simCardParser.TryParse(excelData, i);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(column), column, null);
            }
        }
    }
}