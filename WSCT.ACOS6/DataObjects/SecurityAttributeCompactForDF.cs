namespace WSCT.ACOS6.DataObjects;

/// <summary>
/// Defines the Security Attribute Compact (SAC) for DF.
/// </summary>
public class SecurityAttributeCompactForDF : SecurityAttributeCompact
{
    /// <summary>
    /// Conditions allowing to CREATE a DF in this DF ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte CreateDF { set => _b2 = value; }

    /// <summary>
    /// Conditions allowing to CREATE an EF in this DF ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte CreateEF { set => _b1 = value; }

    /// <summary>
    /// Conditions allowing to DELETE a File in this DF ('00': Always, 'FF': never, or SE ID)
    /// </summary>
    public byte DeleteChild { set => _b0 = value; }
}
