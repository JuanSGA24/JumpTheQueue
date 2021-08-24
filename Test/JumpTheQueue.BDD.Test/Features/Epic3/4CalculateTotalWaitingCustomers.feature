#Epic 3: Manage the queue

Feature: CalculateTotalWaitingCustomers
	As an owner/employee, I want to be able to see the total number of customers waiting, 
	So that I can manage my queue efficiently

@mytag
Scenario: There are some people in the queue
	Given I want to mange my queue
	When the total number of people is calculated
	Then the number of people waiting is showed in the management queue page