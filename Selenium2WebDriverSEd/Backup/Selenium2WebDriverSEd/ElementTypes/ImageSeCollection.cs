/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Collections.Generic;
using WebDriverSEd.Extensions;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ImageSeCollection : BaseSeCollection<ImageSe>
    {
        public ImageSeCollection()
        {
        }

        public ImageSeCollection(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        public ImageSeCollection(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ImageSeCollection(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ImageSeCollection(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ImageSeCollection(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }
    }
}