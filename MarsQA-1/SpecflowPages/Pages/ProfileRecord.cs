using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class ProfileRecord
    {
        //Scenario1 for Languagetab
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
        //Scenario2 for Languagetab
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

        //Scenario 3 of the language
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
        public string GettheEditedlanguagetext(IWebDriver driver,string language)
        {
            HomePage homepage = new HomePage();
            homepage.GoToProfile(driver);
            //Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr[1]/td[1]", 10);
            //IWebElement editedlanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr[1]/td[1]"));
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

       
        public void DeleteRecord(IWebDriver driver)
        {
            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            deletebutton.Click();
        }
        public string Getthedeleted(IWebDriver driver)
        {
            //Wait.WaitToBeClickable(driver, "//*[@id=,account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 30);
            //IWebElement deletedrecord = driver.FindElement(By.XPath("//*[@id=,account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement deletedrecord = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            string deletedrecordtext = deletedrecord.Text;               
            return deletedrecordtext;                                    

        }
        //Scnario 1 of the skills record
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
        //Scenario2 of Skills record to read
        public void  Readskillsrecord(IWebDriver driver)
        {
            //tables's Xpath
            //IWebElement table = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr"));
            //to locate rows of table                        //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]
            IList<IWebElement> rows = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody"));
            foreach (IWebElement apart in rows)
            {

                Console.WriteLine(apart.Text);
            }
           
        }


        //Scenario 1 of the education
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

        //Scenario 1 for the certification
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
        //Methods for Assertions
        public string GetLanguage(IWebDriver driver)
        {
            //IWebElement profile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            //profile.Click(); 

            IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            //IList<IWebElement> actualLanguages = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
            //Console.WriteLine(actualLanguages.Count);
            //foreach (IWebElement aPart in actualLanguages)
            //{
            //    Console.WriteLine(aPart.Text);
            //}
            
            return actualLanguage.Text;
        }
        public string GetLanguageLevel(IWebDriver driver)
        {
            IWebElement actualLanguageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualLanguageLevel.Text;
        }

        public string GetSkill(IWebDriver driver)
        {
            //Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 3);
            //IWebElement skillstab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            //skillstab.Click();
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
            //IWebElement certificationTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            //certificationTab.Click();
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
