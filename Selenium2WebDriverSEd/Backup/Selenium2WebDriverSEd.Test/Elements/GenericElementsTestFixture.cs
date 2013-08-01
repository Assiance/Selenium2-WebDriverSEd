using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverSEd.ElementTypes;
using WebDriverSEd.Extensions;
using System.Threading;

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
        public void OrigLinkTest()
        {
            WebDriver.Navigate().GoToUrl("http://w3schools.com/html/html_links.asp");

            var link = WebDriver.FindElement(By.LinkText("Visit W3Schools"));
            link.Click();
            Thread.Sleep(1000);

            var headerDiv = WebDriver.FindElement(By.Id("headerdiv1"));
            Assert.IsTrue(headerDiv.Text.Contains("At w3schools.com you will learn how to make a website."));
        }

        [Test]
        public void EdLinkTest()
        {
            WebDriver.Navigate().GoToUrl("http://w3schools.com/html/html_links.asp");

            var link = new LinkSe(WebDriver, By.LinkText("Visit W3Schools"));
            link.Click();
            Thread.Sleep(1000);

            var headerDiv = new DivSe(WebDriver, By.Id("headerdiv1"));
            Assert.IsTrue(headerDiv.Text.Contains("At w3schools.com you will learn how to make a website."));
        }

        [Test]
        public void OrigImgTest()
        {
            WebDriver.Navigate().GoToUrl("http://www.w3schools.com/html/html_images.asp");
            Thread.Sleep(500);

            var image = WebDriver.FindElement(By.CssSelector("html body div div div div div.example div.example_result img"));

            Assert.AreEqual(image.GetAttribute("src"), "http://www.w3schools.com/images/pulpit.jpg");  
        }
       
        [Test]
        public void OrigTableTest()
        {
            WebDriver.Navigate().GoToUrl("http://www.w3schools.com/html/html_tables.asp");

            var fruitTable = WebDriver.FindElement(By.CssSelector("html body div div div div div.example table.reference"));
                
            Assert.AreEqual(fruitTable.Displayed, true);

            var rows = fruitTable.FindElements(By.TagName("tr"));

            Assert.AreEqual(rows.Count, 4); 
        }


        [TearDown]
        public virtual void TearDown()
        {
            WebDriver.Dispose();
        }
    }
}