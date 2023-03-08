using MyDeal.TechTest.Models.Api;

namespace MyDeal.TechTest.DataAccess.Clients;

public interface IUserDetailsClient
{
    Task<UserData> GetUserData(int userId);
}