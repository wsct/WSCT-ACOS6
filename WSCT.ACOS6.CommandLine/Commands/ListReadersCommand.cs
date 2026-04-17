using Spectre.Console.Cli;
using WSCT.ACOS6.CommandLine.Services;

namespace WSCT.ACOS6.CommandLine.Commands;

public class ListReadersCommand(IWSCTConsoleService wsct)
    : Command
{
    protected override int Execute(CommandContext context, CancellationToken cancellationToken)
    {
        var result = wsct.ListReaders();

        return result ? 0 : 1;
    }
}
