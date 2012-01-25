using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class RadioButtonSe : ElementSe
    {
        public RadioButtonSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public RadioButtonSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public RadioButtonSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public RadioButtonSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public RadioButtonSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string ElementTag
        {
            get { return "input"; }
        }

        public bool IsChecked
        {
            get
            {
                try
                {
                    if (WebElement.Selected)
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
    }
}