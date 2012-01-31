/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using OpenQA.Selenium.Support.UI;
using WebDriverSEd.ElementTypes;

namespace WebDriverSEd.Extensions
{
    public static class ControlExtensions
    {
        public static bool IsVisible(this ElementSe target)
        {
            if (target.Style.ToLower().Trim() == "block")
            {
                return true;
            }

            if (target.ClassName.ToLower().Contains("lightbox") && target.Style.ToLower().Trim() != "block")
            {
                return false;
            }

            if (target.Style.ToLower().Trim() == "none" || target.ClassName.ToLower().Contains("hidden"))
            {
                return false;
            }

            return true;
        }
    }
}