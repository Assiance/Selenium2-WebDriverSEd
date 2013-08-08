/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections.Generic;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ButtonSeCollection : BaseSeCollection<ButtonSe>
    {
        public ButtonSeCollection()
        {
        }

        public ButtonSeCollection(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        public ButtonSeCollection(IWebDriver webDriver, By by)
            :base(webDriver, by)
        { 
        }

        public ButtonSeCollection(IWebElement webElement, By by)
            :base(webElement, by)
        {
        }

        public ButtonSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            :base(webDriver, by, predicate)
        {
        }

        public ButtonSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            :base(webElement, by, predicate)
        {
        }
    }
}