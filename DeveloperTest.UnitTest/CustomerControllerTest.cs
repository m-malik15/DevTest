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
    class CustomerControllerTest
    {
       
        [Test]
        public void CustomerController_GetById_ReturnsNotFoundResultWhenNoMatchFoundOnId()
        {
            // Arrange

            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(x => x.GetCustomerById(It.IsAny<int>())).ReturnsAsync((Customer)null);

            // Act
            var controller = new CustomerController(mockCustomerService.Object);
            var result = controller.Get(100).Result;

            //Assert

            Assert.IsInstanceOf<NotFoundResult>(result);
            Assert.IsNotInstanceOf<OkObjectResult>(result);


        }

        
    }
}
