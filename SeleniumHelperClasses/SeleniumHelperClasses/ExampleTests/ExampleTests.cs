/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumHelperClasses.Entities.Data;
using SeleniumHelperClasses.ElementTypes;
using SeleniumHelperClasses.Extensions;

namespace SeleniumHelperClasses.ExampleTests
{
    [TestFixture]
    public class ExampleTests
    {
        public IWebDriver WebDriver { get; set; }
        public IWebElement WebElement { get; set; }

        [SetUp]
        public virtual void Setup()
        {
            FirefoxProfile profile = new FirefoxProfile();

            //USE YOUR DEFAULT FIREFOX PROFILE!!! by un-commenting this code and commenting out the line above  -- it looks better, but doesnt work on evryones cpu
            //FirefoxProfileManager profileManager = new FirefoxProfileManager();
            //var profiles = profileManager.ExistingProfiles;
            //FirefoxProfile profile = profileManager.GetProfile(profiles.First());

            WebDriver = new FirefoxDriver(profile);
        }

        [Test]
        // This Test does not actually work. Just shows examples of how to use the classes.
        public void Class_Examples()
        {
            ElementSe ele = new ElementSe(WebDriver, By.Id("theId"));

            SelectListSe selectList = new SelectListSe(WebDriver, By.ClassName("theClassName"));
            
            selectList.SelectListItem("theOption");

            bool visible = selectList.IsVisible();
            string theSelectedItem = selectList.SelectedOption.Text;


            TableSe aTable = new TableSe(WebDriver, By.Id("anID"));
            
            // click cell 8 on row 4
            aTable.TableBody.Rows[5].Cells[9].Click();

            // clear the field and type Tiger in the first cell that contains Tigere in the first row that contains Cats  
            aTable.TableBody.Rows.First(i => i.Text == "Cats").Cells.First(i => i.Text == "Tigere").ClearFirstSendKeys("Tiger");
        }

        [Test]
        public void Loan_Calculator_Test_WITH_Comments()
        {
            WebDriver.Navigate().GoToUrl("http://www.bankrate.com/calculators/mortgages/loan-calculator.aspx");

            //This just grabs the first element on the page with a classname of "pageHolder". In this case it is a div that holds the main page.
            ElementSe pageHolderdivClass = new ElementSe(WebDriver, By.ClassName("pageHolder"));

            /* The next two lines of code essentially perform the same operations except by passing in the WebDriver as the first parameter
               you are searching the entire page for the id that was passed into the second parameter.
               by passing in the pageHolderDivClass that we obtained in the previous line of code, only the Page Holder Div is searched for the
               id passed in the second parameter.   --- its useful when dealing with a page that contains alot of similiar divs. you can search one instead of all.*/
            ElementSe loanAmount_searchWholePage = new ElementSe(WebDriver, By.Id("ctl00_well_DefaultUC_loanAmount"));
            ElementSe loanAmount_searchPageHolderDiv = new ElementSe(pageHolderdivClass, By.Id("ctl00_well_DefaultUC_loanAmount"));


            // Clears the text currently located in the field then writes 3000.00.
            loanAmount_searchPageHolderDiv.ClearFirstSendKeys("3000.00");

            SelectListSe month = new SelectListSe(WebDriver, By.Id("ctl00_well_DefaultUC_LoanMonth"));

            // verify the selectlist is present on the page and the selected option is "Jan"
            Assert.IsTrue(month.Exists);
            Assert.IsTrue(month.SelectedOption.Text == "Jan");

            // change the selected option to "Aug"
            month.SelectListItem("Aug");

            // ok lets pretend that the calculate button did not have an id and there were more than one button with the classname of "smurf-btn"
            // We can search by using a LinQ statement.
            // Here we are search for an element with a classname of "smurf-btn" and a Value of "Calculate". --- We have to use value on this search because the button does not actually contain text.
            // I'm still working on the code. In a while you will be able to use: 
            // ElementSe calcButton = new ElementSe(WebDriver, By.ClassName("smurf-btn"), i => i.Value == "Calculate"); -- instead of
            ElementSe calcButton = new ElementSe(WebDriver, By.ClassName("smurf-btn"), i => i.GetAttribute("value") == "Calculate");
            calcButton.Click();
        }

        [Test]
        public void Loan_Calculator_Test_WITHOUT_Comments()
        {
            WebDriver.Navigate().GoToUrl("http://www.bankrate.com/calculators/mortgages/loan-calculator.aspx");

            ElementSe pageHolderdivClass = new ElementSe(WebDriver, By.ClassName("pageHolder"));

            ElementSe loanAmount_searchWholePage = new ElementSe(WebDriver, By.Id("ctl00_well_DefaultUC_loanAmount"));
            ElementSe loanAmount_searchPageHolderDiv = new ElementSe(pageHolderdivClass, By.Id("ctl00_well_DefaultUC_loanAmount"));

            loanAmount_searchPageHolderDiv.ClearFirstSendKeys("3000.00");

            SelectListSe month = new SelectListSe(WebDriver, By.Id("ctl00_well_DefaultUC_LoanMonth"));

            Assert.IsTrue(month.Exists);
            Assert.IsTrue(month.SelectedOption.Text == "Jan");

            month.SelectListItem("Aug");


            ElementSe calcButton = new ElementSe(WebDriver, By.ClassName("smurf-btn"), i => i.GetAttribute("value") == "Calculate");
            calcButton.Click();
        }

        [TearDown]
        public virtual void TearDown()
        {
            WebDriver.Dispose();
        }
    }
}