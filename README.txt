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
