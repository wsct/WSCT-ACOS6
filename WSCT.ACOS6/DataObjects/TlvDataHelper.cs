using WSCT.Helpers;
using WSCT.Helpers.BasicEncodingRules;

namespace WSCT.ACOS6.DataObjects;

internal static class TlvDataHelper
{
    public static TlvData ToTlvData(this byte[] buffer, uint tag)
        => new(tag, (uint)buffer.Length, buffer);

    public static TlvData ToTlvData(this Span<byte> buffer, uint tag)
        => new(tag, (uint)buffer.Length, buffer.ToArray());

    public static TlvData ToTlvData(this IEnumerable<byte> buffer, uint tag)
        => buffer.ToArray().ToTlvData(tag);

    public static TlvData ToTlvData(this string buffer, uint tag)
        => buffer.FromHexa().ToTlvData(tag);
}
