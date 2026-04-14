using Spectre.Console;
using WSCT.Wrapper;

namespace WSCT.ACOS6.CommandLine.Services;

internal class WSCTConsoleService(IWSCTService wsct) : IWSCTConsoleService
{
    /// <inheritdoc />
    public bool CloseAndRelease()
    {
        wsct.Disconnect();
        var errorCode = wsct.Release();

        return errorCode == ErrorCode.Success;
    }

    /// <inheritdoc />
    public bool Connect(string readerName)
    {
        AnsiConsole.MarkupLine("[yellow]Connecting to card...[/]");

        var connectResult = wsct.Connect(readerName);
        if (connectResult != ErrorCode.Success)
        {
            AnsiConsole.MarkupLine($"[red]Connect failed: {connectResult}[/]");
            return false;
        }
        return true;
    }

    /// <inheritdoc />
    public string InitializeAndSelectReader()
    {
        var establishResult = wsct.Establish();

        if (establishResult != ErrorCode.Success)
        {
            AnsiConsole.MarkupLine($"[red]Establish failed: {establishResult}[/]");
            return "";
        }

        var readers = wsct.GetReaders();

        if (readers.Length == 0)
        {
            AnsiConsole.MarkupLine("[red]No readers found[/]");
            return "";
        }

        var readerName = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[yellow]Select the reader to use[/]")
                .AddChoices(readers));

        return readerName ?? "";
    }

    /// <inheritdoc />
    public bool ListReaders()
    {
        try
        {
            var establishResult = wsct.Establish();

            if (establishResult != ErrorCode.Success)
            {
                AnsiConsole.MarkupLine($"[red]Establish failed: {establishResult}[/]");
                return false;
            }

            var readers = wsct.GetReaders();

            if (readers.Length == 0)
            {
                AnsiConsole.MarkupLine("[red]No readers found[/]");
                return false;
            }

            var table = new Table()
                .RoundedBorder()
                .AddColumn("Id")
                .AddColumn("Reader");

            var id = 1;
            foreach (var reader in readers)
            {
                table.AddRow($"{id}", reader);
                id++;
            }

            AnsiConsole.Write(table);

            wsct.Release();

            return true;
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLineInterpolated($"[red]Exception: {e.Message}[/]");
            return false;
        }
        finally
        {
            wsct.Release();
        }
    }
}
