using System.Threading.Tasks;
using MyDeal.TechTest.Models.ViewModels;

namespace MyDeal.TechTest.Services;

public interface ISettingsService
{
    Task<SettingsVm> GetUserDetails(int userId);
}