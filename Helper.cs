using System;
using System.Diagnostics;
using BDD.Models;
using BDD.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace BDD
{
      [Binding]
    public class Helper
    {
        public static  IWebDriver driver;
        
        public static void NavigateToSite(string url)
        {
            
            driver.Navigate().GoToUrl(url);

        }

        public static void OpenBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(11);
        }





        [BeforeFeature()]
        public static void BeforeFeature()
        {
            OpenBrowser();
        }
        [AfterFeature()]
        public static void CloseChromeProcess()
        {
            driver.Close();

            Process[] chromeProcesses = Process.GetProcessesByName("chromedriver");

            foreach (var process in chromeProcesses)
            {
                process.Kill();
            }
           
        }
    }
}
