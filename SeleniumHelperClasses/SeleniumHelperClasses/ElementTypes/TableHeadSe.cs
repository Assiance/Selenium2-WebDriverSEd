/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class TableHeadSe : ElementSe
    {
        private List<TableRowSe> rows = new List<TableRowSe>();

        public TableHeadSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            InitializeRows();
        }
       
        public TableHeadSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            InitializeRows();
        }

        public TableHeadSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
            InitializeRows();
        }

        public TableHeadSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
            InitializeRows();
        }

        public TableHeadSe(IWebElement body)
            : base(body)
        {
            var theRows = body.FindElements(By.TagName("tr"));

            foreach (var row in theRows)
            {
                TableRowSe temp = new TableRowSe(row, "th");

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

        private void InitializeRows()
        {
            var theRows = WebElement.FindElements(By.TagName("tr"));

            foreach (var row in theRows)
            {
                TableRowSe temp = new TableRowSe(row, "th");

                Rows.Add(temp);
            }
        }
    }
}
