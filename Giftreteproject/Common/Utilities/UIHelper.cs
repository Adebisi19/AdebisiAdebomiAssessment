using System;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers;
using System.Linq;
using System.Threading.Tasks;
using Giftreteproject.Hook;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Giftreteproject.Common.Utilities
{
    class UIHelper
    {

		public static IWebDriver driver;
		public static Random rnd = new Random();

		public UIHelper()
		{
			driver = BaseTest.driver;
		}
		public void AssertElementPresent(IWebElement element)
		{
			Assert.IsTrue(element.Displayed);
		}

		public void AssertElementNotPresent(IWebElement element)
		{
			try
			{
				AssertElementPresent(element);
			}

			catch (Exception e)
			{
				var str = e.Message;
				Assert.IsTrue(e.Message.Contains("Expected: True") && str.Contains("But was: False"));
			}
		}

		public IWebElement RandomListSelector(IList<IWebElement> selectList)
		{
			selectList.RemoveAt(0);
			return selectList[rnd.Next(selectList.Count)];
		}

		public IWebElement RandomElementSelector(IList<IWebElement> selectList)
		{
			return selectList[rnd.Next(selectList.Count)];
		}

		public string GetRandonNumber()
		{
			return rnd.ToString();
		}

		public string GetDateFormat()
		{
			DateTime aDate = DateTime.Now;

			return aDate.ToString("_yyyyMMdd_HHmmss");
		}

		//public string RandomGenerator()
		//{
		//	Random randomGenerator = new Random();
		//	int randomInt = randomGenerator.Next(1000);
		//}


	}
}
