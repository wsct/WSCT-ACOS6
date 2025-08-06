using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{
    /// <summary>
    /// SELECT command set to select the MF.<br/>
    /// 00 A4 00 00 00
    /// </summary>
    public class SelectMFCommand : CommandAPDU
    {
        /// <summary>
        /// Creates a SELECT command to select the MF (Master File).
        /// </summary>
        public SelectMFCommand() : base(0x00, 0xA4, 0x00, 0x00, 0x00)
        {
        }
    }
}
