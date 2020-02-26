using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ZCms.Configuration.Dto;

namespace ZCms.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ZCmsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
