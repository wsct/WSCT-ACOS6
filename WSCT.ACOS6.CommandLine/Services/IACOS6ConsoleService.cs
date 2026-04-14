namespace WSCT.ACOS6.CommandLine.Services;

internal interface IACOS6ConsoleService
{
    bool ClearCard();

    bool GetCardInformation();

    bool GetSerialNumber();
}
