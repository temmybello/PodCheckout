using NUnit.Framework;
using PodCheckout.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PodCheckout.StepDefinition
{
    [Binding]
    public class AbelAndColeBasketSteps
    {

        AbelAndColeBasketPage abelAndColeBasketPage;


        public AbelAndColeBasketSteps()
        {
            abelAndColeBasketPage = new AbelAndColeBasketPage();
        }


        [Given(@"That I click Basket")]
        public void GivenThatIClickBasket()
        {
            abelAndColeBasketPage.IClickOnBasketCount();
        }

        [Given(@"user confirm product basket displayed")]
        public void GivenUserConfirmProductBasketDisplayed()
        {
            Assert.That(abelAndColeBasketPage.IsProductBasketDisplayed);
        }

        [Given(@"User click carat drop down")]
        public void GivenUserClickCaratDropDown()
        {
            abelAndColeBasketPage.IclickCaratDropDown();
        }

        [Given(@"User  click ""(.*)""")]
        public void GivenUserClick(int p0)
        {
            abelAndColeBasketPage.IClickCarat3();
        }

        [Given(@"user click continue")]
        public void GivenUserClickContinue()
        {
            abelAndColeBasketPage.IClickContinue();
        }


        [Given(@"That i navigate to the website ""(.*)""")]
        public void GivenThatINavigateToTheWebsite(string url)
        {
            abelAndColeBasketPage.INavigateToTheWebsite(url);
        }
        
        [Given(@"user click accept cookies")]
        public void GivenUserClickAcceptCookies()
        {
            abelAndColeBasketPage.IClickAcceptCookies();
        }
        
        [Given(@"That click on Log in")]
        public void GivenThatClickOnLogIn()
        {
            abelAndColeBasketPage.IClickLogin();
        }
        
        [Given(@"That user enter email address ""(.*)""")]
        public void GivenThatUserEnterEmailAddress(string EmailText)
        {
            abelAndColeBasketPage.IEnterEmail(EmailText);
        }
        
        [Given(@"That enter Password ""(.*)""")]
        public void GivenThatEnterPassword(string PasswordText)
        {
            abelAndColeBasketPage.IEnterPassword(PasswordText);
        }
        
        [Given(@"That I click login button")]
        public void GivenThatIClickLoginButton()
        {
            abelAndColeBasketPage.UserClickLogInButton();
        }
        
        [Given(@"I That I click Basket")]
        public void GivenIThatIClickBasket()
        {
         
        }
    }
}
