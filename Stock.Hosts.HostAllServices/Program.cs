namespace Stock.Hosts.HostAllServices
{
    using System;
    using System.ServiceModel;
    using System.Linq;
    using System.Reflection;
    using Autofac.Integration.Wcf;

    class Program
    {
        static void Main()
        {
            var container = Bootstrapper.BuildContainer();

            var types = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(assembly => assembly.GetTypes())
                     .Where(type =>
                             type.IsClass && type.GetInterfaces().Any(y => y.IsDefined(typeof(ServiceContractAttribute))) &&
                             type.Namespace != null && type.Namespace.StartsWith("Stock.Services")).ToList();

            Console.WriteLine("ServiceHost");
            try
            {
                foreach (var type in types)
                {
                    var serviceHost = new ServiceHost(type);
                    serviceHost.AddDependencyInjectionBehavior(type, container);
                    serviceHost.Open();
                }
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
