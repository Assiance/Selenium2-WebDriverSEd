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
    public class TableBodySe : ElementSe
    {
        private List<TableRowSe> rows = new List<TableRowSe>();

        public TableBodySe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            InitializeRows();
        }

        public TableBodySe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            InitializeRows();
        }

        public TableBodySe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
            InitializeRows();
        }

        public TableBodySe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
            InitializeRows();
        }

        public TableBodySe(IWebElement body)
            : base(body)
        {
            TableRowSeCollection theRows = new TableRowSeCollection(body, By.TagName("tr"));

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

        private void InitializeRows()
        {
            TableRowSeCollection theRows = new TableRowSeCollection(WebElement, By.TagName("tr"));

            foreach (var row in theRows)
            {
                TableRowSe temp = new TableRowSe(row, "td");

                Rows.Add(temp);
            }
        }
    }
}
