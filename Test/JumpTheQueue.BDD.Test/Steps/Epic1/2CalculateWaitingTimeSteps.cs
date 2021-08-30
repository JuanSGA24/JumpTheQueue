using System;
using TechTalk.SpecFlow;

namespace JumpTheQueue.BDD.Test.Steps.Epic1
{
    [Binding]
    public class CalculateWaitingTimeSteps
    {
        [Given(@"that the customers have a ticket number ""(.*)""")]
        public void GivenThatTheCustomersHaveATicketNumber(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"is the turn of the (.*)nd customer in the queue")]
        public void GivenIsTheTurnOfTheNdCustomerInTheQueue(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the average attetion time is (.*) minutes")]
        public void GivenTheAverageAttetionTimeIsMinutes(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"they want to know how long they will have to wait")]
        public void GivenTheyWantToKnowHowLongTheyWillHaveToWait()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"there is a queue of customers and a minimum waiting time of (.*) minute")]
        public void GivenThereIsAQueueOfCustomersAndAMinimumWaitingTimeOfMinute(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the customer click a button of estimated waiting time")]
        public void WhenTheCustomerClickAButtonOfEstimatedWaitingTime()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the waiting time appears on the screen")]
        public void WhenTheWaitingTimeAppearsOnTheScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the estimated waiting time is (.*) minutes")]
        public void ThenTheEstimatedWaitingTimeIsMinutes(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the waiting time can not be shorted than (.*) minute")]
        public void ThenTheWaitingTimeCanNotBeShortedThanMinute(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"if it is shorter the waiting time will be (.*) minute")]
        public void ThenIfItIsShorterTheWaitingTimeWillBeMinute(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
