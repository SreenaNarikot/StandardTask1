using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions : Driver
    {
        HomePage homePage = new HomePage(driver);
        ProfileRecord profileRecord = new ProfileRecord(driver);

        [Given(@": I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            homePage.GoToProfile();
        }

        [When(@":I click new skills with valid '([^']*)' and '([^']*)' details")]
        public void WhenIClickNewSkillsWithValidAndDetails(string skill, string level)
        {
            profileRecord.Createskillsrecord(skill, level);
        }
        [Then(@":The '([^']*)' details with will be created successfully  \.")]
        public void ThenTheDetailsWithWillBeCreatedSuccessfully_(string skill)
        {
            string actualmessage = profileRecord.Message();
            string expectedmessage = skill + " has been added to your skills";
            Assert.AreEqual(expectedmessage, actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Skill created");
        }
              
        [When(@": I Click Update on skills tab with valid '([^']*)' and '([^']*)' details")]
        public void WhenIClickUpdateOnSkillsTabWithValidAndDetails(string skill, string level)
        {
           profileRecord.Updatekillsrecord(skill, level);   
 
        }
        [Then(@":   skill must be  updated with new '([^']*)' deatils\.")]
        public void ThenSkillMustBeUpdatedWithNewDeatils_(string skill)
        {
            string actualmessage = profileRecord.Message();
            string expectedmessage = skill + " has been updated to your skills";
            Assert.AreEqual(expectedmessage, actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Skill Updated");

        }
        [When(@": I click delete button on skills tab")]
        public void WhenIClickDeleteButtonOnSkillsTab()
        {
            homePage.GoToSkillstab();
            profileRecord.Deleteskill();
        }

        [Then(@": Skills will be deleted")]
        public void ThenSkillsWillBeDeleted()
        {
            int count = profileRecord.Validatedelete();
            Assert.AreEqual(0, count);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Skill Deleted");
        }
    }
}
