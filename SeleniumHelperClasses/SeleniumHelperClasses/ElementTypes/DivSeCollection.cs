using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
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