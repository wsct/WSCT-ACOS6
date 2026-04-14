using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Spectre.Console.Cli;
using WSCT.ACOS6.CommandLine.Commands;
using WSCT.ACOS6.CommandLine.Services;

ServiceCollection services = new();

// Services
services.AddSingleton<IWSCTService, WSCTService>();
services.AddSingleton<IWSCTConsoleService, WSCTConsoleService>();

services.AddSingleton<IACOS6Service, ACOS6Service>();
services.AddSingleton<IACOS6ConsoleService, ACOS6ConsoleService>();


// Logging
services.AddLogging(configure => configure.AddSimpleConsole(options =>
{
    options.TimestampFormat = "yyyy-MM-dd HH:mm:ss ";
    options.SingleLine = true;
    options.IncludeScopes = true;
}));

var registrar = new TypeRegistrar(services);

var app = new CommandApp(registrar);
app.Configure(config =>
{
    config.AddCommand<ListReadersCommand>("list-readers")
        .WithDescription("Lists available readers");

    config.AddBranch("get", cardConfig =>
    {
        cardConfig.AddCommand<GetSerialNumberCommand>("serial-number")
            .WithDescription("Gets the serial number of the card");
        cardConfig.AddCommand<GetCardInformationCommand>("card-info")
            .WithDescription("Gets information about the card");
    });

    config.AddCommand<ClearCardCommand>("clear-card")
        .WithDescription("Clear the card (back to Pre-Perso State)");
});

return app.Run(args);
