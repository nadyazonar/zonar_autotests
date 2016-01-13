using System;
using TechTalk.SpecFlow;
using zonarNunit.Steps;

namespace zonarNunit
{
    [Binding]
    public class RolesSteps : BaseSteps
    {
        [Given(@"I have entered Exist Basic Login")]
        public void GivenIHaveEnteredExistBasicLogin()
        {
            actionsLoginPage.enterLogin(loginPageData.basicLogin);
        }
        
        [Given(@"I have entered Exist Basic Password")]
        public void GivenIHaveEnteredExistBasicPassword()
        {
            actionsLoginPage.enterPassword(loginPageData.basicPass);
        }

        [Given(@"I have entered Exist Pro Login")]
        public void GivenIHaveEnteredExistProLogin()
        {
            actionsLoginPage.enterLogin(loginPageData.proRoleLogin);

        }
        [Given(@"I have entered Exist Pro Password")]
        public void GivenIHaveEnteredExistProPassword()
        {
            actionsLoginPage.enterPassword(loginPageData.proRolePass);
        }
        
        [Given(@"I have entered Exist Admin Login")]
        public void GivenIHaveEnteredExistAdminLogin()
        {
            actionsLoginPage.enterLogin(loginPageData.adminLogin);
        }
        
        [Given(@"I have entered Exist Admin Password")]
        public void GivenIHaveEnteredExistAdminPassword()
        {
            actionsLoginPage.enterPassword(loginPageData.adminPass);
        }
        
        [Given(@"I have entered Exist Editor Login")]
        public void GivenIHaveEnteredExistEditorLogin()
        {
            actionsLoginPage.enterLogin(loginPageData.editorLogin);
        }

        [Given(@"I have entered Exist Editor Password")]
        public void GivenIHaveEnteredExistEditorPassword()
        {
            actionsLoginPage.enterPassword(loginPageData.editorPass);
        }
        
        [When(@"I have Open My Buildings Tab")]
        public void WhenIHaveOpenMyBuildingsTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I open Existed Building")]
        public void WhenIOpenExistedBuilding()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Have Open Base Codes Tab")]
        public void WhenIHaveOpenBaseCodesTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I open Calibration Tab")]
        public void WhenIOpenCalibrationTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I open User Management Tab")]
        public void WhenIOpenUserManagementTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I don't see User Management Tab")]
        public void ThenIDonTSeeUserManagementTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I don't see Calibration Tab")]
        public void ThenIDonTSeeCalibrationTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Clone Button is absent")]
        public void ThenCloneButtonIsAbsent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Clone to Custon Codes Button is absent")]
        public void ThenCloneToCustonCodesButtonIsAbsent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Check-boxes on Base Codes Tab is absent")]
        public void ThenCheck_BoxesOnBaseCodesTabIsAbsent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I have Opened Calibration Tab")]
        public void ThenIHaveOpenedCalibrationTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I have opened User Management Tab")]
        public void ThenIHaveOpenedUserManagementTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Clone Button is present")]
        public void ThenCloneButtonIsPresent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Clone to Custon Codes Button is present")]
        public void ThenCloneToCustonCodesButtonIsPresent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Check-boxes on Base Codes Tab is present")]
        public void ThenCheck_BoxesOnBaseCodesTabIsPresent()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
