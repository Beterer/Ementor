using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Ementor.EntityFramework;

namespace Ementor
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(EmentorCoreModule))]
    public class EmentorDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
