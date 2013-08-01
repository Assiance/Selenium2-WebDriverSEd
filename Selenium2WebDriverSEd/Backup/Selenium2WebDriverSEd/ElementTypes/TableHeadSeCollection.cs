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
    public class TableHeadSeCollection : BaseSeCollection<TableHeadSe>
    {
        public TableHeadSeCollection()
        {
        }

        public TableHeadSeCollection(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        public TableHeadSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public TableHeadSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public TableHeadSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public TableHeadSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}