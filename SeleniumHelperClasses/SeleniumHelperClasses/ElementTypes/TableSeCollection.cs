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
    public class TableSeCollection : ElementSeCollection
    {
        public TableSeCollection()
        {
            
        }

        public TableSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            
        }

        public TableSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {

        }

        public TableSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            :base(webDriver, by, predicate)
        {

        }

        public TableSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {

        }
    }
}