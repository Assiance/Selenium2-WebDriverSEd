/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;
namespace WebDriverSEd.ElementTypes
{
    public class DivSe : ElementSe
    {
        public DivSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public DivSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public DivSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public DivSe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public DivSe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string ElementTag
        {
            get { return "div"; }
        }
    }
}