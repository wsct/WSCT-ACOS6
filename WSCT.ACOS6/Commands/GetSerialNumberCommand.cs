using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{
    /// <summary>
    /// GET CARD INFO command set to retrieve the card's unique serial number.<br/>
    /// 80 14 00 00 08
    /// </summary>
    /// <remarks></remarks>
    public class GetSerialNumberCommand : CommandAPDU
    {
        /// <summary>
        /// Creates a GET CARD INFO command to retrieve the card's unique serial number.
        /// </summary>
        public GetSerialNumberCommand() : base(0x80, 0x14, 0x00, 0x00, 0x08)
        {
        }
    }
}
