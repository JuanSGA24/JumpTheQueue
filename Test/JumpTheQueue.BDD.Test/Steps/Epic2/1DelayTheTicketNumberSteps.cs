using System;
using TechTalk.SpecFlow;

namespace JumpTheQueue.BDD.Test.Steps.Epic2
{
    [Binding]
    public class DelayTheTicketNumberSteps
    {
        [Given(@"the customer has a ticket number assigned")]
        public void GivenTheCustomerHasATicketNumberAssigned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the customer clicks in ""(.*)"" button")]
        public void WhenTheCustomerClicksInButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"this customer will go to the last place of the queue")]
        public void ThenThisCustomerWillGoToTheLastPlaceOfTheQueue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"message with new estimated waiting time in the queue")]
        public void ThenMessageWithNewEstimatedWaitingTimeInTheQueue()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
