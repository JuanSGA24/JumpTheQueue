using System;
using TechTalk.SpecFlow;

namespace JumpTheQueue.BDD.Test.Steps.Epic2
{
    [Binding]
    public class LeaveTheQueueSteps
    {
        [Given(@"the customer has a ticket number in the queue ""(.*)""")]
        public void GivenTheCustomerHasATicketNumberInTheQueue(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the customer wants to leave and click in ""(.*)"" button")]
        public void WhenTheCustomerWantsToLeaveAndClickInButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"after the confirmation the customer will be redirected to a Customer out page")]
        public void ThenAfterTheConfirmationTheCustomerWillBeRedirectedToACustomerOutPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the queue jumps to the next customer ""(.*)""")]
        public void ThenTheQueueJumpsToTheNextCustomer(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the state of the accesCode changes to ""(.*)""")]
        public void ThenTheStateOfTheAccesCodeChangesTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
