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

        protected IUserRepository UserRepository
        {
            get
            {
                return AutofacContainer.Resolve<IUserRepository>();
            } 
        }

        protected IPetRepository PetRepository
        {
            get
            {
                return AutofacContainer.Resolve<IPetRepository>();
            }
        }

        protected ITransRepository TransRepository
        {
            get
            {
                return AutofacContainer.Resolve<ITransRepository>();
            }
        }

        protected IPetManager PetManager
        {
            get
            {
                return AutofacContainer.Resolve<IPetManager>();
            }
        }

    }
}
