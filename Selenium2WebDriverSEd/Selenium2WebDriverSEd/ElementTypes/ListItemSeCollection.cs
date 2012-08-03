using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ListItemSeCollection : BaseSeCollection<ListItemSe>
    {
        public ListItemSeCollection()
        {
        }

        public ListItemSeCollection(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        public ListItemSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ListItemSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ListItemSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ListItemSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}