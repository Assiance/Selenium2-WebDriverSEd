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
    public class TableSe : ElementSe
    {
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

        public string GetValueFromColumn(string key, int keyColumn, int valueColumn)
        {
            TableRowSe row = TableBody.Rows.Find(i => i.Cells[keyColumn].Text.Contains(key));
            TableCellSe cell = row.Cells[valueColumn];
            return cell.Text;
        }

        public void ClickTableButton(string keyValue, int keyColumnIndex, int actionColumnIndex)
        {
            TableRowSe row = TableBody.Rows.Find(i => i.Cells[keyColumnIndex].Text.Contains(keyValue));
            var button = row.Cells[actionColumnIndex].FindElements(By.TagName("input"));
            button.First().Click();
        }

        public List<string> GetRowTextCommaSeparated()
        {
            List<string> tableValues = new List<string>();

            foreach (TableRowSe row in TableBody.Rows)
            {
                if (row.Cells[1].Style.ToLower() != "none")
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

            return new List<string>();
        }
    }
}

