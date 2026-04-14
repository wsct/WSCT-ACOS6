using Spectre.Console.Cli;
using WSCT.ACOS6.CommandLine.Services;

namespace WSCT.ACOS6.CommandLine.Commands;

internal class ClearCardCommand(IACOS6ConsoleService acos6Console)
    : Command
{
    protected override int Execute(CommandContext context, CancellationToken cancellationToken)
    {
        var result = acos6Console.ClearCard();

        return result ? 0 : 1;
    }
}
