using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BDD.Models;
using BDD.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD.StepDefinitions
{
    [Binding]
    public sealed class Create_LoginStepDefinition
    {
        public IWebDriver Driver = Helper.driver;

        public GmailPageObjects gmail;

        public List<CreatedUserModel> CreatedUser;

        [Given(@"I have successfully navigated to the gmail site")]
        public void GivenIHaveSuccessfullyNavigatedToTheGmailSite()
        {
            Helper.NavigateToSite(CreatedUserModel.url);
            gmail  = new GmailPageObjects();
           
 
           
        }


        [Given(@"I create a new account with valid credentials")]
        public void GivenICreateANewAccountWithValidCredentials(Table table)
        {
            gmail.FirstNameTextField.SendKeys("MAX");
            gmail.LastNameTextField.SendKeys("MAX");

            gmail.UserNameTextField.SendKeys("MEGA12344566");

            gmail.BirthdayTextField.SendKeys("11");
            gmail.BirthyearTextField.SendKeys("1991");

            gmail.PasswordTextField.SendKeys("MEGA12345-");
            gmail.ConfirmPasswordTextField.SendKeys("MEGA12345-");

            gmail.BirthMonth.Click();
            gmail.SetMonth("3");

            gmail.setGender("Male");

            gmail.SubmitButton.Click();

            gmail.arrowdownbutton.Click();
            gmail.arrowdownbutton.Click();
            gmail.arrowdownbutton.Click();

            Thread.Sleep(2);
            gmail.iagreebutton.Click();
        }

        [Given(@"I create a new account with invalid credentials")]
        public void GivenICreateANewAccountWithInvalidCredentials(Table table)
        {
            var accountDetails = table.CreateInstance<CreatedUserModel>();
            gmail.FirstNameTextField.SendKeys("MAX");
            gmail.LastNameTextField.SendKeys("MAX");

            gmail.UserNameTextField.SendKeys(accountDetails.Email);

            gmail.BirthdayTextField.SendKeys("11");
            gmail.BirthyearTextField.SendKeys("1991");

            gmail.PasswordTextField.SendKeys("MEGA12345-");
            gmail.ConfirmPasswordTextField.SendKeys("MEGA12345-");

            gmail.BirthMonth.Click();
            gmail.SetMonth("3");

            gmail.setGender("Male");

            gmail.SubmitButton.Click();

            
        }

        [Then(@"i should get an error message")]
        public void ThenIShouldGetAnErrorMessage()
        {
            Assert.True(gmail.USernameEmptyErrorMessage.Displayed);
        }

        [Given(@"I have successfully navigated to the gmail Login site")]
        public void GivenIHaveSuccessfullyNavigatedToTheGmailLoginSite()
        {
            Helper.NavigateToSite(CreatedUserModel.LoginUrl);
            gmail = new GmailPageObjects();
        
        }

        [Given(@"i login with valid credentials")]
        public void GivenILoginWithValidCredentials(Table table)
        {
            var accountdetails = table.CreateInstance<CreatedUserModel>();
            gmail.Signin(accountdetails.Email,accountdetails.Password);
        }

        [Then(@"i successfully log out")]
        public void ThenISuccessfullyLogOut()
        {
            gmail.SignOut();
        }


    }
}
