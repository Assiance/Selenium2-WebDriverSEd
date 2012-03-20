/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class LabelSe : ElementSe
    {
        public LabelSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public LabelSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public LabelSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public LabelSe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public LabelSe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string ElementTag
        {
            get { return "label"; }
        }

        public string Url
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("href");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public string For
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("for");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}