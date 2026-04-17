using WSCT.ACOS6.DataObjects;
using WSCT.Helpers;

namespace WSCT.ACOS6.UnitTests.DataObjects;

[TestFixture]
internal class SecurityAttributeCompactUnitTest
{
    [TestCase]
    public void SacForDF()
    {
        var securityAttributeCompact = new SecurityAttributeCompactForDF
        {
            DeleteSelf = 0x01,
            Terminate = 0xFF,
            Activate = 0x01,
            Deactivate = 0x01,
            CreateDF = 0x00,
            CreateEF = 0x00,
            DeleteChild = 0x01
        };

        byte[] expected = "7F 01 FF 01 01 00 00 01".FromHexa();
        Assert.That(securityAttributeCompact.ToBytes(), Is.EqualTo(expected));
    }

    [TestCase]
    public void SacForEF()
    {
        var securityAttributeCompact = new SecurityAttributeCompactForEF
        {
            DeleteSelf = 0x00,
            Terminate = 0xFF,
            Activate = 0x00,
            Deactivate = 0x00,
            Update = 0x03,
            Read = 0xFF
        };

        byte[] expected = "7B 00 FF 00 00 03 FF".FromHexa();
        Assert.That(securityAttributeCompact.ToBytes(), Is.EqualTo(expected));
    }
}
