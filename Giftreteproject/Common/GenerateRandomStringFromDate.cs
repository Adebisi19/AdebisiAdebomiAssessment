using System;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Text;

namespace Giftreteproject.Common
{
    class GenerateRandomStringFromDate
    {

        public static string GetDate()
        {
            return DateTime.Now.ToString("yyyyMMdd HHmmss");
        }

        public static string GenerateRandomText(string text)
        {
            return text + GetDate();
        }

        public static string GenerateTextAndStoreInContext(string text, string contextName)
        {
            string name = GenerateRandomText(text);
            ScenarioContext.Current[contextName] = name;
            return name;











        }
    }    }
