/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public abstract class ControlSe : ElementSe
    {
        public ControlSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ControlSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ControlSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ControlSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public IWebDriver WebDriver { get; set; }
    }
}
