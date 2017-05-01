namespace Stock.BL.Repositories.Abstract
{
    using System.Collections.Generic;
    using DtoEntities;

    public interface IDataRepository
    {
        List<ManufacturerDto> Manufacturers { get; }
        List<InterfaceForConnectingDto> ConectionTypes { get; }
        List<ScreenTypeDto> ScreenTypes { get; }
    }
}