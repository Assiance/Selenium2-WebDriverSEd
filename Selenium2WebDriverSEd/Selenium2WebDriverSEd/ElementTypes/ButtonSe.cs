/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;
namespace WebDriverSEd.ElementTypes
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

        public ButtonSe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ButtonSe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string ElementTag
        {
            get { return "input"; }
        }
    }
}