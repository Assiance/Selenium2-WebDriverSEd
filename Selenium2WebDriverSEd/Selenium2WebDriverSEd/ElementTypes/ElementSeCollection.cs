/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections.Generic;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ElementSeCollection : BaseSeCollection<ElementSe>
    {
        public ElementSeCollection()
        {
        }

        public ElementSeCollection(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        public ElementSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ElementSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ElementSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ElementSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}