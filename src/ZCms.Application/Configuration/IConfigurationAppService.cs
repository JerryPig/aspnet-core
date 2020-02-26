using System.Threading.Tasks;
using ZCms.Configuration.Dto;

namespace ZCms.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
