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
            ProfileRecord profileRecord =new ProfileRecord();
            profileRecord.ValidatecreatedCertification(driver,certificate);
        }
    }
}
