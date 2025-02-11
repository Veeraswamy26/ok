using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace apprc.hooks
{
    [Binding]
    public class Hooks1
    {
       
        [BeforeScenario]
        public static void BeforeScenario()
        {


            {
                var appOptions = new AppiumOptions();
                appOptions.AddAdditionalCapability("platformName", "Android");

                appOptions.AddAdditionalCapability("deviceName", "google pixel");
                appOptions.AddAdditionalCapability("platformVersion", "15");
                appOptions.AddAdditionalCapability("udid", "33301JEHN01912");
                appOptions.AddAdditionalCapability("app", "C:\\Users\\iray\\Downloads\\TestMultiplePlugins.apk");
                appOptions.AddAdditionalCapability("uiautomator2ServerInstallTimeout", 180000);
                //  appOptions.AddAdditionalCapability("automationName", "UiAutomator2");
                // appOptions.AddAdditionalCapability("newCommandTimeout", 300);
                //  appOptions.AddAdditionalCapability("appium:host", "http://localhost:4723");


                Driver.driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appOptions);
            }
            }
        
        [AfterScenario]
        public void AfterScenario()
        {
         
        }
    }
}