/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class TableSeCollection : List<TableSe>
    {
        public TableSeCollection()
        {
        }

        public TableSeCollection(IWebDriver webDriver, By by)
        { 
            try
            {
                var tempElements = webDriver.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new TableSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public TableSeCollection(IWebElement webElement, By by)
        {
            try
            {
                var tempElements = webElement.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new TableSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public TableSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webDriver.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new TableSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public TableSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webElement.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new TableSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }
    }
}