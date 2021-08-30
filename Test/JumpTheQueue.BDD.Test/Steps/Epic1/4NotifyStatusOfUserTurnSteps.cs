using System;
using TechTalk.SpecFlow;

namespace JumpTheQueue.BDD.Test.Steps.Epic1
{
    [Binding]
    public class NotifyStatusOfUserTurnSteps
    {
        [Given(@"the current user is being attended")]
        public void GivenTheCurrentUserIsBeingAttended()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"has a ticket with a one number less than mine")]
        public void GivenHasATicketWithAOneNumberLessThanMine()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I will be the next to be attended")]
        public void WhenIWillBeTheNextToBeAttended()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"choose the option ""(.*)""")]
        public void WhenChooseTheOption(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my number is discarted")]
        public void ThenMyNumberIsDiscarted()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I leave the queue")]
        public void ThenILeaveTheQueue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my number will be delayed")]
        public void ThenMyNumberWillBeDelayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
