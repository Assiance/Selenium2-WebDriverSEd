using OpenQA.Selenium;

namespace SeleniumHelperClasses.ElementTypes
{
    public abstract class ControlSe : ElementSe
    {
        public ControlSe(IWebDriver webDriver, By by)
            : base(webDriver, by)
        {
        }

        public ControlSe(IWebElement webElement, By by)
            : base(webElement, by)
        {
        }

        public IWebDriver WebDriver { get; set; }
    }
}
