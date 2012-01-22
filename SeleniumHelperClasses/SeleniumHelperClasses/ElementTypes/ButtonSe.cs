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
    public class ButtonSe : ElementSe
    {
        public ButtonSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public ButtonSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ButtonSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ButtonSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ButtonSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}