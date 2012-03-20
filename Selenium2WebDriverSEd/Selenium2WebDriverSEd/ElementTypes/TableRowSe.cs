/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
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

        public TableRowSe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
            : base(webDriver, by, predicate)
        {
            InitializeCells();
        }

        public TableRowSe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
            : base(webElement, by, predicate)
        {
            InitializeCells();
        }

        public TableRowSe(IWebElement row, string rowTag)
            : base(row)
        {
            TableCellSeCollection theCells = new TableCellSeCollection(row, By.TagName(rowTag));
            foreach (var cell in theCells)
            {
                Cells.Add(new TableCellSe(cell));
            }
        }

        public TableRowSe(IWebElement row)
            : base(row)
        {
            TableCellSeCollection theCells = new TableCellSeCollection(row, By.TagName("td"));

            foreach (var cell in theCells)
            {
                Cells.Add(new TableCellSe(cell));
            }
        }

        public override string ElementTag
        {
            get { return "tr"; }
        }

        public List<TableCellSe> Cells
        {
            get
            {
                return cells;
            }
        }

        public TableCellSe FindCell(string keyText)
        {
            return Cells.Find(i => i.Text.Contains(keyText));
        }

        public TableCellSe GetCell(int targetCell)
        {
            return Cells[targetCell];
        }

        private void InitializeCells()
        {
            TableCellSeCollection theCells = new TableCellSeCollection(WebElement, By.TagName("td"));

            foreach (var cell in theCells)
            {
                TableCellSe temp = new TableCellSe(cell);

                Cells.Add(temp);
            }
        }
    }
}
