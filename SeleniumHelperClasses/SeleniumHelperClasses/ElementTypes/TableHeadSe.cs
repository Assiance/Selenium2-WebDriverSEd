/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Text;
using SeleniumHelperClasses.Entities.Args;
using SeleniumHelperClasses.Entities.Data;

namespace SeleniumHelperClasses.ElementTypes
{
    public class TableHeadSe : ElementSe
    {
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
            TableRowSeCollection theRows = new TableRowSeCollection(body, By.TagName("tr"));

            foreach (var row in theRows)
            {
                TableRowSe temp = new TableRowSe(row, "th");

                Rows.Add(temp);
            }
        }

        private List<TableRowSe> rows = new List<TableRowSe>();

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
                TableRowSe temp = new TableRowSe(row, "th");

                Rows.Add(temp);
            }
        }

        public TableRowSe FindRow(FindRow findRow)
        {
            return Rows.Find(i => i.Cells[findRow.KeyColumn].Text.Contains(findRow.Key));
        }

        public TableRowSe GetRow(int targetRow)
        {
            return Rows[targetRow];
        }


        public T GetTableElement<T>(FindRow findRow, string targetCellText, TypeSe ele) where T : ElementSe
        {
            TableRowSe row = FindRow(findRow);
            TableCellSe cell = row.Cells.Find(i => i.Text.Contains(targetCellText));
            ElementSe element = new ElementSe(cell, By.TagName(ele.ToTag()));
            return element.ConvertTo<T>();
        }

        public T GetTableElement<T>(FindRow findRow, int targetCell, TypeSe ele) where T : ElementSe
        {
            TableRowSe row = FindRow(findRow);
            ElementSe element = new ElementSe(row.Cells[targetCell], By.TagName(ele.ToTag()));
            return element.ConvertTo<T>();
        }

        public List<string> GetCommaSeparatedTableRowText()
        {
            List<string> tableValues = new List<string>();

            foreach (TableRowSe row in Rows)
            {
                if (row.Style.ToLower() != "none")
                {
                    System.Text.StringBuilder sb = new StringBuilder();
                    foreach (TableCellSe cell in row.Cells)
                    {
                        sb.AppendFormat("{0}, ", cell.Text);
                    }

                    string s = sb.ToString().Trim().Trim(',');
                    tableValues.Add(s);
                }
            }

            return tableValues;
        }
    }
}
