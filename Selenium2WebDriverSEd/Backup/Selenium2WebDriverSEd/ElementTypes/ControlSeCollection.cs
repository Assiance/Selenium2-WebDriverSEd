using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ControlSeCollection<T> : BaseSeCollection<ControlSe>
    {
        public ControlSeCollection()
        {
        }

        public ControlSeCollection(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        public ControlSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ControlSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ControlSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ControlSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}