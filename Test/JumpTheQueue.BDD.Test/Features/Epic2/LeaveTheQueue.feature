#Epic 2: Delay and Leave queue

Feature: Leave the queue
	As a customer I want to be able to leave the queue as I don’t need it anymore, 
	So the owner will attend only the people with active tickets in the queue.

@mytag
Scenario: A customer who wants to leave the queue
	Given the customer has a ticket number in the queue
	When the customer wants to leave and click in "Leave" red button
	Then after the confirmation the customer will be redirected to a Customer out page
	And the queue jumps to the next customer