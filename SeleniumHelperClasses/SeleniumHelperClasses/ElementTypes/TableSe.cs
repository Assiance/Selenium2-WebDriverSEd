/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class TableSe : ElementSe
    {
        public TableSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            var head = WebElement.FindElement(By.TagName("thead"));
            var body = WebElement.FindElement(By.TagName("tbody"));

            TableHead = new TableHeadSe(head);
            TableBody = new TableBodySe(body);
        }

        public TableSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public TableHeadSe TableHead { get; set; }
        public TableBodySe TableBody { get; set; }
    }
}

