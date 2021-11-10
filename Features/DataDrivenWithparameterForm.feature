Feature: DataDrivenWithparameterForm
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driven With parameter Form
    Given I Navigate to "https://angularjs.realworld.io/#/"
	And User Click Sign In
	And User enter email address "toyunh@gmail.com"
	And User enter password "mombsame22"
	And User Click Sign in
	And User Click New article
	And I enter article Title "Thebodyname"
	And I Enter What this article about "Children"
	And I enter Write your article "Isaboutthepeace"
	When I enter tags "Theland"
	Then I should publish article
	Then I should be able to register successfully
	