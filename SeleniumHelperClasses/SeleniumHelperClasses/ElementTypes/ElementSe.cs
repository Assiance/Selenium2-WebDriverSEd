/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using OpenQA.Selenium;
using SeleniumHelperClasses.Extensions;

namespace SeleniumHelperClasses.ElementTypes
{
    public class ElementSe : IWebElement
    {
        public ElementSe()
        {            
        }

        public ElementSe(IWebElement webElement)
        {
            WebElement = WebElement;
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
            WebElement = webElement.FindElement(by);
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

        public bool IsPresent
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
    }
}
