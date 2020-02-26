using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZCms.Authorization;

namespace ZCms
{
    [DependsOn(
        typeof(ZCmsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ZCmsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ZCmsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ZCmsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
