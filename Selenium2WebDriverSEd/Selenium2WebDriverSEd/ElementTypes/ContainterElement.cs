/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;
namespace WebDriverSEd.ElementTypes
{
    public abstract class ContainterElement : BaseElementSe
    {
        public ContainterElement(IWebElement webElement)
            : base(webElement)
        {
        }

        public ContainterElement(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ContainterElement(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ContainterElement(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ContainterElement(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

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

        public ElementSe Element(Predicate<BaseElementSe> predicate)
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

        public ButtonSe Button(Predicate<BaseElementSe> predicate)
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

        public CheckBoxSe CheckBox(Predicate<BaseElementSe> predicate)
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

        public DivSe Div(Predicate<BaseElementSe> predicate)
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

        public ImageSe Image(Predicate<BaseElementSe> predicate)
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

        public LabelSe Label(Predicate<BaseElementSe> predicate)
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

        public LinkSe Link(Predicate<BaseElementSe> predicate)
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

        public RadioButtonSe RadioButton(Predicate<BaseElementSe> predicate)
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

        public SelectListSe SelectList(Predicate<BaseElementSe> predicate)
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

        public SpanSe Span(Predicate<BaseElementSe> predicate)
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

        public TableSe Table(Predicate<BaseElementSe> predicate)
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

        public TextFieldSe TextField(Predicate<BaseElementSe> predicate)
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
    }
}