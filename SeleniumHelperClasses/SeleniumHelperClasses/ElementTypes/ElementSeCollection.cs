using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public class ElementSeCollection : IList<ElementSe>
    {
        public ElementSeCollection()
        {
            
        }

        private List<ElementSe> d { get; set; }
        public ElementSeCollection(IWebDriver webDriver, By by)
        {
            try
            {
                var webElements = webDriver.FindElements(by);

                foreach (var webElement in webElements)
                {
                    
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSeCollection(IWebElement webElement, By by)
        {
           // WebElement = webElement.FindElement(by);
        }

        public ElementSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
              //  WebElement = webDriver.FindElement(by, predicate);
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                //WebElement = webElement.FindElement(by, predicate);
            }
            catch (NoSuchElementException)
            {
            }
        }

        public IEnumerator<ElementSe> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(ElementSe item)
        {
            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(ElementSe item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(ElementSe[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ElementSe item)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public int IndexOf(ElementSe item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, ElementSe item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public ElementSe this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}