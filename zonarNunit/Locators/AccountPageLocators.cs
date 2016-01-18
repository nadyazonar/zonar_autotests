using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace zonarNunit.Locators
{
    public class AccountPageLocators 
    {
        //side menu
        public static By myAccount = By.XPath("html/body/main/div/div/div[1]/ul/li[1]/a[1]");
        public static By myBuilding = By.XPath("html/body/main/div/div/div[1]/ul/li[1]/a[2]");
        public static By baseCodes = By.XPath("html/body/main/div/div/div[1]/ul/li[1]/a[3]");
        public static By myCustomCodes = By.XPath("html/body/main/div/div/div[1]/ul/li[1]/a[4]");
        public static By myBuildingParameters = By.XPath("html/body/main/div/div/div[1]/ul/li[1]/a[5]");
        public static By accountSettings = By.XPath("html/body/main/div/div/div[1]/ul/li[1]/a[6]");
        public static By logout = By.XPath(".//*[@href='/logout']");

        //account page
        public static By logo = By.XPath(".//*[@id='work_area']/div/div[1]/div/h3/span[1]");
        public static By createBuildingButton = By.XPath("html/body/main/div/div/div[1]/div/div[1]/button");


        // create building pop up
        public static By popUpWindow = By.Id("launch-app");
        public static By title = By.XPath(".//*[@id='launch-header']/h4");
        public static By name = By.XPath(".//*[@name='newBuildingName']");
        public static By width = By.XPath(".//*[@name='Width']");
        public static By depth = By.XPath(".//*[@name='Depth']");
        public static By zoningCode = By.XPath(".//*[@name='ZoningCode']");
        public static By zoneT6 = By.XPath(".//*[@label='T6']");
        public static By zone = By.XPath(".//*[@name='zone']");
        public static string zoneT6byname = "T6";
        public static By subzone36b = By.XPath(".//*[@label='36B']");
        public static By subZone = By.XPath(".//*[@name='subzone']");
        public static By type = By.XPath(".//*[@name='zonetype']");
        public static By createButtonOnPopUp = By.XPath(".//*[@value='Create']");

        //My Building Tab 
        public static By deleteLinkBuildingTab = By.XPath(".//*[@data-reveal-id='deleteProjectModal']");
        public static By projectCardBuildingTab = By.XPath(".//*[@id='myProject']/div[1]/div/div[1]");
        public static By projectCardBuildingTabs = By.XPath(".//*[@id='myProject']");
        public static By label = By.TagName("label");
        public static By openProjectLink = By.XPath(".//*[@id='myProject']/div[1]/div/div/div/div/div[2]/a[1]");

        //Base Codes Tab
        public static By codeLabel = By.XPath(".//*[@id='myCodes']/div/div/div/div/label");
        public static By codeCheckBox = By.XPath(".//*[@id='checkboxZoningCode0']");
        public static By codeCloneButton = By.XPath(".//*[@id='myCodes']/div/div/div/div/div/div[2]/div/div[1]/a/span");
        public static By codeCloneCustomButton = By.XPath(".//*[@id='myCodes']/div/div/div/div/div/div[2]/div/div[2]/a/i");
        public static By closeCodeClonePopup = By.XPath(".//*[@id='closeReveal']");
        
        //Users Management Tab
        public static By managementTable = By.XPath(".//*[@id='managementAccountSection']/div[1]");

        public static By deleteBuildingPopUpTitle = By.CssSelector(".row.m0.modalTitle");
        public static By deleteButtonOnPopUp = By.XPath(".//*[@id='deleteProjectModal']/div[3]/a[1]");
    }
}
