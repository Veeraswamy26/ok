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

namespace apprc.utility
{
    public class convert {
       
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
            string filePath = "C:\\Users\\iray\\source\\repos\\apprc\\apprc\\testdata\\xpath.json";
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
 

    public void ScrollToElement(string xpath)
        {
            int Scrolls = 10;
            int scrollCount = 0;
           

            while (scrollCount < Scrolls)
            {
                try
                {
                   
                    AndroidElement element = (AndroidElement)Driver.driver.FindElement(By.XPath(xpath));
                    if (element.Displayed)
                    {
                        element.Click();
                        break;
                    }
                }
                catch (Exception)
                {
                   
                }
                Driver.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollForward();"));
                scrollCount++;
            }
        }
    }
}
