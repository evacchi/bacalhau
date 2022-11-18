/* 
 * Bacalhau API
 *
 * This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: team@bacalhau.org
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

using bacalhau-client.Client;
using bacalhau-client.Api;
using bacalhau-client.Model;

namespace bacalhau-client.Test
{
    /// <summary>
    ///  Class for testing JobApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class JobApiTests
    {
        private JobApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new JobApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JobApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' JobApi
            //Assert.IsInstanceOfType(typeof(JobApi), instance, "instance is a JobApi");
        }

        /// <summary>
        /// Test PkgapiServerSubmit
        /// </summary>
        [Test]
        public void PkgapiServerSubmitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicapiSubmitRequest body = null;
            //var response = instance.PkgapiServerSubmit(body);
            //Assert.IsInstanceOf<PublicapiSubmitResponse> (response, "response is PublicapiSubmitResponse");
        }
        /// <summary>
        /// Test PkgpublicapiList
        /// </summary>
        [Test]
        public void PkgpublicapiListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicapiListRequest body = null;
            //var response = instance.PkgpublicapiList(body);
            //Assert.IsInstanceOf<PublicapiListResponse> (response, "response is PublicapiListResponse");
        }
        /// <summary>
        /// Test Pkgpublicapievents
        /// </summary>
        [Test]
        public void PkgpublicapieventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicapiEventsRequest body = null;
            //var response = instance.Pkgpublicapievents(body);
            //Assert.IsInstanceOf<PublicapiEventsResponse> (response, "response is PublicapiEventsResponse");
        }
        /// <summary>
        /// Test PkgpublicapilocalEvents
        /// </summary>
        [Test]
        public void PkgpublicapilocalEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicapiLocalEventsRequest body = null;
            //var response = instance.PkgpublicapilocalEvents(body);
            //Assert.IsInstanceOf<PublicapiLocalEventsResponse> (response, "response is PublicapiLocalEventsResponse");
        }
        /// <summary>
        /// Test Pkgpublicapiresults
        /// </summary>
        [Test]
        public void PkgpublicapiresultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicapiStateRequest body = null;
            //var response = instance.Pkgpublicapiresults(body);
            //Assert.IsInstanceOf<PublicapiResultsResponse> (response, "response is PublicapiResultsResponse");
        }
        /// <summary>
        /// Test Pkgpublicapistates
        /// </summary>
        [Test]
        public void PkgpublicapistatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicapiStateRequest body = null;
            //var response = instance.Pkgpublicapistates(body);
            //Assert.IsInstanceOf<PublicapiStateResponse> (response, "response is PublicapiStateResponse");
        }
    }

}
