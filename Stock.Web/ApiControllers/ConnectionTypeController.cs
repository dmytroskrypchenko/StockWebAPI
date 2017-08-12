namespace Stock.Web.ApiControllers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using BL.Services.Abstract;

    public class ConnectionTypeController : ApiController
    {
        private readonly IConnectionTypeService _connectionTypeService;

        public ConnectionTypeController(IConnectionTypeService connectionTypeService)
        {
            _connectionTypeService = connectionTypeService;
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var connectionTypes = _connectionTypeService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, connectionTypes);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
