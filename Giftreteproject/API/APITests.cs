using System;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using RestSharp;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FluentAssertions.Execution;

using System.Text;
using NUnit.Framework;

namespace Giftreteproject.API
{
    class APITests
    {
     public void APITestMethod1()
        {
            var client = new RestClient("http://bpdts-test-app-v2.herokuapp.com/swagger.json");
            
          var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            string errorMessage = response.ErrorMessage.ToString();
           // Assert.IsTrue(APITestMethod1,OK );
        
        
        
        
        }
    
    
    
    
    
    
    }
}
