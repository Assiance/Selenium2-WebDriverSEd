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
    public class LinkSe : ElementSe
    {
        public LinkSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public LinkSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public LinkSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public LinkSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public LinkSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string FinalTag
        {
            get { return "a"; }
        }
    }
}