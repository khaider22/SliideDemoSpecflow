using OpenQA.Selenium.Appium;
using SliideDemoSpecflow.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SliideDemoSpecflow.Hooks
{
    [Binding]
    class IntializeHook
    {
        private readonly ScenarioContext _scenarioContext;

        public IntializeHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Initialize()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            
            _scenarioContext.Set(appiumDriver.InitializeAppium());
        }
    }
}
