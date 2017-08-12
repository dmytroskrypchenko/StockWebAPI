namespace Stock.Web.ApiControllers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using BL.Services.Abstract;

    public class ManufacturerController : ApiController
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var manufacturers = _manufacturerService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, manufacturers);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
