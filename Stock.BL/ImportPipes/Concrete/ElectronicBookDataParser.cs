namespace Stock.BL.ImportPipes.Concrete
{
    using System;
    using System.Collections.Generic;
    using ColumnParsers;
    using DtoEntities;
    using Enums;
    using Abstract;
    using Models;

    public class ElectronicBookDataParser : BasePipe<ElectronicBookExcelData, List<ElectronicBookDto>>
    {
        private ElectronicBookExcelData _fileData;
        private StringParser<ElectronicBookColumnNames> _nameParser;
        private PriceParser<ElectronicBookColumnNames> _priceParser;
        private StringParser<ElectronicBookColumnNames> _descriptionParser;
        private ManufacturerParser<ElectronicBookColumnNames> _manufacturerParser;
        private DoubleParser<ElectronicBookColumnNames> _screenDiagonalParser;
        private ScreenTypeParser<ElectronicBookColumnNames> _screenTypeParser;
        private IntParser<ElectronicBookColumnNames> _batteryCapacityParser;
        private StringParser<ElectronicBookColumnNames> _workingTimeParser;
        private ElectronicBookDto currentElectronicBook;

        public ElectronicBookDataParser(ElectronicBookExcelData fileData) : base(fileData)
        {
            _nameParser = new StringParser<ElectronicBookColumnNames>(ElectronicBookColumnNames.Name);
            _priceParser = new PriceParser<ElectronicBookColumnNames>(ElectronicBookColumnNames.Price);
            _descriptionParser = new StringParser<ElectronicBookColumnNames>(ElectronicBookColumnNames.Description);
            //_manufacturerParser =
            //    new ManufacturerParser<ElectronicBookColumnNames>(ElectronicBookColumnNames.Manufacturer, );
            _screenDiagonalParser = new DoubleParser<ElectronicBookColumnNames>(ElectronicBookColumnNames.ScreenDiagonal);
            //_screenTypeParser = new ScreenTypeParser<ElectronicBookColumnNames>(ElectronicBookColumnNames.ScreenType, );
            _batteryCapacityParser = new IntParser<ElectronicBookColumnNames>(ElectronicBookColumnNames.BatteryCapacity);
            _workingTimeParser = new StringParser<ElectronicBookColumnNames>(ElectronicBookColumnNames.WorkingTime);
        }

        public override List<ElectronicBookDto> Process()
        {
            var result = new List<ElectronicBookDto>();

            for (var i = 0; i < _fileData.Length; i++)
            {
                currentElectronicBook = new ElectronicBookDto();
                foreach (var column in _fileData.ExistingColumns)
                {
                    Parse(_fileData, column, i);
                }
                result.Add(currentElectronicBook);
            }
            return result;
        }

        private void Parse(ElectronicBookExcelData excelData, ElectronicBookColumnNames column, int i)
        {
            switch (column)
            {
                case ElectronicBookColumnNames.Name:
                    currentElectronicBook.Name = _nameParser.TryParse(excelData, i);
                    break;
                case ElectronicBookColumnNames.Price:
                    currentElectronicBook.Price = _priceParser.TryParse(excelData, i);
                    break;
                case ElectronicBookColumnNames.Description:
                    currentElectronicBook.Description = _descriptionParser.TryParse(excelData, i);
                    break;
                case ElectronicBookColumnNames.Manufacturer:
                    currentElectronicBook.Manufacturer = new ManufacturerDto
                    {
                        Id = _manufacturerParser.TryParse(excelData, i)
                    };
                    break;
                case ElectronicBookColumnNames.ScreenDiagonal:
                    currentElectronicBook.ScreenDiagonal = _screenDiagonalParser.TryParse(excelData, i);
                    break;
                case ElectronicBookColumnNames.ScreenType:
                    currentElectronicBook.ScreenType = new ScreenTypeDto
                    {
                        Id = _screenTypeParser.TryParse(excelData, i)
                    };
                    break;
                case ElectronicBookColumnNames.BatteryCapacity:
                    currentElectronicBook.BatteryCapacity = _batteryCapacityParser.TryParse(excelData, i);
                    break;
                case ElectronicBookColumnNames.WorkingTime:
                    currentElectronicBook.WorkingTime = _workingTimeParser.TryParse(excelData, i);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(column), column, null);
            }
        }
    }
}