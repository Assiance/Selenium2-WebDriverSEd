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
        private static string columnTag = "th";

        public TableHeadSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            InitializeRowsandCells(columnTag);
        }
       
        public TableHeadSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            InitializeRowsandCells(columnTag);
        }

        public TableHeadSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
            InitializeRowsandCells(columnTag);
        }

        public TableHeadSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
            InitializeRowsandCells(columnTag);
        }

        public TableHeadSe(IWebElement body)
            : base(body, columnTag)
        {
        }

        public override string ElementTag
        {
            get { return "thead"; }
        }
    }
}
