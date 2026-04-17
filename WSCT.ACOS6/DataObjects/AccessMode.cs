namespace WSCT.ACOS6.DataObjects;

/// <summary>
/// Defines the Access Mode Data Object (AMDO) used in SAE.
/// </summary>
public class AccessMode
{
    private byte _tag = 0x80;
    private byte? _claValue;
    private byte? _insValue;
    private byte? _p1Value;
    private byte? _p2Value;
    private byte _valueCount = 0;

    /// <summary>
    /// Add a condition on CLA byte.
    /// </summary>
    public AccessMode WithCla(byte value)
    {
        _tag |= 0x08;

        if (_claValue == null)
        {
            _valueCount++;
        }
        _claValue = value;

        return this;
    }

    /// <summary>
    /// Add a condition on INS byte.
    /// </summary>
    public AccessMode WithIns(byte value)
    {
        _tag |= 0x04;

        if (_insValue == null)
        {
            _valueCount++;
        }
        _insValue = value;

        return this;
    }

    /// <summary>
    /// Add a condition on P1 byte.
    /// </summary>
    public AccessMode WithP1(byte value)
    {
        _tag |= 0x02;

        if (_p1Value == null)
        {
            _valueCount++;
        }
        _p1Value = value;

        return this;
    }

    /// <summary>
    /// Add a condition on P2 byte.
    /// </summary>
    public AccessMode WithP2(byte value)
    {
        _tag |= 0x01;

        if (_p2Value == null)
        {
            _valueCount++;
        }
        _p2Value = value;

        return this;
    }

    /// <summary>
    /// Exports the access mode to a byte array formatted for ACOS6.
    /// </summary>
    public byte[] ToBytes()
    {
        var value = new byte[_valueCount];

        var index = 0;
        if (_claValue != null)
        {
            value[index++] = _claValue.Value;
        }
        if (_insValue != null)
        {
            value[index++] = _insValue.Value;
        }
        if (_p1Value != null)
        {
            value[index++] = _p1Value.Value;
        }
        if (_p2Value != null)
        {
            value[index] = _p2Value.Value;
        }

        return [_tag, _valueCount, .. value];
    }
}
