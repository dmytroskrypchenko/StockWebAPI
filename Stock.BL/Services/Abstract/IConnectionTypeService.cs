namespace Stock.BL.Services.Abstract
{
    using DtoEntities;
    using DAL;

    public interface IConnectionTypeService : IBaseService<InterfaceForConnecting, InterfaceForConnectingDto>
    {
    }
}
