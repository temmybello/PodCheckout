using PodCheckout.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PodCheckout.StepDefinition
{
    [Binding]
    public class AmazonSteps
    {
        AmazonRegistrationPage amazonregistrationpage;


        public AmazonSteps()
        {
            amazonregistrationpage = new AmazonRegistrationPage();
        }






        [Given(@"I navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            amazonregistrationpage.INavigateToTheWebsite(url);
        }
        [Given(@"I click Account List Drop down")]
        public void GivenIClickAccountListDropDown()
        {
            amazonregistrationpage.IClickAccountDropDown();
        }

        [Given(@"I click Create your amazon account")]
        public void GivenIClickCreateYourAmazonAccount()
        {
            amazonregistrationpage.IClickCreateAmazonAccount();
        }

        [Given(@"I Enter your name ""(.*)""")]
        public void GivenIEnterYourName(string NameText)
        {
            amazonregistrationpage.IEnterYourName(NameText);
        }



        [Given(@"The enter email address ""(.*)""")]
        public void GivenTheEnterEmailAddress(string EmailText)
        {
            amazonregistrationpage.IEnterEmail(EmailText);
        }
        
        [Given(@"I will enter password ""(.*)""")]
        public void GivenIWillEnterPassword(string PasswordText)
        {
            amazonregistrationpage.IEnterPassword(PasswordText);
        }

        [Given(@"I will re-enter password ""(.*)""")]
        public void GivenIWillRe_EnterPassword(string PasswordText)
        {
            amazonregistrationpage.IReEnterPassword(PasswordText);
        }


        [Given(@"I click create amazon account")]
        public void GivenIClickCreateAmazonAccount()
        {
            amazonregistrationpage.IClickUserAmazonAccount();
        }
    }
}
