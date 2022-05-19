using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
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
    class Languagestepdefinitions : Driver
    {
        ProfileRecord profileRecord = new ProfileRecord(driver);
        HomePage homePage = new HomePage(driver);

        [Given(@":I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            homePage.GoToProfile();
        }

        [When(@": I click new language with valid '([^']*)' and '([^']*)' details")]
        public void WhenIClickNewLanguageWithValidAndDetails(string language, string level)
        {
            profileRecord.Createlanguagerecord(language,level);
        }

        [Then(@": The '([^']*)' details  will be created successfully\.")]
        public void ThenTheDetailsWillBeCreatedSuccessfully_(string language)
        {
            string actualmessage = profileRecord.Message();
            string expectedmessage = language + " has been added to your languages";
            Assert.AreEqual(expectedmessage, actualmessage);
        }

        [Then(@": '([^']*)' Records must have been created successfully")]
        public void ThenRecordsMustHaveBeenCreatedSuccessfully(int p0)
        {
            int actualcount = profileRecord.ReadLanguagerecord();
            Assert.AreEqual(actualcount, p0);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Language created");
        }

        [When(@":I click update the record with  new '([^']*)' and '([^']*)'")]
        public void WhenIClickUpdateTheRecordWithNewAnd(string language, string level)
        {
           profileRecord.EditTheLanguage(language,level);
        }

        [Then(@": the Record should have been edited successfully with  '([^']*)' and '([^']*)' \.")]
        public void ThenTheRecordShouldHaveBeenEditedSuccessfullyWithAnd_(string language, string level)
        {
            string editedlanguage = profileRecord.GettheEditedlanguagetext(language);
            Assert.AreEqual(editedlanguage, language);
            string actuallevel = profileRecord.GettheEditedleveltext(driver, level);
            Assert.AreEqual(actuallevel, level);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Language Updated");
        }
     
        [When(@": I click delete button")]
        public void WhenIClickDeleteButton()
        {
           profileRecord.DeleteRecord();
        }

        [Then(@": The record '([^']*)'will be deleted")]
        public void ThenTheRecordWillBeDeleted(string language)
        {
            string record = profileRecord.Getthedeleted();
            Assert.That(record!= language,"Record not deleted");
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed! Language Deleted.");
        }
    }
}