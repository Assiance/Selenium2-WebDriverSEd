/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumHelperClasses.Entities.Args;
using SeleniumHelperClasses.Entities.Data;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class TableBodySe : TableElements
    {
        public TableBodySe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            InitializeRows(columnTag);
        }

        public TableBodySe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            InitializeRows(columnTag);
        }

        public TableBodySe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
            InitializeRows(columnTag);
        }

        public TableBodySe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
            InitializeRows(columnTag);
        }

        public TableBodySe(IWebElement body)
            : base(body)
        {
            TableRowSeCollection theRows = new TableRowSeCollection(body, By.TagName("tr"));

            foreach (var row in theRows)
            {
                TableRowSe temp = new TableRowSe(row, columnTag);

                Rows.Add(temp);
            }
        }

        private string columnTag = "td";

        public override string ElementTag
        {
            get { return "tbody"; }
        }
    }
}
