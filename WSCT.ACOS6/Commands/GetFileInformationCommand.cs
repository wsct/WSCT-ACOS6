using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{
    /// <summary>
    /// GET CARD INFO command set to return file information of the <paramref name="index"/>th file in the current DF.
    /// The 8 bytes are: {FDB, DCB, FILE ID, FILE ID, SIZE or MRL, SIZE or NOR, SFI, LCSI};
    /// </summary>
    public class GetFileInformationCommand : CommandAPDU
    {
        /// <summary>
        /// Creates a GET CARD INFO command to retrieve file information of the <paramref name="index"/>th file in the current DF.
        /// </summary> 
        /// <param name="index">The index of the file to retrieve information for, starting from 0.</param>
        public GetFileInformationCommand(byte index) : base(0x80, 0x14, 0x02, index, 0x08)
        {
        }
    }
}
