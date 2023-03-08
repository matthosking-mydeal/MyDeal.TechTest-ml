using MyDeal.TechTest.Models.Api;
using System.Net.Http.Json;

namespace MyDeal.TechTest.DataAccess.Clients
{
    public class UserDetailsClient : IUserDetailsClient
    {
        private readonly HttpClient _httpClient;

        public UserDetailsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserData> GetUserData(int userId)
        {
            var result = await _httpClient.GetAsync(
                $"{userId}");

            if (result.IsSuccessStatusCode)
            {
                return await result.Content.ReadFromJsonAsync<UserData>() ??
                       throw new NullReferenceException(
                           $"There was a problem with the response when getting userdata {userId}");
            }

            //Need to properly handle the responses. either through a results pattern or custom exceptions with error handling middleware
            throw new Exception($"There was a problem with the response when getting userdata {userId}");
        }
    }
}