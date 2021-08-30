#Epic 2: Delay and Leave queue

Feature: Delay the ticket number
	As a customer, I want to be able to delay my number in the queue 
	So that I have more time to do what I need to do before being attended.

@mytag
Scenario: A customer who wants to be attended at another time
	Given the customer has a ticket number assigned 
	When the customer clicks in "Delay" button
	Then this customer will go to the last place of the queue
	And message with new estimated waiting time in the queue
