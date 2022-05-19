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
        HomePage homePage = new HomePage(driver);
        Shareskill shareskill = new Shareskill(driver);

        [Given(@":I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            homePage.GoToProfile();
        }

        //Add new Shareskill details
        [When(@": I click new shareskill with valid '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)',  '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' details")]
        public void WhenIClickNewShareskillWithValidDetails(string title, string description, string category, string subcat, string tags, string p5, string p6, string p7, string p8, string mon, string p10, string p11, string p12, string p13, string hidden)
        {
            homePage.GoToShareSkill();
            shareskill.CreateShareSkill(title, description, category, subcat, tags, p5, p6, p7, p8, mon, p10, p11, p12, p13, hidden);
        }
        [Then(@": details will be created successfully with '([^']*)'")]
        public void ThenDetailsWillBeCreatedSuccessfullyWith(string message)
        {
            string actualmessage = shareskill.validatemessage();
            Assert.AreEqual(message, actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Share skill created");
        }
       
        //Without mandatory ShareSkill details -Displays error message
        [When(@": I click Save sharekill with out mandatory details for '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)',  '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void WhenIClickSaveSharekillWithOutMandatoryDetailsFor(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12, string p13, string p14)
        {
            homePage.GoToShareSkill();
            shareskill.CreateShareSkill(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }

        [Then(@": I should get the '([^']*)' displayed\.")]
        public void ThenIShouldGetTheDisplayed_(string errormessage)
        {
            string actualerrormessage = shareskill.Geterrormessage();
            Assert.AreEqual(errormessage, actualerrormessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,'Please complete the form correctly' Displayed !");
        }
    }
}
