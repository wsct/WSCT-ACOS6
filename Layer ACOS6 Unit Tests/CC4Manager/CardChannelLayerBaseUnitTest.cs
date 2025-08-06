using Moq;
using NUnit.Framework;
using WSCT.Core.APDU;
using WSCT.Helpers;
using WSCT.ISO7816;
using WSCT.Linq;
using WSCT.Stack;
using WSCT.Wrapper;

namespace WSCT.Layers.ACOS6.CC4Select.UnitTests
{
    [TestFixture]
    public class CardChannelLayerBaseUnitTest
    {
        public CardChannelLayerBaseUnitTest()
        {
            ACOS6Controller.UseCC4Manager = true;
        }

        private static Mock<ICardChannelLayer> GetMockOk()
        {
            var mock = new Mock<ICardChannelLayer>();

            mock.Setup(l => l.Transmit(It.Is<ICardCommand>(c => c.StringCommand == "00 A4 00 00 02 3F 00"), It.IsAny<ICardResponse>()))
                .Returns<ICardCommand, ICardResponse>((c, r) =>
                {
                    r.Parse("90 00");
                    return ErrorCode.Success;
                });

            mock.Setup(l => l.Transmit(It.Is<ICardCommand>(c => c.StringCommand == "00 C0 00 00 08"), It.IsAny<ICardResponse>()))
                .Returns<ICardCommand, ICardResponse>((c, r) =>
                {
                    r.Parse("01 02 03 04 05 06 07 08 90 00");
                    return ErrorCode.Success;
                });

            return mock;
        }

        private static Mock<ICardChannelLayer> GetMockStatusWord6F00()
        {
            var mock = new Mock<ICardChannelLayer>();

            mock.Setup(l => l.Transmit(It.Is<ICardCommand>(c => c.StringCommand == "00 A4 00 00 02 3F 00"), It.IsAny<ICardResponse>()))
                .Returns<ICardCommand, ICardResponse>((c, r) =>
                {
                    r.Parse("6F 00");
                    return ErrorCode.Success;
                });

            return mock;
        }

        private static Mock<ICardChannelLayer> GetMockError()
        {
            var mock = new Mock<ICardChannelLayer>();

            mock.Setup(l => l.Transmit(It.Is<ICardCommand>(c => c.StringCommand == "00 A4 00 00 02 3F 00"), It.IsAny<ICardResponse>()))
                .Returns<ICardCommand, ICardResponse>((c, r) => ErrorCode.Unexpected);

            return mock;
        }

        [Test]
        public void TestCC3()
        {
            var mock = GetMockOk();
            var layers = new[] { new CardChannelLayer(), mock.Object }.ToObservableLayers();
            var stack = new CardChannelStack(layers);

            var response = new ResponseAPDU();
            var ret = stack.Transmit(new CommandAPDU("00 A4 00 00 02 3F 00"), response);

            mock.Verify(l => l.Transmit(It.Is<ICardCommand>(c => c.StringCommand == "00 A4 00 00 02 3F 00"), It.IsAny<ICardResponse>()));

            Assert.That(ret, Is.EqualTo(ErrorCode.Success));
            Assert.That(response.StatusWord, Is.EqualTo(0x9000));
            Assert.That(response.Udr.ToHexa(), Is.EqualTo(""));
        }

        [Test]
        public void TestCC4()
        {
            var mock = GetMockOk();
            var layers = new[] { new CardChannelLayer(), mock.Object };
            var stack = new CardChannelStack(layers);

            var response = new ResponseAPDU();
            var ret = stack.Transmit(new CommandAPDU("00 A4 00 00 02 3F 00 08"), response);

            mock.Verify(l => l.Transmit(It.Is<ICardCommand>(c => c.StringCommand == "00 A4 00 00 02 3F 00"), It.IsAny<ICardResponse>()));
            mock.Verify(l => l.Transmit(It.Is<ICardCommand>(c => c.StringCommand == "00 C0 00 00 08"), It.IsAny<ICardResponse>()));

            Assert.That(ret, Is.EqualTo(ErrorCode.Success));
            Assert.That(response.StatusWord, Is.EqualTo(0x9000));
            Assert.That(response.Udr.ToHexa(), Is.EqualTo("01 02 03 04 05 06 07 08"));
        }

        [Test]
        public void TestCC4WithStatusWordError()
        {
            var mock = GetMockStatusWord6F00();
            var layers = new[] { new CardChannelLayer(), mock.Object };
            var stack = new CardChannelStack(layers);

            var response = new ResponseAPDU();
            var ret = stack.Transmit(new CommandAPDU("00 A4 00 00 02 3F 00 08"), response);

            mock.Verify(l => l.Transmit(It.Is<ICardCommand>(c => c.StringCommand == "00 A4 00 00 02 3F 00"), It.IsAny<ICardResponse>()));

            Assert.That(ret, Is.EqualTo(ErrorCode.Success));
            Assert.That(response.StatusWord, Is.EqualTo(0x6F00));
            Assert.That(response.Udr.ToHexa(), Is.EqualTo(""));
        }

        [Test]
        public void TestCC4WithFailure()
        {
            var mock = GetMockError();
            var layers = new[] { new CardChannelLayer(), mock.Object };
            var stack = new CardChannelStack(layers);

            var response = new ResponseAPDU();
            var ret = stack.Transmit(new CommandAPDU("00 A4 00 00 02 3F 00 08"), response);

            mock.Verify(l => l.Transmit(It.Is<ICardCommand>(c => c.StringCommand == "00 A4 00 00 02 3F 00"), It.IsAny<ICardResponse>()));

            Assert.That(ret, Is.EqualTo(ErrorCode.Unexpected));
        }
    }
}