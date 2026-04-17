using WSCT.Helpers.BasicEncodingRules;
using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands;

/// <summary>
/// CREATE FILE command.
/// 00 E0 00 00 Lc (FCP)
/// </summary>
public class CreateFileCommand : CommandAPDU
{
    /// <summary>
    /// Creates a CREATE FILE command.
    /// </summary>
    public CreateFileCommand(byte[] fileControlParameter) : base(0x00, 0xE0, 0x00, 0x00, (uint)fileControlParameter.Length, fileControlParameter)
    {
    }

    /// <summary>
    /// Creates a CREATE FILE command.
    /// </summary>
    public CreateFileCommand(TlvData fileControlParameter) : this(fileControlParameter.ToByteArray())
    {
    }
}
