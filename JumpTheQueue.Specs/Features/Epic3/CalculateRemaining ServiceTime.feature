#Epic 3: Manage the queue

Feature: CalculateRemaining ServiceTime
	As an owner/employee, I want to be able to see how much time is needed to serve all customers that are waiting in the queue 
	So that I can manage my queue efficiently

@mytag
Scenario: There is people in the queue 
	Given I want to manage my service 
	And my queue efficiently
	When the remainging service time is calculated by multiply the average of attention_time by total number of all customers that are waiting
	Then I know how much time I need to serve all the customers