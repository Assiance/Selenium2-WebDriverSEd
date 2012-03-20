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
    public class ButtonSeCollection : List<ButtonSe>
    {
        public ButtonSeCollection()
        {
        }

        public ButtonSeCollection(IWebDriver webDriver, By by)
        { 
            try
            {
                var tempElements = webDriver.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new ButtonSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ButtonSeCollection(IWebElement webElement, By by)
        {
            try
            {
                var tempElements = webElement.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new ButtonSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ButtonSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webDriver.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new ButtonSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ButtonSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webElement.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    this.Add(new ButtonSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }
    }
}