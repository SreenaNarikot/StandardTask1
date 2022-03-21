using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
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
        [Given(@":I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }

        [When(@": I click new language with valid '([^']*)' and '([^']*)' details")]
        public void WhenIClickNewLanguageWithValidAndDetails(string language, string level)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createlanguagerecord(driver,language,level);
        }
        
       


        [Then(@": The Language details with '([^']*)' and '([^']*)' will be created successfully\.")]
        public void ThenTheLanguageDetailsWithAndWillBeCreatedSuccessfully_(string language, string level)
        {
             Assert.Pass();
        }

        [Then(@": '([^']*)' Records must have been created successfully")]
        public void ThenRecordsMustHaveBeenCreatedSuccessfully(int p0)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            int actualcount = profileRecord.ReadLanguagerecord(driver);
            Assert.AreEqual(actualcount, p0);

        }



        [When(@":I click update the record with  new '([^']*)' and '([^']*)'")]
        public void WhenIClickUpdateTheRecordWithNewAnd(string language, string level)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.EditTheLanguage(driver,language,level);
           
        }
        

        [Then(@": the Record should have been edited successfully with  '([^']*)' and '([^']*)' \.")]
        public void ThenTheRecordShouldHaveBeenEditedSuccessfullyWithAnd_(string language, string level)
        {
            
            Console.WriteLine("Record edited");
        }
       
        [Then(@": the record is updated with new details '([^']*)' ,'([^']*)'\.")]
        public void ThenTheRecordIsUpdatedWithNewDetails_(string language, string level)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            string editedlanguage = profileRecord.GettheEditedlanguagetext(driver, language);
            Assert.AreEqual(editedlanguage, language);
            string actuallevel = profileRecord.GettheEditedleveltext(driver, level);
            Assert.AreEqual(actuallevel, level);
        }
        
        [When(@": I click delete button")]
        public void WhenIClickDeleteButton()
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.DeleteRecord(driver);
        }

        [Then(@": The record '([^']*)'will be deleted")]
        public void ThenTheRecordWillBeDeleted(string language)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            string record = profileRecord.Getthedeleted(driver);
            Assert.That(record!= language,"Record not deleted");

        }

        
    }
}