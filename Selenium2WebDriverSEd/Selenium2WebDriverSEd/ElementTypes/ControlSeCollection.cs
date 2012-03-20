using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ControlSeCollection<T> : List<T> where T : ControlSe
    {
        public ControlSeCollection()
        {
        }

        public ControlSeCollection(IWebDriver webDriver, By by)
        { 
            try
            {
                var tempElements = webDriver.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(Activator.CreateInstance(typeof(T), new object[] { element }) as T);
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ControlSeCollection(IWebElement webElement, By by)
        {
            try
            {
                var tempElements = webElement.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(Activator.CreateInstance(typeof(T), new object[] { element }) as T);
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ControlSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webDriver.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(Activator.CreateInstance(typeof(T), new object[] { element }) as T);
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ControlSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webElement.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(Activator.CreateInstance(typeof(T), new object[] { element }) as T);
                }
            }
            catch (NoSuchElementException)
            {
            }
        }
    }
}