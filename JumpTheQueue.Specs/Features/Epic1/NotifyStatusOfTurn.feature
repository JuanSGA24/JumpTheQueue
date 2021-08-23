#Epic 1: Visualize code and notification

Feature: Notify status of user turn
	As customer I want to be informed when it is the turn of the person who goes before me 
	So that I don’t lose my turn

@mytag
Scenario: Notify status of my turn in the queue
	Given the current user is in the queue 
	And has a ticket with a one number less than mine
	When I will be the next to be attended
	Then a pop-up will show giving me two options, leave the queue or delay the number.