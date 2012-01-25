/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using OpenQA.Selenium;

namespace WebDriverSEd.Extensions
{
    public static class WebDriverExtensions
    {
        public static IJavaScriptExecutor GetJavaScriptExecutor(this IWebDriver webDriver)
        {
            return (IJavaScriptExecutor)webDriver;
        }
    }
}