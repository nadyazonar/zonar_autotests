Feature: AccountSetting
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: ChangingNameOnAccountSettings
	Given I Have Main Page With Login User
	And I have opened Account Setting Tab
	When I set new Name on First name and Last name field
	And Click Update button
	And Reload page 
	Then new Names are saved
	