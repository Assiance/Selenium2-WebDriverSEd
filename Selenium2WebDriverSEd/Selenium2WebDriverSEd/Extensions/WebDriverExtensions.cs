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
        /// <summary>
        /// Finds the next tab in the current window that matches the given title and switches focus to it. 
        /// Easier than finding by window name/handle.
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="tabTitle">The title contained within the header of the web page.</param>
        public static void SwitchTo(this IWebDriver webDriver, string tabTitle)
        {
            var correctWindow = false;
            var attempts = 0;

            while (correctWindow == false && attempts < webDriver.WindowHandles.Count)
            {
                foreach (var winHandle in webDriver.WindowHandles)
                {
                    webDriver.SwitchTo().Window(winHandle);
                    var currentWindowTitle = webDriver.Title.Trim();

                    if (currentWindowTitle == tabTitle)
                    {
                        correctWindow = true;
                        break;
                    }

                    attempts++;
                }
            }
        }
    }
}