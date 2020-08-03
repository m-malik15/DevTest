using System.Collections.Generic;
using DeveloperTest.Controllers;
using DeveloperTest.Data.Models;
using DeveloperTest.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;

namespace DeveloperTest.UnitTest
{
    public class CustomerTypeControllerTest
    {
        [Test]
        public void CustomerTypeController_Get_ReturnsListOfCustomerTypes()
        {
            // Arrange
            var customerTypes = new List<CustomerType>
            {
                new CustomerType() {CustomerTypeId = 1, Description = "Large"},
                new CustomerType() {CustomerTypeId = 2, Description = "Small"}
            };

            var mockCustomerTypeService = new Mock<ICustomerTypeService>();
            mockCustomerTypeService.Setup(x => x.GetCustomerTypes()).ReturnsAsync(customerTypes);

            // Act
            var controller = new CustomerTypeController(mockCustomerTypeService.Object);
            var result = controller.Get().Result as OkObjectResult;
            var model = (result.Value as List<CustomerType>);

            // Assert
            Assert.NotNull(model);
            Assert.AreEqual(2,model.Count);
        }
    }
}