using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Stepdefinitions
{
    [Binding]
    internal class ManageListingStepdefinitions : Driver
    {
        HomePage homePage = new HomePage(driver);
        Shareskill shareskill= new Shareskill(driver);
        ManageListings manageListings = new ManageListings(driver);

    
        [Given(@": I am on my Profilepage")]
        public void GivenIAmOnMyProfilepage()
        {
            homePage.GoToProfile();
        }

        [When(@": When i create new shareskill with valid '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)',  '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' details")]
        public void WhenWhenICreateNewShareskillWithValidDetails(string c, string p1, string p2, string other, string programming, string p5, string p6, string p7, string p8, string mon, string p10, string p11, string p12, string p13, string hidden)
        {
            homePage.GoToShareSkill();
            shareskill.CreateShareSkill(c, p1, p2, other, programming, p5, p6, p7, p8, mon, p10, p11, p12, p13, hidden);
        }

        [When(@": I Click managelistings tab")]
        public void WhenIClickManagelistingsTab()
        {
            manageListings.Clickmanagelistings();
        }

        [Then(@": I should be able to see the shareskill listings with '([^']*)'")]
        public void ThenIShouldBeAbleToSeeTheShareskillListingsWith(string c)
        {
            string expectedtitle = manageListings.gettitlemanagelistings();
            Assert.AreEqual(expectedtitle,c);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Manage Listings displayed");
        }

        [When(@"I Click editbut ton of a skillshare listing")]
        public void WhenIClickEditbutTonOfASkillshareListing()
        {
            manageListings.managelistingsonhome();
            manageListings.ClickEditlistings();
        }

        [Then(@":I should be able to to change from title to new '([^']*)'")]
        public void ThenIShouldBeAbleToToChangeFromTitleToNew(string newtitle)
        {
            manageListings.EditListings(newtitle);
            string expectedtitle = manageListings.gettitlemanagelistings();
            Assert.AreEqual(expectedtitle,newtitle);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Manage Listings Updated");
        }


        [When(@": I click delete button under shareskills which has '([^']*)' as title")]
        public void WhenIClickDeleteButtonUnderShareskillsWhichHasAsTitle(string title)
        {
            manageListings.managelistingsonhome();
            manageListings.DeleteShareSkillListing(title);
        }

        [Then(@": ShareSkill with the '([^']*)' must be deleted successfully")]
        public void ThenShareSkillWithTheMustBeDeletedSuccessfully(string title)
        {
            string expectedmessage = title + " has been deleted";
            string actualmessage = manageListings.DeletePopupmessage();
            Assert.AreEqual(expectedmessage,actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Manage Listing Deleted");
        }

        [When(@": I Click managelistings")]
        public void WhenIClickManagelistings()
        {
            manageListings.managelistingsonhome();
        }

        [Then(@": I should be able to see the the message '([^']*)'")]
        public void ThenIShouldBeAbleToSeeTheTheMessage(string p0)
        {
            string actualmessage = manageListings.NoListingmessage();
            Assert.AreEqual(p0,actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,No listings Listed");
        }
    }
}
