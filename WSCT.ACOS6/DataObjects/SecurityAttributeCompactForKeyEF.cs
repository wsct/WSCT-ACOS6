namespace WSCT.ACOS6.DataObjects;


/// <summary>
/// Security Attribute Compact (SAC) for Key EF.
/// </summary>
public class SecurityAttributeCompactForKeyEF : SecurityAttributeCompact
{
    /// <summary>
    /// Conditions allowing to SET KEY to the File ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte SetKey { set => _b1 = value; }
}
