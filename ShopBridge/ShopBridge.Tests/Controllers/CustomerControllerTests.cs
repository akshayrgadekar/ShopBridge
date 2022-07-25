using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopBridge.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopBridgeBAL;
using System.Threading.Tasks;
using System.Net;

namespace ShopBridge.Controllers.Tests
{
    [TestClass()]
    public class CustomerControllerTests
    {
        ICustomer _customer;
        CustomerController controller;
        [TestInitialize()]
        public void Initialize()
        {
            _customer = new Customer();
            controller = new CustomerController(_customer);
        }

        [TestMethod()]
        public void GetAllCustomerTest()
        {
            // Arrange
            controller = new CustomerController(_customer);

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [TestMethod()]
        public void GetCustomerTest()
        {
            // Arrange
            controller = new CustomerController(_customer);

            // Act
            var result = controller.Get(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [TestMethod()]
        public void PostTest()
        {
            controller = new CustomerController(_customer);

            // Act
            var result = controller.Post(new Customer() { custfname = "Mark", custlname = "Smith" });

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [TestMethod()]
        public void PutTest()
        {
            controller = new CustomerController(_customer);

            // Act
            var result = controller.Put(5236, new Customer() { custfname = "Mark", custlname = "Smith" });

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            controller = new CustomerController(_customer);

            // Act
            var result = controller.Delete(5236);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(HttpStatusCode.OK, result.StatusCode);
        }
    }
}