using Dotnet.Homeworks.Shared.MessagingContracts.Email;
using MassTransit;

namespace Dotnet.Homeworks.MainProject.Services;

public class CommunicationService : ICommunicationService
{
    private readonly ILogger<CommunicationService> _logger;

    private readonly IBus _bus;

    public CommunicationService(ILogger<CommunicationService> logger, IBus bus)
    {
        _logger = logger;
        _bus = bus;
    }

    public async Task SendEmailAsync(SendEmail sendEmailDto, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Sending SendEmailRequest for user with email {0} to the queue",
            sendEmailDto.ReceiverEmail);
        await _bus.Publish(sendEmailDto, cancellationToken: cancellationToken);
        _logger.LogInformation("SendEmailRequest for user with email {0} sent to queue", sendEmailDto.ReceiverEmail);
    }
}