namespace Stock.BL.ImportPipes.Concrete
{
    using System.Collections.Generic;
    using System.IO;
    using DtoEntities;
    using Enums;
    using Models;

    public class ElectronicBookExcelDataCreator : ExcelDataCreator<ElectronicBookColumnNames, ElectronicBookExcelData>
    {
        public ElectronicBookExcelDataCreator(FileDto file) : base(new MemoryStream(file.FileByteStream))
        {
            FileName = file.FileName;
        }

        protected override string FileName { get; }
        protected override string WorksheetName => "ElectronicBooks";
        protected override ElectronicBookColumnNames MainColumn => ElectronicBookColumnNames.Name;
        protected override ElectronicBookExcelData CreateNewResult(List<Dictionary<ElectronicBookColumnNames, string>> data)
        {
            return new ElectronicBookExcelData(data);
        }

        protected override List<ColumnMapping<ElectronicBookColumnNames>> GetAllColumnDetails()
        {
            return new List<ColumnMapping<ElectronicBookColumnNames>>
            {
                new ColumnMapping<ElectronicBookColumnNames> (ElectronicBookColumnNames.Name, "Name"),
                new ColumnMapping<ElectronicBookColumnNames>(ElectronicBookColumnNames.Price, "Price"),
                new ColumnMapping<ElectronicBookColumnNames>(ElectronicBookColumnNames.Description, "Description"),
                new ColumnMapping<ElectronicBookColumnNames>(ElectronicBookColumnNames.Manufacturer, "Manufacturer"),
                new ColumnMapping<ElectronicBookColumnNames>(ElectronicBookColumnNames.ScreenDiagonal, "Screen Diagonal"),
                new ColumnMapping<ElectronicBookColumnNames>(ElectronicBookColumnNames.ScreenType, "Screen Type"),
                new ColumnMapping<ElectronicBookColumnNames>(ElectronicBookColumnNames.BatteryCapacity, "Battery Capacity"),
                new ColumnMapping<ElectronicBookColumnNames>(ElectronicBookColumnNames.WorkingTime, "Working Time")
            };
        }
    }
}