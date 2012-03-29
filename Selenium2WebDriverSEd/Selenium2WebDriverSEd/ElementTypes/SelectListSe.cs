/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriverSEd.Extensions;

namespace WebDriverSEd.ElementTypes
{
    public class SelectListSe : ElementSe
    {
        public SelectListSe(IWebElement webElement)
            : base(webElement)
        {
            if (WebElement != null)
            {
                SelectElement = new SelectElement(WebElement);
            }
        }

        public SelectListSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            if (WebElement != null)
            {
                SelectElement = new SelectElement(WebElement);
            }
        }

        public SelectListSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            if (WebElement != null)
            {
                SelectElement = new SelectElement(WebElement);
            }
        }

        public SelectListSe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
            : base(webDriver, by, predicate)
        {
            if (WebElement != null)
            {
                SelectElement = new SelectElement(WebElement);
            }
        }

        public SelectListSe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
            : base(webElement, by, predicate)
        {
            if (WebElement != null)
            {
                SelectElement = new SelectElement(WebElement);
            }
        }

        public override string ElementTag
        {
            get { return "select"; }
        }

        public IList<IWebElement> AllSelectedOptions
        {
            get { return SelectElement.AllSelectedOptions; }
        }

        public bool IsMultiple
        {
            get { return SelectElement.IsMultiple; }
        }

        public IList<IWebElement> Options
        {
            get { return SelectElement.Options; }
        }

        public IWebElement SelectedOption
        {
            get { return SelectElement.SelectedOption; }
        }

        private SelectElement SelectElement { get; set; }

        public void DeselectAll()
        {
            SelectElement.DeselectAll();
        }

        public void DeselectByIndex(int index)
        {
            SelectElement.DeselectByIndex(index);
        }

        public void DeselectByText(string text)
        {
            if (!text.IsNullOrEmpty())
            {
                SelectElement.DeselectByText(text);
            }
        }

        public void DeselectByValue(string value)
        {
            if (!value.IsNullOrEmpty())
            {
                SelectElement.DeselectByValue(value);
            }
        }

        public void SelectByIndex(int index)
        {
            SelectElement.SelectByIndex(index);
        }

        public void SelectByText(string text)
        {
            if (!text.IsNullOrEmpty())
            {
                SelectElement.SelectByText(text);
            }
        }

        public void SelectByValue(string value)
        {
            if (!value.IsNullOrEmpty())
            {
                SelectElement.SelectByValue(value);
            }
        }
    }
}
