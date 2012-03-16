using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ElementSe : ContainterElement
    {
        public ElementSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public ElementSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ElementSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ElementSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ElementSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}