using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Stock.Services.ConnectionType;
using Stock.Services.Manufacturer;
using Stock.Services.Product;
using Stock.Services.ScreenType;

namespace Stock.Hosts.HostAllServices
{
    class Program
    {
        private static ServiceHost manufacturerServiceHost;
        private static ServiceHost screenTypeServiceHost;
        private static ServiceHost connectionTypeServiceHost;
        private static ServiceHost productServiceHost;

        static void Main(string[] args)
        {
            Console.WriteLine("ServiceHost");
            try
            {
                manufacturerServiceHost = new ServiceHost(typeof(ManufacturerService));
                manufacturerServiceHost.Open();

                screenTypeServiceHost = new ServiceHost(typeof(ScreenTypeService));
                screenTypeServiceHost.Open();

                connectionTypeServiceHost = new ServiceHost(typeof(ConnectionTypeService));
                connectionTypeServiceHost.Open();

                productServiceHost = new ServiceHost(typeof(ProductService));
                productServiceHost.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Started");
            Console.ReadKey();
        }
    }
}
