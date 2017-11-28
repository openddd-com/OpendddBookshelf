using System.Threading.Tasks;
using Abp.Application.Services;
using Openddd.Sessions.Dto;

namespace Openddd.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
