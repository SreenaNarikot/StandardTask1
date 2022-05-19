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
    internal class ManageListings 
    {
        private IWebDriver driver;
        public ManageListings(IWebDriver driver)
        {
            this.driver = driver;
        }

        //MANAGELISTINGS TAB LOCATORS
        //locate the manage listings tab
        IWebElement Managelisting => driver.FindElement(By.XPath("//*[@id='service-listing-section']/section[1]/div/a[3]"));
        IWebElement managelistingonhome => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));
        IWebElement title => driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        //Locate the edit button
        IWebElement editbutton => driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
        //Locating Nolistings
        IWebElement Nolistings => driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/h3"));
        // list all the records in the Managelistings 
        public void Clickmanagelistings()
        {
            // Identify the element  managelistings
            Wait.TurnOnWaitIAlert(driver,30);
            Managelisting.Click();
 
        }
        public string gettitlemanagelistings()
        {
           return title.Text;
        }
        public void managelistingsonhome()
        {
            Thread.Sleep(2000);
            managelistingonhome.Click();
        }
        // Click on editmanagelisting
        public void ClickEditlistings()
        {
            // Identify the element  managelistings
             editbutton.Click();
        }
        public void EditListings(string newtitle)
        {
            Shareskill shareskill = new Shareskill(driver);
            shareskill.editshareskilltitle(newtitle);
        }

        //Delete the selected shareskill record
        public void DeleteShareSkillListing(string title)
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
        public string DeletePopupmessage()
        {
            Wait.WaitToBeClickable(driver, "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']", 3);
            //Identify the element Add new button and click on it
            IWebElement deletedMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"));
            string deletedmessagetitle = deletedMessage.Text;
            return deletedmessagetitle;

        }
        public string NoListingmessage()
        {
            return Nolistings.Text;
        }
    }
}
