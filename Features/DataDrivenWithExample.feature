Feature: DataDrivenWithExample
	Simple calculator for adding two numbers

@mytag
Scenario Outline: data Driven With Examples
	Given I Navigate to "https://angularjs.realworld.io/#/"
	And  I click on Signup
	And The user enter username text "<username>"
	And The user enter my email address "<email>"
	And The user enter password "<password>"
	When I click on the sign up button 
	Then I should be able to register successfully


  Examples:
  | username  | email               | password     |
  | Seyitunde | Seyi22@gmail.com    | PasswordSure |
  | Messy     | Crazy22@gmail.com   | temi443      |
  | Roland    | Roland444@gmail.com | Passward333  |
	
