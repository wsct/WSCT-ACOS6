using WSCT.ACOS6.DataObjects;

namespace WSCT.ACOS6.UnitTests.DataObjects;

[TestFixture]
internal class AccessModeUnitTest
{
    [TestCase]
    public void HasCla()
    {
        var accessMode = new AccessMode().WithCla(0x80);

        byte[] expected = [0x88, 0x01, 0x80];
        Assert.That(accessMode.ToBytes(), Is.EqualTo(expected));
    }

    [TestCase]
    public void HasInsP1()
    {
        var accessMode = new AccessMode().WithIns(0xA4).WithP1(0x04);

        byte[] expected = [0x86, 0x02, 0xA4, 0x04];
        Assert.That(accessMode.ToBytes(), Is.EqualTo(expected));
    }

    [TestCase]
    public void HasClaP2()
    {
        var accessMode = new AccessMode().WithCla(0xA4).WithP2(0x00);

        byte[] expected = [0x89, 0x02, 0xA4, 0x00];
        Assert.That(accessMode.ToBytes(), Is.EqualTo(expected));
    }
}
