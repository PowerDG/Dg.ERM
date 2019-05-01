using System.Threading.Tasks;
using Dg.ERM.Web.Controllers;
using Shouldly;
using Xunit;

namespace Dg.ERM.Web.Tests.Controllers
{
    public class HomeController_Tests: ERMWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
