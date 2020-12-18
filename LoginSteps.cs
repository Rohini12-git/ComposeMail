using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ComposeMail
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"the url of gmail login")]
        public void GivenTheUrlOfGmailLogin()
        {
            login_gmail.url();
        }
        
        [When(@"enter the email and password of user")]
        public void WhenEnterTheEmailAndPasswordOfUser()
        {
            login_gmail.login();
        }
        
        [Then(@"it should redirect to inbox page")]
        public void ThenItShouldRedirectToInboxPage()
        {
            string currentUrl = Hooks.driver.Url;
            Assert.AreEqual("https://mail.google.com/mail/u/0/#inbox", currentUrl);
        }

        [Then(@"compose mail by clicking on compose button")]
        public void ThenComposeMailByClickingOnComposeButton()
        {
            Thread.Sleep(1000);
            Hooks.driver.FindElement(By.CssSelector(".aic .z0 div")).Click();
        }

        [Then(@"enter the recipient and reciver address with subject and body")]
        public void ThenEnterTheRecipientAndReciverAddressWithSubjectAndBody()
        {
            Hooks.driver.FindElement(By.CssSelector(".oj div textarea")).SendKeys("rohinipriya12@gmail.com");
            Hooks.driver.FindElement(By.CssSelector(".aoD.az6 input")).SendKeys("Test");
            Hooks.driver.FindElement(By.CssSelector(".Ar.Au div")).SendKeys("Testing");
        }

        [When(@"click on send button")]
        public void WhenClickOnSendButton()
        {
            Hooks.driver.FindElement(By.CssSelector("tr.btC td.gU.Up div.dC")).Click();
        }

        [Then(@"send the message to recipient")]
        public void ThenSendTheMessageToRecipient()
        {
            Console.WriteLine("Message Sent");
        }

    }
}
