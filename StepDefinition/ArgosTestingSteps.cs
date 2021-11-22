using NUnit.Framework;
using PodCheckout.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PodCheckout.StepDefinition
{
    [Binding]
    public class ArgosTestingSteps
    {
         ArgosTestingPage argostestingpage;

        public ArgosTestingSteps()
        {
            argostestingpage = new ArgosTestingPage();
        }

        [Given(@"I click all images with palm trees")]
        public void GivenIClickAllImagesWithPalmTrees()
        {
            argostestingpage.IclickImageWithpalmTrees();
        }



        [Given(@"I that navigate to the website ""(.*)""")]
        public void GivenIThatNavigateToTheWebsite(string Url)
        {
            argostestingpage.INavigateToTheWebsite(Url);
        }
        [Given(@"I Click Accept all cookies")]
        public void GivenIClickAcceptAllCookies()
        {
            argostestingpage.IClickAcceptAllCookies();
        }
        [Given(@"I confirm Argos page is displayed")]
        public void GivenIConfirmArgosPageIsDisplayed()
        {
            Assert.That(argostestingpage.IsArgosPageDisplayed);
        }





        [Given(@"I click account")]
        public void GivenIClickAccount()
        {
            argostestingpage.IClickAccount();
        }
        
        [Given(@"I Enter email address ""(.*)""")]
        public void GivenIEnterEmailAddress(string EmailText)
        {
            argostestingpage.IEnterEmailAddress(EmailText);
        }
        
        [Given(@"the user enter password ""(.*)""")]
        public void GivenTheUserEnterPassword(string PasswordText)
        {
            argostestingpage.IEnterPassword(PasswordText);
        }
        
        [Given(@"I sign in in securely")]
        public void GivenISignInInSecurely()
        {
            argostestingpage.IClickSignInSecurely();
        }
        
        [Given(@"I click shop drop down")]
        public void GivenIClickShopDropDown()
        {
            argostestingpage.IClickShop();
        }
        
        [Given(@"I click technology")]
        public void GivenIClickTechnology()
        {
            argostestingpage.IClickTechnology();
        }
        
        [Given(@"I Mobile phones and accessories")]
        public void GivenIMobilePhonesAndAccessories()
        {
            argostestingpage.IClickMobilePhoneAndAccessories();
        }
        
        [Given(@"I click SIM free phones")]
        public void GivenIClickSIMFreePhones()
        {
            argostestingpage.IClickSimFreePhone();
        }
        
        
        
        [Given(@"I click apple")]
        public void GivenIClickApple()
        {
            argostestingpage.IClickApple();
        }
        
        [Given(@"I click SIM Free iPhone SE (.*)GB Mobile Phone-Black")]
        public void GivenIClickSIMFreeIPhoneSEGBMobilePhone_Black(int p0)
        {
            argostestingpage.IClickSIMFreeIPhoneSE();
        }
        
        [Given(@"I click Colour Black")]
        public void GivenIClickColourBlack()
        {
            argostestingpage.IClickColorBlack();
        }
        
        [Given(@"I click add to trolley")]
        public void GivenIClickAddToTrolley()
        {
            argostestingpage.IClickAddTrolley();
        }
        
        [Given(@"I click continue shopping")]
        public void GivenIClickContinueShopping()
        {
            argostestingpage.IClickContinueShopping();
        }
        
        [Given(@"I click black friday")]
        public void GivenIClickBlackFriday()
        {
          
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
