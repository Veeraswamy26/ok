using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using testmultipleplugin.Drivers;

namespace testmultipleplugin.Hooks
{
    [Binding]
    public sealed class Hooks1
    {


        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
          
            var appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("platformName", "Android");
            appOptions.AddAdditionalCapability("deviceName", "google pixel");
            appOptions.AddAdditionalCapability("platformVersion", "15");
            appOptions.AddAdditionalCapability("udid", "2C161FDH200BEZ");
            appOptions.AddAdditionalCapability("app", "C:\\Users\\iray\\Downloads\\TestMultiplePlugins.apk");
            _driver.driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appOptions);
        }

        [AfterScenario]
        public void AfterScenario()
        {
           
        }
    }
}