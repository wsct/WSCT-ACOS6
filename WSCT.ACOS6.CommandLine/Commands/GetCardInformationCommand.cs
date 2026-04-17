using Spectre.Console.Cli;
using WSCT.ACOS6.CommandLine.Services;

namespace WSCT.ACOS6.CommandLine.Commands
{
    internal class GetCardInformationCommand(IACOS6ConsoleService acos6Console)
    : Command
    {
        protected override int Execute(CommandContext context, CancellationToken cancellationToken)
        {
            var result = acos6Console.GetCardInformation();

            return result ? 0 : 1;
        }
    }
}
