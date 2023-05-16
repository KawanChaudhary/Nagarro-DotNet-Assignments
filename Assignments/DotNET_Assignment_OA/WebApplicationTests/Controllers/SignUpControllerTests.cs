using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;
using ServiceLayer.Service.Interface;
using Moq;
using DomainLayer.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers.Tests
{
    [TestClass()]
    public class SignUpControllerTests
    {
        [TestMethod()]
        public async Task SignupTest()
        {
            var mockUserService = new Mock<ISignUpRepository>();

            SignUpController controller = new SignUpController(mockUserService.Object);

            var newUser = new SignUpUserModel { FirstName = "Unit", LastName = "Test", Email = "unittest@go.com", Password = "password123" };

            // Act
            IActionResult result = await controller.Signup(newUser);

            // Assert
            mockUserService.Verify(x => x.CreateUserAsync(newUser), Times.Once);
            Assert.IsInstanceOfType(result.GetType(), typeof(IActionResult));
        }
    }
}