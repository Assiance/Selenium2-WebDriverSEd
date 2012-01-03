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
