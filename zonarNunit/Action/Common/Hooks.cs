using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;






namespace zonarNunit.Action
{
    [Binding]
    public class Hooks : BaseAction
    {

        
        [BeforeTestRun]
        public static void BeforeSuite()
        {
            
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new ChromeDriver(@"D:\tool\");
            //driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
  
        }

        [AfterScenario] 
        public static void AfterScenario()
        {

                Thread.Sleep(500);
               
            
        }

        

        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Quit();
        }
    }
}
