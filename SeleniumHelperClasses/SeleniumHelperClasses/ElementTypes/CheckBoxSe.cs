/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class CheckBoxSe : ElementSe
    {
        public CheckBoxSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public CheckBoxSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public CheckBoxSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public CheckBoxSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public CheckBoxSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public bool IsChecked
        {
            get
            {
                try
                {
                    if (WebElement.GetAttribute("checked=") == "checked")
                    {
                        return true;
                    }

                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public void SetChecked(bool theValue)
        {
            if (theValue && !IsChecked)
            {
                WebElement.Click();
            }
            else if (!theValue && IsChecked)
            {
                WebElement.Click();
            }
        }
    }
}
