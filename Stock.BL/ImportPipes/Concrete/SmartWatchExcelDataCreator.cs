namespace Stock.BL.ImportPipes.Concrete
{
    using System.Collections.Generic;
    using System.IO;
    using DtoEntities;
    using Enums;
    using Models;

    public class SmartWatchExcelDataCreator : ExcelDataCreator<SmartWatchColumnNames, SmartWatchExcelData>
    {
        public SmartWatchExcelDataCreator(FileDto file) : base(new MemoryStream(file.FileByteStream))
        {
            FileName = file.FileName;
        }

        protected override string FileName { get; }
        protected override string WorksheetName => "SmartWatches";
        protected override SmartWatchColumnNames MainColumn => SmartWatchColumnNames.Name;
        protected override SmartWatchExcelData CreateNewResult(List<Dictionary<SmartWatchColumnNames, string>> data)
        {
            return new SmartWatchExcelData(data);
        }

        protected override List<ColumnMapping<SmartWatchColumnNames>> GetAllColumnDetails()
        {
            return new List<ColumnMapping<SmartWatchColumnNames>>
            {
                new ColumnMapping<SmartWatchColumnNames> (SmartWatchColumnNames.Name, "Name"),
                new ColumnMapping<SmartWatchColumnNames>(SmartWatchColumnNames.Price, "Price"),
                new ColumnMapping<SmartWatchColumnNames>(SmartWatchColumnNames.Description, "Description"),
                new ColumnMapping<SmartWatchColumnNames>(SmartWatchColumnNames.Manufacturer, "Manufacturer"),
                new ColumnMapping<SmartWatchColumnNames>(SmartWatchColumnNames.InterfaceForConnecting, "Interface For Connecting"),
                new ColumnMapping<SmartWatchColumnNames>(SmartWatchColumnNames.ScreenDiagonal, "Screen Diagonal"),
                new ColumnMapping<SmartWatchColumnNames>(SmartWatchColumnNames.Pulsometer, "Pulsometer"),
                new ColumnMapping<SmartWatchColumnNames>(SmartWatchColumnNames.SimCard, "Sim Card")
            };
        }
    }
}