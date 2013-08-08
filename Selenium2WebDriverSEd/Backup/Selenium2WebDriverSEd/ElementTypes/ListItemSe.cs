/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;
namespace WebDriverSEd.ElementTypes
{
    public class ListItemSe : ElementSe
    {
        public ListItemSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public ListItemSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ListItemSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ListItemSe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ListItemSe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string ElementTag
        {
            get { return "li"; }
        }
    }
}