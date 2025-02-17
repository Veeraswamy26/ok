using apprc.hooks;
using apprc.utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System.IO;
using System.Reflection.Metadata;


namespace apprc.StepDefinitions
{

    [Binding]
    public class CalculatorStepDefinitions : convert
    {
        [Given(@"open app")]
        public void GivenOpenApp()
        {
            Thread.Sleep(1000);

            //string element = "about";
            //string xpath = convert.elementpath(element);
            Driver.driver.FindElement(By.XPath($"{GetXPath("about")}")).Click();
            Driver.driver.Navigate().Back();
            //string elements = "aboutback";
            //string xpaths = convert.elementpath(elements);
            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
            //Driver.driver.Navigate().Back();
            //Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"Integration.\r\nConsentPlugin\"));"));
        }

        [When(@"click on take me demo mode")]

        public void WhenClickOnTakeMeDemoMode()
        {
            Driver.driver.FindElement(By.XPath($"{GetXPath("TNC")}")).Click();
            Driver.driver.Navigate().Back();
            //Driver.driver.FindElement(By.XPath($"{GetXPath("TNCclose")}")).Click();
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

        [Then(@"click on the DirectionofSound")]
        public void ThenClickOnTheDirectionofSound()
        {
            scrolling($"{GetXPath("display")}");
            Driver.driver.Navigate().Back();
          //Driver.driver.FindElement(By.XPath($"{GetXPath("intclose")}")).Click();
        }

        [Then(@"click  Noise Filtering")]
        public void ThenClickNoiseFiltering()
        {
            scrolling($"{GetXPath("readprivacypolicy")}");
            Driver.driver.Navigate().Back();
            // Driver.driver.FindElement(By.XPath($"{GetXPath("intclose")}")).Click();
        }

        [Then(@"click oon Wind Filtering")]
        public void ThenClickOonWindFiltering()
        {
            scrolling($"{GetXPath("integration")}");
            //Driver.driver.FindElement(By.XPath($"{GetXPath("intclose")}")).Click();
            Driver.driver.Navigate().Back();
        }

        [Then(@"click on Equalizer")]
        public void ThenClickOnEqualizer()
        {
            scrolling($"{GetXPath("about")}");
           Driver.driver.FindElement(By.XPath($"{GetXPath("aboutback")}")).Click();

        }
    }
}
//        //public static void dataxpaths()
//        //{
//        //    string filePath = "C:\\Users\\iray\\source\\repos\\apprc\\apprc\\testdata\\xpath.json";
//        //    if (File.Exists(filePath))
//        //    {
//        //        string jsonString = File.ReadAllText(filePath);
//        //        //var data = JsonConvert.DeserializeObject<MyData>(jsonString);
//        //        //string jsonString = File.ReadAllText(filePath);
//        //        var data = JsonConvert.DeserializeObject<MyData>(jsonString);
//        //      //  var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
//        //        Console.WriteLine($"{ data.about}");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("File not found.");
//        //    }
//        //}
//        //public class MyData
//        //{
//        //    public string about { get; set; }
//        //    public string TNC { get; set; }
//        //    public string soundplugin { get; set; }
//        //}

//        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
//        [Given(@"open app")]
//        public void GivenOpenApp()
//        {
//            Thread.Sleep(1000);

//            //string element = "about";
//            //string xpath = convert.elementpath(element);
//            Driver.driver.FindElement(By.XPath($"{GetXPath("about")}")).Click();
//            Driver.driver.Navigate().Back();
//            //string elements = "aboutback";
//            //string xpaths = convert.elementpath(elements);
//            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
//            //Driver.driver.Navigate().Back();
//            //Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"Integration.\r\nConsentPlugin\"));"));
//        }

//        [When(@"click on take me demo mode")]

//        public void WhenClickOnTakeMeDemoMode()
//        {
//            //Driver.driver.FindElement(By.XPath($"{GetXPath("TNC")}")).Click();
//            //Driver.driver.Navigate().Back();
//            //Driver.driver.FindElement(By.XPath($"{GetXPath("TNCclose")}")).Click();
//            //string element = "TNC";
//            //string xpath = convert.elementpath(element);
//            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
//            //string elements = "TNCclose";
//            //string xpaths = convert.elementpath(elements);
//            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();

//            //string elemen = "soundplugin";
//            //string xpat = convert.elementpath(elemen);
//            //Driver.driver.FindElement(By.XPath($"{xpat}")).Click();

//        }

//        //string filePath = "C:\\Users\\iray\\source\\repos\\apprc\\apprc\\testdata\\xpath.json";
//        //    string jsonString = File.ReadAllText(filePath);
//        //    var xpaths = JObject.Parse(jsonString);
//        //    Console.WriteLine(xpaths);
//        //    string elementName = "about";


//        //        string xpath = xpaths[elementName].ToString();
//        //        Console.WriteLine($"XPath for {elementName}: {xpath}");
//        //    Driver.driver.FindElement(By.XPath(xpath)).Click();
//        // Use the XPath in your Appium automation (example)
//        // driver.FindElement(By.XPath(xpath)).Click();

//        [Then(@"click on the ""([^""]*)""")]
//        public void ThenClickOnThe(string DirectionofSound)
//        {

//            //Driver.driver.FindElement(By.XPath($"{GetXPath("soundplugin")}")).Click();
//            // Driver.driver.FindElement(By.XPath($"{GetXPath(DirectionofSound)}")).Click();
//            // Driver.driver.FindElement(By.XPath($"{GetXPath("directionback")}")).Click();
//            // Driver.driver.FindElement(By.XPath($"{GetXPath("soundclose")}")).Click();
//            //string element = "direction";
//            //string xpath = convert.elementpath(element);
//            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
//            //string elements = "directionback";
//            //string xpaths = convert.elementpath(elements);
//            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
//            //ScrollToElement($"{GetXPath("readprivacypolicy")}");
//            //Driver.driver.Navigate ().Back();   

//        }

//        [Then(@"click  ""([^""]*)""")]
//        public void ThenClick(string intclose)
//        {
//            //Driver.driver.FindElement(By.XPath($"{GetXPath("about")}")).Click();
//            //Driver.driver.FindElement(By.XPath($"{GetXPath("aboutback")}")).Click();
//            //string element = "noise";
//            //string xpath = convert.elementpath(element);
//            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
//            //string elements = "noiseback";
//            //string xpaths = convert.elementpath(elements);
//            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
//            scrolling($"{GetXPath("integration")}");
//            Driver.driver.FindElement(By.XPath($"{GetXPath("intclose")}")).Click();
//        }

//        [Then(@"click oon ""([^""]*)""")]
//        public void ThenClickOon(string p0)
//        {
//            //Driver.driver.FindElement(By.XPath($"{GetXPath("about")}")).Click();
//            //Driver.driver.FindElement(By.XPath($"{GetXPath("aboutback")}")).Click();
//            //string element = "wind";
//            //string xpath = convert.elementpath(element);
//            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
//            //string elements = "windback";
//            //string xpaths = convert.elementpath(elements);
//            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
//            scrolling($"{GetXPath("readprivacypolicy")}");
//            Driver.driver.Navigate().Back();
//        }

//        [Then(@"click on ""([^""]*)""")]
//        public void ThenClickOn(string equalizer)
//        {
//            //Driver.driver.FindElement(By.XPath($"{GetXPath("about")}")).Click();
//            //Driver.driver.FindElement(By.XPath($"{GetXPath("aboutback")}")).Click();
//            //string element = "equalizer";
//            //string xpath = convert.elementpath(element);
//            //Driver.driver.FindElement(By.XPath($"{xpath}")).Click();
//            //string elements = "equalizerback";
//            //string xpaths = convert.elementpath(elements);
//            //Driver.driver.FindElement(By.XPath($"{xpaths}")).Click();
//            //string eleme = "soundclose";
//            //string xpa = convert.elementpath(eleme);
//            //Driver.driver.FindElement(By.XPath($"{xpa}")).Click();
//            //AndroidElement moves = Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
//            //ScrollToElement($"{GetXPath("phonepermission")}");
//            //Driver.driver.Navigate().Back();
//            scrolling($"{GetXPath("about")}");
//            //Driver.driver.FindElement(By.XPath($"{GetXPath("about")}")).Click();
//            Driver.driver.Navigate().Back();
//        }




//    }




//}

