#Epic 1: Visualize code and notification

Feature: Obtain a ticket number
	As a Customer 
	I want to join the queue
	So that I can will be attended and get my service

@mytag
Scenario: Customer wants to join a queue	
	Given the customer reads the QR code of the queue
	When the URL page is opened
	Then the customer should see the ticket number in the queue like Q001

	
Scenario: Customer in the queue with a wrong ticket format
	Given a customer in a queue
	When the customer open the main page
	Then the customer will see a ticket with a format like "Q0020" what is a bad format
	And this ticket number does not work 


Scenario: Last customer in the queue
	Given a last customer in the queue with number "Q999"
	Then a new customer wants to join the queue
	Then the number assigned to this new customer is "Q001"

Scenario: A ticket is removed from system
	Given a ticket number in the system 
	When this ticket is removed 
	Then this ticket cannot be re-assigned to other customer in the queue


Scenario: Customer cannot get a ticket
	Given the customer reads the QR code
	When the ticket cannot be assigned to the customer
	Then the customer will see a help message "Can not get a ticket number?"


Scenario: Customer wants to join to the same queue
	Given the customer has a previous ticket for the queue 1
	When the customer wants to join the queue 1
	Then the app will throw an error message "You cant join the same queue more than once"