using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class HomePage
    {
        public void GoToProfile(IWebDriver driver)
        {

            //Identify the element profile tab and click on it
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[1]/div/a[2]", 3);
            IWebElement profile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            profile.Click();                                   
        }
        
        public void GoToSkillstab(IWebDriver driver)
        {
            IWebElement skillstab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillstab.Click();
        }
        
    }
}
