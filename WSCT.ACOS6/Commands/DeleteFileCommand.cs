using WSCT.Helpers;
using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{
    /// <summary>
    /// DELETE FILE command.<br/>
    /// 00 E4 00 00 00
    /// 00 E4 00 00 02 (File ID)
    /// </summary>
    public class DeleteFileCommand : CommandAPDU
    {
        /// <summary>
        /// Creates a DELETE FILE command to delete the currently selected DF or EF
        /// </summary>
        public DeleteFileCommand() : base(0x00, 0xE4, 0x00, 0x00, 0x00, [])
        {
        }

        /// <summary>
        /// Creates a DELETE FILE command to delete the file whose ID is referenced by the DATA
        /// </summary>
        /// <param ref="fileId">File ID to delete.</param>
        public DeleteFileCommand(byte[] fileId) : this()
        {
            Udc = fileId;
        }

        /// <summary>
        /// Creates a DELETE FILE command to delete the file whose ID is referenced by the DATA
        /// </summary>
        /// <param ref="fileId">File ID to delete.</param>
        public DeleteFileCommand(string fileId) : this(fileId.FromHexa())
        {
        }
    }

}
