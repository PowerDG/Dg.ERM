using System.Threading.Tasks;
using Abp.Application.Services;
using DG.ERM.Sessions.Dto;

namespace DG.ERM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
