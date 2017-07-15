namespace Stock.Hosts.HostAllServices
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.ServiceModel;
    using System.Linq;
    using System.Reflection;
    using Autofac.Integration.Wcf;

    class Program
    {
        static void Main()
        {
            var assemblies = GetAssemblies();
            
            var types = assemblies
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.IsClass && type.GetInterfaces().Any(y => y.IsDefined(typeof(ServiceContractAttribute))))
                .ToList();

            var container = Bootstrapper.BuildContainer(assemblies);

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

        private static List<Assembly> GetAssemblies()
        {
            var currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (currentPath == null)
            {
                throw new NullReferenceException("Unable to build the container because currentPath variable is null.");
            }

            var libFolder = new DirectoryInfo(currentPath);
            var libFiles = libFolder.GetFiles("Stock.Services*.dll", SearchOption.TopDirectoryOnly);
            return libFiles.Select(lib => Assembly.LoadFrom(lib.FullName)).ToList();
        }
    }
}
