using WSCT.Helpers;
using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands;

/// <summary>
/// APPEND RECORD command.
/// 00 E2 00 00 Lc (data)
/// </summary>
public class AppendRecordCommand : CommandAPDU
{
    /// <summary>
    /// Creates a APPEND RECORD command.
    /// </summary>
    /// <param name="data">The record data to append to the file.</param>
    public AppendRecordCommand(byte[] data) : base(0x00, 0xE2, 0x00, 0x00, (uint)data.Length, data)
    {
    }

    public AppendRecordCommand(string hexa) : this(hexa.FromHexa())
    {
    }
}
