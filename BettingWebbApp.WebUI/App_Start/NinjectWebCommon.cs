[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BettingWebbApp.WebUI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(BettingWebbApp.WebUI.App_Start.NinjectWebCommon), "Stop")]

namespace BettingWebbApp.WebUI.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    using BettingWebbApp.Domain.Abstract;
    using BettingWebbApp.Domain.Concrete;
    using BettingWebbApp.Domain.Entities;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IBettingRepository>().To<BettingRepository>();
            //Mock<IBettingRepository> mock = new Mock<IBettingRepository>();
            //mock.Setup(m => m.bettings).Returns(new List<Betting>
            //{
            //    new Betting {Name="Chelsea vs Man Utd", Odd = 3, Description="EPL match involving two giants", Amount= 100, Category="EPL"},
            //    new Betting {Name="Inter Vs AC", Odd = 6, Description="Serie-A match involving two giants in italy", Amount= 200, Category="SERIA A"},
            //    new Betting {Name="Barca vs Madrid", Odd = 3, Description="Liga match involving two giants in paris", Amount= 10000, Category="Liga"}
            //});

            //kernel.Bind<IBettingRepository>().ToConstant(mock.Object);
        }       
    }
}
