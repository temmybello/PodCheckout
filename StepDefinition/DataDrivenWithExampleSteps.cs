using PodCheckout.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PodCheckout.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleSteps
    {
        DataDrivenWithExamplePage datadrivenwithexamplepage;
        public DataDrivenWithExampleSteps()
        {
            datadrivenwithexamplepage = new DataDrivenWithExamplePage();
        }

        [Given(@"The user enter username text ""(.*)""")]
        public void GivenTheUserEnterUsernameText(string username)
        {
            datadrivenwithexamplepage.EnterUsername(username);
        }
        
        [Given(@"The user enter my email address ""(.*)""")]
        public void GivenTheUserEnterMyEmailAddress(string email)
        {
            datadrivenwithexamplepage.UserEnterEmail(email);
        }
        
        [Given(@"The user enter password ""(.*)""")]
        public void GivenTheUserEnterPassword(string password)
        {
            datadrivenwithexamplepage.UserEnterPassword(password);
        }
    }
}
