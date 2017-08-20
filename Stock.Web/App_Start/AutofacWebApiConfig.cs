namespace Stock.Web
{
    using System.Reflection;
    using System.Web.Http;
    using Autofac;
    using Autofac.Integration.WebApi;
    using BL.Services.Abstract;
    using BL.Services.Concrete;

    public class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }
        
        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<ConnectionTypeService>().As<IConnectionTypeService>();
            builder.RegisterType<ManufacturerService>().As<IManufacturerService>();
            builder.RegisterType<PhoneService>().As<IPhoneService>();
            builder.RegisterType<ElectronicBookService>().As<IElectronicBookService>();
            builder.RegisterType<SmartWatchService>().As<ISmartWatchService>();
            builder.RegisterType<ScreenTypeService>().As<IScreenTypeService>();

            Container = builder.Build();

            return Container;
        }
    }
}