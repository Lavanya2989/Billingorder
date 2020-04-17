using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApp4
{
    [Binding]
       public class APITestsSteps
    {
        RestClient restclient;
        RestRequest req;
        IRestResponse response;
        string JsonRequest = @"{ ""addressLine1"": ""14"",""addressLine2"": ""street"",""city"": ""wlg"",""comment"": ""sdh"",""email"": ""shar@gmail.com"",""firstName"": ""raj"",""id"": 0,""itemNumber"": 0,""lastName"": ""shar"",""phone"": ""6789012345"", ""state"": ""AL"",""zipCode"": ""456789""}";

        [Given(@"I have correct billing order")]
        public void GivenIHaveCorrectBillingOrder()
        {
            RestClient client = new RestClient("http://localhost:8080");
        }

        [When(@"I send this order to API via Post request")]
        public void WhenISendThisOrderToAPIViaPostRequest()
        {
            req = new RestRequest("/BillingOrder", Method.POST);
            req.AddJsonBody(JsonRequest);
            response = restclient.Execute(req);
        }

        [Then(@"Receive response with correct http address")]
        public void ThenReceiveResponseWithCorrectHttpAddress()
        {
            TestContext.WriteLine("ResponseCode :" + response.Content);
        }
    }
}
