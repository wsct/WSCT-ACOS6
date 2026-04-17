using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{
    /// <summary>
    /// CLEAR CARD command to set the card back to Pre-Perso State.
    /// </summary>
    public class ClearCardCommand : CommandAPDU
    {
        /// <summary>
        /// Creates a CLEAR CARD command to set the card back to Pre-Perso State. It is available only if the card is in Perso State.
        /// </summary> 
        public ClearCardCommand() : base(0x80, 0x30, 0x00, 00, 0x00)
        {
        }
    }
}
