namespace WSCT.ACOS6.CommandLine.Services;

internal interface IACOS6Service
{
    bool ClearCard();

    byte[] GetCardIdNumber();

    byte[] GetCardVersion();

    int GetEepromSize();

    byte[] GetSerialNumber();
}
