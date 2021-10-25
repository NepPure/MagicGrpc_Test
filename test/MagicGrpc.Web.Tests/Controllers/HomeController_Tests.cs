using System.Threading.Tasks;
using MagicGrpc.Web.Controllers;
using Shouldly;
using Xunit;

namespace MagicGrpc.Web.Tests.Controllers
{
    public class HomeController_Tests: MagicGrpcWebTestBase
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
