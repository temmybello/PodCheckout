using NUnit.Framework;
using PodCheckout.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PodCheckout.StepDefinition
{
    [Binding]
    public class AbelShoppingLoginSteps
    {
   
            AbelShoppingLoginPage abelShoppingLoginPage;


            public AbelShoppingLoginSteps()
            {
                abelShoppingLoginPage = new AbelShoppingLoginPage();
            }

         [Given(@"user navigate to the website ""(.*)""")]
        public void GivenUserNavigateToTheWebsite(string url)
        {
            abelShoppingLoginPage.INavigateToTheWebsite(url);
        }
        
        [Given(@"The user accept cookies")]
        public void GivenTheUserAcceptCookies()
        {
            abelShoppingLoginPage.IClickAcceptCookies();
        }
        
        [Given(@"user click on Log in")]
        public void GivenUserClickOnLogIn()
        {
            abelShoppingLoginPage.IClickLogin();
        }
        
        [Given(@"The user enter email address ""(.*)""")]
        public void GivenTheUserEnterEmailAddress(string EmailText)
        {
            abelShoppingLoginPage.IEnterEmail(EmailText);
        }
        
        [Given(@"User enter Password ""(.*)""")]
        public void GivenUserEnterPassword(string PasswordText)
        {
            abelShoppingLoginPage.IEnterPassword(PasswordText);
        }
        
        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            abelShoppingLoginPage.UserClickLogInButton();
        }
        
        [Given(@"I Click Fruit and veg drop down")]
        public void GivenIClickFruitAndVegDropDown()
        {
            abelShoppingLoginPage.IClickFruitAndVegDropDown();
        }
        
        [Given(@"I click fruit")]
        public void GivenIClickFruit()
        {
            abelShoppingLoginPage.IClickFruit();
        }

        [Given(@"I confirm search is on the page")]
        public void GivenIConfirmSearchIsOnThePage()
        {
            Assert.That(abelShoppingLoginPage.IConfirmSearchIsDisplayed);
        }

        [Given(@"I click fruit & veg boxes")]
        public void GivenIClickFruitVegBoxes()
        {
            abelShoppingLoginPage.IClickFruitVegBoxes();
        }

        [Given(@"I Tropical Fruit Favourites Box Organic")]
        public void GivenITropicalFruitFavouritesBoxOrganic()
        {
            abelShoppingLoginPage.IClickTropicalFruit();
        }

        [Given(@"I click Add textbox quality")]
        public void GivenIClickAddTextboxQuality()
        {
            abelShoppingLoginPage.IClickTextBoxQuality();
        }

        [Given(@"Click Add sign plus ""(.*)""")]
        public void GivenClickAddSignPlus(int p0)
        {
            abelShoppingLoginPage.IClickAddSignPlus();
        }

        [Given(@"I click Add")]
        public void GivenIClickAdd()
        {
            abelShoppingLoginPage.IClickAdd();

        }

        [Given(@"I confirm item is added successfully in the basket")]
        public void GivenIConfirmItemIsAddedSuccessfullyInTheBasket()
        {
            Assert.That(abelShoppingLoginPage.IConfirmBasketIsDisplayed);
        }

        [Given(@"I confirm product basket displayed")]
        public void GivenIConfirmProductBasketDisplayed()
        {
            Assert.That(abelShoppingLoginPage.IsProductBasketDisplayed);
        }

        [Given(@"I click carat drop down")]
        public void GivenIClickCaratDropDown()
        {
            abelShoppingLoginPage.IclickCaratDropDown();
        }

        [Given(@"I click ""(.*)""")]
        public void GivenIClick(int p0)
        {
            abelShoppingLoginPage.IClickCarat3();
        }

        [Given(@"the user click continue")]
        public void GivenTheUserClickContinue()
        {
            abelShoppingLoginPage.IClickContinue();
        }



    }
}
