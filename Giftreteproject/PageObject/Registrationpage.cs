using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Giftreteproject.Common.Utilities;
using System.Linq;
using System.Threading.Tasks;
using Giftreteproject.Hook;
using System.Collections.Generic;
using System.Text;
using Giftreteproject.Common;

namespace Giftreteproject.PageObject
{
    class Registrationpage
    {

        UIHelper helper;
        private readonly Waits _wait;
        private readonly FileLocation _fileLocation;
        ElementActions _elementActions;
        GenerateRandomStringFromDate generateRandomStringFromDate;
        

        public Registrationpage()
        {
           // PageFactory.InitElements(BaseTest.driver, this);
            helper = new UIHelper();
            _wait = new Waits();
            _fileLocation = new FileLocation();
            _elementActions = new ElementActions();
        }


        readonly string helloSignIn = "//div[@class='login d-inline-block']";
        readonly string register = "#register-tab";
        readonly string firstName = "input[name='first_name']";
        readonly string lastName = "input[name='last_name']";
        readonly string email = "input[id='email']";
        readonly string countryCode = "div[title='United Kingdom: +44']";
        readonly string mobileNumber = "input[id='mobile']";
        readonly string country = "li[id='iti-item-gb']";
        readonly string password = "input[id=reg_password]";
        readonly string reEnterPassword = "input[id=confirm_password]";
        readonly string signUp = "button[id=btn_signup]";
        readonly string successMessage = "h5[id='successModalTitle']";
        //readonly string successMessage = "div[id=successModalBody]";




        public void ClickOnHelloSignIn()
        {
            _elementActions.Click(helloSignIn);
        }

        public void ClickOnRegister()
        {
            _elementActions.Click(register);
        }

        public void EnterFirstName(string firstnameText)
        {
            _elementActions.SendKeys(firstName, firstnameText);
        }

        public void EnterLastName(string lastnameText)
        {
            _elementActions.SendKeys(lastName, lastnameText);
        }

        public void EnterEmail(string emailText)
        {
            // _elementActions.SendKeys(email, emailText);
            //   _elementActions.SendKeys(email, "emailText" + helper.GetDateFormat());


            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            _elementActions.SendKeys(email, "emailText" + randomInt + "@propertyrete.com");

        }

        public void ClickOnCountryCode()
        {
            _elementActions.Click(countryCode);

        }

        public void ClickOnCountry()
        {
            _elementActions.Click(country);

        }

        public void EnterMobileNumber(string mobileNumberText)
        {
            _elementActions.SendKeys(mobileNumber, mobileNumberText);
        }

        public void EnterPassword(string passwordText)
        {
            _elementActions.SendKeys(password, passwordText);
        }

        public void EnterToConfirmPassword(string passwordText)
        {
            _elementActions.SendKeys(reEnterPassword, passwordText);
        }

        public void ClickOnSignUp()
        {
            _elementActions.Click(signUp);
        }

        public bool IsSuccessMessageDispalyed(string successMessageText)
        {
            return _elementActions.IsElementPresentInAList(successMessage, successMessageText);
        }

        public string SuccessMessage()
        {

            {
                return _wait.WaitForElement(successMessage).Text;
            }

        }

        public void NavigateToWebsite(string url)
        {
            BaseTest.driver.Navigate().GoToUrl(url);

        }

    }

    internal class PageFactory
    {
    }
}
