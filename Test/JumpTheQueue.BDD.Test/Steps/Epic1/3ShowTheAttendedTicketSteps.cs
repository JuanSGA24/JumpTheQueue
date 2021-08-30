using System;
using TechTalk.SpecFlow;

namespace JumpTheQueue.BDD.Test.Steps.Epic1
{
    [Binding]
    public class ShowTheAttendedTicketSteps
    {
        [Given(@"the customer has a ticket number assigned")]
        public void GivenTheCustomerHasATicketNumberAssigned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a queue of service")]
        public void GivenAQueueOfService()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the customer open the main page of ticket number")]
        public void WhenTheCustomerOpenTheMainPageOfTicketNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"there are two attended customers like Q(.*) and Q(.*)")]
        public void WhenThereAreTwoAttendedCustomersLikeQAndQ(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a user is being attended")]
        public void WhenAUserIsBeingAttended()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the customer must see below the number being attended like Now attending: ""(.*)""")]
        public void ThenTheCustomerMustSeeBelowTheNumberBeingAttendedLikeNowAttending(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"he has an accessCide with state ""(.*)""")]
        public void ThenHeHasAnAccessCideWithState(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"this state is result of having NULL End_date")]
        public void ThenThisStateIsResultOfHavingNULLEnd_Date()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"NOT NULL Start_date")]
        public void ThenNOTNULLStart_Date()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
