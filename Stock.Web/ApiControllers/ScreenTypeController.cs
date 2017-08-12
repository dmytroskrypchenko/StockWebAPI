namespace Stock.Web.ApiControllers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using BL.Services.Abstract;

    public class ScreenTypeController : ApiController
    {
        private readonly IScreenTypeService _screenTypeService;

        public ScreenTypeController(IScreenTypeService screenTypeService)
        {
            _screenTypeService = screenTypeService;
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var screenTypes = _screenTypeService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, screenTypes);
            }
            catch (Exception ex)
            {

               return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
