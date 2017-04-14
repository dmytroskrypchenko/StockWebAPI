namespace Stock.WebServices.Product
{
    using System.Collections.Generic;
    using BL.DtoEntities;
    using BL.Services.Abstract;
    using BL.Services.Concrete;

    public class ProductService : IProductService
    {
        private readonly IElectronicBookService _electronicBookService;
        private readonly ISmartWatchService _smartWatchService;
        private readonly IPhoneService _phoneService;

        public ProductService()
        {
            _smartWatchService = new SmartWatchService();
            _electronicBookService = new ElectronicBookService();
            _phoneService = new PhoneService();
        }

        public string GetData(int value)
        {
            return $"You entered: {value}";
        }

        public void AddPhone(PhoneDto phone)
        {
            _phoneService.Insert(phone);
        }

        public void AddElectronicBook(ElectronicBookDto electronicBook)
        {
            _electronicBookService.Insert(electronicBook);
        }

        public void AddSmartWatch(SmartWatchDto smartWatch)
        {
            _smartWatchService.Insert(smartWatch);
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            var phones = _phoneService.GetAll();
            var electronicBooks = _electronicBookService.GetAll();
            var smartWatches = _smartWatchService.GetAll();

            var productsDto = new List<ProductDto>();
            productsDto.AddRange(phones);
            productsDto.AddRange(electronicBooks);
            productsDto.AddRange(smartWatches);

            return productsDto;
        }
    }
}
