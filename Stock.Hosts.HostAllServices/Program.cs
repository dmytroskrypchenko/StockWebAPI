namespace Stock.Hosts.HostAllServices
{
    using System;
    using System.ServiceModel;
    using Autofac.Integration.Wcf;
    using Services.ConnectionType;
    using Services.Manufacturer;
    using Services.Product;
    using Services.ScreenType;
    class Program
    {
        private static ServiceHost manufacturerServiceHost;
        private static ServiceHost screenTypeServiceHost;
        private static ServiceHost connectionTypeServiceHost;
        private static ServiceHost productServiceHost;

        static void Main()
        {
            var container = Bootstrapper.BuildContainer();
            
            Console.WriteLine("ServiceHost");
            try
            {
                manufacturerServiceHost = new ServiceHost(typeof(ManufacturerService));
                manufacturerServiceHost.AddDependencyInjectionBehavior<ManufacturerService>(container);
                manufacturerServiceHost.Open();

                screenTypeServiceHost = new ServiceHost(typeof(ScreenTypeService));
                screenTypeServiceHost.AddDependencyInjectionBehavior<ScreenTypeService>(container);
                screenTypeServiceHost.Open();

                connectionTypeServiceHost = new ServiceHost(typeof(ConnectionTypeService));
                connectionTypeServiceHost.AddDependencyInjectionBehavior<ConnectionTypeService>(container);
                connectionTypeServiceHost.Open();

                productServiceHost = new ServiceHost(typeof(ProductService));
                productServiceHost.AddDependencyInjectionBehavior<ProductService>(container);
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
