namespace Stock.Services.ScreenType
{
    using Autofac;

    public class Bootstrapper : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ScreenTypeService>();
            builder.RegisterType<BL.Services.Concrete.ScreenTypeService>().As<BL.Services.Abstract.IScreenTypeService>();
        }
    }
}