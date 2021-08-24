#Epic 1: Visualize code and notification

Feature: Show the attended ticket
	As a customer or owner/employee, I want to see the current customer who is being attended
	So I can know how many visitors are before me

@mytag
Scenario: Customer wants to know which ticket is being attended
	Given the customer has a ticket number assigned
	When the customer open the main page of ticket number
	Then the customer must see the number being attended


Scenario: Format of the ticket
	Given a customer in a queue
	When the customer open the main page
	Then the customer will see a ticket with a format like this: QXXX (e.g: Q047)