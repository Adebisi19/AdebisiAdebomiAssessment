using System;
using Giftreteproject.Hook;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace Giftreteproject.Common.Utilities
{
    class ElementActions
    {
        private Waits _wait;
        public ElementActions()
        {
            _wait = new Waits();
        }

        public void Click(string cssSelector)
        {
            IWebElement element = _wait.WaitForElement(cssSelector);
            element.Click();

            // _wait.WaitForElement(cssSelector).Click();

        }
        public void ClickByPressingEnterKey(string cssSelector)
        {
            IWebElement element = _wait.WaitForElement(cssSelector);
            element.SendKeys(Keys.Enter);
        }
        public void SendKeys(string cssSelector, string textToEnter)
        {
            _wait.WaitForElement(cssSelector).SendKeys(textToEnter);
        }
        public void SelectFromDropDownByIndex(string cssSelector, int index)
        {
            SelectElement select = new SelectElement(_wait.WaitForElement(cssSelector));
            select.SelectByIndex(index);
        }
        public void SelectFromDropDownByText(string cssSelector, string text)
        {
            SelectElement select = new SelectElement(_wait.WaitForElement(cssSelector));
            select.SelectByText(text);
        }
        public void SelectFromDropDownByValue(string cssSelector, string value)
        {
            SelectElement select = new SelectElement(_wait.WaitForElement(cssSelector));
            select.SelectByValue(value);
        }
        public bool IsElementDisplayed(string cssSelector)
        {
            try
            {
                return _wait.WaitForElement(cssSelector).Displayed;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public IList<IWebElement> GetListOfElements(string cssSelector)
        {
            return BaseTest.driver.FindElements(By.CssSelector(cssSelector));
        }
        public bool IsElementPresentInAList(string cssSelector, string text)
        {
            foreach (IWebElement element in GetListOfElements(cssSelector))
            {
                if (element.Text == text)
                    return true;
            }

            return false;
        }

    }
}
