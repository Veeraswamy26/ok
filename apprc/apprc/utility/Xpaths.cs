using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using apprc.hooks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using NUnit.Framework;

namespace apprc.utility
{
    public class convert
    {

        //public static string elementpath(string element)
        //{
        //    string filePath = "C:\\Users\\iray\\source\\repos\\apprc\\apprc\\testdata\\xpath.json";
        //    string jsonString = File.ReadAllText(filePath);
        //    var xpaths = JObject.Parse(jsonString);
        //    Console.WriteLine(xpaths);
        //    string xpath = xpaths[element].ToString();
        //    Console.WriteLine(xpath);
        //    return xpath;
        //}
        public static Dictionary<string, string> xpathDictionary; // Dictionary to store XPaths

        // Constructor to Load Data into Dictionary
        public convert()
        {
            string filePath = "C:\\Users\\iray\\folder\\apprc\\apprc\\testdata\\xpath.json";
            string jsonString = File.ReadAllText(filePath);
            var xpaths = JObject.Parse(jsonString);

            // Store data in the dictionary
            xpathDictionary = new Dictionary<string, string>();
            foreach (var item in xpaths)
            {
                xpathDictionary[item.Key] = item.Value.ToString();
            }

            Console.WriteLine("XPath data loaded into dictionary.");
        }

        // Method to Get XPath from Dictionary
        public string GetXPath(string element)
        {
            if (xpathDictionary.ContainsKey(element))
            {
                return xpathDictionary[element];
            }
            else
            {

                Console.WriteLine($"XPath for '{element}' not found.");
                return null;
            }

        }
        //public void ScrollAndClick(string elementXPath, int maxScrolls = 20)
        //{
        //    int scrollCount = 0;
        //    bool isElementFound = false;
        //    string scrollForward = "new UiScrollable(new UiSelector().scrollable(true)).scrollForward()";
        //    string scrollBackward = "new UiScrollable(new UiSelector().scrollable(true)).scrollBackward()";

        //    while (scrollCount < maxScrolls)
        //    {
        //        try
        //        {
        //            AndroidElement element = (AndroidElement)Driver.driver.FindElement(By.XPath(elementXPath));
        //            if (element.Displayed)
        //            {
        //                element.Click();
        //                isElementFound = true;
        //                break;
        //            }
        //        }
        //        catch (NoSuchElementException)
        //        {
        //            Console.WriteLine($"Attempt {scrollCount + 1}: Element not found, scrolling...");
        //        }

        //        string scrollDirection = (scrollCount < maxScrolls / 2) ? scrollForward : scrollBackward;
        //        Driver.driver.FindElement(MobileBy.AndroidUIAutomator(scrollDirection));

        //        scrollCount++;
        //    }

        //    if (!isElementFound)
        //    {
        //        Console.WriteLine("Element not found after maximum scroll attempts.");
        //    }
        //}



        public void scrolling(string path)
        {


            //string alter = "//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.StandardMenuWithPlugins.Pages.MenuPage.MenuItem.TranslationPackPrinterPlugin\"]";

            int Scrolls = 20;
            int scrollCount = 0;

            while (scrollCount < Scrolls)
            {
                if (scrollCount < 10)
                {
                    try
                    {
                        //string alter = "//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.StandardMenuWithPlugins.Pages.MenuPage.MenuItem.TranslationPackPrinterPlugin\"]";
                        AndroidElement element = (AndroidElement)Driver.driver.FindElement(By.XPath(path));
                        if (element.Displayed)
                        {
                            element.Click();
                            break;

                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("element not found");
                    }

                    Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).flingForward();"));

                }

                else
                {

                    while (scrollCount < Scrolls/2)
                    {

                        try
                        {
                            //string alter = "//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.StandardMenuWithPlugins.Pages.MenuPage.MenuItem.TranslationPackPrinterPlugin\"]";
                            AndroidElement element = (AndroidElement)Driver.driver.FindElement(By.XPath(path));
                            if (element.Displayed)
                            {
                                element.Click();
                                break;

                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("element not found");
                        }

                        Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).flingBackward();"));

                    }
                }
                scrollCount++;
            }
        }
    }
}



//else
//{
//    while (scrollCount < Scrolls)
//    {

//        try
//        {
//            //string alter = "//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.StandardMenuWithPlugins.Pages.MenuPage.MenuItem.TranslationPackPrinterPlugin\"]";
//            AndroidElement element = (AndroidElement)Driver.driver.FindElement(By.XPath(path));
//            if (element.Displayed)
//            {
//                element.Click();
//                break;
//            }

//        }
//        catch (Exception)
//        {

//        }
//        Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).flingBackward();"));
//        scrollCount++;
//    }


//public void ScrollToElement(string xpath)
//{
//    int Scrolls = 10;
//    int scrollCount = 0;


//    while (scrollCount < Scrolls)
//    {

//        try
//        {
//            //string alter = "//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.StandardMenuWithPlugins.Pages.MenuPage.MenuItem.TranslationPackPrinterPlugin\"]";
//            AndroidElement element = (AndroidElement)Driver.driver.FindElement(By.XPath(xpath));
//            if (element.Displayed)
//            {
//                element.Click();
//                break;
//            }
//            //else
//            //{



//            //    Assert.AreEqual(element, alter);
//            //    Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).flingBackward();"));
//            //    // Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView((new UiSelector().text("")));"));
//            //    // Scroll to an element with a specific XPath using Appium (Java)
//            //    //Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView();"));
//            //}
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("element not found");
//        }
//        Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).flingForward();"));
//        scrollCount++;
//    }
//}
//public void ScrollToElementup(string xpath)
//{
//    int Scrolls = 10;
//    int scrollCount = 0;


//    while (scrollCount < Scrolls)
//    {

//        try
//        {
//            string alter = "//android.widget.TextView[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.StandardMenuWithPlugins.Pages.MenuPage.MenuItem.TranslationPackPrinterPlugin\"]";
//            AndroidElement element = (AndroidElement)Driver.driver.FindElement(By.XPath(xpath));
//            if (element.Displayed)
//            {
//                element.Click();
//                break;
//            }
//            //else
//            //{



//            //    Assert.AreEqual(element, alter);
//            //    Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).flingBackward();"));
//            //    // Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView((new UiSelector().text("")));"));
//            //    // Scroll to an element with a specific XPath using Appium (Java)
//            //    //Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView();"));
//            //}
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("element not found");
//        }
//        Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).flingBackward();"));
//        //Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().text(\"Integration.\r\nConsentPlugin\"));"));


//        scrollCount++;
//    }
//}

