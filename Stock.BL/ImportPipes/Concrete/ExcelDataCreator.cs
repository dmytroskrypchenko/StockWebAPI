namespace Stock.BL.ImportPipes.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using OfficeOpenXml;
    using OfficeOpenXml.FormulaParsing;
    using Abstract;
    using Models;

    public abstract class ExcelDataCreator<T, TOut> : BasePipe<Stream, TOut>
        where TOut : ExcelData<T>
        where T : struct
    {
        protected readonly Dictionary<T, int> columnIndices;
        private ExcelRange cells;
        private const int excelStartIndex = 1;
        private const int headerLength = 1;

        protected ExcelDataCreator(Stream dataStream)
            : base(dataStream)
        {
            columnIndices = new Dictionary<T, int>();
            
        }
        protected abstract string FileName { get;}
        protected abstract string WorksheetName { get; }
        protected abstract T MainColumn { get; }
        protected abstract TOut CreateNewResult(List<Dictionary<T, string>> data);

        public override TOut Process()
        {
            using (var package = new ExcelPackage(_inputData))
            {
                cells = GetCells(package);
                SeekForHeader();
                int rowCount = GetRowCountAndCheckRowStructure();
                return TransferDataFromCellToContainer(rowCount);
            }
        }

        protected abstract List<ColumnMapping<T>> GetAllColumnDetails();

        protected bool IsValueExistInMainCell(int row)
        {
            var cglIndicator = columnIndices[MainColumn];
            return string.IsNullOrWhiteSpace(GetCell(row, cglIndicator));
        }
        private void SeekForHeader()
        {
            var columnDetails = GetAllColumnDetails();

            var counter = 0;

            while (counter++ < 50)
            {
                var data = GetCell(excelStartIndex, counter);

                if (string.IsNullOrWhiteSpace(data))
                    continue;

                var columnDetail = columnDetails.Find(e => e.ColumnRealName == data);

                if (columnDetail == null)
                {
                    continue;
                }

                columnDetails.Remove(columnDetail);
                columnIndices.Add(columnDetail.Column, counter);
            }
        }

        private int GetRowCountAndCheckRowStructure()
        {
            var startIndex = excelStartIndex + headerLength;
            var counter = startIndex;

            do
            {
                counter++;
            } while (!IsValueExistInMainCell(counter));

            if (!IsValueExistInMainCell(counter + 1) ||
                 !IsValueExistInMainCell(counter + 2) ||
                 !IsValueExistInMainCell(counter + 3))
            {
                //importLogger.AddError(FileName + " file structure is incorrect. Please check that there are no empty rows.", new ExcelRowInfo(-1));
            }

            return counter - excelStartIndex;
        }

        private TOut TransferDataFromCellToContainer(int rowCount)
        {
            int i = headerLength;
            try
            {
                var data = new List<Dictionary<T, string>>(rowCount);

                for (; i < rowCount; i++)
                {
                    data.Add(new Dictionary<T, string>());
                    foreach (var columnIndex in columnIndices)
                    {
                        var value = GetCell(i + excelStartIndex, columnIndex.Value);
                        data[i - 1].Add(columnIndex.Key, value.Trim() ?? "");
                    }
                }

                return CreateNewResult(data);
            }
            catch (Exception)
            {
                //importLogger.AddError("TransferDataFromCellToContainer error.", new ExcelRowInfo(i));
                return null;
            }
        }


        protected virtual ExcelRange GetCells(ExcelPackage package)
        {
            var targetSheet = package.Workbook.Worksheets.FirstOrDefault(e => e.Name == WorksheetName);
            if (targetSheet == null)
            {
                //importLogger.AddError(FileName + " file structure is incorrect. Required \"Details\" tab missing.", new ExcelFileInfo());
            }
            targetSheet.Calculate(new ExcelCalculationOption());
            return targetSheet.Cells;
        }

        protected string GetCell(int rowNumber, int columnNumber)
        {
            try
            {
                object value = cells[rowNumber, columnNumber].Value;
                if (value == null)
                    return "";
                string parsedValue = value.ToString();

                return string.IsNullOrWhiteSpace(parsedValue) ? "" : value.ToString();
            }
            catch (Exception)
            {
                //importLogger.AddError($"Unexpected Error! Can not get excel cell value from column: {columnNumber}.", new ExcelRowInfo(rowNumber));
                return null;
            }
        }
    }
}