using apprc.hooks;
using apprc.utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System.Reflection.Metadata;


namespace apprc.StepDefinitions
{
    
    [Binding]
    public class CalculatorStepDefinitions : convert
    {
       
        //public static void dataxpaths()
        //{
        //    string filePath = "C:\\Users\\iray\\source\\repos\\apprc\\apprc\\testdata\\xpath.json";
        //    if (File.Exists(filePath))
        //    {
        //        string jsonString = File.ReadAllText(filePath);
        //        //var data = JsonConvert.DeserializeObject<MyData>(jsonString);
        //        //string jsonString = File.ReadAllText(filePath);
        //        var data = JsonConvert.DeserializeObject<MyData>(jsonString);
        //      //  var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
        //        Console.WriteLine($"{ data.about}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("File not found.");
        //    }
        //}
        //public class MyData
        //{
        //    public string about { get; set; }
        //    public string TNC { get; set; }
        //    public string soundplugin { get; set; }
        //}

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        [Given(@"open app")]
        public void GivenOpenApp()
        {
            Thread.Sleep(1000);
            
            //string element = "about";
            //string xpath = convert.elementpath(element);
            Driver.driver.FindElement(By.XPath($"{GetXPath("about")}")).Click();
            Driver.driver.FindElement(By.XPath($"{GetXPath("aboutback")}")).Click();
            //string elements = "aboutback";
            //string xpaths = convert.elementpath(elements);
            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
            //Driver.driver.Navigate().Back();
        }

        [When(@"click on take me demo mode")]
       
        public void WhenClickOnTakeMeDemoMode()
        {
            //string element = "TNC";
            //string xpath = convert.elementpath(element);
            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
            //string elements = "TNCclose";
            //string xpaths = convert.elementpath(elements);
            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();

            //string elemen = "soundplugin";
            //string xpat = convert.elementpath(elemen);
            //Driver.driver.FindElement(By.XPath($"{xpat}")).Click();
           
        }

        //string filePath = "C:\\Users\\iray\\source\\repos\\apprc\\apprc\\testdata\\xpath.json";
        //    string jsonString = File.ReadAllText(filePath);
        //    var xpaths = JObject.Parse(jsonString);
        //    Console.WriteLine(xpaths);
        //    string elementName = "about";


        //        string xpath = xpaths[elementName].ToString();
        //        Console.WriteLine($"XPath for {elementName}: {xpath}");
        //    Driver.driver.FindElement(By.XPath(xpath)).Click();
        // Use the XPath in your Appium automation (example)
        // driver.FindElement(By.XPath(xpath)).Click();

        [Then(@"click on the ""([^""]*)""")]
        public void ThenClickOnThe(string p0)
        {
            //string element = "direction";
            //string xpath = convert.elementpath(element);
            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
            //string elements = "directionback";
            //string xpaths = convert.elementpath(elements);
            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
        }

        [Then(@"click  ""([^""]*)""")]
        public void ThenClick(string p0)
        {
            //string element = "noise";
            //string xpath = convert.elementpath(element);
            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
            //string elements = "noiseback";
            //string xpaths = convert.elementpath(elements);
            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
        }

        [Then(@"click oon ""([^""]*)""")]
        public void ThenClickOon(string p0)
        {
            //string element = "wind";
            //string xpath = convert.elementpath(element);
            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
            //string elements = "windback";
            //string xpaths = convert.elementpath(elements);
            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
        }

        [Then(@"click on ""([^""]*)""")]
        public void ThenClickOn(string equalizer)
        {
            //string element = "equalizer";
            //string xpath = convert.elementpath(element);
            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
            //string elements = "equalizerback";
            //string xpaths = convert.elementpath(elements);
            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
            //string eleme = "soundclose";
            //string xpa = convert.elementpath(eleme);
            //Driver.driver.FindElement(By.XPath($"{xpa}")).Click();
            //AndroidElement moves = Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
            ScrollToElement("//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.StandardMenuWithPlugins.Pages.MenuPage.MenuItem.ClearConsentPart1Plugin\"]");
        }




    }




}

