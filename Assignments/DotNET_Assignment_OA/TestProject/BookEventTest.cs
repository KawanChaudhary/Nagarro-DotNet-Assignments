using DomainLayer.Models;
using DomainLayer.OtherFiles;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using WebApplication.Controllers;

namespace TestProject
{
    class BookEventTest
    {
        private Mock<IBookEventService> _mockRepo;


        private BookController controller;

        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IBookEventService>();
            /*controller = new BookController(_mockRepo.Object);*/
        }

        [Test]
        public void AddBookEvent_PageTest()
        {
            //Act
            var result = controller.Book() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void AddBookEvent_TestValidEvent()
        {
            // Arrange
            var title = "Book Launch Event";
            var description = "Join us for the launch of our new book!";
            var location = "Delhi";
            var date = new DateTime(2023, 6, 1, 0, 0, 0);
            var startTime = new DateTime(0001, 01, 01, 5, 30, 0);
            var duration = 3;
            var type = EventType.Public;
            var newEvent = new EventViewModel()
            {
                EventDetails = new BookEventModel()
                {
                    Title = title,
                    Description = description,
                    Location = location,
                    Date = date,
                    StartTime = startTime,
                    Duration = duration,
                    Type = type
                }
            };


            // Act
            _mockRepo.Setup(x => x.AddNewBookEvent(newEvent));

            var result = controller.AddNewEvent(newEvent).Result as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            _mockRepo.Verify(x => x.AddNewBookEvent(newEvent), Times.Once());
        }

        [Test]
        public void TestAddBookEvent_InvalidEvent()
        {
            // Arrange
            var title = "";
            var description = "Join us for the launch of our new book!";
            var location = "Delhi";
            var date = new DateTime(2023, 6, 1, 0, 0, 0);
            var startTime = new DateTime(0001, 01, 01, 5, 30, 0);
            var duration = 3;
            var type = EventType.Public;
            var newEvent = new EventViewModel()
            {
                EventDetails = new BookEventModel()
                {
                    Title = title,
                    Description = description,
                    Location = location,
                    Date = date,
                    StartTime = startTime,
                    Duration = duration,
                    Type = type
                }
            };

            // Act
            _mockRepo.Setup(x => x.AddNewBookEvent(newEvent));

            var result = controller.AddNewEvent(newEvent).Result as ViewResult;

            // Assert
            Assert.IsNull(result);
        }
    }
}
