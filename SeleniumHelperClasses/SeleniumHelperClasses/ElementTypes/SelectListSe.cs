/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class SelectListSe : ElementSe
    {
        public SelectListSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public SelectListSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public SelectListSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public SelectListSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public string GetSelectedItem()
        {
            string targetValue = WebElement.GetAttribute("value");

            return WebElement.FindElement(By.CssSelector("select [value='" + targetValue + "']")).Text;
        }
    }
}
