#Epic 3: Manage the queue

Feature: StartQueue
	As an owner/employee, I want to start with the first number of the queue 
	So that I can attend the first customer.

Scenario: The owner wants to start the service so starts the queue
	Given the owner provides the queue details as name "Queue 1", logo "Logo 1", description "Description 1", access link "AccessLink 1", minimun attention time 1 minute
	When the owner creates this queue
	Then queue is created with the name name "Queue 1"