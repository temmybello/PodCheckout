using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PodCheckout.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PodCheckout.PageObject
{
    class AbelShoppingLoginPage
    {
            public AbelShoppingLoginPage()
            {
                driver = Hooks1.driver;
            }
            IWebDriver driver;

            IWebElement Login => driver.FindElement(By.XPath("//*[@id='my-account']/div[2]/a"));
            IWebElement LogInButton => driver.FindElement(By.XPath("//input[@class='cta-button no-arrow log-in']"));
            IWebElement AcceptCookies => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));
            IWebElement Email => driver.FindElement(By.XPath("//*[@id='UserName']"));
            IWebElement Password => driver.FindElement(By.XPath("//*[@id='Password']"));
            IWebElement FruitAndVegDropDown => driver.FindElement(By.XPath("//*[@id='menu-parent']/ul/li[1]"));
            IWebElement Search=> driver.FindElement(By.XPath("//*[@id='search-term']"));
            IWebElement FruitVegBoxes => driver.FindElement(By.XPath("//*[@class='push-banner']"));
            IWebElement TropicalFruit => driver.FindElement(By.XPath("//*[@id='product-list']/li[1]/div[3]/div[1]/a"));
            IWebElement BasketIcon => driver.FindElement(By.XPath("//*[@class='icon-basket basket-quantity']"));
            IWebElement TextBoxQuatity => driver.FindElement(By.XPath("//*[@id='main-inner']/div[3]/div[1]/form/div/div[3]/div[2]"));
            IWebElement AddSignPlus => driver.FindElement(By.XPath("//*[@class='add-sign plus']"));
            IWebElement Add => driver.FindElement(By.XPath("//*[@class='add cta-button']"));
            IWebElement BasketSuccessfully => driver.FindElement(By.XPath("//span[text()='4']"));
            IWebElement ProductBasket => driver.FindElement(By.XPath("//*[@class='basket-product-container']"));
            IWebElement PickNumber => driver.FindElement(By.XPath("//*[@class='focus']"));
            IWebElement CaratNumber => driver.FindElement(By.XPath("(//*[@class='selected'])[2]"));
            IWebElement Continue => driver.FindElement(By.XPath("//*[@class='cta-checkout-button']"));
            IWebElement BasketButton => driver.FindElement(By.XPath("//*[@id='basket-icon']/div"));
            IWebElement DropDown => driver.FindElement(By.XPath("(//*[@class='dropdown'])[2]"));
            IWebElement BasketCount => driver.FindElement(By.XPath("//*[@id='BasketCount']"));
            IWebElement Title => driver.FindElement(By.XPath("//*[@class='Title']"));
            IWebElement OnBoardingCheckout => driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/section"));
            IWebElement TitleDropDown => driver.FindElement(By.XPath("//*[@class='title-dropdown__select']"));
            IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='FirstName']"));
            IWebElement LastName => driver.FindElement(By.XPath("//*[@id='LastName']"));
            IWebElement PhoneNumber => driver.FindElement(By.XPath("//*[@id='Telephone']"));
            IWebElement DeliveryNote => driver.FindElement(By.XPath("//*[@id='DeliveryNotes']"));
            IWebElement Continue2 => driver.FindElement(By.XPath("//*[@class='cta-continue-button']"));
            IWebElement Paymentdetails => driver.FindElement(By.XPath("//*[@class='title card-details']"));
            IWebElement LogOut => driver.FindElement(By.XPath("//*[@id='masthead-space']/div[1]/div[2]/div/a"));
            IWebElement PlusSign => driver.FindElement(By.XPath("(//*[@class='add-sign plus'])[2]"));
            IWebElement SearchButton => driver.FindElement(By.XPath("//*[@id='search-btn']"));
            IWebElement AddItem => driver.FindElement(By.XPath("//*[@class='add cta-button ']"));
            IWebElement Close => driver.FindElement(By.XPath("//*[@id='left_side_auto']/div[3]"));
            IWebElement Tropicalfruit => driver.FindElement(By.XPath("//*[@id='search_autocomplete']"));
            IWebElement SearchButton2 => driver.FindElement(By.XPath("//*[@id='search-term']"));
            IWebElement UserAddItem => driver.FindElement(By.XPath("//*[@class='add cta-button ']"));
            IWebElement UserClose => driver.FindElement(By.XPath("//*[@id='left_side_auto']/div[3]"));
            IWebElement SearchButton3 => driver.FindElement(By.XPath("//*[@id='search-term']"));
            IWebElement AddItem3 => driver.FindElement(By.XPath("//*[@class='add cta-button ']"));
            IWebElement UserClose3 => driver.FindElement(By.XPath("//*[@id='left_side_auto']/div[3]"));
            IWebElement SearchBotton => driver.FindElement(By.XPath("//*[@id='search-term']"));
            IWebElement AddItem4 => driver.FindElement(By.XPath("//*[@class='add cta-button ']"));
            IWebElement UserCloseBotton => driver.FindElement(By.XPath("//*[@id='left_side_auto']/div[3]"));
            IWebElement Closing => driver.FindElement(By.XPath("//*[@class='closing-x']"));
            IWebElement PlusSign1 => driver.FindElement(By.XPath("//div[@class='add-sign plus']"));
            IWebElement Promo => driver.FindElement(By.XPath("//*[@class='promostrip']"));
            IWebElement ClosePop => driver.FindElement(By.XPath("(//*[@id='delivery-date']/div[1]/img)[2]"));
            IWebElement Christmas => driver.FindElement(By.XPath("//*[@id='menu-parent']/ul/li[1]/span/a"));




        public IWebElement SelectNumber { get; private set; }
        public IWebElement SelectTitle { get; private set; }


        public void IClickClosePop()
        {
            Thread.Sleep(5000);
            ClosePop.Click();
        }

        public void IClickChristmas()
        {
            Thread.Sleep(5000);
            Christmas.Click();
        }


        public void IClickPromo()
        {
            Thread.Sleep(5000);
            Promo.Click();
        }



        public void IClickClosing()
        {
            Thread.Sleep(5000);
            Closing.Click();
        }


        public void IClickAddItem4()
        {
            Thread.Sleep(5000);
            AddItem4.Click();    
        }

        public void IClickUserCloseBotton()
        {
            Thread.Sleep(5000);
            UserCloseBotton.Click();
        }


       public void IClickSearchBotton()
        {
            Thread.Sleep(3000);
            SearchBotton.Click();
            SearchBotton.Clear();
            SearchBotton.SendKeys("Clementines Organic");
        }

        
        public void IClickAddItem3()
        {
            Thread.Sleep(5000);
            AddItem3.Click();
        }

        public void ClickUserClose3()
        {
            Thread.Sleep(3000);
            UserClose3.Click();
        }


        public void UserClickSearchButton3()
        {
            Thread.Sleep(3000);
            SearchButton3.Click();
            SearchButton3.Clear();
            SearchButton3.SendKeys("Bergamot Lemons Organic");
        }


        public void ClickUserAddItem()
        {
            Thread.Sleep(3000);
            UserAddItem.Click();
            PlusSign1.Click();
        }


        public void ClickUserClose()
        {
            UserClose.Click();
        }

        public void UserClickSearchButton2()
        {
            SearchButton2.Click();
            SearchButton2.Clear();
            SearchButton2.SendKeys("Oranges For Juicing, Organic ");
        }



        public bool IConfirmTropicalFruitAddedSuccessfully()
        {
            Thread.Sleep(3000);
            return Tropicalfruit.Selected;
        }


        public void IClickAddItem()
        {
            Thread.Sleep(5000);
            AddItem.Click();
        }
        public void IClickClose()
        {
            Thread.Sleep(3000);
            Close.Click();
        }

        public void IClickSearchButton()
        {
           
            Thread.Sleep(5000);
            SearchButton.Clear();
            SearchButton.Click();
            SearchButton.SendKeys("Clementines Gift Box Organic");
        }
        public void ISelectTitleDropDown()
        {
            Thread.Sleep(5000);
            TitleDropDown.Click();
            SelectElement select = new SelectElement(SelectTitle);
            select.SelectByValue("2");
        }

        public bool IsPaymentDetailsIsDisplayed()
        {
            Thread.Sleep(3000);
            return Paymentdetails.Displayed;
        }
        public void IClickTitle()
        {
            Title.Click();
        }
        public void IClickLogOut()
        {
            LogOut.Click();
        }

        public void IEnterFirstName(string NameText)
        {
            FirstName.SendKeys(NameText);
        }

        public void IEnterLastName(String NameText)
        {
            LastName.SendKeys(NameText);
        }
        public void IEnterPhoneNumber()
        {
            PhoneNumber.SendKeys("0796106499");
        }

        public void IEnterDeliveryNote(String Text)
        {
            DeliveryNote.SendKeys(Text);
        }

        public void IClickContinue2()
        {
           Continue2.Click();
        }

        public bool IConfirmedOnBoardingCheckoutIsDisplayed()
        {
            return OnBoardingCheckout.Displayed;
        }

        public bool IConfirmItemAddedToBasketCountSuccessfully()
        {
            Thread.Sleep(3000);
            return BasketCount.Displayed;
        }


        public void IClickDropDown()
        {
            DropDown.Click();
        }

        public void IClickCaratNumber()
        {
            CaratNumber.SendKeys("4");
        }
        public void IclickBasketButton()
        {
            BasketButton.Click();
        }

        public void IClickBasketIcon()
        {
            Thread.Sleep(3000);
            BasketIcon.Click();
        }

        public bool IConfirmFourBasketAddedSuccessfully()
        {
            Thread.Sleep(3000);
            return BasketSuccessfully.Displayed;
        }
       public void IClickPickNumber()
        {
            Thread.Sleep(3000);
            //PickNumber.SendKeys("4");
            //PickNumber.Clear();
            PickNumber.Click();
           
        }
        public bool IsProductBasketDisplayed()
        {
            Thread.Sleep(3000);
            return ProductBasket.Displayed;
        }
       
        public void ISelectCaratNumber()
        {
            Thread.Sleep(3000);
            SelectElement select = new SelectElement(SelectNumber);
            select.SelectByValue("7");
        }
        public void IClickContinue()
        {
            Thread.Sleep(5000);
            Continue.Click();
        }
       
        
        public void IClickAdd()
        {
            Thread.Sleep(5000);
            Add.Click();
            PlusSign.Click();
        }



        public bool IConfirmProductBasketIsDisplayed()
        {
            return ProductBasket.Displayed;
        }
        public void IClickTextBoxQuatity()
        {
            TextBoxQuatity.Click();
        }
        public void IClickTropicalFruit()
        {
            Thread.Sleep(3000);
            TropicalFruit.Click();
        }

        public void IClickFruitVegBoxes()
        {
            Thread.Sleep(3000);
            FruitVegBoxes.Click();
        }

        public void IClickLogin()
        {
            Login.Click();
        }
        public void IClickAddSignPlus()
        {
            AddSignPlus.Click();
            Thread.Sleep(5000);
            AddSignPlus.Click();
        }
        public void INavigateToTheWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void IClickFruitAndVegDropDown()
        {
            FruitAndVegDropDown.Click();
        }

    
        public void UserClickLogInButton()
        {
            LogInButton.Click();
        }
        public void IEnterEmail(String EmailText)
        {
            Email.SendKeys(EmailText);
        }

        public void IEnterPassword(String PasswordText)
        {
            Password.SendKeys(PasswordText);
        }
        public void IClickAcceptCookies()
        {
            Thread.Sleep(3000);
            AcceptCookies.Click();
        }
        public bool IConfirmSearchIsDisplayed()
        {
            return Search.Displayed;
        }



























    }
}
