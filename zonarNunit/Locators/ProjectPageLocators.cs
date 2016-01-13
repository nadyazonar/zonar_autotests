using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace zonarNunit.Locators
{
    public class ProjectPageLocators
    {


        // Zonin Allowances
        // top Menu
        public static By zoningAllowances = By.XPath(".//*[@id='tab0']");
        public static By capacityAnalysis = By.XPath(".//*[@id='tab1']");
        public static By calibration = By.XPath(".//*[@id='tab2']");

        //Lot Information
        public static By lotInformationTab = By.XPath(".//*[@id='fiter-information']/div/div/ul/li[1]/a");
        public static By zoningCodeDD = By.XPath(".//*[@id='panel1']/fieldset[1]/select");
        public static By zoneDD = By.XPath(".//*[@id='panel1']/fieldset[2]/select");
        public static By subZoneDD = By.XPath(".//*[@id='panel1']/fieldset[3]/select");
        public static By typeZoneDD = By.XPath(".//*[@id='panel1']/fieldset[4]/select");

        public static By lotWidthDimensionF = By.XPath(".//*[@id='panel1']/fieldset[8]/div/div[1]/input");
        public static By lotDepthDimensionF = By.XPath(".//*[@id='panel1']/fieldset[9]/div/div[1]/input");
        public static By frontageALengthF= By.XPath(".//*[@id='panel1']/fieldset[10]/div/div[1]/input");

        public static By moreThanOneFrontageCB = By.XPath(".//*[@id='panel1']/fieldset[11]/label");
        public static By onStreetParkingAvailableCB = By.XPath(".//*[@id='panel1']/fieldset[12]/div/label");
        public static By lotAbutsDifferentZonesCB = By.XPath(".//*[@id='panel1']/fieldset[14]/div/label");
        public static By facingaCivicSpaceCB = By.XPath(".//*[@id='panel1']/fieldset[18]/div/label");
        public static By transitOrientedDevelopmentCB= By.XPath(".//*[@id='panel1']/fieldset[19]/div/label");
        public static By nearTransitCorridor  = By.XPath(".//*[@id='panel1']/fieldset[21]/div/label");

        public static By buildingParametersButton = By.XPath(".//*[@id='inputContainer']/div[2]/div[1]/div/div/div[2]/button[1]");
        public static By mixViewDD = By.XPath(".//*[@id='inputContainer']/div[2]/div[1]/div/div/div[2]/button[2]");
        public static By saveButton= By.XPath("html/body/footer/div[1]/nav/a[1]");
        public static By generateReportButton= By.XPath("html/body/footer/div[1]/nav/a[2]");



        //Location Variables
        //Additional Options

        // Result panel
        public static By itemCssSelector = By.CssSelector(".des-left.ng-binding");
        public static By itemValueCssSelector = By.CssSelector(".price.right.ng-binding");


        //Capacity Tab
        // Capacity Left menu Locators
        //Capacity right panel locators

        public static By resultTableCapacityTab = By.XPath(".//*[a='Results']");


        

    }
}
