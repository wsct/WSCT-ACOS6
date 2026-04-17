using Spectre.Console;
using WSCT.Helpers;

namespace WSCT.ACOS6.CommandLine.Services;

internal class ACOS6ConsoleService(IWSCTConsoleService wsctConsole, IACOS6Service acos6) : IACOS6ConsoleService
{
    public bool ClearCard()
    {
        try
        {
            var readerName = wsctConsole.InitializeAndSelectReader();

            if (string.IsNullOrEmpty(readerName))
            {
                return false;
            }

            AnsiConsole.MarkupLine($"Now working with [blue]{readerName}[/]");

            if (!wsctConsole.Connect(readerName))
            {
                return false;
            }

            var result = acos6.ClearCard();

            if (result)
            {
                AnsiConsole.MarkupLine("[green]Card cleared successfully![/]");
            }
            else
            {
                AnsiConsole.MarkupLine("[red]Failed to clear the card.[/]");
            }
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLineInterpolated($"[red]Exception: {e.Message}[/]");
            return false;
        }
        finally
        {
            wsctConsole.CloseAndRelease();
        }
        return true;
    }

    public bool GetCardInformation()
    {
        try
        {
            var readerName = wsctConsole.InitializeAndSelectReader();

            if (string.IsNullOrEmpty(readerName))
            {
                return false;
            }

            AnsiConsole.MarkupLine($"Now working with [blue]{readerName}[/]");

            if (!wsctConsole.Connect(readerName))
            {
                return false;
            }

            var serialNumber = acos6.GetSerialNumber();
            var cardVersion = acos6.GetCardVersion();
            var cardIdNumber = acos6.GetCardIdNumber();
            var cardEepromSize = acos6.GetEepromSize();

            var table = new Table()
                .RoundedBorder()
                .AddColumn("Id")
                .AddColumn("S/N")
                .AddColumn("Version")
                .AddColumn("ID Number")
                .AddColumn("EEPROM");

            table.AddRow(@"1",
                $"{serialNumber.ToHexa()}",
                $"{cardVersion.ToHexa()}",
                $"{cardIdNumber.ToHexa()}",
                $"{cardEepromSize}K");

            AnsiConsole.Write(table);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLineInterpolated($"[red]Exception: {e.Message}[/]");
            return false;
        }
        finally
        {
            wsctConsole.CloseAndRelease();
        }
        return true;
    }

    public bool GetSerialNumber()
    {
        try
        {
            var readerName = wsctConsole.InitializeAndSelectReader();

            if (string.IsNullOrEmpty(readerName))
            {
                return false;
            }

            AnsiConsole.MarkupLine($"Now working with [blue]{readerName}[/]");

            if (!wsctConsole.Connect(readerName))
            {
                return false;
            }

            var serialNumber = acos6.GetSerialNumber();

            var table = new Table()
                .RoundedBorder()
                .AddColumn("Id")
                .AddColumn("SerialNumber");

            table.AddRow(@"1",
                $"{serialNumber.ToHexa()}");

            AnsiConsole.Write(table);
        }
        catch (Exception e)
        {
            AnsiConsole.MarkupLineInterpolated($"[red]Exception: {e.Message}[/]");
            return false;
        }
        finally
        {
            wsctConsole.CloseAndRelease();
        }
        return true;
    }
}

