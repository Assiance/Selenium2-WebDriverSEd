/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class CheckBoxSeCollection : ElementSeCollection
    {
        public CheckBoxSeCollection()
        {
            
        }

        public CheckBoxSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            
        }

        public CheckBoxSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {

        }

        public CheckBoxSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            :base(webDriver, by, predicate)
        {

        }

        public CheckBoxSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {

        }
    }
}