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
    public class TableBodySe : ElementSe
    {
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
                TableRowSe temp = new TableRowSe(row, "td");

                Rows.Add(temp);
            }
        }

        public TableRowSe GetRow(FindRow findRow)
        {
            return Rows.Find(i => i.Cells[findRow.KeyColumn].Text.Contains(findRow.Key));
        }

        public T GetTableElement<T>(FindRow findRow, int targetColumn, TypeSe ele) where T : ElementSe
        {
            TableRowSe row = GetRow(findRow);
            ElementSe element = new ElementSe(row.Cells[targetColumn], By.TagName(ele.ToTag()));
            return element.ConvertTo<T>();
        }

        public List<string> GetCommaSeparatedTableRowText()
        {
            List<string> tableValues = new List<string>();

            foreach (TableRowSe row in Rows)
            {
                if (row.Style.ToLower() != "none")
                {
                    StringBuilder sb = new StringBuilder();
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
