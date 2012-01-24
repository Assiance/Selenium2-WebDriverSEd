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
    public class LabelSe : ElementSe
    {
        public LabelSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public LabelSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public LabelSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public LabelSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public LabelSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string FinalTag
        {
            get { return "label"; }
        }
    }
}