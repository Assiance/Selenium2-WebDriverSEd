using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class ButtonSeCollection : ElementSeCollection
    {
        public ButtonSeCollection()
        {
            
        }

        public ButtonSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            
        }

        public ButtonSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {

        }

        public ButtonSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            :base(webDriver, by, predicate)
        {

        }

        public ButtonSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {

        }
    }
}