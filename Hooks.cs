using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ComposeMail
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static IWebDriver driver;
        [BeforeFeature]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            
            
        }

        [AfterFeature]
        public static void AfterScenario()
        {
            driver.Close();
        }
    }
}
