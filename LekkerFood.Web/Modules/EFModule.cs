using Autofac.Integration.Mvc;
using Autofac;
using System.Reflection;
using System.Linq;
using LekkerFood.Repository.Interfaces;
using LekkerFood.Repository;
using System.Data.Entity;

namespace LekkerFood.Modules
{

    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(LekkerDbContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();

        }

    }
}