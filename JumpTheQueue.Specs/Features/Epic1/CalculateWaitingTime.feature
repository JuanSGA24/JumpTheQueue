#Epic 1: Visualize code and notification

Feature: Calculate waiting time
	As a customer I want to know how much time I need to wait until I will be attended 
	So that I can better manage my time

@mytag
Scenario: Customers are waiting for their turn in the queue
	Given that the customers have a ticket
	And they want to know how long they will have to wait
	When the customer click a button of estimated waiting time
	Then the customer knows how much time he has left to be attended