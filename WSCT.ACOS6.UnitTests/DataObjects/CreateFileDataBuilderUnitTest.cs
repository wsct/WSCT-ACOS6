using WSCT.ACOS6.DataObjects;
using WSCT.Helpers;

namespace WSCT.ACOS6.UnitTests.DataObjects;

[TestFixture]
internal class CreateFileDataBuilderUnitTest
{
    [TestCase]
    public void Test1()
    {
        var createFileData = new CreateFileDataBuilder()
            .SetFileDescriptorByte(0x0C)
            .SetDataCodedByte(0x01)
            .SetRecordInfo(0x06, 0x02)
            .SetFileId("41 99".FromHexa())
            .SetShortFileIdentifier(0x01)
            .SetLifeCycleState(0x01)
            .SetSecurityAttributeCompact(new SecurityAttributeCompactForEF
            {
                DeleteSelf = 0x00,
                Terminate = 0xFF,
                Activate = 0x00,
                Deactivate = 0x00,
                Update = 0x00,
                Read = 0xFF
            })
            .Build();

        var expected = "62 1A 82 05 0C 01 00 06 02 83 02 41 99 88 01 01 8A 01 01 8C 07 7B 00 FF 00 00 00 FF".FromHexa();
        Assert.That(createFileData, Is.EqualTo(expected));
    }
}
