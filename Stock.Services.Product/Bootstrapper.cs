namespace Stock.Services.Product
{
    using Autofac;

    public class Bootstrapper : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>();
            builder.RegisterType<BL.Services.Concrete.PhoneService>().As<BL.Services.Abstract.IPhoneService>();
            builder.RegisterType<BL.Services.Concrete.ElectronicBookService>().As<BL.Services.Abstract.IElectronicBookService>();
            builder.RegisterType<BL.Services.Concrete.SmartWatchService>().As<BL.Services.Abstract.ISmartWatchService>();
        }
    }
}