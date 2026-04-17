namespace WSCT.ACOS6.DataObjects;

/// <summary>
/// Defines the abstract Security Attribute Compact (SAC) class, used for File attributes.
/// It allows to set conditions for various operations (Delete, Terminate, Activate, Deactivate) on the File.
/// </summary>
public abstract class SecurityAttributeCompact
{
    private byte? _b6;
    private byte? _b5;
    private byte? _b4;
    private byte? _b3;
    protected byte? _b2;
    protected byte? _b1;
    protected byte? _b0;

    /// <summary>
    /// Conditions allowing to DELETE the File ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte DeleteSelf { set => _b6 = value; }

    /// <summary>
    /// Conditions allowing to TERMINATE the File ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte Terminate { set => _b5 = value; }

    /// <summary>
    /// Conditions allowing to ACTIVATE the File ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte Activate { set => _b4 = value; }

    /// <summary>
    /// Conditions allowing to DEACTIVATE the File ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte Deactivate { set => _b3 = value; }

    /// <summary>
    /// Exports the SAC to a byte array formatted for ACOS6.
    /// </summary>
    public byte[] ToBytes()
    {
        byte accessMode = 0x00;
        List<byte> fields = [];

        UpdateField(0x40, _b6, fields, ref accessMode);
        UpdateField(0x20, _b5, fields, ref accessMode);
        UpdateField(0x10, _b4, fields, ref accessMode);
        UpdateField(0x08, _b3, fields, ref accessMode);
        UpdateField(0x04, _b2, fields, ref accessMode);
        UpdateField(0x02, _b1, fields, ref accessMode);
        UpdateField(0x01, _b0, fields, ref accessMode);

        return [accessMode, .. fields];
    }

    private static void UpdateField(byte flag, byte? bx, List<byte> fields, ref byte accessMode)
    {
        if (bx is not null)
        {
            accessMode |= flag;
            fields.Add(bx.Value);
        }
    }
}
