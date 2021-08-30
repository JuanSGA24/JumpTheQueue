#Epic 1: Visualize code and notification

Feature: Show the attended ticket
	As a customer or owner/employee, 
	I want to see the current customer who is being attended
	So I can know how many visitors are before me

@mytag
Scenario: Customer wants to know which ticket is being attended
	Given the customer has a ticket number assigned
	When the customer open the main page of ticket number
	Then the customer must see below the number being attended like Now attending: "Q001"

Scenario: More than one attended customer in the same queue
	Given a queue of service
	When there are two attended customers like Q001 and Q002
	Then the app will throw an error message "It can not be more than 1 attended customer in the same queue"

Scenario: How to know who is the current customer being attended
	Given a queue of service
	When a user is being attended
	Then he has an accessCide with state "attending"
	And this state is result of having NULL End_date
	And NOT NULL Start_date