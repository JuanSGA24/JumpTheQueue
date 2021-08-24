#Epic 3: Manage the queue

Feature: CallNextCustomer
	As an owner/employee, I want to be able to call the next customer 
	So that I can know which ticket to attend

@mytag
Scenario: The owner has to be able to call the next customer of the queue
	Given there is a queue of customers
	When the "Next" button is pressed
	Then the access code is updated to the access code of the new customer
	And the information for all non-attentded customers gets updated

Scenario: Last customer in queue
	Given the current user is the last
	When the "Next" button is pressed
	Then no access code will be displayed