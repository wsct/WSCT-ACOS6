using Microsoft.Extensions.Logging;
using WSCT.ACOS6.Commands;
using WSCT.Core.Fluent.Helpers;
using WSCT.ISO7816;

namespace WSCT.ACOS6.CommandLine.Services
{
    internal class ACOS6Service(ILogger<ACOS6Service> logger, IWSCTService wsct) : IACOS6Service
    {
        public bool ClearCard()
        {
            if (wsct.CardChannel is null)
            {
                logger.LogError("Card channel is not established.");

                return false;
            }

            var isSuccess = true;

            var crp = new ClearCardCommand()
                .Transmit(wsct.CardChannel)
                .ThrowIfNotSuccess()
                .If((c, r) => r.StatusWord != 0x9000, (c, r) => isSuccess = false);

            return isSuccess;
        }

        public byte[] GetCardIdNumber()
        {
            if (wsct.CardChannel is null)
            {
                logger.LogError("Card channel is not established.");

                return [];
            }

            var crp = new GetCardIdNumberCommand()
                .Transmit(wsct.CardChannel)
                .ThrowIfNotSuccess();

            return crp.RApdu.Udr;
        }

        public byte[] GetCardVersion()
        {
            if (wsct.CardChannel is null)
            {
                logger.LogError("Card channel is not established.");

                return [];
            }

            var crp = new GetCardVersionCommand()
                .Transmit(wsct.CardChannel)
                .ThrowIfNotSuccess();

            return crp.RApdu.Udr;
        }

        public int GetEepromSize()
        {
            if (wsct.CardChannel is null)
            {
                logger.LogError("Card channel is not established.");

                return 0;
            }

            var crp = new GetEepromSizeCommand()
                .Transmit(wsct.CardChannel)
                .ThrowIfNotSuccess()
                .If((c, r) => r.Sw1 != 0x90, (c, r) => logger.LogWarning("Status Word: {r.StatusWord:X4}", r.StatusWord));

            return crp.RApdu.Sw2;
        }

        public byte[] GetSerialNumber()
        {
            if (wsct.CardChannel is null)
            {
                logger.LogError("Card channel is not established.");

                return [];
            }

            var crp = new GetSerialNumberCommand()
                .Transmit(wsct.CardChannel)
                .ThrowIfNotSuccess()
                .ThrowIfSWNot9000();

            return crp.RApdu.Udr;
        }
    }
}
