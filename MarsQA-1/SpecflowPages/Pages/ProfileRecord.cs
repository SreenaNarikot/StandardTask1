using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class ProfileRecord
    {
        //Scenario1 for Languagetab - Add Language
        public void Createlanguagerecord(IWebDriver driver, string language, string level)
        {
            Wait.WaitToBeClickable(driver,"//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div",3);
            //Identify the element Add new button and click on it
            IWebElement addNew = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNew.Click();
            //Identify the textboxbutton Addlanguage and enter the value
            Wait.WaitToBeClickable(driver,"//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 3);
            IWebElement addLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguage.SendKeys(language);
            //Identify the dropdown
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 3);
            IWebElement chooseLanguagelevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLanguagelevel.Click();
            SelectElement selectElement = new SelectElement(chooseLanguagelevel);
            selectElement.SelectByText(level);
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 3);
            IWebElement add = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            add.Click();
        }
        //Validating the created Language
        public void ValidatecreatedLanguage(IWebDriver driver, string language)
        {
            try
            {
                IList <IWebElement> titlerows = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
                var rowcount = titlerows.Count();
                for (int i = 1; i <= rowcount; i++)
                {
                    Thread.Sleep(2000);
                    IWebElement actuallanguages = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]"));
                    string actuallanguage = actuallanguages.Text; 
                    try
                    {
                        if (actuallanguage.Equals(language))
                        {
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Language Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Language Updated");
                            Assert.IsTrue(true);
                        }
                    }
                    catch (Exception ex)
                    { 
                        Console.WriteLine(ex.Message,language +"not created");
                    }
                    
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed-catch", e.Message);
            }


        }


        //Scenario2 for Languagetab - Total Number of records created
        public int ReadLanguagerecord(IWebDriver driver)
        {
            IList<IWebElement> actualLanguages = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
            foreach (IWebElement aPart in actualLanguages)
            {
                Console.WriteLine(aPart.Text);
                
            }
            int count = actualLanguages.Count;
            return count;

        }

        //Scenario 3 for the Language - Edit a perticular record
        public void EditTheLanguage(IWebDriver driver, string language, string level)
        {
            IWebElement userprofile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            userprofile.Click();
            //IWebElement profile = driver.FindElement(By.XPath("//*[@id=account-profile-section']/div/div[1]/div[2]/div/span/div/a[1]"));
            //profile.Click();                                       
            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));
            editbutton.Click();
            IWebElement firstlanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            firstlanguage.Clear();
            firstlanguage.SendKeys(language);
            //Thread.Sleep(7000);
            Wait.WaitToBeClickable(driver, "//*[@name='level']",10);
            IWebElement chooseLanguagelevel = driver.FindElement(By.XPath("//*[@name='level']"));          
            SelectElement selectElement = new SelectElement(chooseLanguagelevel);
            selectElement.SelectByText(level);
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]", 7);
            IWebElement upadate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            upadate.Click();
           
        }
        // Language - Identify and return the updated record
        public string GettheEditedlanguagetext(IWebDriver driver,string language)
        {
            HomePage homepage = new HomePage();
            homepage.GoToProfile(driver);
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]", 10);
            IWebElement editedlanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            string editedlanguagetext = editedlanguage.Text;               
            return editedlanguagetext;
        }   
        public string GettheEditedleveltext(IWebDriver driver,string level)
        {
           
           // Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]", 10);
            IWebElement editedlevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[1]/td[2]"));
            string editedleveltext = editedlevel.Text;
            return editedleveltext;
        }

       //Delete the  selected record-language
        public void DeleteRecord(IWebDriver driver)
        {
            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            deletebutton.Click();
        }
        public string Getthedeleted(IWebDriver driver)
        {
            IWebElement deletedrecord = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            string deletedrecordtext = deletedrecord.Text;               
            return deletedrecordtext;                                    

        }
        //Scenario1 - Create skills record
        public void Createskillsrecord(IWebDriver driver, string skill, string level)
        {
            //Identify the Skills tab and click on it
            IWebElement skills = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skills.Click();
            IWebElement addnewskills = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewskills.Click();
            //Find the textbox addskill and enter the value
            IWebElement addskilltextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addskilltextbox.SendKeys(skill);
            //Find the dropdown chooseskilllevel and select an option
            IWebElement chooseSkillLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            chooseSkillLevel.Click();
            SelectElement selectskilllevel = new SelectElement(chooseSkillLevel);
            selectskilllevel.SelectByText(level);
            IWebElement addskill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addskill.Click();
        }
        //Validate the created skills record
        public void ValidatecreatedSkills(IWebDriver driver, string skill)
        {
            try
            {
                //Identify the totals rows of the skills record
                IList<IWebElement> titlerows = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
                var rowcount = titlerows.Count();
                for (int i = 1; i <= rowcount; i++)
                {
                    //Identify the i'th title
                    IWebElement actualtitles = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                    string actualtitle = actualtitles.Text;
                    try
                    {
                        if (actualtitle.Equals(skill))
                        {
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Skills Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Skills Updated");
                            Assert.IsTrue(true);
                        }
                    }
                    catch (Exception)
                    {
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    }
                       
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }


        }

        //Scenario2 of Skills record to read
        public void  Readskillsrecord(IWebDriver driver)
        {
            //tables's Xpath
            //IWebElement table = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr"));

            //To locate rows of table 
            IList<IWebElement> rows = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody"));
            foreach (IWebElement apart in rows)
            {

                Console.WriteLine(apart.Text);
            }
           
        }

        //Scenario 1 of the Education
        public void Createeducationtab(IWebDriver driver, string country, string university, string titletab, string degree, string p4)
        {
            //Identify the tab Education and click on it
            IWebElement educationtab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationtab.Click();
            IWebElement addneweducation = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addneweducation.Click();
            IWebElement universitytextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            universitytextbox.SendKeys(university);
            IWebElement countrydropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countrydropdown.Click();
            Thread.Sleep(1000);
            SelectElement countryofuniversity = new SelectElement(countrydropdown);
            countryofuniversity.SelectByText(country);
            IWebElement titledropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titledropdown.Click();
            SelectElement titletab1 = new SelectElement(titledropdown);
            titletab1.SelectByText(titletab);
            IWebElement degreetextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreetextbox.SendKeys(degree);
            IWebElement yearofgraduationdropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearofgraduationdropdown.Click();
            SelectElement yearofgraduation = new SelectElement(yearofgraduationdropdown);
            yearofgraduation.SelectByValue(p4);
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 3);
            IWebElement addeducation = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addeducation.Click();
        }
        // Validating created Education
        public void ValidatecreatedEducation(IWebDriver driver, string title)
        {
            try
            {
                IWebElement educationtab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
                educationtab.Click();
                IList<IWebElement> titlerows = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
                var rowcount = titlerows.Count();                            
                for (int i = 1; i <= rowcount; i++)
                {
                    IWebElement actualtitles = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]"));
                    string actualtitle = actualtitles.Text;
                    Console.WriteLine(actualtitle);
                    try
                    {
                        if (actualtitle.Equals(title))
                        {
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Education Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Updated");
                            Assert.IsTrue(true);
                        }
                    }
                    catch (Exception)
                    {
                        CommonMethods.test.Log(LogStatus.Fail, " Updation Validation Test Failed");
                    }
                }          
                       
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }


        }

        //Scenario 1 Create Certification
        public void Createcertification(IWebDriver driver, string certificate ,string from, string year)
        {
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 3);
            //Identify the tap certification and click on it
            IWebElement certificationTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationTab.Click();
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 3);
            IWebElement addnewCertification = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addnewCertification.Click();
            IWebElement certificationtextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificationtextbox.SendKeys(certificate);
            IWebElement certifiedFromTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedFromTextBox.SendKeys(from);
            IWebElement yeardropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            yeardropdown.Click();
            SelectElement yearTextbox = new SelectElement(yeardropdown);
            yearTextbox.SelectByValue(year);
            IWebElement addcert = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addcert.Click();

        }
        //Validating the created record - Certifications
        public void ValidatecreatedCertification(IWebDriver driver, string certificate)
        {
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 3);
            //Identify the tap certification and click on it
            IWebElement certificationTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationTab.Click();
            try
            {
                 IList<IWebElement> titlerows = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
                var rowcount = titlerows.Count();
                for (int i = 1; i <= rowcount; i++)
                {
                    IWebElement actualcertificates = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                    string actualcertificate = actualcertificates.Text;  
                    Console.WriteLine(actualcertificate);
                    try
                    {
                        if (actualcertificate.Equals(certificate))
                        {
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Certificate Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificateUpdated");
                            Assert.IsTrue(true);
                        }
                    }
                    catch (Exception)
                    {
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    }
                        
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }


        }



        //Methods for Assertions
        public string GetLanguage(IWebDriver driver)
        {
             IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            IList<IWebElement> actualLanguages = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
            Console.WriteLine(actualLanguages.Count);
            return actualLanguage.Text;
        }
        public string GetLanguageLevel(IWebDriver driver)
        {
            IWebElement actualLanguageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualLanguageLevel.Text;
        }

        public string GetSkill(IWebDriver driver)
        {
            IWebElement skill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return skill.Text;

        }
        public string GetSkillLevel(IWebDriver driver)
        {
            IWebElement skilllevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return skilllevel.Text;
        }
        public string Getcertficate(IWebDriver driver)
        {
            IWebElement certificate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return certificate.Text;
        }
        public string GetCertificatefrom(IWebDriver driver)
        {
            IWebElement from = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return from.Text;
        }
        public string GetYearofthecertificate(IWebDriver driver)
        {
            IWebElement year = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return year.Text;
        }
        public string GetCountry(IWebDriver driver)
        {
            IWebElement country = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return country.Text;
        }
        public string GetUniversity(IWebDriver driver)
        {
            IWebElement university = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return university.Text;
        }
        public string GetTitle(IWebDriver driver)
        {
            IWebElement title = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return title.Text;
        }
        public string GetDegree(IWebDriver driver)
        {
            IWebElement degree = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return degree.Text;
        }
       public string GetGraduationyear(IWebDriver driver)
       {
            IWebElement graduationYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return graduationYear.Text;
       }
    }
}
