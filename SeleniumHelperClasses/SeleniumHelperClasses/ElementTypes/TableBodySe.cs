/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System.Collections.Generic;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class TableBodySe : ElementSe
    {
        private List<TableRowSe> rows = new List<TableRowSe>();

        public TableBodySe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public TableBodySe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public TableBodySe(IWebElement body)
        {
            var theRows = body.FindElements(By.TagName("tr"));

            foreach (var row in theRows)
            {
                TableRowSe temp = new TableRowSe(row, "td");

                Rows.Add(temp);
            }
        }

        public List<TableRowSe> Rows
        {
            get
            {
                return rows;
            }
        }
    }
}
