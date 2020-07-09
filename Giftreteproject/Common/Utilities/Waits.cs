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
    class Waits
    {


        public IWebElement WaitForElement(string elementCSS)
        {
            IWebElement elementFound = null;

            for (var i = 0; i < 3; i++)
            {

                try
                {
                    WebDriverWait fluentWait = new WebDriverWait(BaseTest.driver, TimeSpan.FromSeconds(5));

                    fluentWait.Timeout = TimeSpan.FromSeconds(5);
                    fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
                    fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                    elementFound = fluentWait.Until(x => BaseTest.driver.FindElement(By.CssSelector(elementCSS)));
                    if (elementFound.Displayed)
                        break;
                }
                catch
                {

                }


            }

            return elementFound;

        }


        public IWebElement WaitForElement(IWebElement element)
        {
            for (var i = 0; i < 3; i++)
            {

                try
                {
                    DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(BaseTest.driver);

                    fluentWait.Timeout = TimeSpan.FromSeconds(5);
                    fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
                    fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                    if (fluentWait.Until(x => element.Enabled))
                        return element;
                }
                catch
                {

                }

            }

            return null;

        }













    }
}
