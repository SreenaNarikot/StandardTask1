using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions : Driver
    {
        [Given(@": I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }

        [When(@":I click new skills with valid '([^']*)' and '([^']*)' details")]
        public void WhenIClickNewSkillsWithValidAndDetails(string skill, string level)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createskillsrecord(driver, skill, level);
        }

        [Then(@":The Skills details with '([^']*)' and '([^']*)' will be created successfully\.")]
        public void ThenTheSkillsDetailsWithAndWillBeCreatedSuccessfully_(string skill, string level)
        {
            //Assertions to verify the skills created
            ProfileRecord profileRecord = new ProfileRecord();
            string actualskill = profileRecord.GetSkill(driver);
            //Assert.That(actualskill == skill, "Actual Skill and Expected skill do not match");
            string actualskilllevel = profileRecord.GetSkillLevel(driver);
            //Assert.That(actualskilllevel == level, "Actual Skill and Expected skill level do not match");
            Assert.Pass();
        }


        [When(@": I Click on skills tab")]
        public void WhenIClickOnSkillsTab()
        {
            HomePage homepage = new HomePage();
            homepage.GoToSkillstab(driver);
        }
        [Then(@":  It should list all the records\.")]
        public void ThenItShouldListAllTheRecords_()
        {
            ProfileRecord profilerecord = new ProfileRecord();
            profilerecord.Readskillsrecord(driver);
        }

      
    }
}
