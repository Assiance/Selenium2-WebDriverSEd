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

        public void SetChecked(bool isChecked)
        {
            if (Value == "true" && !isChecked)
            {
                WebElement.Click();
            }
            else if (Value == "false" && isChecked)
            {
                WebElement.Click();
            }
        }
    }
}
