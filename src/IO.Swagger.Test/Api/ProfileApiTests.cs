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
    ///  Class for testing ProfileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProfileApiTests
    {
        private ProfileApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProfileApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProfileApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProfileApi
            //Assert.IsInstanceOfType(typeof(ProfileApi), instance, "instance is a ProfileApi");
        }

        
        /// <summary>
        /// Test RestV1BalanceGet
        /// </summary>
        [Test]
        public void RestV1BalanceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RestV1BalanceGet();
            //Assert.IsInstanceOf<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test RestV1UserLockupCodeCodePost
        /// </summary>
        [Test]
        public void RestV1UserLockupCodeCodePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string code = null;
            //instance.RestV1UserLockupCodeCodePost(code);
            
        }
        
    }

}