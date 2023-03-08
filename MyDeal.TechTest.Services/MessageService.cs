using Microsoft.Extensions.Options;
using MyDeal.TechTest.Models.Options;

namespace MyDeal.TechTest.Services;

public class MessageService : IMessageService
{
    private readonly SettingsOptions _settings;

    public MessageService(IOptions<SettingsOptions> settingOptions)
    {
        _settings = settingOptions.Value;
    }

    public string GetMessageFromSettings()
    {
        return _settings.Message;
    }
}