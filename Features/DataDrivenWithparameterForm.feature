

Feature: DataDrivenWithparameterForm
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driven With parameter Form
    Given I Navigate to "https://angularjs.realworld.io/#/"
	And User Click Sign In
	And  enter email address "toyunh@gmail.com"
	And  enter password "mombsame22"
	And  The User Click Sign in
	And  Click New article
	And  enter article Title "Thebodyname"
	And  Enter What this article about "Children"
	And  enter Write your article "Isaboutthepeace"
	When enter tags "Theland"
	Then  should publish article
	Then User should be able to register successfully
	