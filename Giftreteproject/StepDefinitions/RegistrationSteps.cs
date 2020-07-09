using System;
using TechTalk.SpecFlow;

namespace Giftreteproject.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter your name ""(.*)""")]
        public void WhenIEnterYourName(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter emailaddress""(.*)""")]
        public void WhenIEnterEmailaddress(string p0)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter password""(.*)""")]
        public void WhenIEnterPassword(string p0)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter confirm password""(.*)""")]
        public void WhenIEnterConfirmPassword(string p0)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the Create your accountwith amazon button")]
        public void WhenIClickOnTheCreateYourAccountwithAmazonButton()
        {
          //  ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am registered")]
        public void ThenIAmRegistered()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
