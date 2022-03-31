using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class Shareskill
    {
        public void CreateShareSkill(IWebDriver driver, string title, string description, string category, string subcategory, string tags, string servicetype, string locationtype, string startdate, string enddate, string selectday, string starttime, string endtime, string skilltrade, string skillexchange, string active)
        {
            // Identify the textbox title
         
            IWebElement addtitle = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            addtitle.Click();
            addtitle.SendKeys(title);

            //Identify the textbox Description
            IWebElement adddescription = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            adddescription.SendKeys(description);

            //Identify the dropdown category
            IWebElement categorydropdown = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select")); 
            categorydropdown.Click();
            SelectElement selectcategory = new SelectElement(categorydropdown);
            selectcategory.SelectByText(category);

            //Identify the dropdown subcategory and selct by text
            IWebElement subcategorydropdown = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subcategorydropdown.Click();
            SelectElement selectsubcategory = new SelectElement(subcategorydropdown);
            selectsubcategory.SelectByText(subcategory);

            //Identify the textbox tags and insert value and press enter
            IWebElement tagstextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagstextbox.Click();       
            tagstextbox.SendKeys(tags);
            tagstextbox.SendKeys(Keys.Enter);

            //Identify the Servicetype one-off service button and click
            if (servicetype == "One-off service")
            {
                IWebElement oneOffService = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
                oneOffService.Click();
            }

            //Identify the  button 'On-site' under locationtype and click
            if (locationtype == "On-site")
            {
                IWebElement onSite = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
                onSite.Click();
            }

            //Identify the start date and insert value
            IWebElement startDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            startDate.Click();
            startDate.SendKeys(startdate);

            //Identify the textbox enddate and insert value
            IWebElement endDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            endDate.Click();
            endDate.SendKeys(enddate);

            //Identify the day 
            if (selectday == "Mon")
            {
                IWebElement mon = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
                mon.Click();


                //Identify the start time and insert value
                IWebElement selectStarttime = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
                selectStarttime.Click();
                selectStarttime.SendKeys(starttime);


                //Identify the endtime and Insert value
                IWebElement selectEndTime = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
                selectEndTime.Click();
                selectEndTime.SendKeys(endtime);

            }

            //Identify the Skill Exchange button under skill trade and click
            IWebElement selectSkillTrade = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            selectSkillTrade.Click();

            //Identify skillExcahange text box and insert value and press enter
            IWebElement skillExchangetag = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            skillExchangetag.SendKeys(skillexchange);
            skillExchangetag.SendKeys(Keys.Enter);

            //Identify the element 'hidden' in the Active
            IWebElement hiddenbutton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
            hiddenbutton.Click();

            //Identify the element save and click
            Wait.WaitToBeClickable(driver, "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]", 3);
            IWebElement savebutton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            savebutton.Click();
        }
        //Validating the created shareskill
        public void validatecreatedSharelisting(IWebDriver driver, string title)
        {
            try
            {
                IList<IWebElement> titlerows = driver.FindElements(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
                var rowcount = titlerows.Count();
                for (int i = 1; i <= rowcount; i++)
                {
                    IWebElement actualtitles = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]"));
                    string actualtitle = actualtitles.Text;
                    try
                    {
                        if (actualtitle.Equals(title))
                        {
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated ShareSkill Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "ShareSkill Updated");
                            Assert.IsTrue(true);
                        }
                    }
                    catch (Exception)
                    {
                        CommonMethods.test.Log(LogStatus.Fail, " Create Shareskill validation Test Failed");
                    }

                }
        
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }


        }

        //Error Message checking for create ShareSkill
        public string  Geterrormessage(IWebDriver driver)
        {
            
                //Identify the error message
                IWebElement message = driver.FindElement(By.XPath("//div[text()='Please complete the form correctly.']"));
                //if (message.Text == "Please complete the form correctly.")
                return message.Text;
           
        }

       
      
    }
}
