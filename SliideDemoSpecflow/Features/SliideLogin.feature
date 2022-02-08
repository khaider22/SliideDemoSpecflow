Feature: SliideLogin

@validateDisplay
Scenario: ValidateLoginScreen
	Given the app is launched
	Then the username box is displayed
	And the password box is displayed
	And the login button is displayed

@SuccessfullLogin
Scenario: SuccessfullLogin
	Given the app is launched
	When I enter the username "CorrectUsername"
	When I enter the password "CorrectPassword"
	And I click the login button
	Then I can see the news screen
	
@FailedLogin
Scenario: SuccessfullLogin
	Given the app is launched
	When I enter the username "WrongUsername"
	When I enter the password "WrongPassword"
	And I click the login button
	Then I see the errors on username and password box

Scenario: LoadTheNewsScreen
	Given the app is launched
	When I enter the username "CorrectUsername"
	When I enter the password "CorrectPassword"
	And I click the login button
	When there is internet connection
	Then images are displayed in row