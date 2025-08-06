using WSCT.Helpers;
using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{

    /// <summary>
    /// ACTIVATE FILE command.<br/>
    /// 00 44 00 00 02 (fileId)
    /// </summary>
    public class ActivateFileCommand : CommandAPDU
    {
        /// <summary>
        /// Activates a file given its FID as a <c>byte[]</c>.
        /// </summary>
        /// <param ref="fileId">File ID of the file that must be of length 2.</param>
        public ActivateFileCommand(byte[] fileId) : base(0x00, 0x44, 0x00, 0x00, 0x02, fileId)
        {
        }

        /// <summary>
        /// Activates a file given its FID as an hexa <c>string</c>.
        /// </summary>
        /// <param ref="fileId">File ID of the file that must be of length 2.</param>
        public ActivateFileCommand(string hexaFileId) : this(hexaFileId.FromHexa())
        {
        }
    }

}
