using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDD.PageObjects
{
   public class GmailPageObjects
    {
       // public IWebDriver driver { get;  set; }

        public GmailPageObjects()
        {
                 
                PageFactory.InitElements(Helper.driver,this);
        }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstNameTextField { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastNameTextField { get; set; }

        [FindsBy(How = How.Id, Using = "GmailAddress")]
        public IWebElement UserNameTextField { get; set; }


        [FindsBy(How = How.Id, Using = "Passwd")]
        public IWebElement PasswordTextField { get; set; }

        [FindsBy(How = How.Id, Using = "PasswdAgain")]
        public IWebElement ConfirmPasswordTextField { get; set; }


       


        [FindsBy(How = How.XPath, Using = ".//*[@id='gb']/div[1]/div[1]/div[2]/div[4]/div[1]/a/span")]
        public IWebElement GmailAccountOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='gb_71']")]
        public IWebElement SignOutButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='RveJvd snByac']")]
        public IWebElement SignInPasswordNextButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='identifierNext']/content/span")]
        public IWebElement SignInNextButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='identifierId']")]
        public IWebElement SignInEmailField { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='password']/div[1]/div/div[1]/input")]
        public IWebElement SignInPasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "BirthDay")]
        public IWebElement BirthdayTextField { get; set; }

        [FindsBy(How = How.Id, Using = "BirthYear")]
        public IWebElement BirthyearTextField { get; set; }

        [FindsBy(How = How.Id, Using = "iagreebutton")]
        public IWebElement iagreebutton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='tos-scroll-button-icon']")]
        public IWebElement arrowdownbutton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='BirthMonth']/div[1]/div[2]")]
        public IWebElement BirthMonth { get; set; }


        [FindsBy(How = How.XPath, Using = "*[@id='Gender']/div")]
        public IWebElement Gender { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='goog-menuitem-content']")]
        public IList<IWebElement> Months { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='submitbutton']")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='errormsg_0_GmailAddress']")]
        public IWebElement USernameEmptyErrorMessage { get; internal set; }



        public void SetMonth(string monthvalue)
        {
            Helper.driver.FindElement(By.XPath(".//*[@id=':"+monthvalue+"']/div")).Click();
        }

        public void setGender(string gender)
        {
            Helper.driver.FindElement(By.XPath(".//*[@id=':d']")).Click();

            if (gender == "male")
            {
                Helper.driver.FindElement(By.XPath(".//*[@id=':f']/div")).Click();
            }

            Helper.driver.FindElement(By.XPath(".//*[@id=':e']/div")).Click();
        }


        public void Signin(string username, string password)
        {
            SignInEmailField.SendKeys(username);

            SignInNextButton.Click();

            SignInPasswordField.SendKeys(password);
            SignInPasswordNextButton.Click();

        }


        public void SignOut()
        {

            GmailAccountOptions.Click();

            SignOutButton.Click();
        }
            //Passwd

        //PasswdAgain

        //BirthDay

        //BirthYear

        //submitbutton

        //iagreebutton

        // //*[@id="tos-scroll-button"]/div/img
        //  mmax26358
        //    mmax26358-






















        public void Login(string username, string password)
        {
            
        }

        public void Logout()
        {
            
        }
    }
}
