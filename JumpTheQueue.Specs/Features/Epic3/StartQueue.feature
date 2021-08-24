#Epic 3: Manage the queue

Feature: StartQueue
	As an owner/employee, I want to start with the first number of the queue 
	So that I can attend the first customer.

@mytag
Scenario: The owner wants to start the service so starts the queue
	Given the owner wants to start the queue
	When the owner press the "Start" button
	Then queue begins and the first active ticket number is attended