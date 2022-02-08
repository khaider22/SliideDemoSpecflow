using SliideDemoSpecflow.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SliideDemoSpecflow.Features
{
    [Binding]
    public class SliideLoginSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public SliideLoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        LoginPageMethods loginPageMethods = new LoginPageMethods();


        [Given(@"the app is launched")]
        public void GivenTheAppIsLaunched()
        {
            loginPageMethods.ConfimrAppLaunch(_scenarioContext);
        }
        
        [Then(@"the username box is displayed")]
        public void TheUsernameBoxIsDisplaed()
        {
            loginPageMethods.UsernameBoxIsDisplayed(_scenarioContext);
        }

        [When(@"I enter the username ""(.*)""")]
        public void GivenIEnterTheUsername(string email)
        {            
            loginPageMethods.EnterUsername(email, _scenarioContext);
        }
        
        [Then(@"the password box is displayed")]
        public void ThePasswordBoxIsDisplaed()
        {
            loginPageMethods.PasswordBoxIsDisplayed(_scenarioContext);
        }

        [When(@"I enter the password ""(.*)""")]
        public void GivenIEnterThePassword(string password)
        {
            loginPageMethods.EnterPassword(password, _scenarioContext);
        }

        [Then(@"the login button is displayed"]
        public void TheLoginButtonIsDisplayed()
        {
            loginPageMethods.LoginButtonIsDisplayed(_scenarioContext);
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPageMethods.ClickLoginButton(_scenarioContext);
        }
        
        [Then(@"I can see the news screen")]
        public void ICanSeeTheNewsScreen()
        {
            
        }

        [Then(@"I see the errors on username and password box")]
        public void ISeeTheErrorsOnUsernameAndPasswordBox()
        {

        }
    }
}
