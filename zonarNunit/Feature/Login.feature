Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	
@Login @Smoke
Scenario: LoginPageSmoke
	Given I have Opened Login Page
	And I have displayed emailField, passField, logInButton
	When I press Login Button
	Then I see Required Validation message 


@Stable @Login @Negative
Scenario: RequiredFieldIsValidated
	Given I have Opened Login Page
	When I press Login Button
	Then I see Required Validation message 



 @Stable  @Login @Positive
Scenario: Login
	Given I have Opened Login Page
	And  I have entered Exist Login
	And I have entered Exist Password
	When I press Login Button
	Then The result Account Page is Opened
	And  I see my name in a conner



@Stable @Login @Negative
	Scenario: LoginWithWrongPassword
	Given I have Opened Login Page
	And I have entered Exist Login
	And I have entered Wrong Password 
	When I press Login Button
	Then The result User see validation message
	
	
	
