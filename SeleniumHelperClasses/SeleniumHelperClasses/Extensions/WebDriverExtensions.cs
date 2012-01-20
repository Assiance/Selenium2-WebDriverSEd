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

namespace SeleniumHelperClasses.Extensions
{
    public static class WebDriverExtensions
    {
        public static IJavaScriptExecutor GetJavaScriptExecutor(this IWebDriver webDriver)
        {
            return (IJavaScriptExecutor)webDriver;
        }
    }
}