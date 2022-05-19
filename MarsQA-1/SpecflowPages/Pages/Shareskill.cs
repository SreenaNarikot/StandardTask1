using AutoItX3Lib;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class Shareskill
    {
        private IWebDriver driver;
        public Shareskill(IWebDriver driver)
        {
            this.driver = driver;
        }
        //SHARESKILL LOCATORS
        //Locate title button
        IWebElement addtitle => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
        //Locate the textbox description
        IWebElement adddescription => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
        //Locate category dropdown
        IWebElement categorydropdown => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select"));
        //Locate the element subcategory dropdown
        IWebElement subcategorydropdown => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
        //Locate the element tags textbox
        IWebElement tagstextbox => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        //Locate the radio button one-off service
        IWebElement oneOffService => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
        //Locate the radiobutton On-Site
        IWebElement onSite => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
        //Locate the element startdate
        IWebElement startDate => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
        //Locate the element Enddate
        IWebElement endDate => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        //Locate Skill exchange under skilltrade
        IWebElement selectSkillTrade => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
        //Locate the tag skillexchangetextbox
        IWebElement skillExchangetag => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        //Locate the hidden
        IWebElement hiddenbutton => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
        //Locate Save button
        IWebElement savebutton => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
        //Locating the message for shareskill creation
        IWebElement messagedisplayed => driver.FindElement(By.XPath("//div[text()='Service Listing Added successfully']"));

        public void CreateShareSkill(string title, string description, string category, string subcategory, string tags, string servicetype, string locationtype, string startdate, string enddate, string selectday, string starttime, string endtime, string skilltrade, string skillexchange, string active)
        {
            // click title and input values
            addtitle.Click();
            addtitle.SendKeys(title);

            //Input values to description
            adddescription.SendKeys(description);

            //Click the dropdown category and slect the required value
            categorydropdown.Click();
            SelectElement selectcategory = new SelectElement(categorydropdown);
            selectcategory.SelectByText(category);

            //Click the dropdown subcategory and selct by text
            subcategorydropdown.Click();
            SelectElement selectsubcategory = new SelectElement(subcategorydropdown);
            selectsubcategory.SelectByText(subcategory);

            //Click the textbox tags and insert value and press enter
            tagstextbox.Click();       
            tagstextbox.SendKeys(tags);
            tagstextbox.SendKeys(Keys.Enter);

            //Select servicetye
            Selectservicetype(servicetype);
            //Select locationtype
            Selectlocationtype(locationtype);

            //Click the start date and insert value
            startDate.Click();
            startDate.SendKeys(startdate);

            //Click the textbox enddate and insert value
            endDate.Click();
            endDate.SendKeys(enddate);

            //Identify the day ,starttime and end time
            selectdayandtime(selectday,starttime,endtime);

            //Identify the Skill Exchange button under skill trade and click
            selectSkillTrade.Click();

            //Identify skillExcahange text box and insert value and press enter
            skillExchangetag.SendKeys(skillexchange);
            skillExchangetag.SendKeys(Keys.Enter);

            //FileUpload
            SamplefileUpload();

            //Click the element 'hidden' in the Active
            hiddenbutton.Click();

            //Click Save button
            Wait.WaitToBeClickable(driver, "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]", 3);
            savebutton.Click();
        }
        //Common method for servicetype
        public void Selectservicetype(string servicetype)
        {
            //Click the Servicetype one-off service button and click
            if (servicetype == "One-off service")
            {
                oneOffService.Click();
            }
        }
        //Common method for locationtype
        public void Selectlocationtype(string locationtype)
        {
            //Click the  button 'On-site' under locationtype and click
            if (locationtype == "On-site")
            {
                onSite.Click();
            }

        }

        //Common method to select Day and its start and end time
        public void selectdayandtime(string selectday,string starttime ,string endtime)
        {
            for (int row = 2; row <= 8; row++)
            {
                var day = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div["+ row +"]/div[1]/div/input"));

                //Identify the start time 
                IWebElement selectStarttime = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div["+ row + "]/div[2]/input"));
        
                //Identify the endtime 
                IWebElement selectEndTime = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + row + "]/div[3]/input"));
 
                var label = driver.FindElement(By.XPath("//div[@class='fields']["+ row +"]/div/div//label"));
                if (selectday == label.Text)
                {
                    day.Click();
                    selectStarttime.Click();
                    //input value to startdate
                    selectStarttime.SendKeys(starttime);
                    selectEndTime.Click();
                    //inputvalue to endtime
                    selectEndTime.SendKeys(endtime);
                }

            }
        }
        //Method for File Upload
       public void SamplefileUpload()
        {
            IWebElement fileUpload = driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));
            fileUpload.Click();
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            Thread.Sleep(1000);
            autoIt.Send(Path.GetFullPath(ConstantHelpers.Filepath));
            Thread.Sleep(2000);
            autoIt.Send("{ENTER}");
        }
        //Validating the created shareskill
        public string validatemessage()
        {
            return messagedisplayed.Text;
        }

        //Error Message checking for create ShareSkill
        public string  Geterrormessage()
        {
                //Identify the error message
                IWebElement message = driver.FindElement(By.XPath("//div[text()='Please complete the form correctly.']"));
                //if (message.Text == "Please complete the form correctly.")
                return message.Text;
        }
        public void editshareskilltitle(string newtitle)
        {
            // click title and input values
            addtitle.Clear();
            addtitle.Click();
            addtitle.SendKeys(newtitle);
            //Click Save button
            Wait.WaitToBeClickable(driver, "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]", 3);
            savebutton.Click();
        }
    }
}
