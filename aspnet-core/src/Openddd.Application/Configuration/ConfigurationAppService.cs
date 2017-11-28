using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Openddd.Configuration.Dto;

namespace Openddd.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OpendddAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
