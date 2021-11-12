using PodCheckout.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PodCheckout.StepDefinition
{
    [Binding]
    public class DataDrivenWithparameterFormSteps
    {
        DataDrivenWithParameterFormPage datadrivenwithparameterformpage;

        public DataDrivenWithparameterFormSteps()
        {
            datadrivenwithparameterformpage = new DataDrivenWithParameterFormPage();
        }

        
        [Given(@"User Click Sign In")]
        public void GivenUserClickSignIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter email address ""(.*)""")]
        public void GivenEnterEmailAddress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter password ""(.*)""")]
        public void GivenEnterPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The User Click Sign in")]
        public void GivenTheUserClickSignIn()
        {
            ScenarioContext.Current.Pending();
        }


        [Given(@"Click New article")]
        public void GivenClickNewArticle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter article Title ""(.*)""")]
        public void GivenEnterArticleTitle(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Enter What this article about ""(.*)""")]
        public void GivenEnterWhatThisArticleAbout(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter Write your article ""(.*)""")]
        public void GivenEnterWriteYourArticle(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"enter tags ""(.*)""")]
        public void WhenEnterTags(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"should publish article")]
        public void ThenShouldPublishArticle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"User should be able to register successfully")]
        public void ThenUserShouldBeAbleToRegisterSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
