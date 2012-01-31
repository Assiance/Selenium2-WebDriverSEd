/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class TableHeadSe : TableElements
    {
        private string columnTag = "th";

        public TableHeadSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            InitializeRows(columnTag);
        }
       
        public TableHeadSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            InitializeRows(columnTag);
        }

        public TableHeadSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
            InitializeRows(columnTag);
        }

        public TableHeadSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
            InitializeRows(columnTag);
        }

        public TableHeadSe(IWebElement body)
            : base(body)
        {
            TableRowSeCollection theRows = new TableRowSeCollection(body, By.TagName("tr"));

            foreach (var row in theRows)
            {
                TableRowSe temp = new TableRowSe(row, columnTag);

                Rows.Add(temp);
            }
        }

        public override string ElementTag
        {
            get { return "thead"; }
        }
    }
}
