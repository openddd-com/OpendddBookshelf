using System.Threading.Tasks;
using Openddd.Configuration.Dto;

namespace Openddd.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
