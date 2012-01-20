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

namespace SeleniumHelperClasses.ElementTypes
{
    public class SelectListSeCollection : ElementSeCollection
    {
        public SelectListSeCollection()
        {
            
        }

        public SelectListSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            
        }

        public SelectListSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {

        }

        public SelectListSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            :base(webDriver, by, predicate)
        {

        }

        public SelectListSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {

        }
    }
}