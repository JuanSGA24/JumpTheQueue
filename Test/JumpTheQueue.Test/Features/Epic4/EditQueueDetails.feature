#Epic 4: Personalize the queue

Feature: EditQueueDetails
	As an owner, I want to be able to edit the interface of the queue 
	So that I can adapt it to my needs


@mytag
Scenario: The queue should be modified by the owner
	Given the desire to modify some details of queue
	When the owner press the "Edit" button
	Then a page in modify mode is openened, so there the appearance of the page could be changed