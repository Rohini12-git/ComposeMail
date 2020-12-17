using System;
using TechTalk.SpecFlow;

namespace ComposeMail
{
    [Binding]
    public class Gmail_LoginSteps
    {
        [Given(@"the url of gmail")]
        public void GivenTheUrlOfGmail()
        {
            gmail_login.url();
        }
        
        [When(@"enter the email and password")]
        public void WhenEnterTheEmailAndPassword()
        {
            gmail_login.login();
        }
        
        [Then(@"it should redirect to account page")]
        public void ThenItShouldRedirectToAccountPage()
        {
            Console.WriteLine("asd");
        }
    }
}
