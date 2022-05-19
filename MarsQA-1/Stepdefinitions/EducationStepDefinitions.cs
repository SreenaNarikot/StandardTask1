using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions : Driver
    {
        ProfileRecord profileRecord = new ProfileRecord(driver);
        HomePage homePage = new HomePage(driver);

        [Given(@":I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            homePage.GoToProfile();
        }

        [When(@": I Click Add new Education with '([^']*)' ,'([^']*)','([^']*)','([^']*)', '([^']*)' details")]
        public void WhenIClickAddNewEducationWithDetails(string country, string university, string title, string degree, string p4)
        {
            profileRecord.Createeducationtab(country, university, title, degree, p4);
        }


        [Then(@": The Education details will be created successfully with '([^']*)' displayed\.")]
        public void ThenTheEducationDetailsWillBeCreatedSuccessfullyWithDisplayed_(string message)
        {
            string actualmessage = profileRecord.Message();
            Assert.AreEqual(message, actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Education Created");
        }
    }
}
