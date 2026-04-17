namespace WSCT.ACOS6.DataObjects;

/// <summary>
/// The Authentication Template (AT) defines the security condition that must be meant for this SE to be satisfied.
/// The security conditions are either PIN or Key authentications.
/// </summary>
public class AuthenticationTemplate()
{
    private readonly List<byte> _pinIdentifiers = [];
    private readonly List<byte> _keyIdentifiers = [];

    /// <summary>
    /// Adds a Key to the authentication template.
    /// </summary>
    /// <param name="keyId">The ID of the key to add.</param>
    /// <returns>The current instance of <see cref="AuthenticationTemplate"/>.</returns>
    public AuthenticationTemplate WithKey(byte keyId)
    {
        _keyIdentifiers.Add(keyId);

        return this;
    }

    /// <summary>
    /// Adds a PIN to the authentication template.
    /// </summary>
    /// <param name="pinId">The ID of the PIN to add.</param>
    /// <returns>The current instance of <see cref="AuthenticationTemplate"/>.</returns>
    public AuthenticationTemplate WithPin(byte pinId)
    {
        _pinIdentifiers.Add(pinId);

        return this;
    }

    /// <summary>
    /// Exports the authentication template to a byte array formatted for ACOS6.
    /// </summary>
    /// <returns></returns>
    public byte[] ToBytes()
    {
        byte[] atTags = [.. PinIdentifiersToBytes(), .. KeyIdentifiersToBytes()];

        return [0xA4, (byte)atTags.Length, .. atTags];
    }

    private byte[] KeyIdentifiersToBytes()
    {
        if (_keyIdentifiers.Count == 0)
        {
            return [];
        }

        List<byte> keyTags = [];
        foreach (var keyId in _keyIdentifiers)
        {
            keyTags.AddRange([0x83, 0x01, keyId]);
        }

        keyTags.AddRange([0x95, 0x01, 0x80]);

        return [.. keyTags];
    }

    private byte[] PinIdentifiersToBytes()
    {
        if (_pinIdentifiers.Count == 0)
        {
            return [];
        }

        List<byte> pinTags = [];
        foreach (var pinId in _pinIdentifiers)
        {
            pinTags.AddRange([0x83, 0x01, pinId]);
        }

        pinTags.AddRange([0x95, 0x01, 0x08]);

        return [.. pinTags];
    }
}
