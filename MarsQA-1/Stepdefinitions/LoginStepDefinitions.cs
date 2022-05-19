using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [When(@":I navigate to the URL and click Sign In and enter invalid '([^']*)' and valid '([^']*)'")]
        public void WhenINavigateToTheURLAndClickSignInAndEnterInvalidAndValid(string p0, string p1)
        {
            SignIn.Login(p0, p1);
        }

        [Then(@": then the error message'([^']*)' should be displayed")]
        public void ThenThenTheErrorMessageShouldBeDisplayed(string p0)
        { 
            string actualmessage = SignIn.Geterrormessage();
            Assert.AreEqual(p0, actualmessage);
            CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Login error message displayed");
        }
    }
}
