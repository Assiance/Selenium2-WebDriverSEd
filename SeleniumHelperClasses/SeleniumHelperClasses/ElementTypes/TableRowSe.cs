﻿/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class TableRowSe : ElementSe
    {
        private List<TableCellSe> cells = new List<TableCellSe>();

        public TableRowSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            InitializeCells();
        }

        public TableRowSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            InitializeCells();
        }

        public TableRowSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
            InitializeCells();
        }

        public TableRowSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
            InitializeCells();
        }

        public TableRowSe(IWebElement body, string rowTag)
        {
            var theCells = body.FindElements(By.TagName(rowTag));

            foreach (var cell in theCells)
            {
                TableCellSe temp = new TableCellSe(cell);

                Cells.Add(temp);
            }
        }

        public TableRowSe(IWebElement body)
        {
            var theCells = body.FindElements(By.TagName("td"));

            foreach (var cell in theCells)
            {
                TableCellSe temp = new TableCellSe(cell);

                Cells.Add(temp);
            }
        }

        public List<TableCellSe> Cells
        {
            get
            {
                return cells;
            }
        }

        private void InitializeCells()
        {
            var theCells = WebElement.FindElements(By.TagName("td"));

            foreach (var cell in theCells)
            {
                TableCellSe temp = new TableCellSe(cell);

                Cells.Add(temp);
            }
        }
    }
}
