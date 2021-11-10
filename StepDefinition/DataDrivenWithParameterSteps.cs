using NUnit.Framework;
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
        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            datadrivenwithparameterpage.IClickSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(3000);
            Assert.That(datadrivenwithparameterpage.IsNewArticleDisplayed);
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

        [Given(@"User Click Sign in")]
        public void GivenUserClickSignIn()
        {
            datadrivenwithparameterpage.UserClickSignIn();
        }
        
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
