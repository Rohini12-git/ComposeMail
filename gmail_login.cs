using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposeMail
{
    class gmail_login
    {
        public static IWebDriver driver;
        public static string email = "vikash.prasad@nathcorp.com";
        public static void url()
        {
            //UserSteps.driver = new ChromeDriver();
            driver = new FirefoxDriver();
            string url = "https://accounts.google.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        public static void login()
        {


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            string emailId = "identifierId";
            //string email = "vikash.prasad@nathcorp.com";
            driver.FindElement(By.Id(emailId)).SendKeys("tselenium023@gmail.com");
            driver.FindElement(By.Id("identifierNext")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //string passwordXpath = "//body/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/span[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]";
            //string password = "Nathcorp@123";
            
            driver.FindElement(By.Name("password")).SendKeys("seleniumtest1994");
            driver.FindElement(By.Name("passwordNext")).Click();

            //IWebElement element = driver.FindElement(By.ClassName("VfPpkd-RLmnJb"));

            //Actions actions = new Actions(driver);
            //actions.MoveToElement(element).Click().Perform();



        }
    }
}
