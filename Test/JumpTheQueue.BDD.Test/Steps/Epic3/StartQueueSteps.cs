using System;
using TechTalk.SpecFlow;

namespace JumpTheQueue.BDD.Test.Steps.Epic3
{
    [Binding]
    public class StartQueueSteps
    {
        [Given(@"the owner provides the queue name ""(.*)""")]
        public void GivenTheOwnerProvidesTheQueueName(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the owner creates the queue")]
        public void WhenTheOwnerCreatesTheQueue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"queue is created with the name ""(.*)"" and the first active ticket number is attended")]
        public void ThenQueueIsCreatedWithTheNameAndTheFirstActiveTicketNumberIsAttended(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
