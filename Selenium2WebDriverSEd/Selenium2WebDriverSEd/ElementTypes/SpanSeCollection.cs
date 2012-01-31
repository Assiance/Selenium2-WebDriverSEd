/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class SpanSeCollection : ElementSeCollection
    {
        public SpanSeCollection()
        {           
        }

        public SpanSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {            
        }

        public SpanSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public SpanSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public SpanSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}