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
using WebDriverSEd.ElementTypes;

namespace WebDriverSEd.ElementTypes
{
    public class TableCellSeCollection : ElementSeCollection
    {
        public TableCellSeCollection()
        {
            
        }

        public TableCellSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            
        }

        public TableCellSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {

        }

        public TableCellSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            :base(webDriver, by, predicate)
        {

        }

        public TableCellSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {

        }
    }
}