using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.Helpers;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace MarsQA_1.StepDefinitions 
{
    [Binding]
    public class CreatingTheShareskillInTheProfilePageWithValidDataStepDefinitions : Driver
    {
        [Given(@":I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }

        //Add new Shareskill details
        [When(@": I click new shareskill with valid '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)',  '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' details")]
        public void WhenIClickNewShareskillWithValidDetails(string selenium, string p1, string programming, string qA, string testing, string p5, string p6, string p7, string p8, string mon, string p10, string p11, string p12, string p13, string hidden)
        {
            HomePage homePage = new HomePage();
            homePage.GoToShareSkill(driver);
            Shareskill shareskill = new Shareskill();
            shareskill.CreateShareSkill(driver, selenium, p1, programming, qA, testing, p5, p6, p7, p8, mon, p10, p11, p12, p13, hidden);
        }
        [Then(@": details will be created successfully with '([^']*)'")]
        public void ThenDetailsWillBeCreatedSuccessfullyWith(string title)
        {
            Shareskill shareskill = new Shareskill();
            shareskill.validatecreatedSharelisting(driver,title);
        }

       
        //Without mandatory ShareSkill details -Displays error message
        [When(@": I click Save sharekill with out mandatory details for '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)',  '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void WhenIClickSaveSharekillWithOutMandatoryDetailsFor(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12, string p13, string p14)
        {
            HomePage homePage = new HomePage();
            homePage.GoToShareSkill(driver);
            Shareskill shareskill = new Shareskill();
            shareskill.CreateShareSkill(driver,p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }

        [Then(@": I should get the '([^']*)' displayed\.")]
        public void ThenIShouldGetTheDisplayed_(string errormessage)
        {
            Shareskill shareskill = new Shareskill();
            string actualerrormessage = shareskill.Geterrormessage(driver);
            Assert.AreEqual(errormessage, actualerrormessage);
        }


        // Listing the shareskill
        [When(@": I Click managelistings tab")]
        public void WhenIClickManagelistingsTab()
        {
           ManageListings manageListings = new ManageListings();
           manageListings.viewmanagelistings(driver);

        }

        [Then(@": I should be able to see all the shareskill listings")]
        public void ThenIShouldBeAbleToSeeAllTheShareskillListings()
        {
            ManageListings manageListings = new ManageListings();
            manageListings.listmanagelistings(driver);
        }

        //Edit the shareSkill
        [When(@"I Click editbutton of a skillshare listing")]
        public void WhenIClickEditbuttonOfASkillshareListing()
        {
            ManageListings manageListings = new ManageListings();
            manageListings.viewmanagelistings(driver);
        }

        [Then(@":I should be able to to change from '([^']*)' to new '([^']*)'")]
        public void ThenIShouldBeAbleToToChangeFromToNew(string title, string newtitle)
        {
            ManageListings manageListings = new ManageListings();
            manageListings.EditManageListings(driver, title,newtitle);
            manageListings.validateUpdatedSharelisting(driver, newtitle);
        }

        //Deleting the shareskill by the title
        [When(@": I click delete button under shareskills which has '([^']*)' as title")]
        public void WhenIClickDeleteButtonUnderShareskillsWhichHasAsTitle(string title)
        {
            ManageListings manageListings = new ManageListings();
            manageListings.viewmanagelistings(driver);
            manageListings.DeleteShareSkillListing(driver, title);
             
        }

        [Then(@": ShareSkill with the '([^']*)' must be deleted successfully")]
        public void ThenShareSkillWithTheMustBeDeletedSuccessfully(string title)
        {
            try
            {
                ManageListings manageListings = new ManageListings();
                string deletedmessage = manageListings.DeletePopupmessage(driver);
                string actualmesage = title + " has been deleted";
                Assert.AreEqual(actualmesage, deletedmessage);
                CommonMethods.test.Log(LogStatus.Pass, "Record deleted");
            }
            catch (Exception e)
            {
             
                CommonMethods.test.Log(LogStatus.Fail, "Record not deleted", e.Message);
            }
        
        }





    }
}
