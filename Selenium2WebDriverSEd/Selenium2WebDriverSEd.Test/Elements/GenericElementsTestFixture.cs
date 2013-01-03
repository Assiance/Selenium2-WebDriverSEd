using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverSEd.ElementTypes;
using WebDriverSEd.Extensions;

namespace Selenium2WebDriverSEd.Test.Elements
{
    [TestFixture]
    public class GenericElementsTestFixture
    {
        public IWebDriver WebDriver { get; set; }
        public IWebElement WebElement { get; set; }

        [SetUp]
        public virtual void Setup()
        {
            FirefoxProfile profile = new FirefoxProfile();
            WebDriver = new FirefoxDriver(profile);
        }

        [Test]
        public void ExtraElementInfoTest()
        {
            WebDriver.Navigate().GoToUrl("https://stratusbeta.com/");
            var r = new ElementSe(WebDriver, By.TagName("body")).Links;
            LinkSe CreateSiteLink = new LinkSe(WebDriver, By.LinkText("Create a new site"));
            Assert.AreEqual(CreateSiteLink.Url, "https://onrealm.org/Site/Create");

            DivSe buttonsDiv = new DivSe(WebDriver, By.CssSelector("#login form ul li div.buttons"));
            Assert.AreEqual(buttonsDiv.ClassName, "buttons");

            ButtonSe continueButton = new ButtonSe(WebDriver, By.Id("Continue"));          
            Assert.AreEqual(continueButton.ElementTag, "input");
            Assert.AreEqual(continueButton.Value, "Continue");
            Assert.AreEqual(continueButton.Id, "Continue");
            Assert.AreEqual(continueButton.Type, "button");

            continueButton.Click();

            CheckBoxSe rememberMeCheckBox = new CheckBoxSe(WebDriver, By.Id("rememberMe"));
            Assert.AreEqual(rememberMeCheckBox.Title, "Check this box if you would like us to remember your user name and password for 6 months.");
            Assert.AreEqual(rememberMeCheckBox.Name, "rememberMe");
            Assert.AreEqual(rememberMeCheckBox.IsChecked, false);
            
            rememberMeCheckBox.Click();
            Assert.AreEqual(rememberMeCheckBox.IsChecked, true);

            LabelSe rememberMeLabel = new LabelSe(WebDriver, By.CssSelector("#login form ul.horizontal li p.buttons label"));
            Assert.AreEqual(rememberMeLabel.For, null);
            Assert.AreEqual(rememberMeLabel.Text, "Remember me");
        }

        [Test]
        public void FindElementsByLinQTest()
        {
            WebDriver.Navigate().GoToUrl("https://stratusbeta.com/");

            LinkSe createNewSiteLink = new LinkSe(WebDriver, By.TagName("a"), i => i.Text == "Create a new site");
            createNewSiteLink.WaitUntilVisible();
        }

        [Test]
        public void MyTest2()
        {
            WebDriver.Navigate().GoToUrl("http://www.nuget.org");

            var searchBox = WebDriver.FindElement(By.Id("searchBoxInput"));
            searchBox.SendKeys("WebDriver");

            var searchButton = WebDriver.FindElement(By.Id("searchBoxSubmit"));
            searchButton.Click();

            var links = new LinkSeCollection(WebDriver);

            var searchResults = WebDriver.FindElement(By.Id("searchResults"));
            var theListItems = searchResults.FindElements(By.TagName("li"));

            var searchResults2 = WebDriver.FindElement(By.Id("searchResults"));
            var theListItems2 = searchResults.FindElements(By.CssSelector("ol#searchResults > li"));

            var webDriverSEdLI = theListItems2.First(item => item.Text.Contains("WebDriverSEd"));
            //var thePackage = results.First(i => i.Text.Contains("WebDriverSEd"));
            //thePackage.FindElement(By.TagName("a")).Click();

            webDriverSEdLI.FindElement(By.TagName("a")).Click();

            var theTable = WebDriver.FindElements(By.TagName("table"));

            var table = new TableSeCollection(WebDriver, By.ClassName("sexy-table"));
        }

        [TearDown]
        public virtual void TearDown()
        {
            WebDriver.Dispose();
        }
    }
}
