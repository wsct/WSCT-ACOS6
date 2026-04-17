namespace WSCT.ACOS6.CommandLine.Services;

public interface IWSCTConsoleService
{
    bool CloseAndRelease();

    bool Connect(string readerName);

    string InitializeAndSelectReader();

    public bool ListReaders();
}
