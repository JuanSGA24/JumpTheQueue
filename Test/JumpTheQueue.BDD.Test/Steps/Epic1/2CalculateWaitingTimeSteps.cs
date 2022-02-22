using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Services;
using JumpTheQueue.WebAPI.Implementation.Const;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using Moq;
using System;
using TechTalk.SpecFlow;

namespace JumpTheQueue.BDD.Test.Steps.Epic1
{
    [Binding]
    public class CalculateWaitingTimeSteps
    {
        private Mock<IUnitOfWork<JumpTheQueueContext>> _UnitOfWork;

        private AccessCodeDto _expectedAccessCodeDto;

        private int _waitingTime;
        private int _averageAttentionTime;
        private int _noAttendedCustomers;

        private QueueService _queueService;

        [BeforeScenario]
        public void SetUpTest()
        {
            _UnitOfWork = new Mock<IUnitOfWork<JumpTheQueueContext>>();
            _queueService = new QueueService(_UnitOfWork.Object);
        }


        [Given(@"that the customers have a ticket number ""(.*)""")]
        public void GivenThatTheCustomersHaveATicketNumber(string accessCodeNumber)
        {
            _expectedAccessCodeDto = new AccessCodeDto
            {
                Id = Guid.NewGuid(),
                Code = accessCodeNumber,
                Status = nameof(QueueStatus.Waiting),
                QueueId = Guid.NewGuid(),
                VisitorId = Guid.NewGuid(),
                CreatedTime = DateTime.UtcNow
            };
        }
        
        [Given(@"is the turn of the (.*)nd customer in the queue")]
        public void GivenIsTheTurnOfTheNdCustomerInTheQueue(int positionInQueue)
        {
            _noAttendedCustomers = positionInQueue - 1;
        }
        
        [Given(@"the average attetion time is (.*) minutes")]
        public void GivenTheAverageAttetionTimeIsMinutes(int averageAttentionTime)
        {
            _waitingTime = _queueService.CalculateWaitingTime(averageAttentionTime, _noAttendedCustomers);
        }
        
        [Given(@"the average attetion time is (.*) minutes")]
        public void GivenTheAverageAttetionTimeIsMinutes(Decimal averageAttentionTime)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"there is a queue of customers and a minimum waiting time of (.*) minute")]
        public void GivenThereIsAQueueOfCustomersAndAMinimumWaitingTimeOfMinute(int minimunWaitingTime)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the customer click a button of estimated waiting time")]
        public void WhenTheCustomerClickAButtonOfEstimatedWaitingTime()
        {
            
        }
        
        [Then(@"the estimated waiting time is (.*) minutes")]
        public void ThenTheEstimatedWaitingTimeIsMinutes(int estimatedWaitingTime)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the waiting time can not be shorted than (.*) minute")]
        public void ThenTheWaitingTimeCanNotBeShortedThanMinute(int minimunWaitingTime)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the waiting time will be (.*) minute")]
        public void ThenTheWaitingTimeWillBeMinute(int minimunWaitingTime)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
