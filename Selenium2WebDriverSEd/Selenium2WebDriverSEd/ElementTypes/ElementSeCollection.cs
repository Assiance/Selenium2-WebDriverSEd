/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ElementSeCollection : IList<ElementSe>
    {
        public ElementSeCollection()
        {
            Elements = new List<ElementSe>();
        }

        public ElementSeCollection(IWebDriver webDriver, By by)
        { 
            try
            {
                Elements = new List<ElementSe>();
                var tempElements = webDriver.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    Elements.Add(new ElementSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSeCollection(IWebElement webElement, By by)
        {
            try
            {
                Elements = new List<ElementSe>();
                var tempElements = webElement.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    Elements.Add(new ElementSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                Elements = new List<ElementSe>();
                var tempElements = webDriver.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    Elements.Add(new ElementSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                Elements = new List<ElementSe>();
                var tempElements = webElement.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    Elements.Add(new ElementSe(element));
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public List<ElementSe> Elements { get; set; }

        public int Count
        {
            get { return Elements.Count; }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public ElementSe this[int index]
        {
            get { return Elements[index]; }
            set { Elements[index] = value; }
        }

        public IEnumerator<ElementSe> GetEnumerator()
        {
            return Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(ElementSe item)
        {
            Elements.Add(item);
        }

        public void Clear()
        {
            Elements.Clear();
        }

        public ElementSe Find(Predicate<ElementSe> match)
        {
            return Elements.Find(match);
        }

        public List<ElementSe> FindAll(Predicate<ElementSe> match)
        {
            return Elements.FindAll(match);
        }

        public bool Contains(ElementSe item)
        {
            return Elements.Contains(item);
        }

        public void CopyTo(ElementSe[] array, int arrayIndex)
        {
            Elements.CopyTo(array, arrayIndex);
        }

        public bool Remove(ElementSe item)
        {
            return Elements.Remove(item);
        }

        public int IndexOf(ElementSe item)
        {
            return Elements.IndexOf(item);
        }

        public void Insert(int index, ElementSe item)
        {
            Elements.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            Elements.RemoveAt(index);
        }
    }
}