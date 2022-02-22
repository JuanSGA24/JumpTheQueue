#Epic 4: Personalize the queue

Feature: Login to the queue
	As an owner/employee, I want to be able to access the queue throw a login page,
	So that I can access management page of the queue

@mytag
Scenario: The user wants to login to the queue by providing valid credentials
	Given the user provide a username "achito"
	And the password "pass123"
	When the user clicks the button "Login"
	Then the provided credentials are "valid"

Scenario: The user wants to login to the queue by providing invalid credentials
	Given the user provide a username "achito"
	And the password "pass124"
	When the user clicks the button "Login"
	Then the provided credentials are "true"