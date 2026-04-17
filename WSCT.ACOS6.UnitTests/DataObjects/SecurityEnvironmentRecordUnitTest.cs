using WSCT.ACOS6.DataObjects;
using WSCT.Helpers;

namespace WSCT.ACOS6.UnitTests.DataObjects;

[TestFixture]
internal class SecurityEnvironmentRecordUnitTest
{
    [TestCase]
    public void WithKeys()
    {
        var securityEnvironmentRecordKeysOnly = new SecurityEnvironmentRecord(0x03).WithKey(0x84).WithKey(0x81);

        byte[] expected = "80 01 03 A4 09 83 01 84 83 01 81 95 01 80".FromHexa();
        Assert.That(securityEnvironmentRecordKeysOnly.ToBytes(), Is.EqualTo(expected));
    }

    [TestCase]
    public void WithPins()
    {
        var securityEnvironmentRecord2 = new SecurityEnvironmentRecord(0x03).WithPin(0x84).WithPin(0x81);

        byte[] expected = "80 01 03 A4 09 83 01 84 83 01 81 95 01 08".FromHexa();
        Assert.That(securityEnvironmentRecord2.ToBytes(), Is.EqualTo(expected));
    }
}
