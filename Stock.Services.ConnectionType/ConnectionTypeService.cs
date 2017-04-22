namespace Stock.Services.ConnectionType
{
    using System.Collections.Generic;
    using BL.DtoEntities;
    
    public class ConnectionTypeService : IConnectionTypeService
    {
        private readonly BL.Services.Abstract.IConnectionTypeService _connectionTypeService;

        public ConnectionTypeService()
        {
            _connectionTypeService = new BL.Services.Concrete.ConnectionTypeService();
        }

        public IEnumerable<InterfaceForConnectingDto> GetAll()
        {
            return _connectionTypeService.GetAll();
        }
    }
}
