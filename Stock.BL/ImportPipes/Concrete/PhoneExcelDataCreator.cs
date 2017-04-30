namespace Stock.BL.ImportPipes.Concrete
{
    using System.Collections.Generic;
    using System.IO;
    using DtoEntities;
    using Enums;
    using Models;

    public class PhoneExcelDataCreator : ExcelDataCreator<PhoneColumnNames, PhoneExcelData>
    {
        public PhoneExcelDataCreator(FileDto file) : base(new MemoryStream(file.FileByteStream))
        {
            FileName = file.FileName;
        }

        protected override string FileName { get; }
        protected override string WorksheetName => "Phones";
        protected override PhoneColumnNames MainColumn => PhoneColumnNames.Name;
        protected override PhoneExcelData CreateNewResult(List<Dictionary<PhoneColumnNames, string>> data)
        {
            return new PhoneExcelData(data);
        }

        protected override List<ColumnMapping<PhoneColumnNames>> GetAllColumnDetails()
        {
            return new List<ColumnMapping<PhoneColumnNames>>
            {
                new ColumnMapping<PhoneColumnNames> (PhoneColumnNames.Name, "Name"),
                new ColumnMapping<PhoneColumnNames>(PhoneColumnNames.Price, "Price"),
                new ColumnMapping<PhoneColumnNames>(PhoneColumnNames.Description, "Description"),
                new ColumnMapping<PhoneColumnNames>(PhoneColumnNames.Manufacturer, "Manufacturer"),
                new ColumnMapping<PhoneColumnNames>(PhoneColumnNames.RAM, "RAM"),
                new ColumnMapping<PhoneColumnNames>(PhoneColumnNames.ROM, "ROM"),
                new ColumnMapping<PhoneColumnNames>(PhoneColumnNames.CPU, "CPU"),
                new ColumnMapping<PhoneColumnNames>(PhoneColumnNames.BatteryCapacity, "Battery Capacity"),
                new ColumnMapping<PhoneColumnNames>(PhoneColumnNames.ScreenDiagonal, "Screen Diagonal"),
                new ColumnMapping<PhoneColumnNames>(PhoneColumnNames.Camera, "Camera")
            };
        }
    }
}