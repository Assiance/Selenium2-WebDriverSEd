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

namespace SeleniumHelperClasses.ElementTypes
{
    public class TableSe : ContainterElement
    {
        public TableSe(IWebElement webElement)
            : base(webElement)
        {
        }

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

        public override string ElementTag
        {
            get { return "table"; }
        }

        public TableSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            if (WebElement.Text.Contains("thead"))
            {
                TableHeadSe head = new TableHeadSe(WebElement, By.TagName("thead"));
                TableHead = new TableHeadSe(head);
            }

            TableBodySe body = new TableBodySe(WebElement, By.TagName("tbody"));
            TableBody = new TableBodySe(body);
        }

        public TableHeadSe TableHead { get; set; }
        public TableBodySe TableBody { get; set; }
    }
}

