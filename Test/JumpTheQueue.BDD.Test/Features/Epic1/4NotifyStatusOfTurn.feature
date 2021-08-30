#Epic 1: Visualize code and notification

Feature: Notify status of user turn
	As customer 
	I want to be informed when it is the turn of the person who goes before me 
	So that I don’t lose my turn

@mytag
Scenario: Customer leaves the queue
	Given the current user is being attended 
	And has a ticket with a one number less than mine
	When I will be the next to be attended
	And choose the option "Leave"
	Then my number is discarted
	And I leave the queue

Scenario: Customer delay the ticket number
	Given the current user is being attended 
	And has a ticket with a one number less than mine
	When I will be the next to be attended
	And choose the option "Delay"
	Then my number will be delayed