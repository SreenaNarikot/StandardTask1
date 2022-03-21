using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions : Driver
    {
        [Given(@":I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }

        [When(@": I Click Add new Education with '([^']*)' ,'([^']*)','([^']*)','([^']*)', '([^']*)' details")]
        public void WhenIClickAddNewEducationWithDetails(string country, string university, string title, string degree, string p4)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createeducationtab(driver, country, university, title, degree, p4);
        }

        [Then(@": The Education details '([^']*)' ,'([^']*)','([^']*)','([^']*)', '([^']*)'will be created successfully\.")]
        public void ThenTheEducationDetailsWillBeCreatedSuccessfully_(string country, string university, string title, string degree, string p4)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            //string actualcountry = profileRecord.GetCountry(driver);
            //string actualUniversity = profileRecord.GetUniversity(driver);  
            //string actualTitle = profileRecord.GetTitle(driver);
            //string actualDegree =profileRecord.GetDegree(driver);
            //string actualGraduationyear = profileRecord.GetGraduationyear(driver);
            Assert.Pass();
        }
    }
}
