using NUnit.Framework;
using OpenQA.Selenium;
using PodCheckout.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PodCheckout.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage datadrivenwithparameterpage;

        //public object GenericHelper { get; private set; }

        public DataDrivenWithParameterSteps()
        {
            datadrivenwithparameterpage = new DataDrivenWithParameterPage();
        }

            [Given(@"I Navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            datadrivenwithparameterpage.NavigateToWebsite(url);
        }
        [Given(@"I click on Signup")]
        public void GivenIClickOnSignup()
        {
            datadrivenwithparameterpage.ClickOnSignUp();
        }


        [Given(@"I enter username text ""(.*)""")]
        public void GivenIEnterUsernameText(string UsernameText)
        {
            datadrivenwithparameterpage.IEnterUsername(UsernameText);
        }
        
        [Given(@"I enter my email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string EmailText)
        {
            datadrivenwithparameterpage.IEnterPassword(EmailText);
        }
        
        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string PasswordText)
        {
            datadrivenwithparameterpage.IEnterPassword(PasswordText);
        }
        [Given(@"I click on the sign up button")]
        public void GivenIClickOnTheSignUpButton()
        {
            datadrivenwithparameterpage.IClickSignUpButton();
        }

        [Given(@"User Confirm new article")]
        public void GivenUserConfirmNewArticle()
        {
            Thread.Sleep(5000);
            Assert.That(datadrivenwithparameterpage.IsNewArticleDisplayed);
        }




        //[Then(@"I should be able to register successfully on the page")]
        //public void ThenIShouldBeAbleToRegisterSuccessfullyOnThePage()
        //Thread.Sleep(5000);
        //Assert.That(datadrivenwithparameterpage.IsNewArticleDisplayed);
        //Assert.IsTrue(GenericHelper.ToSt(By.Id("")));
        //Assert.IsTrue(GenericHelper.(By.Id("new_article")));

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(datadrivenwithparameterpage.IsNewArticleDisplayed);
            //Assert.IsTrue(GenericHelper.Equals(By.Id("")));
       }




        //[Given(@"I should be able to register successfully")]
        //public void GivenIShouldBeAbleToRegisterSuccessfully()
        //{
        //Thread.Sleep(5000);
        //Assert.That(datadrivenwithparameterpage.IsNewArticleDisplayed);
        //}
        [Given(@"I Click Sign In")]
        public void GivenIClickSignIn()
        {
            datadrivenwithparameterpage.IClickSignIn();
        }

        [Given(@"User enter email address ""(.*)""")]
        public void GivenUserEnterEmailAddress(string EmailText)
        {
            datadrivenwithparameterpage.UserEmailAddress(EmailText);
        }

        [Given(@"User enter password ""(.*)""")]
        public void GivenUserEnterPassword(string PasswordText)
        {
            datadrivenwithparameterpage.UserEnterPassword(PasswordText);
        }

        //[Given(@"User Click Sign in")]
        //public void GivenUserClickSignIn()
        //{
            //datadrivenwithparameterpage.UserClickSignIn();
        //}
        
        [Given(@"User Click New article")]
        public void GivenUserClickNewArticle()
        {
            datadrivenwithparameterpage.UserClickNewArticle();
        }



        [Given(@"I enter article Title ""(.*)""")]
        public void GivenIEnterArticleTitle(string TitleText)
        {
            datadrivenwithparameterpage.IEnterArticleTitle(TitleText);
        }

        [Given(@"I Enter What this article about ""(.*)""")]
        public void GivenIEnterWhatThisArticleAbout(string ArticleText)
        {
            datadrivenwithparameterpage.IEnterArticleAbout(ArticleText);
        }

        [Given(@"I enter Write your article ""(.*)""")]
        public void GivenIEnterWriteYourArticle(string Article)
        {
            datadrivenwithparameterpage.IEnterWriteYourArticle(Article);
        }

        [When(@"I enter tags ""(.*)""")]
        public void WhenIEnterTags(string Tags)
        {
            datadrivenwithparameterpage.IEnterTags(Tags);
        }

        [Then(@"I should publish article")]
        public void ThenIShouldPublishArticle()
        {
            datadrivenwithparameterpage.IClickPublish();
        }


        
    }
}
