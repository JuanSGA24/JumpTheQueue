using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using JumpTheQueue.WebAPI.Implementation.Const;
using System;
using TechTalk.SpecFlow;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Services;
using Moq;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;

namespace JumpTheQueue.BDD.Test.Steps.Epic1
{
    [Binding]
    public class CalculateWaitingTimeSteps
    {
        private Visitor _visitor;
        private Queue _queue;
        private AccessCode _accessCode;
        private User _user;

        public QueueService _queueService;
        
        public Mock<IUnitOfWork<JumpTheQueueContext>> _unitOfWork;

        [BeforeScenario]
        public void SetUpTest()
        {
            _queueService = new QueueService(_unitOfWork);
        }


        [Given(@"that the customers have a ticket number ""(.*)""")]
        public void GivenThatTheCustomersHaveATicketNumber(string accessCode)
        {
            _visitor = new Visitor
            {
                Id = Guid.NewGuid()
            };

            _queue = new Queue
            {
                
            };
            _accessCode = new AccessCode
            {
                Id = Guid.NewGuid(),
                Code = accessCode,
                Status = QueueStatus.Waiting.ToString()
            };
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
