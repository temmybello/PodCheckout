using NUnit.Framework;
using PodCheckout.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PodCheckout.StepDefinition
{
    [Binding]
    public class AbelShoppingSteps
    {
        AbelShoppingPage abelShoppingPage;


        public AbelShoppingSteps()
        {
            abelShoppingPage = new AbelShoppingPage();
        }




        [Given(@"i navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            abelShoppingPage.INavigateToTheWebsite(url);
        }
        
        [Given(@"I accept cookies")]
        public void GivenIAcceptCookies()
        {
            abelShoppingPage.IClickAcceptCookies();
        }
        
        [Given(@"I click Sign up")]
        public void GivenIClickSignUp()
        {
            abelShoppingPage.IClickSignUp();
        }

        [Given(@"I enter post code ""(.*)""")]
        public void GivenIEnterPostCode(string PostCodeText)
        {
            abelShoppingPage.IEnterPostCode(PostCodeText);
        }


        [Given(@"I click find address")]
        public void GivenIClickFindAddress()
        {
            abelShoppingPage.IClickFindAddress();
        }
        [Given(@"I select your address")]
        public void GivenISelectYourAddress()
        {
            abelShoppingPage.ISelectAddress();
        }


        [Given(@"I click continue")]
        public void GivenIClickContinue()
        {
            abelShoppingPage.IClickContinue();
        }

        [Given(@"I click continue(.*)")]
        public void GivenIClickContinue(int p0)
        {
            abelShoppingPage.IClickContinue2();
        }


        [Given(@"I click Neither")]
        public void GivenIClickNeither()
        {
            abelShoppingPage.IClickNeither();
        }
        
        [Given(@"I Click next step")]
        public void GivenIClickNextStep()
        {
            abelShoppingPage.IclickNextStep();
        }
        
        [Given(@"i enter email address ""(.*)""")]
        public void GivenIEnterEmailAddress(string EmailText)
        {
            abelShoppingPage.IEnterEmail(EmailText);
        }
        
        [Given(@"I enter Password ""(.*)""")]
        public void GivenIEnterPassword(string PasswordText)
        {
            abelShoppingPage.IEnterPassword(PasswordText);
        }
        
        [Given(@"I select how do you hear about us")]
        public void GivenISelectHowDoYouHearAboutUs()
        {
            abelShoppingPage.ISelectHearAboutUs();
        }
        
        
        [Given(@"I click Yes please I'm in")]
        public void GivenIClickYesPleaseIMIn()
        {
            abelShoppingPage.IClickYesIn();
        }
        
        [Given(@"I click sign up and continue")]
        public void GivenIClickSignUpAndContinue()
        {
            abelShoppingPage.IClickSignUpAndContinue();
        }
        
        

        [Given(@"I click start shopping")]
        public void GivenIClickStartShopping()
        {
            abelShoppingPage.IClickStartShopping();
        }
       
        

       




        [When(@"I Confirm Start shopping is on the page")]
        public void WhenIConfirmStartShoppingIsOnThePage()
        {
            Assert.That(abelShoppingPage.IConfirmStartShoppingIsDisplayed);
        }


        [Given(@"I Confirm all you need is less")]
        public void GivenIConfirmAllYouNeedIsLess()
        {
            Assert.That(abelShoppingPage.IConfirmAllYouNeedIsLessDisplayed);
        }


    }
}
