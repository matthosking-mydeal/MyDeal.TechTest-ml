using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using Moq;
using MyDeal.TechTest.DataAccess.Clients;
using MyDeal.TechTest.Models.Api;
using MyDeal.TechTest.Models.ViewModels;
using Xunit;

namespace MyDeal.TechTest.Services.Tests
{
    public class SettingsServiceTests
    {
        private readonly IFixture _fixture;
        private readonly Mock<IMessageService> _messageServiceMock;
        private readonly Mock<IUserDetailsClient> _userDetailsClientMock;

        public SettingsServiceTests()
        {
            _messageServiceMock = new Mock<IMessageService>();
            _userDetailsClientMock = new Mock<IUserDetailsClient>();
            _fixture = new Fixture();
            _fixture.Inject(_messageServiceMock.Object);
            _fixture.Inject(_userDetailsClientMock.Object);
        }

        [Fact]
        public async Task ShouldReturnSuccessfulResponse()
        {
            //Arrange
            var userId = 2;
            var message = "newMessage";
            _messageServiceMock.Setup(x => x.GetMessageFromSettings()).Returns(message);
            _userDetailsClientMock.Setup(x => x.GetUserData(It.IsAny<int>())).ReturnsAsync(new UserData
            {
                Data = new User
                {
                    Id = userId
                }
            });

            var settingsService = _fixture.Create<SettingsService>();
            //Act
            var response = await settingsService.GetUserDetails(userId);
            //Assert
            response.Should().BeOfType(typeof(SettingsVm));
            response.Message.Should().Be(message);
            response.User.Id.Should().Be(userId);
        }
    }
}