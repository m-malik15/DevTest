using System;
using System.Collections.Generic;
using System.Text;
using DeveloperTest.Controllers;
using DeveloperTest.Data.Models;
using DeveloperTest.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace DeveloperTest.UnitTest
{
    class JobControllerTest
    {
       
        [Test]
        public void JobController_GetById_ReturnsNotFoundResultWhenNoMatchFoundOnId()
        {
            // Arrange

            var mockJobService = new Mock<IJobService>();
            mockJobService.Setup(x => x.GetJob(It.IsAny<int>())).ReturnsAsync((Job)null);

            // Act
            var controller = new JobController(mockJobService.Object);
            var result = controller.Get(100).Result;

            //Assert

            Assert.IsInstanceOf<NotFoundResult>(result);
            Assert.IsNotInstanceOf<OkObjectResult>(result);


        }

        [Test]
        public void JobController_Create_ReturnsBadRequestIfJobDateIsLessThanToday()
        {
            // Arrange

            var mockJobService = new Mock<IJobService>();

            var jobToCreate = new Job()
            {
                CustomerId = 1,
                EngineerId = 2,
                When = DateTime.Now.AddDays(-1)
            };

            // Act
            var controller = new JobController(mockJobService.Object);
            var result = controller.Create(jobToCreate).Result;

            //Assert

            Assert.IsInstanceOf<BadRequestObjectResult>(result);
            Assert.IsNotInstanceOf<OkObjectResult>(result);
            Assert.NotNull(result);
            var value = (result as BadRequestObjectResult).Value;
            Assert.AreEqual("Date cannot be in the past", value);

        }
    }
}
