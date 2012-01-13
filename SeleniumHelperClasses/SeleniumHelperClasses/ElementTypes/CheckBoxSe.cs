/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class CheckBoxSe : ElementSe
    {
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

        public bool Checked
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
            if (theValue && !Checked)
            {
                WebElement.Click();
            }
            else if (!theValue && Checked)
            {
                WebElement.Click();
            }
        }
    }
}
