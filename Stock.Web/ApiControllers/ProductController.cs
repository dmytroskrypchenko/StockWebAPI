using Stock.BL.Repositories.Abstract;

namespace Stock.Web.ApiControllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using BL.DtoEntities;
    using BL.Repositories.Concrete;
    using BL.Services.Abstract;

    public class ProductController : ApiController
    {
        private readonly Lazy<IPhoneService> _phoneService;
        private readonly Lazy<ISmartWatchService> _smartWatchService;
        private readonly Lazy<IElectronicBookService> _electronicBookService;
        private readonly IDataRepository _dataRepository;

        public ProductController(IPhoneService phoneService, ISmartWatchService smartWatchService,
            IElectronicBookService electronicBookService, IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;

            _phoneService = new Lazy<IPhoneService>(() => phoneService);
            _smartWatchService = new Lazy<ISmartWatchService>(() => smartWatchService);
            _electronicBookService = new Lazy<IElectronicBookService>(() => electronicBookService);
        }

        [HttpPut]
        public HttpResponseMessage AddProduct(PhoneDto phone)
        {
            try
            {
                if (phone != null)
                {
                    _phoneService.Value.Insert(phone);
                    return Request.CreateResponse(HttpStatusCode.OK, "Ok");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Model is not valid");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage AddProduct(ElectronicBookDto electronicBook)
        {
            try
            {
                if (electronicBook != null)
                {
                    _electronicBookService.Value.Insert(electronicBook);
                    return Request.CreateResponse(HttpStatusCode.OK, "Ok");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Model is not valid");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage AddProduct(SmartWatchDto smartWatch)
        {
            try
            {
                if (smartWatch != null)
                {
                    _smartWatchService.Value.Insert(smartWatch);
                    return Request.CreateResponse(HttpStatusCode.OK, "Ok");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Model is not valid");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage AddProducts(List<ProductDto> products)
        {
            try
            {
                if (products != null && products.Count > 0)
                {
                    _phoneService.Value.Insert(products.OfType<PhoneDto>());
                    _electronicBookService.Value.Insert(products.OfType<ElectronicBookDto>());
                    _smartWatchService.Value.Insert(products.OfType<SmartWatchDto>());
                    return Request.CreateResponse(HttpStatusCode.OK, "Ok");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Model is not valid");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage ImportProducts(FileDto file)
        {
            try
            {
                if (file != null)
                {
                    _phoneService.Value.Import(_dataRepository, file);
                    _electronicBookService.Value.Import(_dataRepository, file);
                    _smartWatchService.Value.Import(_dataRepository, file);
                    return Request.CreateResponse(HttpStatusCode.OK, "Ok");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "File is not valid");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetPhonesForManufacturer(int idManufacturer, string orderDirection, string orderBy)
        {
            try
            {
                var phones = _phoneService.Value.GetForManufacturer(idManufacturer, orderDirection, orderBy);
                return Request.CreateResponse(HttpStatusCode.OK, phones);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetSmartWatchesForManufacturer(int idManufacturer)
        {
            try
            {
                var smartWatches = _smartWatchService.Value.GetForManufacturer(idManufacturer);
                return Request.CreateResponse(HttpStatusCode.OK, smartWatches);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetElectronicBooksForManufacturer(int idManufacturer)
        {
            try
            {
                var electronicBooks = _electronicBookService.Value.GetForManufacturer(idManufacturer);
                return Request.CreateResponse(HttpStatusCode.OK, electronicBooks);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        public HttpResponseMessage GetAllProducts()
        {
            try
            {
                var phones = _phoneService.Value.GetAll();
                var electronicBooks = _electronicBookService.Value.GetAll();
                var smartWatches = _smartWatchService.Value.GetAll();

                var productsDto = new List<ProductDto>();
                productsDto.AddRange(phones);
                productsDto.AddRange(electronicBooks);
                productsDto.AddRange(smartWatches);

                return Request.CreateResponse(HttpStatusCode.OK, productsDto);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
