using System.Threading.Tasks;
using DG.ERM.Configuration.Dto;

namespace DG.ERM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
