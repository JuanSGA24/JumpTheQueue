#Epic 4: Personalize the queue

Feature: Login to the queue
	As an owner/employee, I want to be able to access the queue throw a login page,
	So that I can access management page of the queue

@mytag
Scenario: The queue needs to be managed and the owner has to fill the follow fields 
	Given the username
	And the password
	When clicks the "Accept" button
	And the credentials are correct
	Then the system grants the acces to manage the page of the queue