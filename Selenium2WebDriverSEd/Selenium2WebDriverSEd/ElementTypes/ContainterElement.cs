/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using OpenQA.Selenium;
namespace WebDriverSEd.ElementTypes
{
    public abstract class ContainterElement : ElementSe
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

        public ElementSe Element(Predicate<ElementSe> predicate)
        {
            try
            {
                return Elements.Elements.Find(predicate);
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
                return Buttons.Elements.Find(predicate).ConvertTo<ButtonSe>();
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
                return CheckBoxes.Elements.Find(predicate).ConvertTo<CheckBoxSe>();
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
                return Divs.Elements.Find(predicate).ConvertTo<DivSe>();
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
                return Images.Elements.Find(predicate).ConvertTo<ImageSe>();
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
                return Labels.Elements.Find(predicate).ConvertTo<LabelSe>();
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
                return Links.Elements.Find(predicate).ConvertTo<LinkSe>();
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
                return RadioButtons.Elements.Find(predicate).ConvertTo<RadioButtonSe>();
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
                return SelectLists.Elements.Find(predicate).ConvertTo<SelectListSe>();
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
                return Spans.Elements.Find(predicate).ConvertTo<SpanSe>();
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
                return Tables.Elements.Find(predicate).ConvertTo<TableSe>();
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
                return TextFields.Elements.Find(predicate).ConvertTo<TextFieldSe>();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}