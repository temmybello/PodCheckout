using NUnit.Framework;
using PodCheckout.PageObject;
using System;
using System.Threading;
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

        [Given(@"I click Add textbox quatity")]
        public void GivenIClickAddTextboxQuatity()
        {
            abelShoppingLoginPage.IClickTextBoxQuatity();
        }

        [Given(@"Click Add sign plus ""(.*)""")]
        public void GivenClickAddSignPlus(int p0)
        {
            abelShoppingLoginPage.IClickAddSignPlus();
        }
        [Given(@"I click Add textbox quality ""(.*)""")]
        public void GivenIClickAddTextboxQuality(int p0)
        {
            abelShoppingLoginPage.IClickTextBoxQuatity();
        }

        [Given(@"I click Basket Icon")]
        public void GivenIClickBasketIcon()
        {
            abelShoppingLoginPage.IClickBasketIcon();
        }





        [Given(@"I click Add")]
        public void GivenIClickAdd()
        {
            abelShoppingLoginPage.IClickAdd();

        }

        [Given(@"I confirm item is added successfully in the basket")]
        public void GivenIConfirmItemIsAddedSuccessfullyInTheBasket()
        {
            Assert.That(abelShoppingLoginPage.IConfirmProductBasketIsDisplayed);
        }
        [Given(@"I click on Basket botton")]
        public void GivenIClickOnBasketBotton()
        {
            abelShoppingLoginPage.IclickBasketButton();
        }




        //[Given(@"I click on Basket Count")]
        //public void GivenIClickOnBasketCount()
        //{
        //abelShoppingLoginPage.IClickOnBasketCount();
        //}

        [Given(@"I confirm product basket displayed")]
        public void GivenIConfirmProductBasketDisplayed()
        {
            Assert.That(abelShoppingLoginPage.IsProductBasketDisplayed);
        }

        [Given(@"I click carat")]
        public void GivenIClickCarat()
        {
            Thread.Sleep(5000);
            abelShoppingLoginPage.IclickCarat();
        }

        [Given(@"I click carat number")]
        public void GivenIClickCaratNumber()
        {
            abelShoppingLoginPage.IClickCaratNumber();
        }

        [Given(@"I click drop down")]
        public void GivenIClickDropDown()
        {
            abelShoppingLoginPage.IClickDropDown();
        }




        [Given(@"the user click continue")]
        public void GivenTheUserClickContinue()
        {
            abelShoppingLoginPage.IClickContinue();
        }



    }
}
