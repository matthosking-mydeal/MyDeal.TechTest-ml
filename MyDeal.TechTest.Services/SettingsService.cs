using System.Threading.Tasks;
using MyDeal.TechTest.DataAccess.Clients;
using MyDeal.TechTest.Models.ViewModels;

namespace MyDeal.TechTest.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly IMessageService _messageService;
        private readonly IUserDetailsClient _userDetailsClient;

        public SettingsService(IMessageService messageService, IUserDetailsClient userDetailsClient)
        {
            _messageService = messageService;
            _userDetailsClient = userDetailsClient;
        }

        public async Task<SettingsVm> GetUserDetails(int userId)
        {
            var userDetails = await _userDetailsClient.GetUserData(userId);
            var message = _messageService.GetMessageFromSettings();

            return new SettingsVm
            {
                Message = message,
                User = userDetails.Data,
            };
        }
    }
}