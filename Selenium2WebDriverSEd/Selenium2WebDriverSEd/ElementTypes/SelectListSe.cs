/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriverSEd.ElementTypes;

namespace WebDriverSEd.ElementTypes
{
    public class SelectListSe : ElementSe
    {
        public SelectListSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public SelectListSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
            SelectElement = new SelectElement(WebElement);
        }

        public SelectListSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
            SelectElement = new SelectElement(WebElement);
        }

        public SelectListSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
            SelectElement = new SelectElement(WebElement);
        }

        public SelectListSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
            SelectElement = new SelectElement(WebElement);
        }

        public override string ElementTag
        {
            get { return "select"; }
        }

        private SelectElement SelectElement { get; set; }

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
            SelectElement.DeselectByText(text);
        }

        public void DeselectByValue(string value)
        {
            SelectElement.DeselectByValue(value);
        }

        public void SelectByIndex(int index)
        {
            SelectElement.SelectByIndex(index);
        }

        public void SelectByText(string text)
        {
            SelectElement.SelectByText(text);
        }

        public void SelectByValue(string value)
        {
            SelectElement.SelectByValue(value);
        }
    }
}
