/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class TableSe : ElementSe
    {
        public TableSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public TableSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public TableSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public TableSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            if (WebElement.Text.Contains("thead"))
            {
                var head = WebElement.FindElement(By.TagName("thead"));
                TableHead = new TableHeadSe(head);
            }

            var body = WebElement.FindElement(By.TagName("tbody"));
            TableBody = new TableBodySe(body);
        }

        public TableHeadSe TableHead { get; set; }
        public TableBodySe TableBody { get; set; }

        public string GetValueFromColumn(string key, int keyColumn, int valueColumn)
        {
            TableRowSe row = TableBody.Rows.Find(i => i.Cells[keyColumn].Text.Contains(key));
            TableCellSe cell = row.Cells[valueColumn];
            return cell.Text;
        }
    }
}

