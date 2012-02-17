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
using WebDriverSEd.Entities.Args;
using WebDriverSEd.Extensions;

namespace WebDriverSEd.ElementTypes
{
    public abstract class TableElements : ContainterElement
    {
        private List<TableRowSe> _rows = new List<TableRowSe>();
        private List<TableCellSe> _cells = new List<TableCellSe>();

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

        public TableElements(IWebElement body, string columnTag)
            : base(body)
        {
            TableRowSeCollection theRows = new TableRowSeCollection(WebElement, By.TagName(columnTag));

            foreach (var row in theRows)
            {
                TableRowSe temp = new TableRowSe(row, columnTag);

                _rows.Add(temp);
            }

            foreach (var row in _rows)
            {
                foreach (var cell in row.Cells)
                {
                    _cells.Add(cell);
                }
            }
        }

        public override string ElementTag
        {
            get { return "tbody"; }
        }

        public List<TableRowSe> Rows
        {
            get
            {
                return _rows;
            }
        }

        public List<TableCellSe> Cells
        {
            get
            {
                return _cells;
            }
        }

        public TableRowSe FindRow(string key, int keyColumn)
        {
            return Rows.Find(i => i.Cells[keyColumn].Text.Contains(key));
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

        public T GetTableElement<T>(FindRow findRow, string targetCellText) where T : ElementSe
        {
            TableRowSe row = FindRow(findRow);
            TableCellSe cell = row.Cells.Find(i => i.Text.Contains(targetCellText));
            string tag = new ElementSe(cell).ConvertTo<T>().ElementTag;
            ElementSe element = new ElementSe(cell, By.TagName(tag));
            return element.ConvertTo<T>();
        }

        public T GetTableElement<T>(FindRow findRow, int targetCell) where T : ElementSe
        {
            TableRowSe row = FindRow(findRow);
            string tag = new ElementSe(row).ConvertTo<T>().ElementTag;
            ElementSe element = new ElementSe(row.Cells[targetCell], By.TagName(tag));
            return element.ConvertTo<T>();
        }

        public List<List<string>> GetRowText(TableSe target)
        {
            List<List<string>> tableValues = new List<List<string>>();

            TableBodySe body = target.TableBody;
            List<TableRowSe> rows = body.Rows;
            foreach (TableRowSe row in rows)
            {
                if (row.Style.ToLower() != "none")
                {
                    List<string> rowValues = new List<string>();
                    List<TableCellSe> cells = row.Cells;
                    foreach (TableCellSe cell in cells)
                    {
                        rowValues.Add(cell.Text.RemoveLineBreaks());
                    }

                    tableValues.Add(rowValues);
                }
            }

            return tableValues;
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

        public List<string> GetAllValuesFromColumn(int columnIndex)
        {
            List<string> values = new List<string>();

            foreach (var row in Rows)
            {
                if (row.Style.ToLower() != "none")
                {
                    TableCellSe cell = row.Cells[columnIndex];
                    if (!string.IsNullOrEmpty(cell.Text))
                    {
                        values.Add(cell.Text);
                    }
                }
            }

            return values;
        }

        public List<string> GetAllValuesFromColumn(int columnIndex, string className)
        {
            List<string> values = new List<string>();

            foreach (var row in Rows)
            {
                if (row.Style.ToLower() != "none")
                {
                    TableCellSe cell = row.Cells[columnIndex];
                    ElementSe element = cell.Div(e => e.ClassName == className).ConvertTo<ElementSe>();
                    if (element.Exists)
                    {
                        string s = element.Text;
                        if (!string.IsNullOrEmpty(s))
                        {
                            values.Add(s);
                        }
                    }
                }
            }

            return values;
        }

        protected void InitializeRowsandCells(string columnTag)
        {
            TableRowSeCollection theRows = new TableRowSeCollection(WebElement, By.TagName("tr"));
            foreach (var row in theRows)
            {
                _rows.Add(new TableRowSe(row, columnTag));
            }

            foreach (var row in _rows)
            {
                foreach (var cell in row.Cells)
                {
                    _cells.Add(cell);
                }
            }
        }
    }
}