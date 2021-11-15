using NUnit.Framework;
using PodCheckout.PageObject;
using System;
using System.Threading;
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
        [Given(@"I click accept cookies")]
        public void GivenIClickAcceptCookies()
        {
            amazonregistrationpage.IClickAceeptCookies();
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

        [When(@"I will re-enter password ""(.*)""")]
        public void WhenIWillRe_EnterPassword(string PasswordText)
        {
            amazonregistrationpage.IReEnterPassword(PasswordText);
        }

        [Then(@"I click create amazon account")]
        public void ThenIClickCreateAmazonAccount()
        {
            amazonregistrationpage.IClickCreateAmazonAccount();
        }


        [Given(@"I confirm amazon\.co\.uk is displayed")]
        public void GivenIConfirmAmazon_Co_UkIsDisplayed()
        {
            Thread.Sleep(5000);
            Assert.That(amazonregistrationpage.IsAmazonCoUkDisplayed);
        }
        [Given(@"I click hello sign in")]
        public void GivenIClickHelloSignIn()
        {
            amazonregistrationpage.IClickHelloSignIn();
        }


        [Given(@"I click all drop down")]
        public void GivenIClickAllDropDown()
        {
            amazonregistrationpage.IClickAllDropDown();
        }

        [Given(@"I click sign in")]
        public void GivenIClickSignIn()
        {
            amazonregistrationpage.IClickSignIn();
        }

        [Given(@"User enter email ""(.*)""")]
        public void GivenUserEnterEmail(string EmailText)
        {
            amazonregistrationpage.IEnterUserEmail(EmailText);
        }

        [Given(@"User click continue")]
        public void GivenUserClickContinue()
        {
            amazonregistrationpage.IClickContinue();
        }

        [Given(@"The user enter sign in password ""(.*)""")]
        public void GivenTheUserEnterSignInPassword(string PasswordText)
        {
            amazonregistrationpage.IEnterSignInPassword(PasswordText);
        }

        [Given(@"User click sign in")]
        public void GivenUserClickSignIn()
        {
            amazonregistrationpage.IClickUserSignIn();
        }

        [Given(@"I click keep me signed in")]
        public void GivenIClickKeepMeSignedIn()
        {
            amazonregistrationpage.IClickSignedIn();
        }

        [Given(@"I Click best sellers")]
        public void GivenIClickBestSellers()
        {
            amazonregistrationpage.IClickBestSellers();
        }

    }
}
