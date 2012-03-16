/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;

namespace WebDriverSEd.ElementTypes
{
    public class ImageSe : BaseElementSe
    {
        public ImageSe(IWebElement webElement)
            : base(webElement)
        {
        }

        public ImageSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ImageSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public ImageSe(IWebDriver webDriver, By by, Func<IWebElement, bool> predicate)
            : base(webDriver, by, predicate)
        {
        }

        public ImageSe(IWebElement webElement, By by, Func<IWebElement, bool> predicate)
            : base(webElement, by, predicate)
        {
        }

        public override string ElementTag
        {
            get { return "img"; }
        }

        public string Alt
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("alt");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public string Source
        {
            get
            {
                try
                {
                    return WebElement.GetAttribute("src");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}