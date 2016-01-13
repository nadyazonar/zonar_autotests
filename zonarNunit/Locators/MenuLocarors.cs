using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace zonarNunit.Locators
{
    public class MenuLocarors
    {
        
        public static By myAccount = By.XPath("html/body/header/div/nav/section/ul/li[2]/ul/li[3]/a/span");
        public static By myBuilding = By.XPath("html/body/header/div/nav/section/ul/li[2]/ul/li[4]/a/span");
        public static By baseCode = By.XPath("html/body/header/div/nav/section/ul/li[2]/ul/li[5]/a/span");
        public static By myCustomCodes = By.XPath("html/body/header/div/nav/section/ul/li[2]/ul/li[6]/a/span");
        public static By myBuildingParameters = By.XPath("html/body/header/div/nav/section/ul/li[2]/ul/li[7]/a/span");
        public static By accountSettings = By.XPath("html/body/header/div/nav/section/ul/li[2]/ul/li[8]/a/span"); 

    }
}
