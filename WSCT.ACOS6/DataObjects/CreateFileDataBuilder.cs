using WSCT.Helpers.BasicEncodingRules;

namespace WSCT.ACOS6.DataObjects;

/// <summary>
/// Builder class for creating the data required for the CREATE FILE command in ACOS6.
/// This class allows to set various parameters related to the file being created, such as its size, file identifier, and security attributes, and then builds the appropriate byte array to be used in the command.
/// </summary>
public class CreateFileDataBuilder
{
    readonly byte[] _tag82Content = [0x00, 0x00, 0x00, 0x00, 0x00];
    byte _tag82Length = 1;

    byte[] _fileId = [];
    byte[] _size = [];
    byte[] _dfLongName = [];
    byte[] _sfi = [];
    byte[] _lcsi = [];
    byte[] _sac = [];
    byte[] _sae = [];
    byte[] _seFileId = [];
    byte[] _fciFileId = [];

    /// <summary>
    /// Sets the File Descriptor Byte (FDB) in the Tag 0x82 content. This byte is mandatory and should be set before building the data.
    /// </summary>
    /// <param name="fdb"></param>
    /// <returns></returns>
    public CreateFileDataBuilder SetFileDescriptorByte(byte fdb)
    {
        _tag82Content[0] = fdb;

        return this;
    }

    /// <summary>
    /// Sets the Data Coded Byte (DCB) in the Tag 0x82 content. This byte mandatory for ISO/IEC 7816 compliance but is not used by ACOS6.
    /// </summary>
    /// <param name="dcb"></param>
    /// <returns></returns>
    public CreateFileDataBuilder SetDataCodedByte(byte dcb)
    {
        _tag82Content[1] = dcb;

        if (_tag82Length < 2)
        {
            _tag82Length = 2;
        }

        return this;
    }

    /// <summary>
    /// Sets the Record Information in the Tag 0x82 content. This information is mandatory for record files and should be set before building the data.
    /// </summary>
    /// <param name="mrl">aximum Record Length (MRL)</param>
    /// <param name="nor">Number of Records (NOR)</param>
    /// <returns></returns>
    public CreateFileDataBuilder SetRecordInfo(byte mrl, byte nor)
    {
        _tag82Content[3] = mrl;
        _tag82Content[4] = nor;

        if (_tag82Length < 5)
        {
            _tag82Length = 5;
        }

        return this;
    }

    /// <summary>
    /// Sets the size of the file in bytes. This information is mandatory for transparent files and should be set before building the data.
    /// </summary>
    /// <param name="size">The size of the file in bytes (2 bytes long).</param>
    /// <returns></returns>
    public CreateFileDataBuilder SetSize(int size)
    {
        _size = [(byte)(size / 0x100), (byte)(size % 0x100)];

        return this;
    }

    /// <summary>
    /// Sets the File Identifier (FID) of the file. This information is mandatory and should be set before building the data.   
    /// </summary>
    /// <param name="fileId">File Identifier of the file (2 bytes long)</param>
    /// <returns></returns>
    public CreateFileDataBuilder SetFileId(byte[] fileId)
    {
        _fileId = fileId;

        return this;
    }

    /// <summary>
    /// Sets the DF Name of the file. This information is optional.
    /// </summary>
    /// <param name="dfLongName">DF Name of the file (up to 16 bytes long)</param>
    /// <returns></returns>
    public CreateFileDataBuilder SetDFLongName(byte[] dfLongName)
    {
        _dfLongName = dfLongName;

        return this;
    }

    /// <summary>
    /// Sets the Short File Identifier (SFI) of the file. This information is optional and should be set before building the data if the file is intended to be accessed using SFI.
    /// </summary>
    /// <param name="sfi">Short File Identifier of the file (1 byte long)</param>
    /// <returns></returns>
    public CreateFileDataBuilder SetShortFileIdentifier(byte sfi)
    {
        _sfi = [sfi];

        return this;
    }

    /// <summary>
    /// Sets the Life Cycle State Information (LCSI) of the file. This information is optional.
    /// </summary>
    /// <param name="lcsi"></param>
    /// <returns></returns>
    public CreateFileDataBuilder SetLifeCycleState(byte lcsi)
    {
        _lcsi = [lcsi];

        return this;
    }

    /// <summary>
    /// Sets the Security Attribute Compact (SAC) of the file. This information is optional.
    /// </summary>
    /// <param name="sac"></param>
    /// <returns></returns>
    public CreateFileDataBuilder SetSecurityAttributeCompact(SecurityAttributeCompact sac)
    {
        _sac = sac.ToBytes();

        return this;
    }

    /// <summary>
    /// Sets the Security Attribute Extended (SAE) of the file. This information is optional.
    /// </summary>
    /// <param name="sae"></param>
    /// <returns></returns>
    public CreateFileDataBuilder SetSecurityAttributeExtended(byte[] sae)
    {
        _sae = sae;

        return this;
    }

    /// <summary>
    /// Sets the SE File Identifier of the file (DF only). This information is optional.
    /// </summary>
    /// <param name="fileId"></param>
    /// <returns></returns>
    public CreateFileDataBuilder SetSEFileId(byte[] fileId)
    {
        _seFileId = fileId;

        return this;
    }

    /// <summary>
    /// Sets the FCI File Identifier of the file (DF only). This information is optional.
    /// </summary>
    /// <param name="fileId">FID of the FCI file (2 bytes long)</param>
    /// <returns></returns>
    public CreateFileDataBuilder SetFCIFileId(byte[] fileId)
    {
        _fciFileId = fileId;

        return this;
    }

    /// <summary>
    /// Builds and returns the bytes based on the information previously set.
    /// </summary>
    public byte[] Build()
    {
        var tlv = new TlvData
        {
            Tag = 0x62,
            InnerTlvs = []
        };

        if (_size.Length > 0)
        {
            tlv.InnerTlvs.Add(_size.ToTlvData(0x80));
        }

        tlv.InnerTlvs.Add(_tag82Content.AsSpan(0, _tag82Length).ToTlvData(0x82));

        tlv.InnerTlvs.Add(_fileId.ToTlvData(0x83));

        if (_dfLongName.Length > 0)
        {
            tlv.InnerTlvs.Add(_dfLongName.ToTlvData(0x84));
        }

        if (_sfi.Length > 0)
        {
            tlv.InnerTlvs.Add(_sfi.ToTlvData(0x88));
        }

        if (_lcsi.Length > 0)
        {
            tlv.InnerTlvs.Add(_lcsi.ToTlvData(0x8A));
        }

        if (_sac.Length > 0)
        {
            tlv.InnerTlvs.Add(_sac.ToTlvData(0x8C));
        }

        if (_sae.Length > 0)
        {
            tlv.InnerTlvs.Add(_sae.ToTlvData(0xAB));
        }

        if (_seFileId.Length > 0)
        {
            tlv.InnerTlvs.Add(_seFileId.ToTlvData(0x8D));
        }

        if (_fciFileId.Length > 0)
        {
            tlv.InnerTlvs.Add(_fciFileId.ToTlvData(0x87));
        }

        return tlv.ToByteArray();
    }
}
