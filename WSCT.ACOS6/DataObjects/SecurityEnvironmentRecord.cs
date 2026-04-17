namespace WSCT.ACOS6.DataObjects;

/// <summary>
/// Defines the Security Environment (SE) record `<SE ID Template> <SE Authentication Template>`
/// </summary>
public class SecurityEnvironmentRecord(byte seId)
{
    private AuthenticationTemplate _authenticationTemplate = new();

    /// <summary>
    /// Adds a key to the SE Authentication Template.
    /// </summary>
    /// <param name="keyId">The ID of the key to add.</param>
    /// <returns>The current instance of <see cref="SecurityEnvironmentRecord"/>.</returns>
    public SecurityEnvironmentRecord WithKey(byte keyId)
    {
        _authenticationTemplate.WithKey(keyId);

        return this;
    }

    /// <summary>
    /// Adds a PIN to the SE Authentication Template.
    /// </summary>
    /// <param name="pinId">The ID of the PIN to add.</param>
    /// <returns>The current instance of <see cref="SecurityEnvironmentRecord"/>.</returns>
    public SecurityEnvironmentRecord WithPin(byte pinId)
    {
        _authenticationTemplate.WithPin(pinId);

        return this;
    }

    /// <summary>
    /// Exports SE Record as a byte array formatted for ACOS6.
    /// </summary>
    public byte[] ToBytes()
    {
        byte[] atTags = _authenticationTemplate.ToBytes();

        return [0x80, 0x01, seId, .. atTags];
    }
}
