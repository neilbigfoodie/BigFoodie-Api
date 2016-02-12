using System;
using System.Configuration;
using BigFoodie.DataAccess.EntityFramework;
using BigFoodie.DataAccess.Repository.Base;
using BigFoodie.Meals.Service;
using Ninject;
using Ninject.Web.Common;
using Ninject.Extensions.Conventions;

namespace BigFoodie.Api
{
    public static class NinjectKernal
    {

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            try
            {
                RegisterServices(kernel);
                return kernel;
            }
            catch (Exception)
            {
                kernel.Dispose();

                throw;
            }

        }

        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IEfRepository>()
                .To<EfRepository>()
                .InRequestScope()
                .WithConstructorArgument("context", ctx => new BFDbContext("BFDbContext"));

            kernel.Bind<IAdoRepository>()
               .To<AdoRepository>()
               .InRequestScope()
               .WithConstructorArgument("connString", ctx => ConfigurationManager.ConnectionStrings["BFDbContext"].ToString());

          //  kernel.Bind<IDisconnectedActionRepository>()
          //.To<DisconnectedActionRepository>()
          //.InRequestScope()
          //.WithConstructorArgument("context", ctx => new ApiContext("ApiContext"));

            kernel.Bind(x => x.FromAssemblyContaining(typeof(EfRepository))
                .SelectAllClasses()
                .NotInNamespaceOf(typeof(EfRepository))
                .BindAllInterfaces()
                .Configure(b => b.InRequestScope()));

            kernel.Bind(x => x.FromThisAssembly()
                .SelectAllClasses()
                .BindAllInterfaces()
                .Configure(b => b.InRequestScope()));

            kernel.Bind(x => x.FromAssemblyContaining(typeof(MealsService))
                .SelectAllClasses()
                .BindAllInterfaces()
                .Configure(b => b.InRequestScope()));
        }
    }
}