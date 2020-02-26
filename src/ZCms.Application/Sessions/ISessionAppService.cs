using System.Threading.Tasks;
using Abp.Application.Services;
using ZCms.Sessions.Dto;

namespace ZCms.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
