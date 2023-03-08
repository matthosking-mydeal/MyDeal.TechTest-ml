using MyDeal.TechTest.Models.Api;
using System.Text.Json.Serialization;

namespace MyDeal.TechTest.Models.ViewModels
{
    public class SettingsVm
    {
        [JsonPropertyName("message")] public string Message { get; set; }
        [JsonPropertyName("user")] public User User { get; set; }
    }
}