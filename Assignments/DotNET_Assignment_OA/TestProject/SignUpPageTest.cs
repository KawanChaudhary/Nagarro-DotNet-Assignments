using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using ServiceLayer.Service.Interface;
using System.Threading.Tasks;
using WebApplication.Controllers;

namespace TestProject
{
    class SignUpPageTest
    {
        private Mock<ISignUpRepository> _mockRepo;
        private SignUpController controller;
        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<ISignUpRepository>();
            controller = new SignUpController(_mockRepo.Object);
        }

        [Test]
        public void SignUpPage_Test()
        {
            
            // Act
            ViewResult result = controller.SignUp() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task SignUp_AddsUserToDatabase()
        {
            // Arrange    
            var newUser = new SignUpUserModel { 
                FirstName = "Unit", 
                LastName = "Test", 
                Email = "unittest@go.com", 
                Password = "password123", 
                ConfirmPassword = "password123"
            };

            // Act
            _mockRepo.Setup(x => x.CreateUserAsync(newUser)).ReturnsAsync(IdentityResult.Success);
            IActionResult result = await controller.Signup(newUser);

            // Assert            
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IActionResult>(result);
            _mockRepo.Verify(x => x.CreateUserAsync(newUser), Times.Once);
        }
    }
}
