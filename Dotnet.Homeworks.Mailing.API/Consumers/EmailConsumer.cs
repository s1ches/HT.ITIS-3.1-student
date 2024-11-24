using Dotnet.Homeworks.Mailing.API.Dto;
using Dotnet.Homeworks.Mailing.API.Services;
using Dotnet.Homeworks.Shared.MessagingContracts.Email;
using MassTransit;

namespace Dotnet.Homeworks.Mailing.API.Consumers;

public class EmailConsumer : IEmailConsumer
{
    private readonly IMailingService _mailingService;

    private readonly ILogger<EmailConsumer> _logger;

    public EmailConsumer(IMailingService mailingService, ILogger<EmailConsumer> logger)
    {
        _mailingService = mailingService;
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<SendEmail> context)
    {
        var message = new EmailMessage(context.Message.ReceiverEmail, context.Message.Subject, context.Message.Content);

        _logger.LogInformation("Sending email for user with name {0} and email {1}", context.Message.ReceiverName,
            context.Message.ReceiverEmail);

        var result = await _mailingService.SendEmailAsync(message, context.CancellationToken);

        if (result.IsFailure)
            _logger.LogError("Failed to send email for user with name {0} and email {1}, Error: {3}",
                context.Message.ReceiverName, context.Message.ReceiverEmail, result.Error);
        else
            _logger.LogInformation("Success send email for user with name {0} and email {1}",
                context.Message.ReceiverName,
                context.Message.ReceiverEmail);
    }
}