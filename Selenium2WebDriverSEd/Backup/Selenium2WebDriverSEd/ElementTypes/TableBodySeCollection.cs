/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class TableBodySeCollection : BaseSeCollection<TableBodySe>
    {
        public TableBodySeCollection()
        {
        }

        public TableBodySeCollection(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        public TableBodySeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public TableBodySeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public TableBodySeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public TableBodySeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}