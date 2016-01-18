using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
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
            actionsAccountPages.iHaveOpenedMyBuildingsTab();
        }

        [When(@"I open Existed Building")]
        public void WhenIOpenExistedBuilding()
        {
            actionsAccountPages.clickOpenProjectButton();
        }

        [When(@"I Have Open Base Codes Tab")]
        public void WhenIHaveOpenBaseCodesTab()
        {
            actionsAccountPages.openedBaseCodesTab();
        }

        [When(@"I open Calibration Tab")]
        public void WhenIOpenCalibrationTab()
        {
            actionsProjectPage.CalibrationTabIsAvailable();
        }

        [When(@"I open User Management Tab")]
        public void WhenIOpenUserManagementTab()
        {
            actionsAccountPages.UsersManagementTabIsAvailable();
        }

        [Then(@"I don't see User Management Tab")]
        public void ThenIDonTSeeUserManagementTab()
        {
            actionsAccountPages.UsersManagementTabIsNotAvailable();
        }

        [Then(@"I don't see Calibration Tab")]
        public void ThenIDonTSeeCalibrationTab()
        {
            actionsProjectPage.CalibrationTabIsNotAvailable();
        }

        [Then(@"Clone Button is absent")]
        public void ThenCloneButtonIsAbsent()
        {
            actionsAccountPages.checkCodeClonButtonAbsent();

        }

        [Then(@"Clone to Custon Codes Button is absent")]
        public void ThenCloneToCustonCodesButtonIsAbsent()
        {
            actionsAccountPages.checkCodeClonCustomButtonAbsent();

        }

        [Then(@"Check-boxes on Base Codes Tab is absent")]
        public void ThenCheck_BoxesOnBaseCodesTabIsAbsent()
        {
            actionsAccountPages.checkCodeCheckBoxExists();

        }

        [Then(@"I have Opened Calibration Tab")]
        public void ThenIHaveOpenedCalibrationTab()
        {
            actionsProjectPage.CalibrationTabIsOpened();
        }

        [Then(@"I have opened User Management Tab")]
        public void ThenIHaveOpenedUserManagementTab()
        {
            actionsAccountPages.openedUsersManagementTab();
        }

        [Then(@"Base Code exists")]
        public void ThenBaseCodeExists()
        {
            actionsAccountPages.checkBaseCodeExists();
        }

        [Then(@"Clone Button is present")]
        public void ThenCloneButtonIsPresent()
        {
            actionsAccountPages.checkCodeClonButtonExists();
        }

        [Then(@"Clone to Custon Codes Button is present")]
        public void ThenCloneToCustonCodesButtonIsPresent()
        {
            actionsAccountPages.checkCodeCloneCustomButtonExists();
        }

        [Then(@"Check-boxes on Base Codes Tab is present")]
        public void ThenCheck_BoxesOnBaseCodesTabIsPresent()
        {
            actionsAccountPages.checkCodeCheckBoxExists();

        }

        [Then(@"I Close Clone Code Popup")]
        public void ThenICloseCloneCodePopup()
        {
            actionsAccountPages.CloseCodeClonButton();
        }

        [Then(@"I Close Clone Custom Code Popup")]
        public void ThenICloseCloneCustomCodePopup()
        {
            actionsAccountPages.CloseCodeClonCustomButton();
        }

    }
}
