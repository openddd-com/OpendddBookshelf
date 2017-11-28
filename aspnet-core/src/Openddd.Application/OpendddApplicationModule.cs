using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Openddd.Authorization;

namespace Openddd
{
    [DependsOn(
        typeof(OpendddCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OpendddApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OpendddAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OpendddApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
