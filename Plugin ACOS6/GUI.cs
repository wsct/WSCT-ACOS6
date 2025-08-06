using System;
using System.Windows.Forms;
using WSCT.Layers.ACOS6;

namespace WSCT.GUI.Plugins.ACOS6
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Gui : Form
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public Gui()
        {
            InitializeComponent();

            CC4Manager.Checked = ACOS6Controller.UseCC4Manager;
        }

        #region >> *_Changed

        private void CC4Manager_CheckedChanged(object sender, EventArgs e)
        {
            ACOS6Controller.UseCC4Manager = CC4Manager.Checked;
        }

        #endregion
    }
}