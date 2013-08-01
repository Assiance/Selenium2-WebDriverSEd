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
    public class LabelSeCollection : BaseSeCollection<LabelSe>
    {
        public LabelSeCollection()
        {
        }

        public LabelSeCollection(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        public LabelSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public LabelSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public LabelSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public LabelSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}