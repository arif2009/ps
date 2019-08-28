using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Domain;
using PS.Manager;
using PS.Service;

namespace PS.Test
{
    public class TestBase
    {
        private IContainer _autofacContainer;
        protected IContainer AutofacContainer
        {
            get
            {
                if (_autofacContainer == null)
                {
                    var builder = new ContainerBuilder();

                    builder.RegisterType<UserRepository>().As<IUserRepository>();
                    builder.RegisterType<PetRepository>().As<IPetRepository>();
                    builder.RegisterType<TransRepository>().As<ITransRepository>();

                    builder.RegisterType<UserManager>().As<IUserManager>();
                    builder.RegisterType<PetManager>().As<IPetManager>();
                    builder.RegisterType<TransManager>().As<ITransManager>();

                    builder.RegisterType<RevenueService>().As<IRevenueService>();

                    var container = builder.Build();

                    _autofacContainer = container;
                }

                return _autofacContainer;
            }
        }

        protected IUserManager UserManager
        {
            get
            {
                return AutofacContainer.Resolve<IUserManager>();
            }
        }

        protected IPetManager PetManager
        {
            get
            {
                return AutofacContainer.Resolve<IPetManager>();
            }
        }

        protected IRevenueService RevenueService
        {
            get
            {
                return AutofacContainer.Resolve<IRevenueService>();
            }
        }

    }
}
