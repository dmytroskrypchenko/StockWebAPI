namespace Stock.Web
{
    using System.Reflection;
    using System.Web.Http;
    using Autofac;
    using Autofac.Integration.WebApi;
    using BL.Services.Abstract;
    using BL.Services.Concrete;
    using BL.DtoEntities;
    using BL.Mapper.Abstract;
    using BL.Mapper.Concrete;
    using DAL;
    using DAL.Infrastructure.Abstract;
    using DAL.Infrastructure.Concrete;
    using BL.Repositories.Abstract;
    using BL.Repositories.Concrete;

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

            builder.RegisterType<UnitOfWorkFactory>().As<IUnitOfWorkFactory>();

            builder.RegisterType<DataRepository>().As<IDataRepository>();

            builder.RegisterType<ConnectionTypeMapper>().As<IMapper<InterfaceForConnecting, InterfaceForConnectingDto>>();
            builder.RegisterType<ElectronicBookMapper>().As<IMapper<ElectronicBook, ElectronicBookDto >>();
            builder.RegisterType<ManufacturerMapper>().As<IMapper<Manufacturer, ManufacturerDto>>();
            builder.RegisterType<PhoneMapper>().As<IMapper<Phone, PhoneDto>>();
            builder.RegisterType<ScreenTypeMapper>().As<IMapper<ScreenType, ScreenTypeDto>>();
            builder.RegisterType<SmartWatchMapper>().As<IMapper<SmartWatch, SmartWatchDto>>();

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