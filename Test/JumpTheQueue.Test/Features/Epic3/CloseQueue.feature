#Epic 3: Manage the queue

Feature: CloseQueue
	As an owner/employee, I want to be able to stop the queue at any moment 
	So that news customers can not join the queue.
@mytag
Scenario: The owner wants to stop the queue
	Given there is a queue
	When the owner press the "Stop" button
	And he confirms the action in the confirmation window
	Then the system stops generate new ticket numbers
	And redirects to the people who wants to join the queue to a customer out page


Scenario: Customer wants to join a closed queue
	Given there is a closed queue
	When a customer wants to join the closed queue
	Then the system will show an info pop-up advising the customer the queue is closed