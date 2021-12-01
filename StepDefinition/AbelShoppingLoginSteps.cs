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
            Thread.Sleep(5000);
            abelShoppingLoginPage.IClickBasketIcon();
        }

        [Given(@"I click closing")]
        public void GivenIClickClosing()
        {
            abelShoppingLoginPage.IClickClosing();
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

        [Given(@"I click pick number")]
        public void GivenIClickPickNumber()
        {
            abelShoppingLoginPage.IClickPickNumber();
        }
        
        [Given(@"I confirm Onboarding checkout is displayed")]
        public void GivenIConfirmOnboardingCheckoutIsDisplayed()
        {
            Thread.Sleep(5000);
            Assert.That(abelShoppingLoginPage.IConfirmedOnBoardingCheckoutIsDisplayed);
        }
        [Given(@"I confirm item added to basket count successfully")]
        public void GivenIConfirmItemAddedToBasketCountSuccessfully()
        {
            Thread.Sleep(3000);
            Assert.That(abelShoppingLoginPage.IConfirmItemAddedToBasketCountSuccessfully);
        }


        [Given(@"I click carat number")]
        public void GivenIClickCaratNumber()
        {
            Thread.Sleep(5000);
            abelShoppingLoginPage.IClickCaratNumber();
        }

        [Given(@"I click drop down")]
        public void GivenIClickDropDown()
        {
            Thread.Sleep(3000);
            abelShoppingLoginPage.IClickDropDown();
        }

        [Given(@"I select Title drop down")]
        public void GivenISelectTitleDropDown()
        {
            Thread.Sleep(5000);
            abelShoppingLoginPage.ISelectTitleDropDown();
        }

        [Given(@"I enter first name ""(.*)""")]
        public void GivenIEnterFirstName(string NameText)
        {
            abelShoppingLoginPage.IEnterFirstName(NameText);
        }
        [Given(@"I click Title")]
        public void GivenIClickTitle()
        {
            abelShoppingLoginPage.IClickTitle();
        }


        [Given(@"I enter last name ""(.*)""")]
        public void GivenIEnterLastName(string NameText)
        {
            abelShoppingLoginPage.IEnterLastName(NameText);
        }

      

        [Given(@"I Where shall we leave your order if you're not in ""(.*)""")]
        public void GivenIWhereShallWeLeaveYourOrderIfYouReNotIn(string Text)
        {
            abelShoppingLoginPage.IEnterDeliveryNote(Text);
        }

        [Given(@"User click continue botton")]
        public void GivenUserClickContinueBotton()
        {
            Thread.Sleep(3000);
            abelShoppingLoginPage.IClickContinue2();
        }
        [Then(@"User click logout")]
        public void ThenUserClickLogout()
        {
            abelShoppingLoginPage.IClickLogOut();
        }



        [Given(@"I enter phone number")]
        public void GivenIEnterPhoneNumber()
        {
            abelShoppingLoginPage.IEnterPhoneNumber();
        }
        [When(@"I confirm Payment details is displayed")]
        public void WhenIConfirmPaymentDetailsIsDisplayed()
        {
            Thread.Sleep(3000);
            Assert.That(abelShoppingLoginPage.IsPaymentDetailsIsDisplayed);
        }



        [Given(@"the user click continue")]
        public void GivenTheUserClickContinue()
        {
            abelShoppingLoginPage.IClickContinue();
        }

        [Given(@"I click search")]
        public void GivenIClickSearch()
        {
            abelShoppingLoginPage.IClickSearchButton();
        }

        [Given(@"I Click Add item")]
        public void GivenIClickAddItem()
        {
            abelShoppingLoginPage.IClickAddItem();
        }

        [Given(@"I confirm tropical fruit added to basket")]
        public void GivenIConfirmTropicalFruitAddedToBasket()
        {
            Thread.Sleep(3000);
            Assert.That(abelShoppingLoginPage.IConfirmTropicalFruitAddedSuccessfully);
        }


        [Given(@"I click Close")]
        public void GivenIClickClose()
        {
            abelShoppingLoginPage.IClickClose();
        }

        [Given(@"User Click Search")]
        public void GivenUserClickSearch()
        {
            abelShoppingLoginPage.UserClickSearchButton2();
        }

        [Given(@"click add Item(.*)")]
        public void GivenClickAddItem(int p0)
        {
            abelShoppingLoginPage.ClickUserAddItem();
        }

        [Given(@"User click close(.*)")]
        public void GivenUserClickClose(int p0)
        {
            abelShoppingLoginPage.ClickUserClose();
        }

        [Given(@"the user click search")]
        public void GivenTheUserClickSearch()
        {
            abelShoppingLoginPage.UserClickSearchButton3();
        }

        [Given(@"The user click Add item")]
        public void GivenTheUserClickAddItem()
        {
            abelShoppingLoginPage.IClickAddItem3();
        }

        [Given(@"The user click close")]
        public void GivenTheUserClickClose()
        {
            abelShoppingLoginPage.ClickUserClose3();
        }


        [Given(@"I click search botton")]
        public void GivenIClickSearchBotton()
        {
            abelShoppingLoginPage.IClickSearchBotton();
        }

        [Given(@"I Add Item botton")]
        public void GivenIAddItemBotton()
        {
            Thread.Sleep(5000);
            abelShoppingLoginPage.IClickAddItem4();
        }

        [Given(@"I click close botton")]
        public void GivenIClickCloseBotton()
        {
            Thread.Sleep(3000);
            abelShoppingLoginPage.IClickUserCloseBotton();
        }

        [Given(@"click Promo")]
        public void GivenClickPromo()
        {
            abelShoppingLoginPage.IClickPromo();
        }

        [Given(@"I click christmas")]
        public void GivenIClickChristmas()
        {
            abelShoppingLoginPage.IClickChristmas();
        }



        [Given(@"I click Close pop")]
        public void GivenIClickClosePop()
        {
            abelShoppingLoginPage.IClickClosePop();
        }





        [Given(@"Is four item in the basket successfully")]
        public void GivenIsFourItemInTheBasketSuccessfully()
        {
            Assert.That(abelShoppingLoginPage.IConfirmFourBasketAddedSuccessfully);

        }







    }
}
