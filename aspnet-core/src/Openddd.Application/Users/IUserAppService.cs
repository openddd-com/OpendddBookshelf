using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Openddd.Roles.Dto;
using Openddd.Users.Dto;

namespace Openddd.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
