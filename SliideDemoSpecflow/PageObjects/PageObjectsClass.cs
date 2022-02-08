using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SliideDemoSpecflow.PageObjects
{
    public class PageObjectsClass
    {
        private readonly ScenarioContext _scenarioContext;

        public PageObjectsClass(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public string pageObject(string value)
        {
            var username = _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementById("id.creatorb.login:id/etUserName");
            return value;
        }
    }
}
