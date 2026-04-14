using WSCT.ISO7816;

namespace WSCT.ACOS6.Commands
{
    /// <summary>
    /// GET CARD INFO command set to return the size of EEPROM in the status bytes SW1-SW2 = 90XX.
    /// </summary>
    public class GetEepromSizeCommand : CommandAPDU
    {
        /// <summary>
        /// Creates a GET CARD INFO command to retrieve the size of EEPROM in the status bytes SW1-SW2 = 90XX. XX is the size of EEPROM in Kbytes.
        /// </summary> 
        public GetEepromSizeCommand() : base(0x80, 0x14, 0x05, 00, 0x00)
        {
        }
    }
}
