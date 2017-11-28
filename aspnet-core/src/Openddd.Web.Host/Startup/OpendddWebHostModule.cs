using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Openddd.Configuration;

namespace Openddd.Web.Host.Startup
{
    [DependsOn(
       typeof(OpendddWebCoreModule))]
    public class OpendddWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OpendddWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OpendddWebHostModule).GetAssembly());
        }
    }
}
