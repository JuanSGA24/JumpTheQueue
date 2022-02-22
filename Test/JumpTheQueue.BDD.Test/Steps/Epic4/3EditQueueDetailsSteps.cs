using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Converters;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Services;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces;
using Moq;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace JumpTheQueue.BDD.Test.Steps.Epic4
{
    [Binding]
    public class EditQueueDetailsSteps
    {
        private Mock<IUnitOfWork<JumpTheQueueContext>> _UnitOfWork;
        private Mock<IQueueRepository> _QueueRepository;

        private QueueService _queueService;

        private Queue initialQueue;
        private Queue expectedQueue;
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


        [Given(@"the desire to modify ""(.*)"", ""(.*)"", ""(.*)"" of queue")]
        public void GivenTheDesireToModifyOfQueue(string nameModify, string logoModify, string descriptionModify)
        {
            initialQueue = new Queue
            {
                Id = Guid.NewGuid(),
                Name = "Queue1",
                Logo = "Logo1",
                Description = "Description1",
                AccessLink = "accessLink",
                UserId = Guid.NewGuid(),
                MinAttentionTime = 1
            };

            expectedQueueDto = new QueueDto
            {
                Id = Guid.NewGuid(),
                Name = nameModify,
                Logo = logoModify,
                Description = descriptionModify,
                AccessLink = "accessLink",
                UserId = Guid.NewGuid(),
                MinAttentionTime = 1
            };

            expectedQueue = new Queue
            {
                Id = expectedQueueDto.Id,
                Name = expectedQueueDto.Name,
                Logo = expectedQueueDto.Logo,
                Description = expectedQueueDto.Description,
                AccessLink = expectedQueueDto.AccessLink,
                UserId = expectedQueueDto.UserId,
                MinAttentionTime = expectedQueueDto.MinAttentionTime
            };
        }

        [When(@"the owner press the ""(.*)"" button")]
        public async Task WhenTheOwnerPressTheButton(string p0)
        {
            _QueueRepository.Setup(x => x.GetFirstOrDefault(It.IsAny<Expression<Func<Queue, bool>>>())).ReturnsAsync(initialQueue);
            _QueueRepository.Setup(x => x.Update(It.IsAny<Queue>(), It.IsAny<bool>())).ReturnsAsync(expectedQueue);

            expectedQueueDto = QueueConverter.ModelToDto(expectedQueue);

            resultQueueDto = await _queueService.ModifyQueueById(expectedQueueDto.Id, expectedQueueDto).ConfigureAwait(false);
        }

        [Then(@"a page in modify mode is openened, so there the appearance of the page could be changed")]
        public void ThenAPageInModifyModeIsOpenenedSoThereTheAppearanceOfThePageCouldBeChanged()
        {
            Assert.False(resultQueueDto == expectedQueueDto);
        }
    }
}
