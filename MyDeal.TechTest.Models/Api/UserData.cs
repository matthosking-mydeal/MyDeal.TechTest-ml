using System.Text.Json.Serialization;

namespace MyDeal.TechTest.Models.Api
{
    public class UserData
    {
        [JsonPropertyName("data")] public User Data { get; set; }
    }
}