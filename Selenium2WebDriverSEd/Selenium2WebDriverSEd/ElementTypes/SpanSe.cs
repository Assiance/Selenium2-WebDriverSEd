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

namespace WebDriverSEd.ElementTypes
{
    public class SpanSe : ElementSe
    {
        public SpanSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public SpanSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public SpanSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public SpanSe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public SpanSe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string ElementTag
        {
            get { return "span"; }
        }
    }
}