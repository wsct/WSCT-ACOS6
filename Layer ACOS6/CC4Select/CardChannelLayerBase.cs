using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.ISO7816;
using WSCT.ISO7816.Commands;
using WSCT.Stack;
using WSCT.Wrapper;

namespace WSCT.Layers.ACOS6.CC4Select
{
    internal class CardChannelLayerBase : ICardChannelLayer
    {
        #region >> Fields

        private ICardChannelStack stack;

        #endregion

        #region >> ICardChannelLayer

        /// <inheritdoc />
        public void SetStack(ICardChannelStack stack)
        {
            this.stack = stack;
        }

        /// <inheritdoc />
        public string LayerId
        {
            get { return "CC4Manager"; }
        }

        #endregion

        #region >> ICardChannel

        /// <inheritdoc />
        public Protocol Protocol
        {
            get { return stack.RequestLayer(this, SearchMode.Next).Protocol; }
        }

        /// <inheritdoc />
        public string ReaderName
        {
            get { return stack.RequestLayer(this, SearchMode.Next).ReaderName; }
        }

        /// <inheritdoc />
        public void Attach(ICardContext context, string readerName)
        {
            stack.RequestLayer(this, SearchMode.Next).Attach(context, readerName);
        }

        /// <inheritdoc />
        public ErrorCode Connect(ShareMode shareMode, Protocol preferedProtocol)
        {
            return stack.RequestLayer(this, SearchMode.Next).Connect(shareMode, preferedProtocol);
        }

        /// <inheritdoc />
        public ErrorCode Disconnect(Disposition disposition)
        {
            return stack.RequestLayer(this, SearchMode.Next).Disconnect(disposition);
        }

        /// <inheritdoc />
        public ErrorCode GetAttrib(Attrib attrib, ref byte[] buffer)
        {
            return stack.RequestLayer(this, SearchMode.Next).GetAttrib(attrib, ref buffer);
        }

        /// <inheritdoc />
        public State GetStatus()
        {
            return stack.RequestLayer(this, SearchMode.Next).GetStatus();
        }

        /// <inheritdoc />
        public ErrorCode Reconnect(ShareMode shareMode, Protocol preferedProtocol, Disposition initialization)
        {
            return stack.RequestLayer(this, SearchMode.Next).Reconnect(shareMode, preferedProtocol, initialization);
        }

        /// <inheritdoc />
        public ErrorCode Transmit(ICardCommand command, ICardResponse response)
        {
            if (ACOS6Controller.UseCC4Manager == false)
            {
                return stack.RequestLayer(this, SearchMode.Next).Transmit(command, response);
            }

            if (command is not CommandAPDU command7816 || response is not ResponseAPDU response7816)
            {
                return stack.RequestLayer(this, SearchMode.Next).Transmit(command, response);
            }

            // if SELECT CC4 (00 A4 00 00 02 Lc UDC Le)
            if (command7816.Ins == 0xA4 && command7816.IsCc4)
            {
                var cc3SelectCommand = new CommandAPDU(command7816.Cla, command7816.Ins, command7816.P1, command7816.P2, command7816.Lc, command7816.Udc);

                var ret = stack.RequestLayer(this, SearchMode.Next).Transmit(cc3SelectCommand, response);

                if (ret != ErrorCode.Success)
                {
                    return ret;
                }

                if (response7816.Sw1 != 0x61)
                {
                    return ret;
                }

                var cc2GetResponseCommand = new GetResponseCommand(command7816.Le);

                return stack.RequestLayer(this, SearchMode.Next).Transmit(cc2GetResponseCommand, response);
            }

            return stack.RequestLayer(this, SearchMode.Next).Transmit(command, response);
        }

        #endregion
    }
}