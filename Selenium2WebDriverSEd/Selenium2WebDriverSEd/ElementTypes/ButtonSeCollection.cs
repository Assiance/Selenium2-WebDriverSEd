/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
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