using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComposeMail
{
    class login_gmail
    {
        // public static IWebDriver driver;
        public static void url()
        {
            string url = "https://mail.google.com/";
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
            Hooks.driver.Navigate().GoToUrl(url);
            Hooks.driver.Manage().Window.Maximize();
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public static void login()
        {
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            string emailId = "identifierId";
            Hooks.driver.FindElement(By.Id(emailId)).SendKeys("tselenium023@gmail.com");
            Hooks.driver.FindElement(By.Id("identifierNext")).Click();
            string passwordId = "//*[@id='password']/div[1]/div/div[1]/input";
            Hooks.driver.FindElement(By.XPath(passwordId)).SendKeys("seleniumtest1994");
            Hooks.driver.FindElement(By.XPath("//*[@id='passwordNext']/div/button/div[2]")).Click();
            Thread.Sleep(2000);









        }

    }
}
