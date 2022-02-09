using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SliideDemoSpecflow.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using Windows.Networking.Connectivity;

namespace SliideDemoSpecflow
{
    public sealed class LoginPageMethods
    {
        private readonly ScenarioContext _scenarioContext;

        public LoginPageMethods(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public LoginPageMethods()
        {

        }

        public bool ConfimrAppLaunch(ScenarioContext _scenarioContext)
        {
            Thread.Sleep(2000);
            var username = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("id.creatorb.login:id/etUserName");
            if(username.Displayed)
            {
                return true;
            }
            else
                return false;
        }

        public bool UsernameBoxIsDisplayed(ScenarioContext _scenarioContext)
        {
            var username = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("id.creatorb.login:id/etUserName");
            if (username.Displayed)
            {
                return true;
            }
            else
                return false;
        }
        public void EnterUsername(string email, ScenarioContext _scenarioContext)
        {
            var username = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("id.creatorb.login:id/etUserName");
            username.SendKeys(email);
        }

        public bool PasswordBoxIsDisplayed(ScenarioContext _scenarioContext)
        {
            var password = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("id.creatorb.login:id/etPass");
            if (password.Displayed)
            {
                return true;
            }
            else
                return false;
        }

        public void EnterPassword(string pwrd, ScenarioContext _scenarioContext)
        {
            var passwrod = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("id.creatorb.login:id/etPass");
            passwrod.SendKeys(pwrd);
        }

        public bool LoginButtonIsDisplayed(ScenarioContext _scenarioContext)
        {
            var logInBtn = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("id.creatorb.login:id/btnSingIn");
            if (logInBtn.Displayed)
            {
                return true;
            }
            else
                return false;
        }

        public void ClickLoginButton(ScenarioContext _scenarioContext)
        {
            var lodinButton = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementById("id.creatorb.login:id/btnSingIn");
            lodinButton.Click();
        }

        public bool CheckConnection(ScenarioContext _scenarioContext)
        {
            ConnectionProfile connection = NetworkInformation.GetInternetConnectionProfile();
            
            if ((connection != null) && (connection.GetNetworkConnectivityLevel() >= NetworkConnectivityLevel.InternetAccess))
            {
                return true;
            }

            else
                return false;
        }
    }
}