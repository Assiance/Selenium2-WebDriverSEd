using System;
using System.Collections.Generic;
using WebDriverSEd.Extensions;
using System.Linq;
using System.Web;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    abstract public class BaseSeCollection<T> : List<T> where T : ElementSe
    {
        public BaseSeCollection()
        {
        }

        public BaseSeCollection(IWebDriver webDriver)
        {
            try
            {
                var selector = defaultCssSelectors[typeof (T)];
                var by = By.CssSelector(selector);

                var tempElements = webDriver.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    var instance = Activator.CreateInstance(typeof(T), new object[] { element }) as T;

                    this.Add(instance);
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public BaseSeCollection(IWebDriver webDriver, By by)
        {
            try
            {
                var tempElements = webDriver.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    var instance = Activator.CreateInstance(typeof (T), new object[] {element}) as T;

                    this.Add(instance);
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public BaseSeCollection(IWebElement webElement, By by)
        {
            try
            {
                var tempElements = webElement.FindElements(by);

                foreach (IWebElement element in tempElements)
                {
                    var instance = Activator.CreateInstance(typeof(T), new object[] { element }) as T;

                    this.Add(instance);
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public BaseSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webDriver.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    var instance = Activator.CreateInstance(typeof(T), new object[] { element }) as T;

                    this.Add(instance);
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        public BaseSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                var tempElements = webElement.FindElements(by, predicate);

                foreach (IWebElement element in tempElements)
                {
                    var instance = Activator.CreateInstance(typeof(T), new object[] { element }) as T;

                    this.Add(instance);
                }
            }
            catch (NoSuchElementException)
            {
            }
        }

        private Dictionary<Type, string> defaultCssSelectors = new Dictionary<Type, string>()
                                                                {
                                                                    { typeof(ButtonSe), "input[type=button]" },
                                                                    { typeof(CheckBoxSe), "input[type=checkbox]" },
                                                                    { typeof(DivSe), "div" },
                                                                    { typeof(ImageSe), "img" },
                                                                    { typeof(LabelSe), "label" },
                                                                    { typeof(LinkSe), "a" },
                                                                    { typeof(RadioButtonSe), "input[type=radio]" },
                                                                    { typeof(SelectListSe), "select" },
                                                                    { typeof(SpanSe), "span" },
                                                                    { typeof(TableBodySe), "tbody" },
                                                                    { typeof(TableCellSe), "td" },
                                                                    { typeof(TableHeadSe), "thead" },
                                                                    { typeof(TableRowSe), "tr" },
                                                                    { typeof(TableSe), "table" },
                                                                    { typeof(TextFieldSe), "input[type=text]" },
                                                                };
    }
}