namespace Stock.Hosts.HostAllServices
{
    using Autofac;
    using Services.ConnectionType;
    using Services.ScreenType;
    using Services.Manufacturer;
    using Services.Product;

    public static class Bootstrapper
    {
        /// <summary>
        /// Configures and builds Autofac IOC container.
        /// </summary>
        /// <returns></returns>
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // register services
            builder.RegisterType<ManufacturerService>();
            builder.RegisterType<ScreenTypeService>();
            builder.RegisterType<ConnectionTypeService>();
            builder.RegisterType<ProductService>();

            // register dependencies
            builder.RegisterType<BL.Services.Concrete.ManufacturerService>().As<BL.Services.Abstract.IManufacturerService>();
            builder.RegisterType<BL.Services.Concrete.ScreenTypeService>().As<BL.Services.Abstract.IScreenTypeService>();
            builder.RegisterType<BL.Services.Concrete.ConnectionTypeService>().As<BL.Services.Abstract.IConnectionTypeService>();
            builder.RegisterType<BL.Services.Concrete.PhoneService>().As<BL.Services.Abstract.IPhoneService>();
            builder.RegisterType<BL.Services.Concrete.ElectronicBookService>().As<BL.Services.Abstract.IElectronicBookService>();
            builder.RegisterType<BL.Services.Concrete.SmartWatchService>().As<BL.Services.Abstract.ISmartWatchService>();

            // build container
            return builder.Build();
        }
    }
}