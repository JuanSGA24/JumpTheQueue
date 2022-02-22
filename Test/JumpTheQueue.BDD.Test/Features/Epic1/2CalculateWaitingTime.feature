#Epic 1: Visualize code and notification

Feature: Calculate waiting time
	As a customer 
	I want to know how much time I need to wait until I will be attended 
	So that I can better manage my time

#Cuanto tiempo me queda para ser atendido
Scenario: Customers are waiting for their turn in the queue
	
	Given that the customers have a ticket number "Q005"
	And is the turn of the 2nd customer in the queue
	And the average attetion time is 2 minutes
	When the customer click a button of estimated waiting time
	Then the estimated waiting time is 6 minutes

#Cuanto tiempo me queda para ser atendido si el timepo minimo de espera es inferior a 1 minuto
Scenario: A minimum waiting_time has to be configured by the owner
	Given that the customers have a ticket number "Q005"
	And is the turn of the 2nd customer in the queue
	And the average attetion time is 0,5 minutes
	And there is a queue of customers and a minimum waiting time of 1 minute
	When the customer click a button of estimated waiting time
	Then the waiting time can not be shorted than 1 minute
	And the waiting time will be 1 minute