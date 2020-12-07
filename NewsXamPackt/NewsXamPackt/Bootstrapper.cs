using Autofac;
using NewsXamPackt.ViewModels;

namespace NewsXamPackt
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<MainShell>();

            containerBuilder
                .RegisterAssemblyTypes(typeof(App).Assembly)
                .Where(x => x.IsSubclassOf(typeof(ViewModel)));

            var container = containerBuilder.Build();

            Resolver.Initialize(container);
        }
    }
}
