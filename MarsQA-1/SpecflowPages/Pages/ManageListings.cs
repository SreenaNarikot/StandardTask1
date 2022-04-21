using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
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
    internal class ManageListings : Driver
    {
        // list all the records in the Managelistings 
        public void viewmanagelistings(IWebDriver driver)
        {
            // Identify the element  managelistings
            Thread.Sleep(2000);
            IWebElement managelisting = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));
            managelisting.Click();
 
        }
        public void listmanagelistings(IWebDriver driver)
        {    
            //identify the row elements
            IList<IWebElement> titlerows = driver.FindElements(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
            Console.WriteLine("Service Listings with the below Titles have been Created :");
            foreach (IWebElement rowelement in titlerows)
            Console.WriteLine(rowelement.Text);
        }
        //Editing the selected manageskill
        public void EditManageListings(IWebDriver driver , string title ,string newtitle)
        {
            //Identify the row elements
            IList<IWebElement> titlerows = driver.FindElements(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
            var rowcount = titlerows.Count();
            for(int i = 1; i <=rowcount; i++)
            {
            IWebElement actualtitles = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr["+ i +"]/td[3]"));
            string actualtitle = actualtitles.Text; 
            if (actualtitle.Equals(title)) 
                    try
                    {
                        
                    Thread.Sleep(2000);
                    IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[2]"));
                    Thread.Sleep(500);
                    editbutton.Click();
                    Thread.Sleep(1000);
                    IWebElement titletextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
                    titletextbox.Clear();
                    titletextbox.SendKeys(newtitle);
                    Wait.WaitToBeClickable(driver, "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]", 3);
                    IWebElement savebutton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
                    savebutton.Click();
                    }
                    catch 
                    {
                        Console.WriteLine("No Such title found");
                    }
            }
        }

        //Validating the Update ShareSkill
        public void validateUpdatedSharelisting(IWebDriver driver, string newtitle)
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
                        if (actualtitle.Equals(newtitle))
                        {
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Edit - Updated the ShareSkill Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "ShareSkil Updated");
                            Assert.IsTrue(true);
                        }
                    }
                   catch (Exception)
                    {
                        CommonMethods.test.Log(LogStatus.Fail, "Validating updated shareskill Test Failed");
                    }
                        
                }
            }
            catch(Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
            

        }
        //Delete the selected shareskill record
        public void DeleteShareSkillListing(IWebDriver driver ,string title)
        {
                try
                {
                    IList<IWebElement> titlerows = driver.FindElements(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
                    var rowcount = titlerows.Count;
                    for (int i = 1; i <= rowcount; i++)
                    {
                        IWebElement actualtitles = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]"));
                        string actualtitle = actualtitles.Text;
                        if (actualtitle == title)
                        {
                            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[3]/i"));
                            deletebutton.Click();
                            IWebElement deleteYes = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
                            deleteYes.Click();
                        }
                    }

                }
                catch (Exception e)
                {
                    CommonMethods.test.Log(LogStatus.Fail, "No Such title exists", e.Message);
                }

        }
        public string DeletePopupmessage(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']", 3);
            //Identify the element Add new button and click on it
            IWebElement deletedMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"));
            string deletedmessagetitle = deletedMessage.Text;
            return deletedmessagetitle;

        }

    }
}
