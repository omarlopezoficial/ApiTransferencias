/* 
 * Swagger Petstore
 *
 * This is a sample Petstore server.  You can find  out more about Swagger at  [http://swagger.io](http://swagger.io) or on  [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing StoreApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StoreApiTests
    {
        private StoreApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StoreApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StoreApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StoreApi
            //Assert.IsInstanceOfType(typeof(StoreApi), instance, "instance is a StoreApi");
        }

        
        /// <summary>
        /// Test DeleteOrder
        /// </summary>
        [Test]
        public void DeleteOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? orderId = null;
            //instance.DeleteOrder(orderId);
            
        }
        
        /// <summary>
        /// Test GetInventory
        /// </summary>
        [Test]
        public void GetInventoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetInventory();
            //Assert.IsInstanceOf<Dictionary<string, int?>> (response, "response is Dictionary<string, int?>");
        }
        
        /// <summary>
        /// Test GetOrderById
        /// </summary>
        [Test]
        public void GetOrderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? orderId = null;
            //var response = instance.GetOrderById(orderId);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test PlaceOrder
        /// </summary>
        [Test]
        public void PlaceOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Order body = null;
            //var response = instance.PlaceOrder(body);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
    }

}
