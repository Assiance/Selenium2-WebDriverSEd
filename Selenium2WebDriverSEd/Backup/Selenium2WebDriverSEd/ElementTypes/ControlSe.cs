/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;
namespace WebDriverSEd.ElementTypes
{
    public abstract class ControlSe : ElementSe
    {
        public ControlSe(IWebElement webElement)
            : base(webElement)
        {
            WebDriver = ElementsWebDriver;
        }

        public ControlSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ControlSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            WebDriver = ElementsWebDriver;
        }

        public ControlSe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ControlSe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
            : base(webElement, by, predicate)
        {
            WebDriver = ElementsWebDriver;
        }

        protected IWebDriver WebDriver { get; set; }
    }
}
