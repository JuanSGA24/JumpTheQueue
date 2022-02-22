using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Services;
using JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Services;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces;
using Moq;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace JumpTheQueue.BDD.Test.Steps.Epic4
{
    [Binding]
    public class LoginToTheQueueSteps
    {
        private Mock<IUnitOfWork<JumpTheQueueContext>> _unitOfWork;
        private Mock<IUserRepository> _userRepository;

        private UserService _userService;

        private UserDto _userDto;

        private bool _result;

        [BeforeScenario]
        public void SetUpTest()
        {
            _unitOfWork = new Mock<IUnitOfWork<JumpTheQueueContext>>();
            _userRepository = new Mock<IUserRepository>();

            _unitOfWork.Setup(x => x.Repository<IUserRepository>()).Returns(_userRepository.Object);

            _userService = new UserService(_unitOfWork.Object);
        }

        [Given(@"the user provide a username ""([^""]*)""")]
        public void GivenTheUserProvideAUsername(string achito)
        {
            _userDto = new UserDto
            {
                Id = Guid.NewGuid(),
                Username = achito
            };
        }

        [Given(@"the password ""([^""]*)""")]
        public void GivenThePassword(string password)
        {
            _userDto.Password = password;
        }

        [When(@"the user clicks the button ""([^""]*)""")]
        public async Task WhenTheUserClicksTheButton(string loginButton)
        {
            _userRepository.Setup(x => x.GetUserById(_userDto.Id)).ReturnsAsync(new User { Id = _userDto.Id, Username = _userDto.Username, Password = "pass123" });
            _result = await _userService.CheckUserCredentials(_userDto).ConfigureAwait(false);
        }

        

        [Then(@"the provided credentials are ""([^""]*)""")]
        public void ThenTheProvidedCredentialsAreWrong(bool aaa)
        {
            Assert.Equal(aaa, _result);
        }
    }
}
