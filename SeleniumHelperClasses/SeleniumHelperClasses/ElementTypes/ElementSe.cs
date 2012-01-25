/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumHelperClasses.Extensions;
using SeleniumHelperClasses.Entities.Data;

namespace SeleniumHelperClasses.ElementTypes
{
    public class ElementSe : IWebElement
    {
        public ElementSe()
        {            
        }

        public ElementSe(IWebElement webElement)
        {
            WebElement = webElement;
        }

        public ElementSe(IWebDriver webDriver, By by)
        {
            try
            {
                WebElement = webDriver.FindElement(by);
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSe(IWebElement webElement, By by)
        {
            try
            {
                WebElement = webElement.FindElement(by);
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                WebElement = webDriver.FindElement(by, predicate);
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
        {
            try
            {
                WebElement = webElement.FindElement(by, predicate);
            }
            catch (NoSuchElementException)
            {
            }
        }

        public IWebElement WebElement { get; set; }

        public bool Displayed
        {
            get { return WebElement.Displayed; }
        }

        public bool Exists
        {
            get
            {
                try
                {
                    if (WebElement != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public string ClassName
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("class");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public string Id
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("id");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public string Style
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("style");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public string Value
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("value");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public string Title
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("title");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public bool Enabled
        {
            get { return WebElement.Enabled; }
        }

        public System.Drawing.Point Location
        {
            get { return WebElement.Location; }
        }

        public bool Selected
        {
            get { return WebElement.Selected; }
        }

        public System.Drawing.Size Size
        {
            get { return WebElement.Size; }
        }

        public virtual string ElementTag
        {
            get { return string.Empty; }
        }

        public string TagName
        {
            get { return WebElement.TagName; }
        }

        public string Text
        {
            get
            {
                try
                {
                    return WebElement.Text;
                }
                catch (Exception)
                {
                    return null;
                }
             }
        }

        public T ConvertTo<T>() where T : ElementSe
        {
            var instance = Activator.CreateInstance(typeof(T), new object[] { WebElement }) as T;

            return instance;
        }

        public IWebElement FindElement(By by)
        {
            return WebElement.FindElement(by);
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return WebElement.FindElements(by);
        }

        public void Clear()
        {
            WebElement.Clear();
        }

        public void Click()
        {
            WebElement.Click();
        }

        public string GetAttribute(string attributeName)
        {
            return WebElement.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return WebElement.GetCssValue(propertyName);
        }

        public void SendKeys(string text)
        {
            WebElement.SendKeys(text);
        }

        public void ClearFirstSendKeys(string text)
        {
            WebElement.Clear();
            WebElement.SendKeys(text);
        }

        public void Submit()
        {
            WebElement.Submit();
        }

        public bool TestElementAccess(string elementLabel, bool hasAccess)
        {
            if (!Exists)
            {
                Assert.That(!hasAccess, "The {0} does not exist and it should.", elementLabel);
                return false;
            }

            if (hasAccess)
            {
                Assert.That(Exists, "The {0} does not exist and it should.", elementLabel);
                return true;
            }
            else
            {
                Assert.That(!Exists, "The {0} exists and it should not.", elementLabel);
                return false;
            }
        }
    }
}
