#Epic 4: Personalize the queue

Feature: EditQueueDetails
	As an owner
	I want to be able to edit the interface of the queue 
	So that I can adapt it to my needs


@mytag
Scenario: The queue should be modified by the owner
	Given the desire to modify "name", "logo", "description" of queue
	When the owner press the "Edit" button
	Then a page in modify mode is openened, so there the appearance of the page could be changed

@mytag
Scenario: The queue should be modified by the owner1
	Given the desire to modify fields
		| name | logo  | description |
		| hola | logo1 | descri1     |
	When the owner press the "Edit" button
	Then a page in modify mode is openened, so there the appearance of the page could be changed