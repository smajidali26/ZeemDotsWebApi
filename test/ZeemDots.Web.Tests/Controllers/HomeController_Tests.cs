using System.Threading.Tasks;
using ZeemDots.Models.TokenAuth;
using ZeemDots.Web.Controllers;
using Shouldly;
using Xunit;

namespace ZeemDots.Web.Tests.Controllers
{
    public class HomeController_Tests: ZeemDotsWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}