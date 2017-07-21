Feature: Create_LoginFeature
	In order to see gmail new feature
	i need to create a new account
	 And login successfully

@mytag
Scenario: Register a valid email 
	Given I have successfully navigated to the gmail site
	And I create a new account with valid credentials
	| FirstName | LastName | EMail                 |
	| TestUSer1 | User     | HelloFriend@gmail.com |
	Then i want to be able to successfully login with the new credentials


	Scenario: Create a new user with an invalid email
	Given I have successfully navigated to the gmail site
	And I create a new account with invalid credentials
		| Email |
		| {}{}{}{} |
	Then i should get an error message


	Scenario: Login in to Gmail and sign out 
	Given I have successfully navigated to the gmail Login site
	And  i login with valid credentials 
	| Email | Password |
	|YOU HAVE TO TYPE IN  A USERNAME HERE |AND PASSWORD HERE|
	Then i successfully log out