#Epic 4: Personalize the queue

Feature: ManageQueueUsers
	As an owner I want to be able to create login credentials for the queue employees, 
	So that I can have an employee which manage the queue instead of myself.

@mytag
Scenario: The employees needs credentials to login the queue and managed them
	Given the username
	And the password
	And the confirm password
	When clicks the "Submit" button
	And the information in the fields are correct
	Then the credentials for the employee are created

Scenario: Required specifications for password
	Given the password
	When the password has at least 7 characters
	And 1 number
	And 1 uppercase letter
	And 1 lowercase letter
	Then the password is valid

Scenario: The required fields are empty
	Given the user name in blank
	And the password in blank
	Ant the confirm password in blank
	When clicks the "Submit" button
	Then an alert appears telling that this fields cannot be empty

Scenario: Username taken
	Given the username
	When the user name is already in use
	Then an alert appears telling that the usarname is taken

Scenario: Password does not match the criteria
	Given the password
	When it does not match with the specified criteria
	Then the password is invalid
	And an error alert appears with "Password entry does not meet criteria"