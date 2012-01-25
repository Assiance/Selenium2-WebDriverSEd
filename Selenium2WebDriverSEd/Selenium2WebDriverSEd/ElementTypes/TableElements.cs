using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using OpenQA.Selenium;
using WebDriverSEd.ElementTypes;
using WebDriverSEd.Entities.Args;

namespace WebDriverSEd.ElementTypes
{
    public abstract class TableElements : ContainterElement
    {
        public TableElements(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public TableElements(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public TableElements(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public TableElements(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public TableElements(IWebElement body)
            : base(body)
        {
        }

        protected List<TableRowSe> rows = new List<TableRowSe>();

        public override string ElementTag
        {
            get { return "tbody"; }
        }

        public List<TableRowSe> Rows
        {
            get
            {
                return rows;
            }
        }

        protected void InitializeRows(string columnTag)
        {
            TableRowSeCollection theRows = new TableRowSeCollection(WebElement, By.TagName("tr"));

            foreach (var row in theRows)
            {
                TableRowSe temp = new TableRowSe(row, columnTag);

                Rows.Add(temp);
            }
        }

        public List<TableCellSe> Cells
        {
            get
            {
                List<TableCellSe> temp = new List<TableCellSe>();

                foreach (var row in Rows)
                {
                    foreach (var cell in row.Cells)
                    {
                        temp.Add(cell);   
                    }
                }

                return temp;
            }
        }

        public TableRowSe FindRow(FindRow findRow)
        {
            return Rows.Find(i => i.Cells[findRow.KeyColumn].Text.Contains(findRow.Key));
        }

        public TableRowSe FindRow(Predicate<TableRowSe> predicate)
        {
            return Rows.Find(predicate);
        }

        public TableRowSe GetRow(int targetRow)
        {
            return Rows[targetRow];
        }


        public T GetTableElement<T>(string targetCellText, FindRow findRow) where T : ElementSe
        {
            TableRowSe row = FindRow(findRow);
            TableCellSe cell = row.Cells.Find(i => i.Text.Contains(targetCellText));
            string tag = new ElementSe(cell).ConvertTo<T>().ElementTag;
            ElementSe element = new ElementSe(cell, By.TagName(tag));
            return element.ConvertTo<T>();
        }

        public T GetTableElement<T>(int targetCell, FindRow findRow) where T : ElementSe
        {
            TableRowSe row = FindRow(findRow);
            string tag = new ElementSe(row).ConvertTo<T>().ElementTag;
            ElementSe element = new ElementSe(row.Cells[targetCell], By.TagName(tag));
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