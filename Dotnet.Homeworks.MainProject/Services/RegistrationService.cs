using Dotnet.Homeworks.MainProject.Dto;
using Dotnet.Homeworks.Shared.MessagingContracts.Email;

namespace Dotnet.Homeworks.MainProject.Services;

public class RegistrationService : IRegistrationService
{
    private readonly ICommunicationService _communicationService;

    private readonly ILogger<RegistrationService> _logger;

    public RegistrationService(ICommunicationService communicationService, ILogger<RegistrationService> logger)
    {
        _communicationService = communicationService;
        _logger = logger;
    }

    public async Task RegisterAsync(RegisterUserDto userDto, CancellationToken cancellationToken = default)
    {
        // pretending we have some complex logic here
        await Task.Delay(100, cancellationToken);
        _logger.LogInformation("Registering user with email {0}, with some magic logic", userDto.Email);

        // publish message to a queue
        await _communicationService.SendEmailAsync(
            new SendEmail(userDto.Name, userDto.Email, "Registration", "You're welcome!"),
            cancellationToken);
    }
}