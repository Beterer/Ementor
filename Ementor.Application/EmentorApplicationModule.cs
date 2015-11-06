using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Ementor
{
    [DependsOn(typeof(EmentorCoreModule), typeof(AbpAutoMapperModule))]
    public class EmentorApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
