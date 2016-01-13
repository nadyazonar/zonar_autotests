using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zonarNunit.Action;
using zonarNunit.ActionsLoginPage;

namespace zonarNunit.Steps
{
    public class BaseSteps
    {
        // Actions
        protected AccountPageActions actionsAccountPages = new AccountPageActions();
        protected BaseAction actionsBase = new BaseAction();
        protected LoginPageActions actionsLoginPage = new LoginPageActions();
        protected ProjectPageActions actionsProjectPage = new ProjectPageActions();
        protected MenuActions actionsMenu = new MenuActions();


        protected zonarNunit.Locators.LoginLocators loginPageLocators = new Locators.LoginLocators();


        // Data
        protected zonarNunit.Data.LoginData loginPageData = new Data.LoginData();

        protected zonarNunit.Data.BuildingCreationData projectPageData = new Data.BuildingCreationData();

    }


}
