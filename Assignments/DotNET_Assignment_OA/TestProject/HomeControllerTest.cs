using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using WebApplication.Controllers;

namespace TestProject
{
    class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
