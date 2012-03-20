/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class TableBodySe : TableElements
    {
        private static string columnTag = "td";

        public TableBodySe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            InitializeRowsandCells(columnTag);
        }

        public TableBodySe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            InitializeRowsandCells(columnTag);
        }

        public TableBodySe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
            : base(webDriver, by, predicate)
        {
            InitializeRowsandCells(columnTag);
        }

        public TableBodySe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
            : base(webElement, by, predicate)
        {
            InitializeRowsandCells(columnTag);
        }

        public TableBodySe(IWebElement body)
            : base(body, columnTag)
        {
        }

        public override string ElementTag
        {
            get { return "tbody"; }
        }
    }
}
