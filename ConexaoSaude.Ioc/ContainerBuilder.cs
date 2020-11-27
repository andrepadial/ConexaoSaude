using System;
using ConexaoSaude.App.Interfaces;
using ConexaoSaude.Repositorios;
using ConexaoSaude.Repositorios.Interfaces;
using ConexaoSaude.Services.Interfaces;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace ConexaoSaude.Ioc
{
    public class ContainerBuilder
    {
        private static Container _container;

        static ContainerBuilder() => CreateContainer();

        public static T ObterInstancia<T>()
           where T : class =>
           _container.GetInstance<T>();

        public static Container Container() => _container;

        private static void CreateContainer()
        {
            _container = new Container();
            _container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            RegisterApplications();
            RegisterServices();
            RegisterRepositories();
            RegisterProxys();
        }

        private static void RegisterApplications()
        {
            _container.Register<IClienteApp, ClienteApp>(Lifestyle.Scoped);            
        }

        private static void RegisterServices()
        {
            _container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);            
        }

        private static void RegisterRepositories()
        {
            _container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Scoped);            
        }

        private static void RegisterProxys()
        {            
        }

    }
}
