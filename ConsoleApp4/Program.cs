using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void Main(string[] args)
        { }
        string BaseUrl = "http://localhost:8080";
        [Test]
        public void API_Get_Method()
        {
            //open API Url
            RestClient client = new RestClient(BaseUrl);
            RestRequest request = new RestRequest("/BillingOrder", Method.GET);
            //Execute the request
            var response = client.Execute(request);
            TestContext.WriteLine("Headers :" + response.Headers);
            TestContext.WriteLine("StatusCode: " + response.StatusCode);
            TestContext.WriteLine("ResponseCode :" + response.Content);
        }
        [Test]
        public void API_Post_Method()
        {
            //open API Url
            RestClient client = new RestClient(BaseUrl);
            RestRequest request = new RestRequest("/BillingOrder", Method.POST);
            //Add the new detail in Json format
            string JsonRequest = @"{ ""addressLine1"": ""14"",""addressLine2"": ""street"",""city"": ""wlg"",""comment"": ""sdh"",""email"": ""shar@gmail.com"",""firstName"": ""raj"",""id"": 0,""itemNumber"": 0,""lastName"": ""shar"",""phone"": ""6789012345"", ""state"": ""AL"",""zipCode"": ""456789""}";
            //Requesting to add Jsonbody
            request.AddJsonBody(JsonRequest);
            //Execute the Post method and print status
            var response = client.Execute(request);
            TestContext.WriteLine("Headers :" + response.Headers);
            TestContext.WriteLine("StatusCode: " + response.StatusCode);
            TestContext.WriteLine("ResponseCode :" + response.Content);
        }
        [Test]
        public void API_PUT_Method()
        {
            //open API Url
            RestClient client = new RestClient(BaseUrl);
            RestRequest request = new RestRequest("/BillingOrder/3", Method.PUT);
            //Update the id
            string JsonRequest= @"{ ""addressLine1"": ""50"",""addressLine2"": ""street"",""city"": ""wlg"",""comment"": ""sdh"",""email"": ""shar@gmail.com"",""firstName"": ""raj"",""id"": 0,""itemNumber"": 0,""lastName"": ""shar"",""phone"": ""6789012345"", ""state"": ""AL"",""zipCode"": ""456789""}";
            request.AddJsonBody(JsonRequest);
            // Execute the Post method and print status
            var response = client.Execute(request);
            TestContext.WriteLine("Headers :" + response.Headers);
            TestContext.WriteLine("StatusCode: " + response.StatusCode);
            TestContext.WriteLine("ResponseCode :" + response.Content);
        }
        [Test]
        public void API_DELETE_Method()
        {
            //open API Url
            RestClient client = new RestClient(BaseUrl);
            RestRequest request = new RestRequest("/BillingOrder/3", Method.DELETE);
            string JsonBody = @"{ ""addressLine1"": ""50"",""addressLine2"": ""street"",""city"": ""wlg"",""comment"": ""sdh"",""email"": ""shar@gmail.com"",""firstName"": ""raj"",""id"": 0,""itemNumber"": 0,""lastName"": ""shar"",""phone"": ""6789012345"", ""state"": ""AL"",""zipCode"": ""456789""}";
            
            var response = client.Execute(request);
            // Execute the Post method and print status
            //Delete the id in billing order
            TestContext.WriteLine("Headers :" + response.Headers);
            TestContext.WriteLine("StatusCode: " + response.StatusCode);
            TestContext.WriteLine("ResponseCode :" + response.Content);
        }
    }
}

