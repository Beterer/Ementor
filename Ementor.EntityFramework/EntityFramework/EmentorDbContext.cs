using System.Data.Common;
using Abp.Zero.EntityFramework;
using Ementor.Authorization.Roles;
using Ementor.MultiTenancy;
using Ementor.Users;
using Ementor.Classes;
using Ementor.Atendeees;
using System.Data.Entity;

namespace Ementor.EntityFramework
{
    public class EmentorDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public IDbSet<Class> Classes { get; set; }
        public IDbSet<Atendee> Atendees { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public EmentorDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in EmentorDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of EmentorDbContext since ABP automatically handles it.
         */
        public EmentorDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public EmentorDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
