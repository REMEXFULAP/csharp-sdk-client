/* 
 * REMESITA API REST
 *
 * Api de remesita.com para desarrolladores. Primero obten tu apiKey y apiSecret, y para autenticarte debes ejecutar el endpoint rest/v1/auth en la respuesta obtendrás un token de acceso que debes usar en el resto de peticiones
 *
 * OpenAPI spec version: 1.0.0
 * 
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
    ///  Class for testing PrepaidCardsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PrepaidCardsApiTests
    {
        private PrepaidCardsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PrepaidCardsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PrepaidCardsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PrepaidCardsApi
            //Assert.IsInstanceOfType(typeof(PrepaidCardsApi), instance, "instance is a PrepaidCardsApi");
        }

        
        /// <summary>
        /// Test RestV1CardNumberTogglePost
        /// </summary>
        [Test]
        public void RestV1CardNumberTogglePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string number = null;
            //var response = instance.RestV1CardNumberTogglePost(number);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test RestV1CardNumberTransactionsPgPgSizeGet
        /// </summary>
        [Test]
        public void RestV1CardNumberTransactionsPgPgSizeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string number = null;
            //int? pg = null;
            //int? pgSize = null;
            //var response = instance.RestV1CardNumberTransactionsPgPgSizeGet(number, pg, pgSize);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test RestV1CardTransferBetweenPost
        /// </summary>
        [Test]
        public void RestV1CardTransferBetweenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body body = null;
            //var response = instance.RestV1CardTransferBetweenPost(body);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test RestV1CardsGet
        /// </summary>
        [Test]
        public void RestV1CardsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RestV1CardsGet();
            //Assert.IsInstanceOf<InlineResponse2004> (response, "response is InlineResponse2004");
        }
        
    }

}
