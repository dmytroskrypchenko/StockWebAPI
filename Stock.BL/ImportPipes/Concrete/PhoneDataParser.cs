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

    public class PhoneDataParser : BasePipe<PhoneExcelData, List<PhoneDto>>
    {
        private StringParser<PhoneColumnNames> _nameParser;
        private PriceParser<PhoneColumnNames> _priceParser;
        private StringParser<PhoneColumnNames> _descriptionParser;
        private ManufacturerParser<PhoneColumnNames> _manufacturerParser;
        private IntParser<PhoneColumnNames> _ramParser;
        private IntParser<PhoneColumnNames> _romParser;
        private StringParser<PhoneColumnNames> _cpuParser;
        private IntParser<PhoneColumnNames> _batteryCapacityParser;
        private DoubleParser<PhoneColumnNames> _screenDiagonalParser;
        private DoubleParser<PhoneColumnNames> _cameraParser;
        private PhoneDto currentPhone;

        public PhoneDataParser(PhoneExcelData fileData, IDataRepository repository) : base(fileData)
        {
            _nameParser = new StringParser<PhoneColumnNames>(PhoneColumnNames.Name);
            _priceParser = new PriceParser<PhoneColumnNames>(PhoneColumnNames.Price);
            _descriptionParser = new StringParser<PhoneColumnNames>(PhoneColumnNames.Description);
            _manufacturerParser = new ManufacturerParser<PhoneColumnNames>(PhoneColumnNames.Manufacturer, repository);
            _ramParser = new IntParser<PhoneColumnNames>(PhoneColumnNames.RAM);
            _romParser = new IntParser<PhoneColumnNames>(PhoneColumnNames.ROM);
            _cpuParser = new StringParser<PhoneColumnNames>(PhoneColumnNames.CPU);
            _batteryCapacityParser = new IntParser<PhoneColumnNames>(PhoneColumnNames.BatteryCapacity);
            _screenDiagonalParser = new DoubleParser<PhoneColumnNames>(PhoneColumnNames.ScreenDiagonal);
            _cameraParser = new DoubleParser<PhoneColumnNames>(PhoneColumnNames.Camera);
        }

        public override List<PhoneDto> Process()
        {
            var result = new List<PhoneDto>();

            for (var i = 0; i < _inputData.Length; i++)
            {
                currentPhone = new PhoneDto();
                foreach (var column in _inputData.ExistingColumns)
                {
                    Parse(_inputData, column, i);
                }
                result.Add(currentPhone);
            }
            return result;
        }

        private void Parse(PhoneExcelData excelData, PhoneColumnNames column, int i)
        {
            switch (column)
            {
                case PhoneColumnNames.Name:
                    currentPhone.Name = _nameParser.TryParse(excelData, i);
                    break;
                case PhoneColumnNames.Price:
                    currentPhone.Price = _priceParser.TryParse(excelData, i);
                    break;
                case PhoneColumnNames.Description:
                    currentPhone.Description = _descriptionParser.TryParse(excelData, i);
                    break;
                case PhoneColumnNames.Manufacturer:
                    currentPhone.Manufacturer = new ManufacturerDto
                    {
                        Id = _manufacturerParser.TryParse(excelData, i)
                    };
                    break;
                case PhoneColumnNames.RAM:
                    currentPhone.RAM = _ramParser.TryParse(excelData, i);
                    break;
                case PhoneColumnNames.ROM:
                    currentPhone.ROM = _romParser.TryParse(excelData, i);
                    break;
                case PhoneColumnNames.CPU:
                    currentPhone.CPU = _cpuParser.TryParse(excelData, i);
                    break;
                case PhoneColumnNames.BatteryCapacity:
                    currentPhone.BatteryCapacity = _batteryCapacityParser.TryParse(excelData, i);
                    break;
                case PhoneColumnNames.ScreenDiagonal:
                    currentPhone.ScreenDiagonal = _screenDiagonalParser.TryParse(excelData, i);
                    break;
                case PhoneColumnNames.Camera:
                    currentPhone.Camera = _cameraParser.TryParse(excelData, i);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(column), column, null);
            }
        }
    }
}