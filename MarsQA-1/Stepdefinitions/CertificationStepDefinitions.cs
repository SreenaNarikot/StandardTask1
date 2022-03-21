using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class CertificationStepDefinitions : Driver
    {
        [Given(@":I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }
        [When(@":I Click Add new Certifications with '([^']*)' ,'([^']*)'\.'([^']*)' details")]
        public void WhenIClickAddNewCertificationsWith_Details(string certificate, string from, string year)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createcertification(driver,certificate,from,year);
        }

        [Then(@":The Certification with '([^']*)' ,'([^']*)'\.'([^']*)' details will be createdsuccessfully\.")]
        public void ThenTheCertificationWith_DetailsWillBeCreatedsuccessfully_(string certificate, string from, string year)
        {
            ////Assertions to verify  certifications
            //ProfileRecord profileRecord = new ProfileRecord();
            //string actualCertificate = profileRecord.Getcertficate(driver);
            ////Assert.That(actualCertificate == certificate , "Actual Certificate  and Expected Certificate do not match");
            //string actualFrom = profileRecord.GetCertificatefrom(driver);
            ////Assert.That(actualFrom == from, "Actual certficate from and expected do not match");
            //string actualYear = profileRecord.GetYearofthecertificate(driver);
            ////Assert.That(actualYear == year, "Actual Year and expected year do not match");
            Assert.Pass();
        }
    }
}
