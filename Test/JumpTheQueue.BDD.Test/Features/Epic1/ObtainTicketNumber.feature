#Epic 1: Visualize code and notification

Feature: Obtain a ticket number
	As a Customer I want to join the queue
	So that I can will be attended and get my service

@mytag
Scenario: Customer wants to join a queue	
	Given the customer reads the QR code of the queue
	When the URL page is opened
	Then the customer should see the ticket number in the queue

	
Scenario: Format of the ticket
	Given a customer in a queue
	When the customer open the main page
	Then the customer will see a ticket with a format like this: QXXX (e.g: Q047)
	And if the ticket number Q999 is reached, the numbering restarts at Q000


Scenario: Removed ticket from system
	Given a ticket number in the system
	When this ticket is removed 
	Then this ticket cannot be re-assigned


Scenario: Customer cannot get a ticket
	Given the customer reads the QR code
	When the ticket cannot be assigned to the customer
	Then the customer will see a feedback popup


Scenario: Customer wants to join to the same queue
	Given the customer has a previous ticket for the queue
	When the customer wants to join the same queue
	Then the app will throw an error