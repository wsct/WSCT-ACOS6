using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{
    /// <summary>
    /// GET CARD INFO command set to return the number of files under the currently selected DF in SW1-SW2 = 90XX, where XX is the number of files.
    /// </summary>
    public class GetFilesCountCommand : CommandAPDU
    {
        /// <summary>
        /// Creates a GET CARD INFO command to retrieve the number of files under the currently selected DF.
        /// </summary>
        public GetFilesCountCommand() : base(0x80, 0x14, 0x01, 0x00, 0x00)
        {
        }
    }
}
