using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{
    /// <summary>
    /// GET CARD INFO command set to return the 6-byte Card ID Number.
    /// </summary>
    public class GetCardVersionCommand : CommandAPDU
    {
        /// <summary>
        /// Creates a GET CARD INFO command to retrieve the 6-byte Card ID Number.
        /// </summary> 
        public GetCardVersionCommand() : base(0x80, 0x14, 0x06, 00, 0x08)
        {
        }
    }
}
