using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using Windows.Networking.Connectivity;

namespace SliideDemoSpecflow.Drivers
{
    public class AppiumDriver
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set; }
        [SetUp]
        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            var appPath = @"C:\Users\kamran.haider\MyApp\Demo.apk";

            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 3");
            driverOption.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator1");
            
            driverOption.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            driverOption.AddAdditionalCapability("ChromeDriverExecuteable", @"C:\Driver\ChromeDriver.exe");

            return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), driverOption);

            
            //var username = driver.FindElementById("id.creatorb.login:id/etUserName");
            //username.SendKeys("K@yahoo.com");
            //var password = driver.FindElementById("id.creatorb.login:id/etPass");
            //password.SendKeys("mypassword");
            //var loginButton = driver.FindElementById("id.creatorb.login:id/btnSingIn");
            //loginButton.Click();
        }
    }
}