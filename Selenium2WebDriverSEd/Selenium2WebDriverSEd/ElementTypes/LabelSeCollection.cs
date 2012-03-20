/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections.Generic;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class LabelSeCollection : List<LabelSe>
    {
        public LabelSeCollection()
        {
        }

        public LabelSeCollection(IWebDriver webDriver, By by)
        { 
            try
            {
                var tempElements = webDriver.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new LabelSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public LabelSeCollection(IWebElement webElement, By by)
        {
            try
            {
                var tempElements = webElement.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new LabelSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public LabelSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webDriver.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new LabelSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public LabelSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webElement.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new LabelSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }
    }
}