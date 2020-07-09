using System;
using Giftreteproject.PageObject;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Threading;
using NUnit.Framework;

namespace Giftreteproject.Test.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {

    

           Registrationpage registrationpage;
          public RegistrationSteps()
          {
        registrationpage = new Registrationpage();
           }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            registrationpage.NavigateToWebsite(url);
        }
        [When(@"I click on register")]
        public void WhenIClickOnRegister()
        {
            registrationpage.ClickOnRegister();
        }
        
        [When(@"I enter my First Name ""(.*)""")]
        public void WhenIEnterMyFirstName(string firstnameText)
        {
            Thread.Sleep(5000);
            registrationpage.EnterFirstName(firstnameText);
        }
        
        [When(@"I enter my Last Name ""(.*)""")]
        public void WhenIEnterMyLastName(string lastnameText)
        {
            registrationpage.EnterLastName(lastnameText);
        }
        
        [When(@"I enter my Email Address ""(.*)""")]
        public void WhenIEnterMyEmailAddress(string emailText)
        {
            registrationpage.EnterEmail(emailText);
        }
        
        [When(@"I click on dropdown to select country code")]
        public void WhenIClickOnDropdownToSelectCountryCode()
        {
            registrationpage.ClickOnCountryCode();
        }
        
        [When(@"I select Country")]
        public void WhenISelectCountry()
        {
            registrationpage.ClickOnCountry();
        }
        
        [When(@"I enter my Mobile ""(.*)""")]
        public void WhenIEnterMyMobile(String mobileNumberText)
        {
            registrationpage.EnterMobileNumber(mobileNumberText);
        }
        
        [When(@"I enter my Password ""(.*)""")]
        public void WhenIEnterMyPassword(string passwordText)
        {
            registrationpage.EnterPassword(passwordText);
        }
        
        [When(@"I re enter my Password ""(.*)""")]
        public void WhenIReEnterMyPassword(string passwordText)
        {
            registrationpage.EnterToConfirmPassword(passwordText);
        }
        
        [When(@"I click on Sign up")]
        public void WhenIClickOnSignUp()
        {
            registrationpage.ClickOnSignUp();
        }
        // [Then(@"I should receive a success message ""(.*)""")]
        // public void ThenIShouldReceiveASuccessMessage(string successMessageText)
        // {
        //Assert.IsFalse(registrationPage.IsSuccessMessageDispalyed(successMessageText));
        ////   Assert.AreEqual(registrationPage.SuccessMessage(), "Success Message");
        // }

        [Then(@"I should receive a success message")]
        public void ThenIShouldReceiveASuccessMessage()
        {
            Thread.Sleep(5000);
            Assert.AreEqual(registrationpage.SuccessMessage(), "Registration Info");
        }
    }
}
