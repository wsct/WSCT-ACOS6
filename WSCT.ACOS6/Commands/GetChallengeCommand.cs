using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{
    /// <summary>
    /// GETCHALLENGE command.<br/>
    /// 00 84 00 00 (04/08)
    /// </summary>
    public class GetChallengeCommand : CommandAPDU
    {
        /// <summary>
        /// Creates a GETCHALLENGE command.
        /// </summary> 
        /// <param ref="size">Only 0x04 and 0x08 are valid values for ACOS6 smartcards.</param>
        public GetChallengeCommand(byte size = 8) : base(0x00, 0x84, 0x00, 0x00, size)
        {
        }
    }
}
