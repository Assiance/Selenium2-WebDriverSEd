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
    public class TextFieldSe : ElementSe
    {
        public TextFieldSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public TextFieldSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public TextFieldSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public TextFieldSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public TextFieldSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string ElementTag
        {
            get { return "input"; }
        }
    }
}