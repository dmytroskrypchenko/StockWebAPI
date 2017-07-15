namespace Stock.Hosts.HostAllServices
{
    using Autofac;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    public static class Bootstrapper
    {
        public static IContainer BuildContainer(IEnumerable<Assembly> assemblies)
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(assemblies.ToArray());

            return builder.Build();
        }
    }
}