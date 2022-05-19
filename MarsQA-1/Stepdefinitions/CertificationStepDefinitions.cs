using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class CertificationStepDefinitions : Driver
    {
        HomePage homePage = new HomePage(driver);
        ProfileRecord profileRecord = new ProfileRecord(driver);

        [Given(@":I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
          
            homePage.GoToProfile();
        }

        [When(@":I Click Add new Certifications with '([^']*)' ,'([^']*)'\.'([^']*)' details")]
        public void WhenIClickAddNewCertificationsWith_Details(string certificate, string from, string year)
        {
            
            profileRecord.Createcertification(certificate,from,year);
        }

        [Then(@":The Certification with '([^']*)' details will be createdsuccessfully\.")]
        public void ThenTheCertificationWithDetailsWillBeCreatedsuccessfully_(string certificate)
        {
            string actualmessage = profileRecord.Message();
            string expectedmessage = certificate + " has been added to your certification";
            Assert.AreEqual(expectedmessage, actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed! Certification Created.");
        }

        [When(@":I Click Add new Certifications with  invalid '([^']*)' ,'([^']*)'\.'([^']*)' details")]
        public void WhenIClickAddNewCertificationsWithInvalid_Details(string certificate, string from, string year)
        {
            profileRecord.Createcertification(certificate, from, year);
        }

        [Then(@":The error '([^']*)' will be displayed\.")]
        public void ThenTheErrorWillBeDisplayed_(string message)
        {
            string actualmessage = profileRecord.Message();
            Assert.AreEqual(message, actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed! Error message displayed with invalid Education details");

        }
        [When(@":I Click Add duplicate Certifications with '([^']*)' ,'([^']*)'\.'([^']*)'\.")]
        public void WhenIClickAddDuplicateCertificationsWith_(string certificate, string from, string year)
        {
            profileRecord.Createcertification(certificate, from, year);
        }

        [Then(@":I should be able to see the '([^']*)'")]
        public void ThenIShouldBeAbleToSeeThe(string message)
        {
            string actualmessage = profileRecord.Message();
            Assert.AreEqual(message, actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed! Error message:'This information is already exist.' Displayed");
        }
        [When(@": I click delete button on certification tab")]
        public void WhenIClickDeleteButtonOnCertificationTab()
        {
            profileRecord.deletecertification();
        }

        [Then(@": Certification with '([^']*)' will be deleted")]
        public void ThenCertificationWithWillBeDeleted(string certificate)
        {
            string actualmessage = profileRecord.Message();
            string expectedmessage = certificate + " has been deleted from your certification";
            Assert.AreEqual(expectedmessage, actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed! Certification Deleted.");
        }
    }
}
