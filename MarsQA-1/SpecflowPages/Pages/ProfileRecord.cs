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
        private IWebDriver driver;

        public ProfileRecord(IWebDriver driver)
        {
            this.driver = driver;
        }
        //LANGUAGE TAB LOCATORS
        //Identify the element Add new 
        IWebElement AddNew => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        IWebElement AddLanguage => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        IWebElement ChooseLanguagelevel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        IWebElement Add => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        //Identify the userprofile button
        IWebElement Userprofile => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
        //Identify the editbutton
        IWebElement Editbutton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));
        //Identify the language to edit
        IWebElement Firstlanguage => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
        //Identify the languagelevel
        IWebElement ChooseLanguageleveltoedit => driver.FindElement(By.XPath("//*[@name='level']"));
        //Identify the element update
        IWebElement Upadate => driver.FindElement(By.XPath("//*[@id='accout-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
        //Identify the delete button                        
        IWebElement Deletebutton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));

        //SKILLS TAB LOCATORS
        //Identify the Skillstab
        IWebElement Skills => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        //Locate the button Addnew skills
        IWebElement Addnewskills => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        //Locate the add skill textbox
        IWebElement Addskilltextbox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        // Locate Chooseskilllevel dropbox                          
        IWebElement ChooseSkillLevel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        //locate the addskill button                                 
        IWebElement Addskill => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        //Locate the update skill button                     
        IWebElement Updateskill => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));
        //Locate the skill textbod to update
        IWebElement Skilltext => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
        //Locate the skilllevel
        IWebElement Skilllevel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
        //Updatebutton
        IWebElement Updateskillnext => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
        //Message locator
        IWebElement Messagedisplayed => driver.FindElement(By.XPath("/html/body/div[1]/div"));
       
        //CERTIFICATION TAB LOCATORS
        //Locate the certification tab
        IWebElement CertificationTab => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        //Locate Add  new Certification
        IWebElement AddnewCertification => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        //Locate the certification text box
        IWebElement Certificationtextbox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        //Locate the element certified from
        IWebElement CertifiedFromTextBox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        //Locate year dropdown
        IWebElement Yeardropdown => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
        //Locate Add Certificate button
        IWebElement Addcert => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        //Locate the delete button
        IWebElement Deletecert=> driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]"));
        
        //EDUCATION TAB LOCATORS
        //Locate the education tab
        IWebElement Educationtab => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        //Add new Education
        IWebElement Addneweducation => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        //Locate University textbox
        IWebElement Universitytextbox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        //Locate the dropdown country of university
        IWebElement Countrydropdown => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        //Locate the element title dropdown
        IWebElement Titledropdown => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        //Locate degree textbox
        IWebElement Degreetextbox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        //Locate the dropdown year of graduation
        IWebElement Yearofgraduationdropdown => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        // Locate 'Add Education'
        IWebElement Addeducation => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        //Message
        


        //Scenario1 for Languagetab - Add Language
        public void Createlanguagerecord(string language, string level)
        {
            Wait.WaitToBeClickable(driver,"//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div",3);
            //Click on addnew button
            AddNew.Click();

            //Enter the value for Language
            Wait.WaitToBeClickable(driver,"//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 3);
            AddLanguage.SendKeys(language);

            //Click the dropdown ans selct the languagelevel
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 3);
            ChooseLanguagelevel.Click();
            SelectElement selectElement = new SelectElement(ChooseLanguagelevel);
            selectElement.SelectByText(level);
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 3);

            //Click add button
            Add.Click();
        }

        //Scenario2 for Languagetab - Total Number of records created
        public int ReadLanguagerecord()
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
        public void EditTheLanguage(string language, string level)
        {
            IWebElement userprofile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            userprofile.Click();
            //Click the editbutton                  
            Editbutton.Click();
            //Clear the text box before entering te value
            Firstlanguage.Clear();
            //Input the value for languagetextbox
            Firstlanguage.SendKeys(language);
            Wait.WaitToBeClickable(driver, "//*[@name='level']",10);
            //Select the language level    
            SelectElement selectElement = new SelectElement(ChooseLanguageleveltoedit);
            selectElement.SelectByText(level);
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]", 7);
            Upadate.Click();
           
        }
        // Language - Identify and return the updated record
        public string GettheEditedlanguagetext(string language)
        {
            HomePage homepage = new HomePage(driver);
            homepage.GoToProfile();
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
        public void DeleteRecord()
        {
            Deletebutton.Click();
        }
        public string Getthedeleted()
        {
            IWebElement deletedrecord = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            string deletedrecordtext = deletedrecord.Text;               
            return deletedrecordtext;                                    

        }
        //Scenario1 - Create skills record
        public void Createskillsrecord(string skill, string level)
        {
            //Click on skills tab
            Skills.Click();
            //Click on add new skills and input the value
            Addnewskills.Click();
            Addskilltextbox.SendKeys(skill);
            //Click on skill level drop down and slect the value
            ChooseSkillLevel.Click();
            SelectElement selectskilllevel = new SelectElement(ChooseSkillLevel);
            selectskilllevel.SelectByText(level);
            //Click the button Addskill
            Addskill.Click();
        }
        public void Updatekillsrecord(string skill, string level)
        {
            //Click on skills tab
            Skills.Click();
            //Click on Update skills and input the value
            Updateskill.Click();
            Thread.Sleep(1000);
            Skilltext.Clear();
            Skilltext.SendKeys(skill);
            //Click on skill level drop down and slect the value              
            Skilllevel.Click();
            SelectElement Skilllevels = new SelectElement(Skilllevel);
            Skilllevels.SelectByText(level);
            //Click the button Addskill
            Updateskillnext.Click();
        }
        //Method for Deleting the skills 
        public void Deleteskill()
        {
            IList<IWebElement> titlerows = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody"));
            var rowcount = titlerows.Count();                           
            for (int i = 1; i <= rowcount; i++)
            {
                IWebElement delete = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]"));
                delete.Click();                                   

            }
        }
        public int Validatedelete()
        {
            IList<IWebElement> rows = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/th"));
            var rowcount = rows.Count();                            
            return rowcount;
        }

        //Validate the message displayed method
        public string Message()
        {
            Thread.Sleep(3000);
            Console.WriteLine(Messagedisplayed.Text);
            return Messagedisplayed.Text;
        }

        //Scenario 1 of the Education
        public void Createeducationtab(string country, string university, string titletab, string degree, string p4)
        {
            //Identify the tab Education and click on it
            
            Educationtab.Click();
            
            Addneweducation.Click();
            
            Universitytextbox.SendKeys(university);
           
            Countrydropdown.Click();
            Thread.Sleep(1000);
            SelectElement countryofuniversity = new SelectElement(Countrydropdown);
            countryofuniversity.SelectByText(country);
            
            Titledropdown.Click();
            SelectElement titletab1 = new SelectElement(Titledropdown);
            titletab1.SelectByText(titletab);
            
            Degreetextbox.SendKeys(degree);
            
            Yearofgraduationdropdown.Click();
            SelectElement yearofgraduation = new SelectElement(Yearofgraduationdropdown);
            yearofgraduation.SelectByValue(p4);
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 3);
            
            Addeducation.Click();
        }
 
        //Scenario 1 Create Certification
        public void Createcertification(string certificate ,string from, string year)
        {
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 3);
            //Click Certification tab
            CertificationTab.Click();
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 3);
            //Clcik on Add new Certification
            AddnewCertification.Click();
            //Input value in the certification textbox
            Certificationtextbox.SendKeys(certificate);
            //Input value for Certified from
            CertifiedFromTextBox.SendKeys(from);
            //Click on Year dropdown and select the required value from the list
            Yeardropdown.Click();
            SelectElement yearTextbox = new SelectElement(Yeardropdown);
            yearTextbox.SelectByValue(year);
            //Click Add Certificate
            Addcert.Click();

        }
        //Delete method for certification
        public void deletecertification()
        {
            Wait.WaitToBeClickable(driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 3);
            //Click Certification tab
            CertificationTab.Click();
            Thread.Sleep(1000);
            Deletecert.Click();
        }
       
        //Methods for Assertions
        public string GetLanguage()
        {
             IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            IList<IWebElement> actualLanguages = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));
            Console.WriteLine(actualLanguages.Count);
            return actualLanguage.Text;
        }
        public string GetLanguageLevel()
        {
            IWebElement actualLanguageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualLanguageLevel.Text;
        }

        public string GetSkill()
        {
            IWebElement skill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return skill.Text;

        }
        public string GetSkillLevel()
        {
            IWebElement skilllevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return skilllevel.Text;
        }
        public string Getcertficate()
        {
            IWebElement certificate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return certificate.Text;
        }
        public string GetCertificatefrom()
        {
            IWebElement from = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return from.Text;
        }
        public string GetYearofthecertificate()
        {
            IWebElement year = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return year.Text;
        }
        public string GetCountry()
        {
            IWebElement country = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return country.Text;
        }
        public string GetUniversity()
        {
            IWebElement university = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return university.Text;
        }
        public string GetTitle()
        {
            IWebElement title = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return title.Text;
        }
        public string GetDegree()
        {
            IWebElement degree = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return degree.Text;
        }
       public string GetGraduationyear()
       {
            IWebElement graduationYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return graduationYear.Text;
       }
    }
}
