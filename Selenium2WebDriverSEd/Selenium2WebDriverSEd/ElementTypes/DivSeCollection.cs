/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class DivSeCollection : ElementSeCollection
    {
        public DivSeCollection()
        {
            
        }

        public DivSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            
        }

        public DivSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {

        }

        public DivSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            :base(webDriver, by, predicate)
        {

        }

        public DivSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {

        }
    }
}