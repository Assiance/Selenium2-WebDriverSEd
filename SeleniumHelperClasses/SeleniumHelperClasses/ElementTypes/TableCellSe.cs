/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class TableCellSe : ElementSe
    {
        public TableCellSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public TableCellSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public TableCellSe(IWebElement cell)
        {
            WebElement = cell;
        }
    }
}
