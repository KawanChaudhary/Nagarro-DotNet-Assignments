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
    public class SignInPageTest
    {
        private SignInController controller;
        private SignInUserModel userModel;
        private Mock<ISignInRepository> _mockRepo;
        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<ISignInRepository>();
            controller = new SignInController(_mockRepo.Object);
            userModel = new SignInUserModel();
        }

        [Test]
        public void SignInPage_Test()
        {

            // Act
            ViewResult result = controller.SignIn() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        /*
        [Test]
         public void SignIn_TestValidSignIn()
         {

             // Arrange            
             userModel.Email = "data@go.com";
             userModel.Password = "datago";
             userModel.RememberMe = false;

             // Act

             _mockRepo.Setup(x => x.PasswordSignInAsync(userModel)).ReturnsAsync(Microsoft.AspNetCore.Identity.SignInResult.Success);

             var result = controller.SignIn(userModel).Result as ViewResult;

             // Assert
             Assert.IsNull(result);
             _mockRepo.Verify(x => x.PasswordSignInAsync(userModel), Times.Once);
         }

         [Test]
         public void SignIn_TestInvalidSignIn()
         {            
             // Arrange
             userModel.Email = "data@go.com";
             userModel.Password = "datago123";
             userModel.RememberMe = false;

             // Act

             _mockRepo.Setup(x => x.PasswordSignInAsync(userModel)).ReturnsAsync(Microsoft.AspNetCore.Identity.SignInResult.Failed);

             var result = controller.SignIn(userModel).Result as ViewResult;

             // Assert
             Assert.IsNotNull(result);
             _mockRepo.Verify(x => x.PasswordSignInAsync(userModel), Times.Once);
         }
     }
 */
    }
 }