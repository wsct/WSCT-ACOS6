namespace WSCT.ACOS6.DataObjects;

/// <summary>
/// Security Attribute Compact (SAC) for EF.
/// </summary>
public class SecurityAttributeCompactForEF : SecurityAttributeCompact
{
    /// <summary>
    /// Conditions allowing to UPDATE/WRITE content to the File ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte Update { set => _b1 = value; }

    /// <summary>
    /// Conditions allowing to READ content from the File ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte Read { set => _b0 = value; }
}
