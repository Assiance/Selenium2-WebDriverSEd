using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class LinkSeCollection : ElementSeCollection
    {
        public LinkSeCollection()
        {
            
        }

        public LinkSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            
        }

        public LinkSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {

        }

        public LinkSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            :base(webDriver, by, predicate)
        {

        }

        public LinkSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {

        }
    }
}