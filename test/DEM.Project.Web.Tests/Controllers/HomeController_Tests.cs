using System.Threading.Tasks;
using DEM.Project.Models.TokenAuth;
using DEM.Project.Web.Controllers;
using Shouldly;
using Xunit;

namespace DEM.Project.Web.Tests.Controllers
{
    public class HomeController_Tests: ProjectWebTestBase
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