#Epic 3: Manage the queue

Feature: StartQueue
	As an owner/employee, I want to start with the first number of the queue 
	So that I can attend the first customer.

@mytag
Scenario: The owner wants to start the service so starts the queue
	Given the owner provides the queue name "Queue1"
	When the owner creates the queue
	Then queue is created with the name "Queue1" and the first active ticket number is attended