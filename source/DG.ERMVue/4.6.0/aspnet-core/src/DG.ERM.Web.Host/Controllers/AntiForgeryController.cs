using Microsoft.AspNetCore.Antiforgery;
using DG.ERM.Controllers;

namespace DG.ERM.Web.Host.Controllers
{
    public class AntiForgeryController : ERMControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
