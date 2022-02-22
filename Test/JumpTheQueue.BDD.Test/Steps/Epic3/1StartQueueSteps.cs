using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Services;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces;
using Moq;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace JumpTheQueue.BDD.Test.Steps.Epic3
{
    [Binding]
    public class StartQueueSteps
    {/*
        private Mock<IUnitOfWork<JumpTheQueueContext>> _UnitOfWork;
        private Mock<IQueueRepository> _QueueRepository;

        private QueueService _queueService;

        private QueueDto expectedQueueDto;
        private QueueDto resultQueueDto;

        [BeforeScenario]
        public void SetUpTest()
        {
            _UnitOfWork = new Mock<IUnitOfWork<JumpTheQueueContext>>();
            _QueueRepository = new Mock<IQueueRepository>();

            _UnitOfWork.Setup(x => x.Repository<IQueueRepository>()).Returns(_QueueRepository.Object);

            _queueService = new QueueService(_UnitOfWork.Object);

        }

        [Given(@"the owner provides the queue details as name ""(.*)"", logo ""(.*)"", description ""(.*)"", access link ""(.*)"", minimun attention time (.*) minute")]
        public void GivenTheOwnerProvidesTheQueueDetailsAsNameLogoDescriptionAccesLinkMinimunAttentionTimeMinute(string queueName, string queueLogo, string queueDescription, string queueAccessLink, int queueMinAttentionTime)
        {
            expectedQueueDto = new QueueDto
            {
                Id = Guid.NewGuid(),
                Name = queueName,
                Logo = queueLogo,
                Description = queueDescription,
                AccessLink = queueAccessLink,
                UserId = Guid.NewGuid(),
                MinAttentionTime = queueMinAttentionTime
            };
        }

        [When(@"the owner creates this queue")]
        public async Task WhenTheOwnerCreatesThisQueue()
        {
            _QueueRepository.Setup(x => x.Create(It.IsAny<Guid>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>(), It.IsAny<bool?>(), It.IsAny<bool?>(), It.IsAny<Guid?>())
            ).ReturnsAsync(new Queue { Id = expectedQueueDto.Id, Name = expectedQueueDto.Name, Logo = expectedQueueDto.Logo, Description = expectedQueueDto.Description, AccessLink = expectedQueueDto.AccessLink, MinAttentionTime = expectedQueueDto.MinAttentionTime, UserId = expectedQueueDto.UserId });

            resultQueueDto = await _queueService.CreateQueue(expectedQueueDto).ConfigureAwait(false);

        }

        [Then(@"queue is created with the name name ""(.*)")]
        public void ThenQueueIsCreatedWithTheNameNameLogoDescriptionAccessLinkMinimunAttentionTimeMinute(string queueName)
        {
            Assert.Equal(expectedQueueDto.Name, resultQueueDto.Name);
        }
        */

    }
}
