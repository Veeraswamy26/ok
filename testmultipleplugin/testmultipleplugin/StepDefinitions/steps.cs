using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testmultipleplugin.Hooks;
using testmultipleplugin.Drivers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace testmultipleplugin.StepDefinitions
{
    [Binding]
    public class Steps
    {
        [Given(@"hi")]
        public void GivenHi()
        {
           Thread.Sleep(1000);  
        }


    }
}
