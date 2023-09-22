/*
 * GroupBy Retail
 *
 * GroupBy Retail API
 *
 * The version of the OpenAPI document: 0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using GroupByInc.RetailApi.Client.Client;
using GroupByInc.RetailApi.Client.Api;
// uncomment below to import models
//using GroupByInc.RetailApi.Client.Model;

namespace GroupByInc.RetailApi.Client.Test.Api
{
    /// <summary>
    ///  Class for testing ProductApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductApiTests : IDisposable
    {
        private ProductApi instance;

        public ProductApiTests()
        {
            instance = new ProductApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductApi
            //Assert.IsType<ProductApi>(instance);
        }

        /// <summary>
        /// Test GetByProductIds
        /// </summary>
        [Fact]
        public void GetByProductIdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collection = null;
            //string productId = null;
            //string xGroupbyCustomerId = null;
            //List<string>? variantIds = null;
            //var response = instance.GetByProductIds(collection, productId, xGroupbyCustomerId, variantIds);
            //Assert.IsType<ProductDto>(response);
        }
    }
}
