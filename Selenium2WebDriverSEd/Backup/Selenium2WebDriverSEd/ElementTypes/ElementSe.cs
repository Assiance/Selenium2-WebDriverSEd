/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Internal;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ElementSe : IWebElement
    {
        public ElementSe()
        {            
        }

        public ElementSe(IWebElement webElement)
        {
            WebElement = webElement;
            InitializeJavaScriptExecutor();
        }

        public ElementSe(IWebDriver webDriver, By by)
        {
            try
            {
                WebElement = webDriver.FindElement(by);
                InitializeJavaScriptExecutor();
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
                InitializeJavaScriptExecutor();
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSe(IWebDriver webDriver, By by, Func<ElementSe, bool> predicate)
        {
            try
            {
                WebElement = webDriver.FindElement(by, predicate);
                InitializeJavaScriptExecutor();
            }
            catch (NoSuchElementException)
            {
            }
        }

        public ElementSe(IWebElement webElement, By by, Func<ElementSe, bool> predicate)
        {
            try
            {
                WebElement = webElement.FindElement(by, predicate);
                InitializeJavaScriptExecutor();
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

        public string Name
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("name");
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

        public string Type
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("type");
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

        public ElementSe Parent
        {
            get
            {
                return new ElementSe(WebElement, By.XPath("./parent::*"));
            } 
        }

        public ElementSe Child
        {
            get
            {
                return new ElementSe(WebElement, By.XPath("./child::*"));
            }
        }

        // public ElementSe PreviousSibling
        //{
        //    get
        //    {
        //        return new ElementSe(WebElement, By.XPath("./preceding-sibling::*"));
        //    }
        //}

        public ElementSe NextSibling
        {
            get
            {
                return new ElementSe(WebElement, By.XPath("./following-sibling::*"));
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

        private IJavaScriptExecutor JavaScriptExecuter { get; set; }
        protected IWebDriver ElementsWebDriver { get; set; }

        //ADD A WHERE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! FOR LINQ!!!!
        public ElementSeCollection Elements
        {
            get
            {
                return new ElementSeCollection(WebElement, By.CssSelector("*"));
            }
        }

        public ButtonSeCollection Buttons
        {
            get
            {
                return new ButtonSeCollection(WebElement, By.TagName("input"), i => i.GetAttribute("type") == "button");
            }
        }

        public CheckBoxSeCollection CheckBoxes
        {
            get
            {
                return new CheckBoxSeCollection(WebElement, By.TagName("input"),
                                                i => i.GetAttribute("type") == "checkbox");
            }
        }

        public DivSeCollection Divs
        {
            get
            {
                return new DivSeCollection(WebElement, By.TagName("div"));
            }
        }

        public ImageSeCollection Images
        {
            get
            {
                return new ImageSeCollection(WebElement, By.TagName("img"));
            }
        }

        public LabelSeCollection Labels
        {
            get
            {
                return new LabelSeCollection(WebElement, By.TagName("label"));
            }
        }

        public LinkSeCollection Links
        {
            get
            {
                return new LinkSeCollection(WebElement, By.TagName("a"));
            }
        }

        public RadioButtonSeCollection RadioButtons
        {
            get
            {
                return new RadioButtonSeCollection(WebElement, By.TagName("input"), i => i.GetAttribute("type") == "radio");
            }
        }

        public SelectListSeCollection SelectLists
        {
            get
            {
                return new SelectListSeCollection(WebElement, By.TagName("select"));
            }
        }

        public SpanSeCollection Spans
        {
            get
            {
                return new SpanSeCollection(WebElement, By.TagName("span"));
            }
        }

        public TableBodySeCollection TableBodies
        {
            get
            {
                return new TableBodySeCollection(WebElement, By.TagName("tbody"));
            }
        }

        public TableCellSeCollection TableBodyCells
        {
            get
            {
                return new TableCellSeCollection(WebElement, By.TagName("td"));
            }
        }

        public TableCellSeCollection TableHeadCells
        {
            get
            {
                return new TableCellSeCollection(WebElement, By.TagName("td"));
            }
        }

        public TableHeadSeCollection TableHeads
        {
            get
            {
                return new TableHeadSeCollection(WebElement, By.TagName("thead"));
            }
        }

        public TableRowSeCollection TableRows
        {
            get
            {
                return new TableRowSeCollection(WebElement, By.TagName("tr"));
            }
        }

        public TableSeCollection Tables
        {
            get
            {
                return new TableSeCollection(WebElement, By.TagName("table"));
            }
        }

        public TextFieldSeCollection TextFields
        {
            get
            {
                return new TextFieldSeCollection(WebElement, By.TagName("input"), i => i.GetAttribute("type") == "text");
            }
        }

        public ElementSe Element(Predicate<ElementSe> predicate)
        {
            try
            {
                return Elements.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ButtonSe Button(Predicate<ElementSe> predicate)
        {
            try
            {
                return Buttons.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public CheckBoxSe CheckBox(Predicate<ElementSe> predicate)
        {
            try
            {
                return CheckBoxes.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DivSe Div(Predicate<ElementSe> predicate)
        {
            try
            {
                return Divs.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ImageSe Image(Predicate<ElementSe> predicate)
        {
            try
            {
                return Images.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public LabelSe Label(Predicate<ElementSe> predicate)
        {
            try
            {
                return Labels.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public LinkSe Link(Predicate<ElementSe> predicate)
        {
            try
            {
                return Links.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public RadioButtonSe RadioButton(Predicate<ElementSe> predicate)
        {
            try
            {
                return RadioButtons.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SelectListSe SelectList(Predicate<ElementSe> predicate)
        {
            try
            {
                return SelectLists.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SpanSe Span(Predicate<ElementSe> predicate)
        {
            try
            {
                return Spans.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public TableSe Table(Predicate<ElementSe> predicate)
        {
            try
            {
                return Tables.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public TextFieldSe TextField(Predicate<ElementSe> predicate)
        {
            try
            {
                return TextFields.Find(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void ExecuteScript(string script, params object[] args)
        {
            JavaScriptExecuter.ExecuteScript(script, args);
        }

        public void ExecuteAsyncScript(string script, params object[] args)
        {
            JavaScriptExecuter.ExecuteAsyncScript(script, args);
        }

        public T ConvertTo<T>() where T : ElementSe
        {
            var instance = Activator.CreateInstance(typeof(T), new object[] { WebElement }) as T;

            return instance;
        }

        public void Focus()
        {
            JavaScriptExecuter.ExecuteScript("arguments[0].focus();", WebElement);
        }

        public void Blur()
        {
            JavaScriptExecuter.ExecuteScript("arguments[0].blur();", WebElement);
        }

        public ElementSe FindElementSe(By by)
        {
            return new ElementSe(WebElement.FindElement(by));
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
            if (text == null)
            {
                text = string.Empty;
            }

            WebElement.SendKeys(text);
        }

        public void ClearFirstSendKeys(string text)
        {
            if (text == null)
            {
                text = string.Empty;
            }

            WebElement.Clear();
            WebElement.SendKeys(text);
        }

        public void Submit()
        {
            WebElement.Submit();
        }

        public void WaitUntilVisible(int timeoutTime = 5000)
        {
            int tempTime = 0;
            while (!WebElement.Displayed && tempTime <= timeoutTime)
            {
                Thread.Sleep(100);
                tempTime += 100;
            }
        }

        public void WaitUntilExists(int timeoutTime = 5000)
        {
            int tempTime = 0;
            while (!Exists && tempTime <= timeoutTime)
            {
                Thread.Sleep(100);
                tempTime += 100;
            }
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

        private void InitializeJavaScriptExecutor()
        {
            try
            {
                var wrappedElement = (IWrapsDriver)WebElement;
                ElementsWebDriver = wrappedElement.WrappedDriver;
                JavaScriptExecuter = (IJavaScriptExecutor)ElementsWebDriver;
            }
            catch (Exception)
            {
                ElementsWebDriver = null;
                JavaScriptExecuter = null;
            }
        }
    }
}
