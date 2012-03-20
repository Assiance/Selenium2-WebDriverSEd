/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using WebDriverSEd.Extensions;

namespace WebDriverSEd.ElementTypes
{
    public class DivSeCollection : List<DivSe>
    {
        public DivSeCollection()
        {
        }

        public DivSeCollection(IWebDriver webDriver, By by)
        { 
            try
            {
                var tempElements = webDriver.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new DivSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public DivSeCollection(IWebElement webElement, By by)
        {
            try
            {
                var tempElements = webElement.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new DivSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public DivSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webDriver.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new DivSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public DivSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webElement.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new DivSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }
    }
}