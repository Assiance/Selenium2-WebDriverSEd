Selenium  2.0 (WebDriver) Helper Classes ---Only For C#---

Make sure to let me know if you are having any issues with anything and I will get to fixing them as soon as I can
or if you are up to it you are welcome to give fixing it a try. Just send the files and I will get them in the repo 
as soon as possible and also make sure to give you some credit. This repo is sure to stay active. My company is 
planning on writing their tests for most of their software in selenium and I'm in the process of converting 2000+ tests. 
So I'm busy trying to make re-writing those tests as easy as possible.


Sample. You may copy and paste code

[Test]
public void Class_Examples()
{
    ElementSe ele = new ElementSe(WebDriver, By.Id("theId"));
            

    SelectListSe selectList = new SelectListSe(WebDriver, By.ClassName("theClassName"));
            
    selectList.SelectListItem("theOption");

    bool visible = selectList.IsVisible();
    string theSelectedItem = selectList.GetSelectedItem();


    TableSe aTable = new TableSe(WebDriver, By.Id("anID"));
            
    // click cell 8 on row 4
    aTable.TableBody.Rows[5].Cells[9].Click();

    // clear the field and type Tiger in the first cell that contains Tigere in the first row that contains Cats  
    aTable.TableBody.Rows.First(i => i.Text == "Cats").Cells.First(i => i.Text == "Tigere").ClearFirstSendKeys("Tiger");
}




//************************----WebDriver Vs. WebDriverSEd----*************************
[Test]
public void WebDriver_Vs_WebDriverSEd()
{
    //The same for both
    WebDriver.Navigate().GoToUrl("http://www.bankrate.com/calculators/mortgages/loan-calculator.aspx");

    //Initializing******************************************************

    //***webDriver
    //IWebElement pageHolderdivClass = WebDriver.findElement(By.ClassName("pageHolder"));
    //***WebDriverSEd
     ElementSe pageHolderdivClass = new ElementSe(WebDriver, By.ClassName("pageHolder"));

    //***webDriver
    //IWebElement loanAmount_searchWholePage = WebDriver.findElement(By.Id("ctl00_well_DefaultUC_loanAmount"));
    //IWebElement loanAmount_searchPageHolderDiv = pageHolderdivClass.findElement(By.Id("ctl00_well_DefaultUC_loanAmount"));
    //***WebDriverSEd
    ElementSe loanAmount_searchWholePage = new ElementSe(WebDriver, By.Id("ctl00_well_DefaultUC_loanAmount"));
    ElementSe loanAmount_searchPageHolderDiv = new ElementSe(pageHolderdivClass, By.Id("ctl00_well_DefaultUC_loanAmount"));

    //Sending Keys******************************************************

    //***WebDriver
    //pageHolderdivClass.Clear();
    //pageHolderdivClass.SendKeys("3000.00");
    //***WebDriverSEd
    pageHolderdivClass.ClearFirstSendKeys("3000.00");

    // Using a SelectList***************************************************

    //***webDriver
    //IWebElement month = WebDriver.findElement(By.Id("ctl00_well_DefaultUC_LoanMonth"));
    //***webDriverSEd
    SelectListSe month = new SelectListSe(WebDriver, By.Id("ctl00_well_DefaultUC_LoanMonth"));

    //***WebDriver
    //SelectElement monthSelect = new SelectElement(month);
    //Assert.IsTrue(monthSelect.SelectedOption.Text == "Jan");
    //***WebDriverSEd
    Assert.IsTrue(month.SelectedOption.Text == "Jan");

    //***WebDriver
    //monthSelect.SelectListItem("Aug");
    //***WebDriverSEd
    month.SelectListItem("Aug");

    // Using LinQ Statements
            
    //***WebDriver
    //There isnt a way to do LinQ statements in the webdriver therefore you would have to use the xpath or css selectors to find this element.
    //***WebDriverSEd
    new ButtonSe(WebDriver, By.ClassName("smurf-btn"), i => i.GetAttribute("value") == "Calculate").Click();
}