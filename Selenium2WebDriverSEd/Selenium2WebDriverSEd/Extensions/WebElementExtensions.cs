/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace WebDriverSEd.Extensions
{
    public static class WebElementExtensions
    {
        public static IWebElement FindElement(this IWebElement driver, By by, Func<IWebElement, bool> predicate)
        {
            return driver.FindElements(by, predicate).First();
        }

        public static IEnumerable<IWebElement> FindElements(this IWebElement driver, By by, Func<IWebElement, bool> predicate)
        {
            return driver.FindElements(by).Where(predicate);
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, Func<IWebElement, bool> predicate)
        {
            return driver.FindElements(by, predicate).First();
        }

        public static IEnumerable<IWebElement> FindElements(this IWebDriver driver, By by, Func<IWebElement, bool> predicate)
        {
            return driver.FindElements(by).Where(predicate);
        }
    }
}
